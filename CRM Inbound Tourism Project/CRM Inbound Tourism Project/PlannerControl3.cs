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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CRM_Inbound_Tourism_Project
{
    public partial class PlannerControl3 : UserControl
    {
        public int id;
        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");

        private static String tripId;

        private static String depatureDate;
        private static String mealPreference;
        private static String hotelStatus;
        private static int singleRoom, doubleRoom, tripleRoom;
        private double total = 0 ;


        public PlannerControl3()
        {
            InitializeComponent();
            fillLocation();
        }


        public String setMealPreference {
            get { return mealPreference; }
            set { mealPreference = value; }
        }

        public String setHotelStatus {
            get { return hotelStatus; }
            set { hotelStatus = value; }
        }


        
        public int setSingleRoom{
               get{ return singleRoom; }
               set{ singleRoom = value; }
        }

        public int setDoubleRoom {
            get { return doubleRoom; }
            set { doubleRoom = value; }
        }

        public int setTripleRoom {

            get { return tripleRoom; }
            set { tripleRoom = value; }
        }



        public String controlTripId {
            get { return tripId; }
            set { tripId = value; }
        }

        public String setDepatureDate {
            get { return depatureDate; }
            set { depatureDate = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlannerControl3_Load(object sender, EventArgs e)
        {
            showToDataGridView();
            fillLocation();
        }

        private void btnAddDayPlan_Click(object sender, EventArgs e)
        {
            if (startTme.Text != "" || endTime.Text != "" || cmbALocation.Text != "" || cmbArea.Text != "" || cmbHotels.Text != "")
            {
                addCustomer();
                showToDataGridView();
            }
            else {
                MessageBox.Show("fill all the fields to proceed");
            }
        }


        private void addCustomer()
        {
            double singlePrice = Convert.ToDouble(txtSingle.Text) * singleRoom;
            double doublePrice = Convert.ToDouble(txtDouble.Text) * doubleRoom;
            double triplePrice = Convert.ToDouble(txtDouble.Text) * tripleRoom;

            total = singlePrice + doublePrice + triplePrice;

            String sql = "INSERT INTO plans ( " +
                "tripId, " +
                "startDate, " +
                "startTime, " +
                "endTime, " +
                "location, " +
                "area, " +
                "hotel," +
                "price ) " +
               
                "VALUES('"  
                + tripId+ "','" 
                + dtpStart.Text + "','" 
                + startTme.Text + "','" 
                + endTime.Text+ "','" 
                + cmbLocation.Text + "','" 
                + cmbArea.Text + "','" 
                + cmbHotels.Text + "','"
                + total +
                "')";

            String sql1 = "SELECT * FROM plans";

            try
            {

                MySqlCommand command1 = new MySqlCommand(sql1, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();

                while (dataReader1.Read()) {
                    id = (int)dataReader1["id"];
                    id = id + 1;
                }
                conn.Close();

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();
                MessageBox.Show("Successfully added...!");
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }
        }

        private void showToDataGridView()
        {
            String sql = "SELECT * FROM plans WHERE tripId='" + tripId + "'";

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

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            setSelectedDay();
            validateDateSelection();
        }

        private void setSelectedDay() {

            lblSelectedDay.Text = dtpStart.Value.Date.ToShortDateString();

        }

        private void validateDateSelection() {
            
            DateTime aDate = dtpStart.Value.Date;
            DateTime eDate = Convert.ToDateTime(depatureDate);
            //DateTime dDate = txtDepatureDate.Value.Date;

            //System.TimeSpan diff = dDate.Subtract(aDate);

            String re = (eDate - aDate).TotalDays.ToString();
            int val = Convert.ToInt16(re);


            //int value = DateTime.Compare(aDate, eDate);

            if (val < 0)
            {
                MessageBox.Show("select appropriated date");

                //dtpStart.Enabled = false;
                startTme.Enabled = false;
                endTime.Enabled = false;
                cmbLocation.Enabled = false;
                cmbArea.Enabled = false;
                cmbHotels.Enabled = false;


                //dtpADate.Enabled = false;
                txtAStartTime.Enabled = false;
                txtAEndTime.Enabled = false;
                cmbALocation.Enabled = false;
                cmbAArea.Enabled = false;
                cmbAHotel.Enabled = false;
            }
            else {


                //dtpStart.Enabled = false;
                startTme.Enabled = true;
                endTime.Enabled = true;
                cmbLocation.Enabled = true;
                cmbArea.Enabled = true;
                cmbHotels.Enabled = true;


                //dtpADate.Enabled = false;
                txtAStartTime.Enabled = true;
                txtAEndTime.Enabled = true;
                cmbALocation.Enabled = true;
                cmbAArea.Enabled = true;
                cmbAHotel.Enabled = true;
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtAId.Text = row.Cells["tripId"].Value.ToString();
                dtpADate.Text = row.Cells["startDate"].Value.ToString();
                txtAStartTime.Text = row.Cells["startTime"].Value.ToString();
                txtAEndTime.Text = row.Cells["endTime"].Value.ToString();
                cmbALocation.Text = row.Cells["location"].Value.ToString();
                cmbAArea.Text = row.Cells["area"].Value.ToString();
                cmbAHotel.Text = row.Cells["hotel"].Value.ToString();
            }
        }

        private void updatePlan() {

            String sql = "UPDATE plans " +
                "SET tripId='" + txtAId.Text +
                "',startDate = '" + dtpADate.Text +
                "',startTime ='" + txtAStartTime.Text +
                "',endTime ='" + txtAEndTime.Text +
                "',location='" + cmbALocation.Text +
                "',area='" + cmbAArea.Text +
                "',hotel='" + cmbAHotel.Text +
                "' WHERE tripId = '" + txtAId.Text +"'";


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatePlan();
            showToDataGridView();
        }

        private void dtpADate_ValueChanged(object sender, EventArgs e)
        {
            validateDateSelection();
        }

        private void fillLocation() {

            String sql = "SELECT * FROM districts";

            try
            {

                MySqlCommand command1 = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();

                while (dataReader1.Read()) {
                    String locations = dataReader1.GetString("districtName");
                    cmbALocation.Items.Add(locations);
                    cmbLocation.Items.Add(locations);
                }


                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to update records : " + e);
                conn.Close();
            }
        }

        private void fillArea() {

            String sql = "SELECT locationName FROM locations WHERE district ='" + cmbLocation.Text+"'";

            try
            {
                
                MySqlCommand command1 = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();
                cmbAArea.Items.Clear();
                while (dataReader1.Read())
                {
                    String area = dataReader1.GetString("locationName");
                    cmbArea.Items.Add(area);
                }
                
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to update records : " + e);
                conn.Close();
            }

        }

        private void fillHotel() {

            String sql = "SELECT name FROM hotels WHERE location ='" + cmbLocation.Text + "' AND h_status = '" + hotelStatus + "'";

            try
            {
                MySqlCommand command1 = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();
                cmbAHotel.Items.Clear();
                while (dataReader1.Read())
                {
                    String hotels = dataReader1.GetString("name");
                    cmbHotels.Items.Add(hotels);
                }

                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to update records : " + e);
                conn.Close();
            }

        }

        private void fillHotelPrice() {

            String sqlSelectRoomPriceSingle = "SELECT * FROM rooms WHERE hotel='"+cmbHotels.Text+ "' AND room_type='1'";
            String sqlSelectRoomPriceDouble = "SELECT * FROM rooms WHERE hotel='" + cmbHotels.Text + "' AND room_type='2'";
            String sqlSelectRoomPriceTriple = "SELECT * FROM rooms WHERE hotel='" + cmbHotels.Text + "' AND room_type='3'";

            try
            {
                
                MySqlCommand command1 = new MySqlCommand(sqlSelectRoomPriceSingle, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();

                while (dataReader1.Read())
                {
                    txtSingle.Text = dataReader1.GetString("price");
                    
                }
                conn.Close();


                /// double room 
                MySqlCommand command2 = new MySqlCommand(sqlSelectRoomPriceDouble, conn);
                MySqlDataReader dataReader2;
                conn.Open();
                dataReader2 = command2.ExecuteReader();

                while (dataReader2.Read())
                {

                    txtDouble.Text = dataReader2.GetString("price");

                }
                conn.Close();


                // triple room 
                MySqlCommand command3 = new MySqlCommand(sqlSelectRoomPriceTriple, conn);
                MySqlDataReader dataReader3;
                conn.Open();
                dataReader3 = command3.ExecuteReader();

                while (dataReader3.Read())
                {

                    txtTriple.Text = dataReader3.GetString("price");

                }
                conn.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to update records : " + e);
                conn.Close();
            }
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillArea();
            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            generatePDFInvoice();
        }

        private void cmbLocation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fillArea();
        }

        private void cmbArea_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fillHotel();
        }

        private void cmbHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillHotelPrice();
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillHotel();
        }


        private void generatePDFInvoice() {

            String sql = "SELECT * FROM plans WHERE tripId='" + tripId + "'";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("D:/doc.pdf", FileMode.Create));
                doc.Open();
                Paragraph p1 = new Paragraph("Invoice");
                Paragraph p2 = new Paragraph("");
                doc.Add(p1);

                int i = 0;
                double tot = 0;
                while (dataReader.Read()) {
                    i++;
                    Paragraph paragraph = new Paragraph("Day "+i+"  :" + total);
                    tot = tot + total;
                    doc.Add(paragraph);
                }

                Paragraph totalP = new Paragraph("Toatl : " + tot);
                doc.Add(totalP);
                doc.Close();
                MessageBox.Show("Invoice generated");

                conn.Close();


                System.Diagnostics.Process.Start("D:/doc.pdf");

            }
            catch (Exception e)
            {
                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }



            
            
        }
    }
}
