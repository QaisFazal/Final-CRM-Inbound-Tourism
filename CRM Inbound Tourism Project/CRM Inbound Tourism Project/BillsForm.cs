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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CRM_Inbound_Tourism_Project
{
    public partial class BillsForm : Form
    {
        private static MySqlConnection conn = new MySqlConnection("server=Localhost;database=crm_inbound_tourism; user id=root");


        public BillsForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadPlans() {

            String sql = "SELECT * FROM plans WHERE tripId LIKE '%" + txtCustomerId.Text + "%'";


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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadPlans();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generteBill();
        }

        private void generteBill() {

            String sql = "SELECT * FROM plans WHERE tripId = '" + txtSelectedTrip.Text + "'";


            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();
                
                Document doc = new Document(iTextSharp.text.PageSize.A4);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("D:/bill.pdf", FileMode.Create));
                MessageBox.Show("Bill generated");
                doc.Open();

                Paragraph paragraph = new Paragraph("Bill for trip : "+ txtSelectedTrip.Text);
                doc.Add(paragraph);
                int temp = 1;
                while (dataReader.Read()) {
                    
                    Paragraph paragraph1 = new Paragraph(
                        dataReader["fromLocation"].ToString() +"   "
                        + dataReader["toLocation"].ToString() + "   "
                        //+ dataReader["description"].ToString() + "   "
                        + dataReader["adultTotalCost"].ToString() + "   "
                        + dataReader["childrenTotalCost"].ToString() + "   "
                        + dataReader["hotelAmout"].ToString() + "   "
                        + dataReader["extraMealAmout"].ToString() + "   "
                        + dataReader["total"].ToString() + "   "
                        );
                    doc.Add(paragraph1);
                    temp++;
                }
                
                doc.Close();



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
                
                txtSelectedTrip.Text = row.Cells["tripId"].Value.ToString();
            }
        }
    }
}
