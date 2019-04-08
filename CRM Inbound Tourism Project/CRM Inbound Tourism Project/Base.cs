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
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel1.BackColor = Color.FromArgb(124, 68, 0);
           // panel2.BackColor = Color.FromArgb(238, 236, 230);
            panelMenue.BackColor = Color.FromArgb(242, 238, 237);
            pictureBox1.BackColor = Color.FromArgb(242, 238, 237);
            btnHome.BackColor = Color.FromArgb(242, 238, 237);
            btnItinerarry.BackColor = Color.FromArgb(242, 238, 237);
            button2.BackColor = Color.FromArgb(242, 238, 237);
            button3.BackColor = Color.FromArgb(242, 238, 237);
            button4.BackColor = Color.FromArgb(242, 238, 237);
           // btnClose.BackColor = Color.FromArgb(242, 238, 237);
            // pictureBox1.BackColor = Color.FromArgb(238, 236, 230);


            panel3.Height = btnHome.Height;
            panel3.Top = btnHome.Top;

            //plannerControl1.Visible = false;
            dashBoardControl4.BringToFront();
            //addUserControl1.Visible = false;
        }

        private void Base_Load(object sender, EventArgs e)
        {
            //to make maxmize
            WindowState = FormWindowState.Maximized;

            //hiding userControls 

            //locationControl1.Hide();
            //plannerControl1.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this code will close the system completely
            System.Windows.Forms.Application.Exit();
        }

        private void btnItinerarry_Click(object sender, EventArgs e)
        {
            //locationControl1.Hide();
            //plannerControl1.Show();

            plannerControl3.BringToFront();
            
            panel3.Height = btnItinerarry.Height;
            panel3.Top = btnItinerarry.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //locationControl1.Hide();
            //plannerControl1.Hide();

           dashBoardControl4.BringToFront();

            panel3.Height = btnHome.Height;
            panel3.Top = btnHome.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //locationControl1.Hide();
            //plannerControl1.Hide();

            hotalControl3.BringToFront();
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //locationControl1.Show();
            //plannerControl1.Hide();

            locationControl3.BringToFront();
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //locationControl1.Hide();
            //plannerControl1.Hide();
            //addUserControl1.Visible = true;
            addUserControl2.BringToFront();
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;
        }

        private void plannerControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMenue.Width = 53;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelMenue.Width = 233;
            panel2.Visible = true;
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            panelMenue.Width = 233;
            panel2.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            //panelMenue.Width = 53;
            ////
            //panel2.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

