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

            name = tbUserName.Text;
            number = tbContactNumber.Text;
            residence = cbCountryOfResidance.Text;
            email = tbEmail.Text;
            nationality = cbNationality.Text;
            language = tbPreferredLanguage.Text;

            String sql = "INSERT INTO customers (name,phone_number,residence,email, nationality, c_language) VALUES('"  + name + "','" + number + "','" + residence + "','" + email + "','" + nationality + "','" + language + "')";


            if (tbUserName.Text.Equals("") || tbContactNumber.Text.Equals("") || cbCountryOfResidance.Text.Equals("") || tbEmail.Text.Equals("") || cbNationality.Text.Equals("") || tbPreferredLanguage.Text.Equals(""))
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
    }
}
