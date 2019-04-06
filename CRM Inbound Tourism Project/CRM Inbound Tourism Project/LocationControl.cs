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
    public partial class LocationControl : UserControl
    {
        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");

        public LocationControl()
        {
            InitializeComponent();
        }

        private void LocationControl_Load(object sender, EventArgs e)
        {
            populateComboBox();
        }


        private void btnAddDeatils_Click(object sender, EventArgs e)
        {
            addLocation();
        }

        private void addLocation()
        {

            String sql = "INSERT INTO locations (locationName, district) VALUES ('" + tbLocationName.Text + "','" + cmbDistrict.Text + "')"; 

            if (tbLocationName.Text.Equals("") || cmbDistrict.Text.Equals(""))
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

        private void populateComboBox() {


            String sql = "SELECT * FROM districts";

            try
            {

                MySqlCommand command1 = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();

                while (dataReader1.Read())
                {
                    String locations = dataReader1.GetString("districtName");
                    cmbDistrict.Items.Add(locations);
                }


                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to update records : " + e);
                conn.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchLocation();
        }

        private void searchLocation() {

            String sql = "SELECT * FROM locations WHERE locationName='" + tbSearch.Text + "'";

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
                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtLocation.Text = row.Cells["locationName"].Value.ToString();
            }
        }

        private void deleteLocation() {

            String sql = "DELETE  FROM locations WHERE locationName='" + txtLocation.Text + "'";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();
                MessageBox.Show("Succesfully deleted ");
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteLocation();
        }
    }
}
