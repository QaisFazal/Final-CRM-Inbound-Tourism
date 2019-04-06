using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Inbound_Tourism_Project
{
    public partial class Splash_Screen : Form
    {
        int move = 2;
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Left += 2;

            if(panel2.Left > 171)
            {
                panel2.Left = 0;
            }
            if(panel2.Left < 0)
            {
                move = 2;
            }
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();  
        }
    }
}
