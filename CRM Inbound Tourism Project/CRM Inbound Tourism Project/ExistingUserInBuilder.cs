using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM_Inbound_Tourism_Project
{
    public partial class ExistingUserInBuilder : UserControl
    {

        private PlannerControl2 plannerControl2;
        

        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");
        private String userMail;
        DateTime date = DateTime.Now;

        public ExistingUserInBuilder()
        {
            InitializeComponent();

        }

        private void searchExistingCustomer() {

            String sql = "SELECT * FROM customers WHERE email='" + tbSearch.Text + "'";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgvAddUser.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }

        }


        private void dgvAddUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {

                DataGridViewRow row = this.dgvAddUser.Rows[e.RowIndex];

                userMail = row.Cells["email"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                searchExistingCustomer();
            }
            else {
                MessageBox.Show("Enter a customer mail to search customer");
            }
        }

        private void ExistingUserInBuilder_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text != "")
            {
                PlannerControl2 plannerControl2 = new PlannerControl2();
                plannerControl2.UserMail = (userMail + date);
                this.Controls.Clear();
                this.Controls.Add(plannerControl2);
                
                
            }
            else {
                MessageBox.Show("please select a user to proceed ");
            }
        }
    }
}
