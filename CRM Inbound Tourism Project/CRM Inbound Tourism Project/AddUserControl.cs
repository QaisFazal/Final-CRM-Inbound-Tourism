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
    public partial class AddUserControl : UserControl
    {

        String id, name, number, residence, email, nationality, language;

        private void button1_Click(object sender, EventArgs e)
        {
            searchUser();
        }



        private void searchUser() {

            String sql = "SELECT * FROM user_credentials WHERE user_id = '"+txtSearchText.Text+"'";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("there is eror in searching data for you, check user mail please" + e);
                conn.Close();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                //txtSelectedTrip.Text = row.Cells["tripId"].Value.ToString();
                txtReMail.Text = row.Cells["user_id"].Value.ToString();
                txtReUserName.Text = row.Cells["user_name"].Value.ToString();
                txtReUserType.Text = row.Cells["user_type"].Value.ToString();


            }
        }

        private void updateUser() {
            if (txtRePass.Text.Equals(txtReRePass.Text)) {
                String sql = "UPDATE user_credentials " +
                "SET user_name='" + txtReUserName.Text +
                "',user_type='" + txtReUserType.Text +
                "', access_code = '" + txtRePass.Text +
                "' WHERE user_id = '" + txtReMail.Text + "'";


                try
                {

                    MySqlCommand command1 = new MySqlCommand(sql, conn);
                    MySqlDataReader dataReader1;
                    conn.Open();
                    dataReader1 = command1.ExecuteReader();

                    MessageBox.Show("Successfully updated...!");
                    conn.Close();
                    
                }
                catch (Exception e)
                {

                    MessageBox.Show("There is a error while attepmting to update records : " + e);
                    conn.Close();
                }

            }
            else {
                MessageBox.Show("Passwords are not matching");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            deleteUser();
        }

        private void deleteUser() {


            String sql = "DELETE  FROM user_credentials  WHERE user_id='" + txtReMail.Text + "'";


            try
            {

                MySqlCommand command1 = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();

                MessageBox.Show("Successfully deleted...!");
                conn.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to delete record : " + e);
                conn.Close();
            }

        }

        private void btnAddDeatils_Click_1(object sender, EventArgs e)
        {
            addCustomer();
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDeatils_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");

        public AddUserControl()
        {
            InitializeComponent();
        }

        private void addCustomer()
        {


            //String sql = "INSERT INTO user_credentials (name,phone_number,residence,email, nationality, c_language) VALUES('" + name + "','" + number + "','" + residence + "','" + email + "','" + nationality + "','" + language + "')";


            if (pass.Text.Equals(rePass.Text))
            {

                String sql = "INSERT INTO user_credentials (user_id, user_name, user_type, access_code) VALUES('" + tbEmail.Text + "','" + tbUserName.Text + "','" + cbCountryOfResidance.Text + "','" + pass.Text + "')";

                if (tbUserName.Text.Equals("") || cbCountryOfResidance.Text.Equals("") || tbEmail.Text.Equals("") || rePass.Text.Equals(""))
                {

                    MessageBox.Show("Please fill all the required fields..");

                }
                else
                {
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        MySqlDataReader dataReader;
                        conn.Open();
                        dataReader = command.ExecuteReader();

                        //assigning email to email in plannerControl2
                        PlannerControl2 control2 = new PlannerControl2();
                        //plannerControl2.UserMail = email;
                        //end 


                        MessageBox.Show("Successfully saved...!");
                        conn.Close();

                    }
                    catch (Exception e)
                    {

                        MessageBox.Show("There is a error while attepmting to add records : " + e);
                        conn.Close();
                    }

                }
            }
            else {
                MessageBox.Show("passwords are not matching");
            }
        }
    }
}
