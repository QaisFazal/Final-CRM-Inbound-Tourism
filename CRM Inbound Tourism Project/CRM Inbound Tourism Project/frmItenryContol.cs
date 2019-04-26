using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM_Inbound_Tourism_Project
{
    public partial class frmItenryContol : Form
    {
        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");


        public frmItenryContol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadTrips();
        }

        public void loadTrips()
        {

            String sql = "SELECT * FROM trips WHERE tripId LIKE '%" + txtCustomerId.Text + "%'";


            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateTrip();
        }

        private void updateTrip()
        {

            String sql = "UPDATE trips" +
                " SET arivalDate = '" + arival.Text +
                "', arivalDate = '" + arival.Text +
                "', depatureDate = '" + depature.Text +
                "', adults = '" + adults.Text +
                "', childrents = '" + childrends.Text +
                "', noOfDays = '" + noOfDays.Text +
                "', noOfRooms = '" + noOfRooms.Text +
                "', singleRoom = '" + singleRoom.Text +
                "', doubleRoom = '" + doubleRoom.Text +
                "', tripleRoom = '" + tripleRoom.Text +
                "', meal = '" + cmbMeals.Text +
                "', starGategory = '" + cmbCategary.Text +
                "' WHERE tripId ='" + tripId.Text + "'";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();

                MessageBox.Show("Successfully updated...!");
                conn.Close();


            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];

                //txtSelectedTrip.Text = row.Cells["tripId"].Value.ToString();
                tripId.Text = row.Cells["tripId"].Value.ToString();
                arival.Text = row.Cells["arivalDate"].Value.ToString();
                depature.Text = row.Cells["depatureDate"].Value.ToString();
                adults.Text = row.Cells["adults"].Value.ToString();
                childrends.Text = row.Cells["childrents"].Value.ToString();
                noOfDays.Text = row.Cells["noOfDays"].Value.ToString();
                noOfRooms.Text = row.Cells["noOfRooms"].Value.ToString();
                singleRoom.Text = row.Cells["singleRoom"].Value.ToString();
                doubleRoom.Text = row.Cells["doubleRoom"].Value.ToString();
                tripleRoom.Text = row.Cells["tripleRoom"].Value.ToString();
                cmbMeals.Text = row.Cells["meal"].Value.ToString();
                cmbCategary.Text = row.Cells["starGategory"].Value.ToString();
            }
        }
    }


}
