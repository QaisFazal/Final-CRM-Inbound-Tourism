using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Inbound_Tourism_Project
{
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            InitializeComponent();
           

            pnlSlide.Width = 60;
            pnlBorder.Left = 60;
            pnlMarked.Height = button1.Height;
            /*
            itineraryBuilderControl1.Hide();
            hotalControl1.Hide();
            locationControl1.Hide();
            addUserControl1.Hide();*/
           // dayToDayPlanControl1.Hide();

            homeControl1.BringToFront();
            
            

        }
        //private void PopulateItem()
        //{
        //    HomePropertiesControl[] homePropertiesControls = new HomePropertiesControl[20];
        //    for (int i = 0; i<homePropertiesControls.Length; i++)
        //    {
        //        homePropertiesControls[i] = new HomePropertiesControl();
        //        homePropertiesControls[i].Name = "Name";
        //        homePropertiesControls[i].ArrivalDate = "Arrival Date";
        //        homePropertiesControls[i].DepatureDate = "Depature Date";

        //        if (homeControl1.Controls.Count < 0)
        //        {
        //            homeControl1.Controls.Clear();
        //        }
        //        else
        //            homeControl1.Controls.Add(homePropertiesControls[i]);


        //    }




        //}
        private void lblExit_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

                pnlSlide.Width = 60;
            pnlBorder.Left = 60;
              

            pnlSlide.Visible = false;


            panelInAnimator.ShowSync(pnlSlide);
            logoAnimator.ShowSync(logo);
            panelInAnimator.ShowSync(pnlBorder);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlSlide.Width = 240;
            pnlBorder.Left = 240;
            

            pnlSlide.Visible = false;

            pnlOutAnimator.ShowSync(pnlSlide);
            logoAnimator.ShowSync(logo);
            pnlOutAnimator.ShowSync(pnlBorder);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMarked.Height = button1.Height;
            pnlMarked.Top = button1.Top;
            /*
            itineraryBuilderControl1.Hide();
            hotalControl1.Hide();
            locationControl1.Hide();
            addUserControl1.Hide();
            dayToDayPlanControl1.Hide();*/
            homeControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlMarked.Height = button5.Height;
            pnlMarked.Top = button5.Top;
            /*
            hotalControl1.Hide();
            locationControl1.Hide();
            addUserControl1.Hide();
            homeControl1.Hide();*/
            dayToDayPlanControl1.Hide();
            itineraryBuilderControl1.BringToFront();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlMarked.Height = button4.Height;
            pnlMarked.Top = button4.Top;
            /*
            locationControl1.Hide();
            addUserControl1.Hide();
            homeControl1.Hide();
            itineraryBuilderControl1.Hide();
            dayToDayPlanControl1.Hide();*/
            hotalControl1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlMarked.Height = button6.Height;
            pnlMarked.Top = button6.Top;
            /*
            addUserControl1.Hide();
            homeControl1.Hide();
            itineraryBuilderControl1.Hide();
            hotalControl1.Hide();
            dayToDayPlanControl1.Hide();*/
            locationControl1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlMarked.Height = button7.Height;
            pnlMarked.Top = button7.Top;
            /*
            homeControl1.Hide();
            itineraryBuilderControl1.Hide();
            hotalControl1.Hide();
            locationControl1.Hide();
            dayToDayPlanControl1.Hide();
            addUserControl1.Hide();*/
            addUserControl1.BringToFront();
           
        }

        private void Landing_Page_Load(object sender, EventArgs e)
        {

        }

        private void SidePanelMouseHover(object sender, EventArgs e)
        {
            if (pnlSlide.Width == 60)
            {
                pnlSlide.Width = 240;
                pnlBorder.Left = 240;
               

                pnlSlide.Visible = false;

                pnlOutAnimator.ShowSync(pnlSlide);
                logoAnimator.ShowSync(logo);
                pnlOutAnimator.ShowSync(pnlBorder);
            }
        }

        private void SidePanelMouseLevaer(object sender, EventArgs e)
        {
            /*
            if (pnlSlide.Width == 240) { 
            pnlSlide.Width = 60;
            pnlBorder.Left = 60;
            button3.Visible = true;

            pnlSlide.Visible = false;


            panelInAnimator.ShowSync(pnlSlide);
            logoAnimator.ShowSync(logo);
            panelInAnimator.ShowSync(pnlBorder);
        }*/
        }

        private void itinryBuilderMouseClicked(object sender, MouseEventArgs e)
        {
            pnlSlide.Width = 60;
            pnlBorder.Left = 60;
            

            pnlSlide.Visible = false;


            panelInAnimator.ShowSync(pnlSlide);
            logoAnimator.ShowSync(logo);
            panelInAnimator.ShowSync(pnlBorder);
        }

        private void HomeMouseClicked(object sender, MouseEventArgs e)
        {

            pnlSlide.Width = 60;
            pnlBorder.Left = 60;
           

            pnlSlide.Visible = false;


            panelInAnimator.ShowSync(pnlSlide);
            logoAnimator.ShowSync(logo);
            panelInAnimator.ShowSync(pnlBorder);
        }

        private void HotelMouseClicked(object sender, MouseEventArgs e)
        {
            pnlSlide.Width = 60;
            pnlBorder.Left = 60;
           
            pnlSlide.Visible = false;


            panelInAnimator.ShowSync(pnlSlide);
            logoAnimator.ShowSync(logo);
            panelInAnimator.ShowSync(pnlBorder);
        }

        private void AddUserMouseClicked(object sender, MouseEventArgs e)
        {
            pnlSlide.Width = 60;
            pnlBorder.Left = 60;
           

            pnlSlide.Visible = false;


            panelInAnimator.ShowSync(pnlSlide);
            logoAnimator.ShowSync(logo);
            panelInAnimator.ShowSync(pnlBorder);
        }

        private void LocationMouseClicked(object sender, MouseEventArgs e)
        {
            pnlSlide.Width = 60;
            pnlBorder.Left = 60;
            

            pnlSlide.Visible = false;


            panelInAnimator.ShowSync(pnlSlide);
            logoAnimator.ShowSync(logo);
            panelInAnimator.ShowSync(pnlBorder);
        }

        private void DayToDayPlanMouseClicked(object sender, MouseEventArgs e)
        {
            pnlSlide.Width = 60;
            pnlBorder.Left = 60;
           
            pnlSlide.Visible = false;


            panelInAnimator.ShowSync(pnlSlide);
            logoAnimator.ShowSync(logo);
            panelInAnimator.ShowSync(pnlBorder);
        }

        private void homeControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
