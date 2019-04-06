using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM_Inbound_Tourism_Project
{
    class DB_Connection
    {
        private static String user_name = "root";
        private static String access_code = "";
               
        private static MySqlConnection conn = new MySqlConnection("database=crm_inbound_tourism;allowuservariables=True; "+user_name);
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlDataAdapter mySqlDataAdapter;
        DataTable dataTable;
        String sql;

        public void validateUser(String user_name, String access_code) {
            conn.Open();
            int i;
            sql = "SELECT * FROM user_credentials  WHERE user_id = '"+user_name+"' AND access_code='"+access_code+"'";
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = sql;
            mySqlCommand.ExecuteNonQuery();
            dataTable = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.Fill(dataTable);
            i = Convert.ToInt32(dataTable.Rows.Count.ToString());

            if (i == 0) {
                MessageBox.Show("check your credential..");
            }
            else {
                Landing_Page l = new Landing_Page();
                l.Show();
            }
            conn.Close();
        }

    
    }
}
