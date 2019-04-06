using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Inbound_Tourism_Project
{
    public partial class HomePropertiesControl : UserControl
    {
        public HomePropertiesControl()
        {
            InitializeComponent();
        }

        private string name;
        private string arrivaldate;
        private string depaturedate;
        private string passportno;

        public string Name
        {
            get { return name; }
            set { name = value; lblName.Text = value; }

        }
        public string ArrivalDate
        {
            get { return arrivaldate; }
            set { arrivaldate = value; lblArrivalDate.Text = value; }
        }
        public string DepatureDate
        {
            get { return depaturedate; }
            set { depaturedate = value; lblDepatureDate.Text = value; }
        }
        public string PassportNo
        {
            get { return passportno; }
            set { passportno = value; lblPassportNo.Text = value; }
        }
    }
}
