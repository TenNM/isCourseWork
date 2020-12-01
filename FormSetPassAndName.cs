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
    public partial class FormSetPassAndName : Form
    {
        public FormSetPassAndName()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private bool isFieldsCorrect()
        {
            return
                !(
                string.IsNullOrWhiteSpace(labeledTextBoxName.Text) ||
                string.IsNullOrWhiteSpace(labeledTextBoxPass.Text)
                );
        }
        private void buttonSetPassAndNameOk_Click(object sender, EventArgs e)
        {
            if (!isFieldsCorrect())
            {
                MessageBox.Show("Incorrect or empty fields");
                return;
            }
            if (labeledTextBoxPass.Text.Length < 8 || labeledTextBoxPass.Text.Length > 16)
            {
                MessageBox.Show("Password length must be 8-16 chars");
                return;
            }
            FormMain fm = this.Owner as FormMain;
            if (fm == null)
            {
                MessageBox.Show("Can't connect to main form");
                return;
            }
            fm.adapter_Aggregator.KeyStorageSetName(labeledTextBoxName.Text);
            fm.adapter_Aggregator.SetHashedPass(Сryptography.GetSha512(labeledTextBoxPass.Text));
            
            fm.StatePass(true);
            fm.labelName.Text = "Name " + labeledTextBoxName.Text;
            fm.labelPassSetted.Text = "Pass setted";

            this.Close();
        }
    }//c
}
