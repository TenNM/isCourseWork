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
            if (isFieldsCorrect())
            {
                FormMain fm = this.Owner as FormMain;
                if (!fm.adapter_Aggregator.IsAdapterAdded(comboBoxChooseAdapter.SelectedItem as string)) {
                    if (fm != null)
                    {
                        fm.adapter_Aggregator.AddAdapter(
                            comboBoxChooseAdapter.SelectedItem as string,
                            labeledTextBoxApi.Text,
                            labeledTextBoxSecret.Text
                            );
                        //add keyset
                        fm.checkedListBoxAdapters.Items.Add(comboBoxChooseAdapter.SelectedItem as string);

                        object[] arr = { comboBoxChooseAdapter.SelectedItem, false };
                        fm.dataGridView1.Rows.Add(arr);

                        this.Close();
                    }
                    else MessageBox.Show("Can't connect to main form");
                }
                else MessageBox.Show("Adapter already added");
            }
            else MessageBox.Show("Incorrect or empty fields");
        }//m
    }//c
}//n
