﻿namespace CRM_Inbound_Tourism_Project
{
    partial class PlannerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblGenerateBill = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.itenararyControl1 = new CRM_Inbound_Tourism_Project.ItenararyControl();
            this.existingUserInBuilder1 = new CRM_Inbound_Tourism_Project.ExistingUserInBuilder();
            this.addUserInBuilder1 = new CRM_Inbound_Tourism_Project.AddUserInBuilder();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 27);
            this.panel1.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this.panel4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblGenerateBill);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(29, 609);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(684, 49);
            this.panel4.TabIndex = 14;
            // 
            // lblGenerateBill
            // 
            this.lblGenerateBill.AutoSize = true;
            this.lblGenerateBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateBill.ForeColor = System.Drawing.Color.Red;
            this.lblGenerateBill.Location = new System.Drawing.Point(310, 15);
            this.lblGenerateBill.Name = "lblGenerateBill";
            this.lblGenerateBill.Size = new System.Drawing.Size(207, 19);
            this.lblGenerateBill.TabIndex = 8;
            this.lblGenerateBill.Text = "Click here to generate bill";
            this.lblGenerateBill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGenerateBill.Click += new System.EventHandler(this.lblGenerateBill_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(227, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(61, 16);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Click Here";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Not a registered user yet?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 772);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(713, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 772);
            this.panel2.TabIndex = 6;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 12;
            this.bunifuElipse2.TargetControl = this.panel7;
            // 
            // panel7
            // 
            this.panel7.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.itenararyControl1);
            this.panel7.Controls.Add(this.existingUserInBuilder1);
            this.panel7.Controls.Add(this.addUserInBuilder1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(29, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(684, 554);
            this.panel7.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(29, 581);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(684, 28);
            this.panel5.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(541, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Itenarary Control";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // itenararyControl1
            // 
            this.itenararyControl1.Location = new System.Drawing.Point(18, 27);
            this.itenararyControl1.Name = "itenararyControl1";
            this.itenararyControl1.Size = new System.Drawing.Size(704, 483);
            this.itenararyControl1.TabIndex = 2;
            this.itenararyControl1.Load += new System.EventHandler(this.itenararyControl1_Load);
            // 
            // existingUserInBuilder1
            // 
            this.existingUserInBuilder1.BackColor = System.Drawing.Color.White;
            this.existingUserInBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.existingUserInBuilder1.Location = new System.Drawing.Point(0, 0);
            this.existingUserInBuilder1.Name = "existingUserInBuilder1";
            this.existingUserInBuilder1.Size = new System.Drawing.Size(684, 554);
            this.existingUserInBuilder1.TabIndex = 1;
            // 
            // addUserInBuilder1
            // 
            this.addUserInBuilder1.BackColor = System.Drawing.Color.White;
            this.addUserInBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserInBuilder1.Location = new System.Drawing.Point(0, 0);
            this.addUserInBuilder1.Name = "addUserInBuilder1";
            this.addUserInBuilder1.Size = new System.Drawing.Size(684, 554);
            this.addUserInBuilder1.TabIndex = 0;
            // 
            // PlannerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "PlannerControl";
            this.Size = new System.Drawing.Size(751, 799);
            this.Load += new System.EventHandler(this.PlannerControl_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public System.Windows.Forms.Panel panel4;
        private ExistingUserInBuilder existingUserInBuilder1;
        private AddUserInBuilder addUserInBuilder1;
        private System.Windows.Forms.Label lblGenerateBill;
        private System.Windows.Forms.Label label2;
        private ItenararyControl itenararyControl1;
    }
}
