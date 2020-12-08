using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isCourseWork
{
    public partial class FormAddKeySet : Form
    {
        public FormAddKeySet()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            comboBoxChooseAdapter.Items.Add("Choose adapter");
            comboBoxChooseAdapter.SelectedIndex = 0;

            comboBoxChooseAdapter.Items.AddRange(Adapter.GetSupportedAdapters());

            labeledTextBoxPassword.TextBox.PasswordChar = Properties.Settings.Default.PASSWORD_CHAR;
        }
        private bool isFieldsCorrect()
        {
            return
                !(
                string.IsNullOrWhiteSpace(labeledTextBoxApi.Text) ||
                string.IsNullOrWhiteSpace(labeledTextBoxSecret.Text) ||
                string.IsNullOrWhiteSpace(labeledTextBoxPassword.Text)
                )
                &&
                comboBoxChooseAdapter.SelectedIndex != 0
                ;
        }
        private void buttonAddKeyForm_Click(object sender, EventArgs e)
        {
            if (!isFieldsCorrect())
            {
                MessageBox.Show("Incorrect or empty fields");
                return;
            }
            FormMain fm = this.Owner as FormMain;
            if (fm == null)
            {
                MessageBox.Show("Can't connect to main form");
                return;
            }
            if (fm.adapter_Aggregator.IsAdapterAdded(comboBoxChooseAdapter.SelectedItem as string))
            {
                MessageBox.Show("Adapter already added");
                return;
            }
            if (!fm.adapter_Aggregator.IsPassHashRight( Сryptography.GetSha512(labeledTextBoxPassword.Text) ))
            {
                MessageBox.Show("Password do not match");
                this.buttonAddKeyForm.Enabled = false;
                System.Threading.Thread.Sleep(1000);//yes, block of thread. Hack for hackers.
                this.buttonAddKeyForm.Enabled = true;
                return;
            }
            fm.AddAdapterInAllPlaces(
                comboBoxChooseAdapter.SelectedItem as string,
                labeledTextBoxApi.Text,
                labeledTextBoxSecret.Text,
                labeledTextBoxPassword.Text
            );
            this.Close();
        }//m
    }//c
}//n
