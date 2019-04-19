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
    public partial class PlannerControl3 : UserControl
    {

        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");

        private PlannerControl3 plannerControl3;
        private PlannerControl2 plannerControl2;

        private String SQLPlannControl;
        private String singleRoom, doubleRoom, tripleRoom, adults, children, category;
        private int days;
        private String h_status; 
        private String tripId;


        public int controlDays {
            get { return days; }
            set { days = value; }
        }
    
        public String controlHStatus {
            get { return h_status; }
            set { h_status = value; }
        }

        public String controlTripId {
            get { return tripId; }
            set { tripId = value; }
        }

        public String controlSingleRoom {
            set { singleRoom = value; }
            get { return singleRoom; }
        }

        public String controlDoubleRoom {
            set { doubleRoom = value; }
            get { return doubleRoom; }
        }

        public String controlTripleRoom {
            get { return tripleRoom; }
            set { tripleRoom = value; }
        }

        public String controlAdults {
            get { return adults; }
            set { adults = value; }
        }

        public String controlChildren
        {
            get { return children; }
            set { children = value; }
        }


        public String controlCategory
        {
            get { return category; }
            set { category = value; }
        }

        public String controlSQLPlannControl{
            set{ SQLPlannControl = value; }
            get{ return SQLPlannControl; }
        }


        public PlannerControl3()
        {
            InitializeComponent();
           
        }

        
        private void PlannerControl3_Load(object sender, EventArgs e)
        {
            // PlannerControl3.Visible = false;
            //this.plannerControl3.single.Text(this.plannerControl2.txtSingle.Value);
            //int x = this.plannerControl2.txtSingle.Text;
            //single.Text = Value;
            int i = 1;
            lblSingleRoom.Text = singleRoom;
            lblDoubleRoom.Text = doubleRoom;
            lblTripleRoom.Text = tripleRoom;
            lblAdults.Text = adults;
            lblChildrens.Text = children;
            lblStarCategory.Text = category;
            l1.Text = Convert.ToString(i);

            loadFromAndTo();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nadult_OnValueChanged(object sender, EventArgs e)
        {

            //int a = nofAdults.Text != "" ? Convert.ToInt32(nofAdults.Text) : 0;
            //int b = txtAdult.Text != "" ? Convert.ToInt32(txtAdult.Text) : 0;
            //int total = a * b;
            //txtTotAdult.Text = total.ToString();
            
        }

        private void nadult_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void nadult_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void nchildren_OnValueChanged(object sender, EventArgs e)
        {
            //int a = txtChildren.Text != "" ? Convert.ToInt32(nofAdults.Text) : 0;
            //int b = bofChild.Text != "" ? Convert.ToInt32(txtAdult.Text) : 0;
            //int total = a * b;
            //txtTotChildren.Text = total.ToString();
        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {
            lblSingleRoom.Text = singleRoom;
            lblDoubleRoom.Text = doubleRoom;
            lblTripleRoom.Text = tripleRoom;
            lblAdults.Text = adults;
            lblChildrens.Text = children;
            lblStarCategory.Text = category;
        }

        private void bunifuMetroTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void l3_Click(object sender, EventArgs e)
        {

        }

        int A = 1;

        private void txtTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadHotels();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            addPlans();
            //validation();

        }

        private void cmbHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRoomPrice();
        }

        public void validation() {
            

        }

        private void addPlans() {

            double extraMeal = Convert.ToDouble(/*txtBreakFast.Text*/4) + 
                               Convert.ToDouble(/*txtLunch.Text*/45) + 
                               Convert.ToDouble(/*txtDinner.Text*/ 56);
            
            Double hotelAmount = 
                (Convert.ToDouble(txtSingleRoomHotel.Text) * Convert.ToDouble(singleRoom) ) * days  + 
                (Convert.ToDouble(txtDoubleRoomHotel.Text) * Convert.ToDouble(doubleRoom) ) * days+
                (Convert.ToDouble(txtTripleRoomHotel.Text) * Convert.ToDouble(tripleRoom) ) * days;
            double total = hotelAmount + extraMeal;

            String sql = "INSERT INTO plans " +
                "(tripId," +
                "fromLocation," +
                "toLocation," +
                "description," +
                "adultTotalCost," +
                "childrenTotalCost," +
                "hotelAmout," +
                "extraMealAmout," +
                "total) " +
                "VALUES(" +
                "'" + tripId + "'," +
                "'" + txtFrom.Text + "'," +
                "'" + txtTo.Text + "'," +
                "'" + txtDescription.Text + "'," +
                "'" + txtTotAdult.Text + "'," +
                "'" + txtTotChildren.Text + "'," +
                "'" + hotelAmount + "'," +
                "'" + extraMeal + "'," +
                "'" + total + "')";


            try
            {
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

        public void loadFromAndTo() {

            String sql = "SELECT * FROM districts";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();
                
                while (dataReader.Read()) {
                    txtFrom.Items.Add(dataReader["districtName"].ToString());
                    txtTo.Items.Add(dataReader["districtName"].ToString());
                }

                conn.Close();


            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }
        }

        public void loadHotels() {


            String sql = "SELECT * FROM hotels WHERE location = '" + txtTo.Text +"' AND h_status = '"+h_status+"'";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();

                cmbHotels.Items.Clear();

                while (dataReader.Read())
                {
                    //txtFrom.Items.Add(dataReader["districtName"].ToString());
                    cmbHotels.Items.Add(dataReader["name"].ToString());
                }

                conn.Close();


            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }

        }

        public void loadRoomPrice()
        {
            txtSingleRoomHotel.Text = "";
            txtDoubleRoomHotel.Text = "";
            txtTripleRoomHotel.Text = "";

            String sql = "SELECT * FROM rooms WHERE hotel = '" + cmbHotels.Text + "' AND room_type = '1'";
            String sql1 = "SELECT * FROM rooms WHERE hotel = '" + cmbHotels.Text + "' AND room_type = '2'";
            String sql2 = "SELECT * FROM rooms WHERE hotel = '" + cmbHotels.Text + "' AND room_type = '3'";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();

                
                while (dataReader.Read())
                {
                    //txtFrom.Items.Add(dataReader["districtName"].ToString());
                    //cmbHotels.Items.Add(dataReader["name"].ToString());
                    txtSingleRoomHotel.Text = dataReader["price"].ToString();
                }

                conn.Close();

                // second

                MySqlCommand command1 = new MySqlCommand(sql1, conn);
                MySqlDataReader dataReader1;
                conn.Open();
                dataReader1 = command1.ExecuteReader();
                
                while (dataReader1.Read())
                {
                    //txtFrom.Items.Add(dataReader["districtName"].ToString());
                    //cmbHotels.Items.Add(dataReader["name"].ToString());
                    txtDoubleRoomHotel.Text = dataReader1["price"].ToString();
                }

                conn.Close();

                //third
                MySqlCommand command2 = new MySqlCommand(sql2, conn);
                MySqlDataReader dataReader2;
                conn.Open();
                dataReader2 = command2.ExecuteReader();
                
                while (dataReader2.Read())
                {
                    //txtFrom.Items.Add(dataReader["districtName"].ToString());
                    //cmbHotels.Items.Add(dataReader["name"].ToString());
                    txtTripleRoomHotel.Text = dataReader2["price"].ToString();
                }

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
