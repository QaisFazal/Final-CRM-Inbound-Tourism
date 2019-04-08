﻿using System;
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
    public partial class PlannerControl3 : UserControl
    {
        private PlannerControl3 plannerControl3;
        private PlannerControl2 plannerControl2;

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
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nadult_OnValueChanged(object sender, EventArgs e)
        {

            int a = nofAdults.Text != "" ? Convert.ToInt32(nofAdults.Text) : 0;
            int b = nadult.Text != "" ? Convert.ToInt32(nadult.Text) : 0;
            int total = a * b;
            tadult.Text = total.ToString();
            
        }

        private void nadult_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void nadult_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void nchildren_OnValueChanged(object sender, EventArgs e)
        {
            int a = nchildren.Text != "" ? Convert.ToInt32(nofAdults.Text) : 0;
            int b = bofChild.Text != "" ? Convert.ToInt32(nadult.Text) : 0;
            int total = a * b;
            tchildren.Text = total.ToString();
        }
    }
}