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
    public partial class PlannerControl : UserControl
    {
        public PlannerControl()
        {
            InitializeComponent();
            
        }

        private void PlannerControl_Load(object sender, EventArgs e)
        {
            addUserInBuilder1.Visible = false;
            //plannerControl31.Visible = false;
            existingUserInBuilder1.Visible = true;

            itenararyControl1.Hide();

        }

        
        private void btnNewUser_Click_1(object sender, EventArgs e)
        {
            //addUserInBuilder1.Visible = true;
            //addUserInBuilder1.BringToFront();
            //existingUserInBuilder1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //addUserInBuilder1.Visible = true;
            //addUserInBuilder1.Visible = false; ;
            //existingUserInBuilder1.BringToFront();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {


            addUserInBuilder1.Visible = true;
            addUserInBuilder1.BringToFront();
            existingUserInBuilder1.Visible = false;

            //addUserInBuilder1.Show();
            //ExistingUserInBuilder eu = new ExistingUserInBuilder();
            //eu.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            existingUserInBuilder1.Visible = true;
            addUserInBuilder1.Visible = false; ;
            existingUserInBuilder1.BringToFront();
            // existingUserInBuilder1.Show();
            //// existingUserInBuilder1.Dock = DockStyle.Fill;
            ///
            //ExistingUserInBuilder eu = new ExistingUserInBuilder();
            //eu.Dock = DockStyle.Fill;
            //panel7.Controls["ExistingUserInBuilder"].BringToFront();
            //AddUserInBuilder au = new AddUserInBuilder();
            //au.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            addUserInBuilder1.Visible = true;
            addUserInBuilder1.BringToFront();
            existingUserInBuilder1.Visible = false;
            panel4.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void existingUserInBuilder1_Load(object sender, EventArgs e)
        {

        }

        private void lblGenerateBill_Click(object sender, EventArgs e)
        {
            BillsForm billsForm = new BillsForm();
            billsForm.Show();
            billsForm.Focus();
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            existingUserInBuilder1.Hide();
            itenararyControl1.Show();
        }

        private void itenararyControl1_Load(object sender, EventArgs e)
        {
            existingUserInBuilder1.Show();
            itenararyControl1.Hide();
            
        }
    }
}
