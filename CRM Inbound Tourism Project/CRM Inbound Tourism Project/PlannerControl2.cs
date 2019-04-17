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
    public partial class PlannerControl2 : UserControl
    {

        private PlannerControl3 plannerControl3;
        private PlannerControl2 plannerControl2;
        private PlannerControl plannerControl;
        private ExistingUserInBuilder existingUserInBuilder;

        private static String userMail = null;
        DateTime date = DateTime.Now;

        //private ExistingUserInBuilder existingUserInBuilder1;
        

        private String arivaleDate, depatureDate, adults, childrens, ages, noOfDays, noOfRooms, single, doubleR, triple;

        private void txtArrivalDate_ValueChanged_1(object sender, EventArgs e)
        {
            getTripDays();
        }

        private void txtArrivalDate_onValueChanged(object sender, EventArgs e)
        {
            getTripDays();
        }

        private void txtDepatureDate_onValueChanged(object sender, EventArgs e)
        {
            getTripDays();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExistingUserInBuilder existingUserInBuilder = new ExistingUserInBuilder();
            // existingUserInBuilder.UserMail = (userMail + date);
             this.Controls.Clear();
            /// plannerControl2.Visible = false;
            //plannerControl2.Visible = false;
            this.Controls.Add(existingUserInBuilder);

            //existingUserInBuilder.Dock = DockStyle.Fill;
            // existingUserInBuilder1.BringToFront();
           //// ExistingUserInBuilder eub =new  ExistingUserInBuilder();
           // eub.Dock = DockStyle.Fill;
           // panel7.Controls.Add(eub);
           


        }

        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");

        public PlannerControl2()
        {
            InitializeComponent();
            
           
        }

        private void PlannerControl2_Load(object sender, EventArgs e)
        {
           // plannerControl31.Visible = false;
        }

        public String UserMail
        {
            get { return userMail; }
            set { userMail = value; }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (txtAdults.Text != "" || txtChildrents.Text != ""  || txtNoOfDays.Text != "" || txtNoOfRooms.Text != "" || txtSingle.Text != "" || txtDouble.Text != "" || txtTriple.Text != "" || cmbMeals.Text != "" || cmbCategary.Text != "") {

                addToTrip();
            }
            else {

                MessageBox.Show("Please fill all the fields");

            }
            
        }

        private void addToTrip()
        {
            String arrivalDate = txtArrivalDate.Text;
            String depatureDate = txtDepatureDate.Value.Date.ToShortDateString();
            String triptId = (userMail + date);

            PlannerControl3 plannerControl3 = new PlannerControl3();
            plannerControl3.BringToFront();


            plannerControl3.l3.Text = txtNoOfDays.Text;


            plannerControl3.controlAdults = txtAdults.Text;
            plannerControl3.controlChildren = txtChildrents.Text;
            plannerControl3.controlCategory = cmbCategary.Text;
            plannerControl3.controlSingleRoom = txtSingle.Text;
            plannerControl3.controlDoubleRoom = txtDouble.Text;
            plannerControl3.controlTripleRoom = txtTriple.Text;
            plannerControl3.controlTripId = triptId;

            
            String sql = "INSERT INTO trips " +
                "(tripId, " +
                "arivalDate, " +
                "depatureDate, " +
                "adults, " +
                "childrents, " +
                "noOfDays, " +
                "noOfRooms, " +
                "singleRoom, " +
                "doubleRoom, " +
                "tripleRoom, " +
                "meal, " +
                "starGategory) " +
                "VALUES('"
                + triptId+"','"
                + arrivalDate + "','"
                + depatureDate + "','"
                + txtAdults.Text + "','"
                + txtChildrents.Text + "','"
                + txtNoOfDays.Text + "','"
                + txtNoOfRooms.Text + "','"
                + txtSingle.Text + "','"
                + txtDouble.Text + "','"
                + txtTriple.Text + "','"
                + cmbMeals.Text + "','"
                + cmbCategary.Text + "')";

            
            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();

                MessageBox.Show("Successfully added...!");
                conn.Close();
                
                plannerControl2 = new PlannerControl2();
                this.Controls.Clear();
                this.Controls.Add(plannerControl3);

            }
            catch (Exception e)
            {

                MessageBox.Show("There is a error while attepmting to add records : " + e);
                conn.Close();
            }
        }

        private void getTripDays()
        {
            String arrivalDate = txtArrivalDate.Value.ToShortDateString();
            String depatureDate = txtDepatureDate.Value.ToShortDateString();

            DateTime aDate = txtArrivalDate.Value.Date;
            DateTime dDate = txtDepatureDate.Value.Date;

            //System.TimeSpan diff = dDate.Subtract(aDate);

            String diff = (dDate - aDate).TotalDays.ToString();

            txtNoOfDays.Text = diff.ToString();
        }

        private void txtArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            getTripDays();
        }

        private void txtDepatureDate_ValueChanged(object sender, EventArgs e)
        {
            getTripDays();
        }
    }
}
