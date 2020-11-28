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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //FormAddKeySet formAddKeySet = new FormAddKeySet();
            //formAddKeySet.Show();

            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Series[0].Points.AddXY("one", 1);
            chart1.Series[0].Points.AddXY("two", 1);
        }
    }
}
