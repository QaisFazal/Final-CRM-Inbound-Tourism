using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Inbound_Tourism_Project
{
    public partial class itineraryBuilderControl : UserControl
    {
        public itineraryBuilderControl()
        {
            InitializeComponent();
            //dayToDayPlanControl1.Hide();
            dayToDayPlanControl1.Visible = false;
           
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            // pnlMarked.Height = button5.Height;
            //pnlMarked.Top = button5.Top;

            // Control trainerTab1 = this.Controls.Find("dayToDayPlanControl", true);
            // Parent.Controls["dayToDayPlanControl"].BringToFront();

            // Landing_Page.Controls["dayToDayPlanControl"].BringToFront();

            int B = 1;
            int value = int.Parse(cbNoOfDays.Text);
            //int  c = cbNoOfDays.g
            for (int i = 0; i < value; i++) { 
            Label abc = new Label();
            dayToDayPlanControl1.Controls.Add(abc);
            abc.Top = i * 50;
            abc.Left = 150;
                abc.Text = "Day" + B.ToString();
            B = B + 1;
            // return abc;
        }
        
            dayToDayPlanControl1.BringToFront();
            dayToDayPlanControl1.Visible = true;

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayToDayPlanControl1_Click(object sender, EventArgs e)
        {
            //Base b = new Base();
            //b.panelMenue.Width = 53;
        }

        private void dayToDayPlanControl1_MouseClick(object sender, MouseEventArgs e)
        {
            //Base b = new Base();
            //b.panelMenue.Width = 53;
        }

        private void lblItineraraybuilder_Click(object sender, EventArgs e)
        {
            //Base b = new Base();
            //lblItineraraybuilder.panelMenue.Width = 53;
        }
    }
}
