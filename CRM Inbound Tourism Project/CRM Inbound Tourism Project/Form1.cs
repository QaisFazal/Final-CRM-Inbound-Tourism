using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM_Inbound_Tourism_Project
{
    public partial class Login_Form : Form
    {
        int i;
        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");

        public Login_Form()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(5650);
            InitializeComponent();
            this.CenterToScreen();
            trd.Abort();

        }
        public void formRun()
        {
            Application.Run(new SplashScreen());

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
        }

        private void tbUsername_Clicked(object sender, EventArgs e)
        {
            //tbUsername.Clear();
            //imgUser.BackgroundImage = Properties.Resources.user12;
            //panel1.ForeColor = Color.SaddleBrown;
            //tbUsername.ForeColor = Color.SaddleBrown;

            //imgPassword.BackgroundImage = Properties.Resources.password11;
            //panel2.ForeColor = Color.Maroon;
            tbPassword.ForeColor = Color.Maroon;
            if(tbPassword.Text=="")
                tbPassword.Text = "************************************";

        }

        private void tbPassword_Clicked(object sender, EventArgs e)
        {
           // tbPassword.Clear();
            if (tbUsername.Text == "")
                tbUsername.Text = "USERNAME";
           // tbPassword.PasswordChar = '*';
            //imgPassword.BackgroundImage = Properties.Resources.password12;
            //panel2.ForeColor = Color.SaddleBrown;
            //tbPassword.ForeColor = Color.SaddleBrown;

            //imgUser.BackgroundImage = Properties.Resources.user11;
            //panel1.ForeColor = Color.Maroon;
            //tbUsername.ForeColor = Color.Maroon;
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignin_MouseHover(object sender, EventArgs e)
        {
            btnSignin.ForeColor = Color.SaddleBrown;
           // btnSignin.Image = Properties.Resources.login12;
        }

        private void btnSignin_MouseLeave(object sender, EventArgs e)
        {
            btnSignin.ForeColor = Color.Maroon;
           // btnSignin.Image = Properties.Resources.login11;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {

            //user validation
            conn.Open();
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "SELECT * FROM user_credentials  WHERE user_id = '" + tbUsername.Text + "' AND access_code='" + tbPassword.Text + "'";
            mySqlCommand.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.Fill(dataTable);
            i = Convert.ToInt32(dataTable.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Check your credentials please.. !");
            }
            else {

                Base l = new Base();
                l.Show();
                Visible = false;
            }

            conn.Close();
        }

        private void bunifuThinBubtnSignintton21_Click(object sender, EventArgs e)
        {
            //user validation
            conn.Open();
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = "SELECT * FROM user_credentials  WHERE user_id = '" + tbUsername.Text + "' AND access_code='" + tbPassword.Text + "'";
            mySqlCommand.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.Fill(dataTable);
            i = Convert.ToInt32(dataTable.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Check your credentials please.. !");
            }
            else
            {

                Base l = new Base();
                l.Show();
                Visible = false;
            }

            conn.Close();
        }
    }
}
