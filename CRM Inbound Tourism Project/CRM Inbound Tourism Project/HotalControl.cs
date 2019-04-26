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
    public partial class HotalControl : UserControl
    {

        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");

        public HotalControl()
        {
            InitializeComponent();
            loadLocation();
        }

        private void HotalControl_Load(object sender, EventArgs e)
        {
            loadLocation();     
        }

        private void addHotels() {

            String sql = "INSERT INTO hotels (name,location,h_status, singleRoomPrice, doubleRoomPrice, tripRoomPrice) VALUES('" + this.tbHotelName.Text+ "','" + this.cmbHotelLocation.Text +"','"+  this.cmbHotelStatus.Text + "','"+txtSingle.Text+"','"+txtDouble.Text+"','"+txtTriple.Text+"')";

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


        private void loadLocation() {
            String sql = "SELECT * FROM districts";

            try
            {

                MySqlCommand command1 = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();


                cmbHotelLocation.Items.Clear();
                cmbHotelLocation1.Items.Clear();
                while (dataReader1.Read())
                {
                    String locations = dataReader1.GetString("districtName");
                    cmbHotelLocation.Items.Add(locations);
                    cmbHotelLocation1.Items.Add(locations);
                }


                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to update records : " + e);
                conn.Close();
            }
        }

        private void btnAddDeatils_Click(object sender, EventArgs e)
        {
            if (tbHotelName.Text != "")
            {
                addHotels();
            }
            else {

                MessageBox.Show("fill all the fields");
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                searchHotel();
            }
            else {

                MessageBox.Show("Enter hotel name to search ");

            }
        }

        private void searchHotel() {

            String sql = "SELECT * FROM hotels WHERE name = '" + tbSearch.Text+"'";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgvHotel.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }

        }

        private void dgvHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHotel.Rows[e.RowIndex];
                //cmbHotelLocation1.Items.Clear();
                //cmbHotelStatus1.Items.Clear();

                txtHotelName1.Text = row.Cells["name"].Value.ToString();
                //cmbHotelLocation1.Items.Add(row.Cells["location"].Value.ToString());
                //cmbHotelStatus1.Items.Add(row.Cells["h_status"].ToString());
                //cmbHotelLocation1.Text = row.Cells["location"].Value.ToString();
                //cmbHotelStatus1.Text = row.Cells["h_status"].ToString();
            }
        }

        private void updateHotels() {


            String sql = "UPDATE hotels " +
                "SET name='" + txtHotelName1.Text +
                "',location='" + cmbHotelLocation1.Text +
                "',h_status='" + cmbHotelStatus1.Text +
                "' WHERE name = '" + txtHotelName1.Text + "'";
            
            try
            {

                MySqlCommand command1 = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();

                MessageBox.Show("Successfully updated...!");
                conn.Close();
                txtHotelName1.Text = "";

            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to update records : " + e);
                conn.Close();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            updateHotels();
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteHotel() {

            String sql = "DELETE  FROM hotels WHERE name='"+txtHotelName1.Text+"'";

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
            deleteHotel();
        }
    }
}
