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
    public partial class SplashScreen : Form
    {
        int move =1;
        public SplashScreen()
        {
            InitializeComponent();
        }

       

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panel2.Width += 1;

            if (panel2.Width > 236)
            {
                panel2.Width = 0;
            }
            if (panel2.Width < 0)
            {
                move = 2;
            }
        }
    }
}
