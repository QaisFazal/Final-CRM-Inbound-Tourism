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

        private String tripId;

   
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

            lblSingleRoom.Text = singleRoom;
            lblDoubleRoom.Text = doubleRoom;
            lblTripleRoom.Text = tripleRoom;
            lblAdults.Text = adults;
            lblChildrens.Text = children;
            lblStarCategory.Text = category;
            
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

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }
        int A = 1;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            addPlans();
            

        }


        private void addPlans() {

            double extraMeal = 0; // = Convert.ToDouble(txtBreakFast.Text) + Convert.ToDouble(txtLunch.Text) + Convert.ToDouble(txtDinner.Text);
            double total = 0;// = Convert.ToDouble(txtTotAdult.Text) + Convert.ToDouble(txtTotChildren.Text) + Convert.ToDouble(txtSingleRoomHotel.Text) + Convert.ToDouble(txtDoubleRoomHotel.Text) + Convert.ToDouble(txtTripleRoomHotel.Text) + extraMeal;
            String hotelAmount = "";
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
                "'" + txtFrom + "'," +
                "'" + txtTo + "'," +
                "'" + txtDescription + "'," +
                "'" + txtTotAdult + "'," +
                "'" + txtTotChildren + "'," +
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


    }
}
