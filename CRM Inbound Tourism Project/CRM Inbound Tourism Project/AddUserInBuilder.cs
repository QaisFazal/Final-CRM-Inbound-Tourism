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
    

    public partial class AddUserInBuilder : UserControl
    {
        
        private String id, name, number, residence, email, nationality, language;
        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");

        private void cbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tbPreferredLanguage_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tbContactNumber_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tbUserName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCountryOfResidance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPreferredLanguage_Click(object sender, EventArgs e)
        {

        }

        private void lblCountryOfResidance_Click(object sender, EventArgs e)
        {

        }

        private void lblNationality_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        PlannerControl2 plannerControl2 = null;
        AddUserInBuilder addUserInBuilder = null;
        public AddUserInBuilder()
        {
            InitializeComponent();
        }

        private void AddUserInBuilder_Load(object sender, EventArgs e)
        {

        }


        private void btnAddDeatils_Click(object sender, EventArgs e)
        {
             addCustomer();

            
            
            //this.Controls.Remove(addUserInBuilder);
            
        }

        private void addCustomer()
        {
            
            name = tbUserName.Text;
            number = tbContactNumber.Text;
            residence = cbCountryOfResidance.Text;
            email = tbEmail.Text;
            nationality = cbNationality.Text;
            language = tbPreferredLanguage.Text;

            String sql = "INSERT INTO customers (name,phone_number,residence,email, nationality, c_language) VALUES('"+ name + "','" + number + "','" + residence + "','" + email + "','" + nationality + "','" + language + "')";


            if (  tbUserName.Text.Equals("") || tbContactNumber.Text.Equals("") || cbCountryOfResidance.Text.Equals("") || tbEmail.Text.Equals("") || cbNationality.Text.Equals("") || tbPreferredLanguage.Text.Equals("") ) {

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

                    /*
                    plannerControl2 = new PlannerControl2();
                    this.Controls.Add(plannerControl2);
                    addUserInBuilder.Hide();
                    */

                    addUserInBuilder = new AddUserInBuilder();
                    plannerControl2 = new PlannerControl2();
                    plannerControl2.UserMail = tbEmail.Text;
                    this.Controls.Clear();
                    this.Controls.Add(plannerControl2);

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
