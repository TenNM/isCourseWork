using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace isCourseWork
{
    public partial class FormMain : Form
    {
        internal Adapter_Aggregator adapter_Aggregator = new Adapter_Aggregator();
        public FormMain()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Series[0].Points.AddXY("a", 1);
            chart1.Series[0].Points.AddXY("b", 1);
            chart1.Series[0].Points.AddXY("c", 1);
            //
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns.Add("Adapter name", "Adapter name");
            dataGridView1.Columns.Add("Inited", "Inited");
            dataGridView1.Columns.Add("Connected", "Connected");

            object[] arr = { "one", "two", "thr"};
            dataGridView1.Rows.Add(arr);          
        }
        //-------------------------------------------------------------------------------------
        internal void AddAdapterInAllPlaces(string adpterName, string api, string secret, string password)
        {
            adapter_Aggregator.AddAdapter(adpterName, api, secret);//1
            adapter_Aggregator.AddOrRewriteKeySet(//2
                adpterName,
                Сryptography.EncryptStringToBytes_Aes(api, Сryptography.PassToByte16Arr(password)),
                Сryptography.EncryptStringToBytes_Aes(secret, Сryptography.PassToByte16Arr(password))
                );
            checkedListBoxAdapters.Items.Add(adpterName);//3

            dataGridView1.Rows.Add(adpterName, false);//4
        }
        //----------------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            adapter_Aggregator.Dispose();
        }
        //---------------------------------------------------------------------------------buttons
        private void buttonDoRequest_Click(object sender, EventArgs e)
        {
            List<string> adapters = new List<string> { Adapter.NAME_TEST };
            List<string> assets = new List<string> { "TEST1", "TEST2" };
            adapter_Aggregator.MassGetBalances();
            var dictionary = adapter_Aggregator.RequestEngine(assets, adapters);
            chart1.Series[0].Points.Clear();
            foreach (var entry in dictionary)
            {
                foreach (var asset in entry.Value)
                {
                    chart1.Series[0].Points.AddXY(
                        entry.Key + " " + asset.Asset,
                        asset.TotalAssetBalance
                        );
                }
            }
        }
        //--------
        private void buttonSetPass_Click(object sender, EventArgs e)
        {

        }
        private void buttonAddAdapter_Click(object sender, EventArgs e)
        {
            FormAddKeySet formAddKeySet = new FormAddKeySet();
            formAddKeySet.Owner = this;
            formAddKeySet.ShowDialog();
        }
        private void buttonDelAdapter_Click(object sender, EventArgs e)
        {
            if (
                dataGridView1.SelectedCells.Count.Equals(1) && 
                dataGridView1.SelectedCells[0].ColumnIndex.Equals(0)
                )
            {
                string name = dataGridView1.SelectedCells[0].Value.ToString();
                bool isAdapterDeleted = adapter_Aggregator.DelAdapter(name);
                bool isKeySetDeleted = adapter_Aggregator.DelKeySet(name);
                checkedListBoxAdapters.Items.Remove(name);
                MessageBox.Show(
                    "Adapter deleted:" + isAdapterDeleted + '\n' +
                    "KeySet  deleted:" + isKeySetDeleted
                    );
            }
        }     
        private void buttonInitAll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Adapter ad = adapter_Aggregator.FindAdapter(dataGridView1.Rows[i].Cells[0].Value.ToString());
                if(ad != null)
                {
                    bool inited = ad.Init();
                    dataGridView1.Rows[i].Cells[1].Value = inited;
                }
            }
        }
        private void buttonCheckConnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Adapter ad = adapter_Aggregator.FindAdapter(dataGridView1.Rows[i].Cells[0].Value.ToString());
                if (ad != null)
                {
                    bool inited = ad.CheckCon();
                    dataGridView1.Rows[i].Cells[2].Value = inited;
                }
            }
        }
    
        //------------------------------------------------------------------------------------end
    }//c
}//n
