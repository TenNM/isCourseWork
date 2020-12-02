using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            dataGridView1.MultiSelect = false;
            //
            dataGridView1.Columns.Add("Adapter name", "Adapter name");
            dataGridView1.Columns.Add("Inited", "Inited");
            dataGridView1.Columns.Add("Connected", "Connected");
            //
            object[] oArr = {
                Adapter.ASSET_TEST1,
                Adapter.ASSET_ETH,
                Adapter.ASSET_ETC,
                Adapter.ASSET_BTC,
                Adapter.ASSET_LTC
            };
            checkedListBoxAssets.Items.AddRange(oArr);
            //
            object[] filterArr = {
                "Balance",
                "Price",
                "Worth"             
            };
            comboBoxFilter.Items.AddRange(filterArr);
            comboBoxFilter.SelectedIndex = 0;
            //
            StatePass(false);
        }
        //
        internal void StatePass(bool isSetted)
        {
            if (!isSetted)
            {
                labelName.Text = "Name unsetted";
                labelPassSetted.Text = "Pass unsetted";
            }

            buttonCallAllServers.Enabled = isSetted;
            buttonFilter.Enabled = isSetted;

            buttonAddAdapter.Enabled = isSetted;
            buttonDelAdapter.Enabled = isSetted;
            buttonInitAll.Enabled = isSetted;
            buttonCheckConnAll.Enabled = isSetted;
        }
        //-------------------------------------------------------------------------------------
        internal bool CellOfFirstColumnSelectedOrNothing()
        {
            /*if (dataGridView1.SelectedCells.Count != 1) return false;
            string selectedCellVal = dataGridView1.SelectedCells[0].Value.ToString();
            foreach(string s in Adapter.GetSupportedAdapters())
            {
                if (selectedCellVal.Equals(s)) return true;
            }
            return false;*/
            return (dataGridView1.SelectedCells.Count).Equals(0)
                || (dataGridView1.SelectedCells[0].ColumnIndex.Equals(0));
        }
        //--------------------------------------------------
        internal void AddAdapterInAllPlaces(string adapterName, string api, string secret, string passwordORIGINAL)
        {
            adapter_Aggregator.AddAdapter(adapterName, api, secret);//1
            bool bInited = adapter_Aggregator.Init(adapterName);
            adapter_Aggregator.AddOrRewriteKeySet(//2
                adapterName,
                Сryptography.EncryptStringToBytes_Aes(api, Сryptography.PassToByte16Arr(passwordORIGINAL)),
                Сryptography.EncryptStringToBytes_Aes(secret, Сryptography.PassToByte16Arr(passwordORIGINAL))
                );
            checkedListBoxAdapters.Items.Add(adapterName);//3

            dataGridView1.Rows.Add(adapterName, bInited, false);//4
        }
        internal void DelAdapterInAllPlaces(string adapterName)
        {
            adapter_Aggregator.DelAdapter(adapterName);//1
            adapter_Aggregator.DelKeySet(adapterName);//2
            checkedListBoxAdapters.Items.Remove(adapterName);//3
            foreach (DataGridViewRow row in dataGridView1.Rows)//4
            {
                if (row.Cells[0].Value.ToString().Equals(adapterName))
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }
            }
        }
        internal void Del_ALL_AdaptersInAllPlaces()
        {
            adapter_Aggregator.Del_ALL_Adapters();//1
            //2
            checkedListBoxAdapters.Items.Clear();//3
            dataGridView1.Rows.Clear();//4
        }
        //----------------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            adapter_Aggregator.Dispose();
        }
        //---------------------------------------------------------------------------------buttons
        private void buttonCallAllServers_Click(object sender, EventArgs e)
        {
            buttonCallAllServers.Enabled = false;
            buttonFilter.Enabled = false;

            adapter_Aggregator.MassGetBalances();
            adapter_Aggregator.MassGetPrices();
            adapter_Aggregator.MassCalcPortfolio();

            buttonCallAllServers.Enabled = true;
            buttonFilter.Enabled = true;
        }
        /*private void buttonFilter_Click(object sender, EventArgs e)
        {
            decimal numData = 0;
            List<string> adapters = checkedListBoxAdapters.CheckedItems.Cast<string>().ToList();
            List<string> assets = checkedListBoxAssets.CheckedItems.Cast<string>().ToList();
            var dictionary = adapter_Aggregator.RequestEngine(assets, adapters);
            chart1.Series[0].Points.Clear();
            foreach (var entry in dictionary)
            {
                foreach (var asset in entry.Value)
                {
                    switch (comboBoxFilter.SelectedItem)
                    {
                        case "Balance": numData = asset.TotalAssetBalance; break;
                        case "Price": numData = asset.Price; break;
                        case "Worth": numData = asset.Worth; break;
                    }
                    chart1.Series[0].Points.AddXY(
                        entry.Key + '\n' + asset.Asset + '\n' + numData,
                        //asset.TotalAssetBalance
                        numData
                        );
                }
            }
        }*/
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            decimal numData = 0;
            chart1.Series[0].Points.Clear();

            foreach (var adapterChecked in checkedListBoxAdapters.CheckedItems)
            {
                Adapter findedAd = adapter_Aggregator.FindAdapter(adapterChecked.ToString());
                if (null == findedAd) continue;

                foreach (var assetChecked in checkedListBoxAssets.CheckedItems)
                {
                    DataOneAsset findedAsset = findedAd.assetList.Find(a => a.Asset.Equals(assetChecked.ToString()));
                    if (null == findedAsset) continue;

                    switch (comboBoxFilter.SelectedItem)
                    {
                        case "Balance": numData = findedAsset.TotalAssetBalance; break;
                        case "Price": numData = findedAsset.Price; break;
                        case "Worth": numData = findedAsset.Worth; break;
                    }
                    chart1.Series[0].Points.AddXY(
                        findedAd.platformName + '\n' + findedAsset.Asset + '\n' + numData,
                        numData
                        );
                }
            }
        }//m
        //--------
        private void buttonSetPassAndName_Click(object sender, EventArgs e)
        {
            FormSetPassAndName f = new FormSetPassAndName();
            f.Owner = this;
            f.ShowDialog();
        }
        private void buttonDecodeKeySet_Click(object sender, EventArgs e)
        {
            FormKeySetDecode f = new FormKeySetDecode();
            f.Owner = this;
            f.ShowDialog();
        }
        private void buttonAddAdapter_Click(object sender, EventArgs e)
        {
            if (!CellOfFirstColumnSelectedOrNothing()) return;
            FormAddKeySet formAddKeySet = new FormAddKeySet();
            formAddKeySet.Owner = this;
            formAddKeySet.ShowDialog();
        }
        private void buttonDelAdapter_Click(object sender, EventArgs e)
        {
            if (!CellOfFirstColumnSelectedOrNothing()) return;
            DelAdapterInAllPlaces( dataGridView1.SelectedCells[0].Value.ToString() );
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
        //--------------------------------------------------------------------------menu
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            Keys.KeyStorage loadedKeyStorage = null;

            openFileDialog.Filter = "bin files (*.bin)|*.bin";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK) //{ return; }
            {
                //string filePath = openFileDialog1.FileName;
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    //FileIOSerializer.loadMk2(ref treeNode, myStream);
                    FileIOSerializer.load(ref loadedKeyStorage, stream);
                    adapter_Aggregator.KeyStorage = loadedKeyStorage;

                    labelName.Text = "Name " + loadedKeyStorage._ksName;
                    labelPassSetted.Text = "Pass setted from file";

                    stream.Close();
                }
            }
        }//m
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "bin files (*.bin)|*.bin";
            //saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) //{ return; }
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    //FileIOSerializer.save(adapter_Aggregator.ke, myStream);
                    adapter_Aggregator.SaveKeyStorageToFile(stream);
                    stream.Close();
                }
            }
        }

        //------------------------------------------------------------------------------------end
    }//c
}//n
