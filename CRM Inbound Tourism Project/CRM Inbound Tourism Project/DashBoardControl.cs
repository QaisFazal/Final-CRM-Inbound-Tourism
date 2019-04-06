using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CRM_Inbound_Tourism_Project
{
    public partial class DashBoardControl : UserControl
    {
        public DashBoardControl()
        {
            InitializeComponent();

            float x1 = 11;
            float x2 = 21;
            float x3 = 39;
            float x4 = 5;
            float x5 = 6;
            float x6 = 2;
            float x7 = 30;
            float x8 = 32;
            float x9 = 40;
            float x10 = 42;


            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            

            //chart.AxisX.LabelStyle.Format = "";
            //chart.AxisY.LabelStyle.Format = "";
            //chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            chart.AxisX.MajorGrid.Enabled = false;
            chart.AxisX.Minimum = 1;
           // chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;
            //chart.AxisY.Maximum = 50;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            //chart1.Series.Add("Graph 1");
            //chart1.Series["Graph 1"].ChartType = SeriesChartType.Line;
            //chart1.Series["Graph 1"].Color = Color.Red;
            //chart1.Series[0].IsVisibleInLegend = false;

            chart1.Series["Graph 1"].Points.AddXY("D1", "0");
            chart1.Series["Graph 1"].Points.AddXY("D2", "10");
            chart1.Series["Graph 1"].Points.AddXY("D3", "23");
            chart1.Series["Graph 1"].Points.AddXY("D4", "5");
            chart1.Series["Graph 1"].Points.AddXY("D5", "8");
            chart1.Series["Graph 1"].Points.AddXY("D6", "18");
            chart1.Series["Graph 1"].Points.AddXY("D7", "28");
            chart1.Series["Graph 1"].Points.AddXY("D8", "20");
            chart1.Series["Graph 1"].Points.AddXY("D9", "19");
            chart1.Series["Graph 1"].Points.AddXY("D10", "11");

            chart1.Series["Graph 2"].Points.AddXY("D1", "0");
            chart1.Series["Graph 2"].Points.AddXY("D2", "6");
            chart1.Series["Graph 2"].Points.AddXY("D3", "18");
            chart1.Series["Graph 2"].Points.AddXY("D4", "23");
            chart1.Series["Graph 2"].Points.AddXY("D5", "10");
            chart1.Series["Graph 2"].Points.AddXY("D6", "12");
            chart1.Series["Graph 2"].Points.AddXY("D7", "16");
            chart1.Series["Graph 2"].Points.AddXY("D8", "25");
            chart1.Series["Graph 2"].Points.AddXY("D9", "10");
            chart1.Series["Graph 2"].Points.AddXY("D10", "5");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x1 = 11;
            float x2 = 21;
            float x3 = 39;
            float x4 = 5;
            float x5 = 6;
            float x6 = 2;
            float x7 = 30;
            float x8 = 32;
            float x9 = 40;
            float x10 = 42;


            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 50;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("HA NQ1");
            chart1.Series["HA NQ1"].ChartType = SeriesChartType.Line;
            chart1.Series["HA NQ1"].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;

            chart1.Series["HA NQ1"].Points.AddXY(1, x1);
            chart1.Series["HA NQ1"].Points.AddXY(2, x2);
            chart1.Series["HA NQ1"].Points.AddXY(3, x3);
            chart1.Series["HA NQ1"].Points.AddXY(4, x4);
            chart1.Series["HA NQ1"].Points.AddXY(5, x5);
            chart1.Series["HA NQ1"].Points.AddXY(6, x6);
            chart1.Series["HA NQ1"].Points.AddXY(7, x7);
            chart1.Series["HA NQ1"].Points.AddXY(8, x8);
            chart1.Series["HA NQ1"].Points.AddXY(9, x9);
            chart1.Series["HA NQ1"].Points.AddXY(10, x10);



        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
