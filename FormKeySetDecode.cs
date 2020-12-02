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
    public partial class FormKeySetDecode : Form
    {
        public FormKeySetDecode()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        //------------------------------------------------------------------------
        private void buttonDecodeKeySet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(labeledTextBoxDecodePass.Text))
            {
                MessageBox.Show("Empty fields");
                return;
            }
            FormMain fm = this.Owner as FormMain;
            if (fm == null)
            {
                MessageBox.Show("Can't connect to main form");
                return;
            }
            if (!fm.adapter_Aggregator.IsPassHashRight(Сryptography.GetSha512(labeledTextBoxDecodePass.Text)))
            {
                MessageBox.Show("Password do not match");
                this.buttonDecodeKeySet.Enabled = false;
                System.Threading.Thread.Sleep(1000);//yes, block of thread. Hack for hackers.
                this.buttonDecodeKeySet.Enabled = true;
                return;
            }
            fm.Del_ALL_AdaptersInAllPlaces();
            fm.adapter_Aggregator.AllPlacesFillFromKS(labeledTextBoxDecodePass.Text, fm);
            fm.StatePass(true);
            this.Close();
        }//m
        //----------------------------------------------------------------------------------
    }
}
