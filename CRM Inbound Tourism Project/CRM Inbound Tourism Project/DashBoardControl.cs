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

           // ListView();
            graph();

            

        }
        private void ListView()
        {
            HomePropertiesControl[] homePropertiesControls = new HomePropertiesControl[20];
            for(int i=0; i<homePropertiesControls.Length; i++)
            {
                homePropertiesControls[i] = new HomePropertiesControl();
                homePropertiesControls[i].Name = "Nasik";
                homePropertiesControls[i].ArrivalDate = "02.2.2019";
                homePropertiesControls[i].DepatureDate = "30.2.2019";
                homePropertiesControls[i].PassportNo = "889898-98098";
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                flowLayoutPanel1.Controls.Add(homePropertiesControls[i]);
                
                

            }
        }
        public void graph()
        {
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
           


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoardControl_Load(object sender, EventArgs e)
        {
            ListView();
        }
    }
}
