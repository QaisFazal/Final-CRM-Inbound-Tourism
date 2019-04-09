namespace CRM_Inbound_Tourism_Project
{
    partial class Base
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenue = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnItinerarry = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addUserControl2 = new CRM_Inbound_Tourism_Project.AddUserControl();
            this.locationControl3 = new CRM_Inbound_Tourism_Project.LocationControl();
            this.hotalControl3 = new CRM_Inbound_Tourism_Project.HotalControl();
            this.plannerControl3 = new CRM_Inbound_Tourism_Project.PlannerControl();
            this.dashBoardControl4 = new CRM_Inbound_Tourism_Project.DashBoardControl();
            this.panelMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenue
            // 
            this.panelMenue.BackColor = System.Drawing.Color.Peru;
            this.panelMenue.Controls.Add(this.button1);
            this.panelMenue.Controls.Add(this.panel3);
            this.panelMenue.Controls.Add(this.panel2);
            this.panelMenue.Controls.Add(this.pictureBox1);
            this.panelMenue.Controls.Add(this.button4);
            this.panelMenue.Controls.Add(this.button3);
            this.panelMenue.Controls.Add(this.button2);
            this.panelMenue.Controls.Add(this.btnItinerarry);
            this.panelMenue.Controls.Add(this.btnHome);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenue.Location = new System.Drawing.Point(0, 26);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(53, 693);
            this.panelMenue.TabIndex = 0;
            this.panelMenue.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panelMenue.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.close;
            this.button1.Location = new System.Drawing.Point(203, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Location = new System.Drawing.Point(3, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 44);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(35, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 1);
            this.panel2.TabIndex = 7;
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BackgroundImage = global::CRM_Inbound_Tourism_Project.Properties.Resources._110;
            this.pictureBox1.Location = new System.Drawing.Point(62, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button4.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.add_user;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(10, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "   ADMIN";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button3.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.location;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(10, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "   LOCATION";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.hotels;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "   HOTELS";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnItinerarry
            // 
            this.btnItinerarry.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnItinerarry.FlatAppearance.BorderSize = 0;
            this.btnItinerarry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItinerarry.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItinerarry.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnItinerarry.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.itinary_builder;
            this.btnItinerarry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItinerarry.Location = new System.Drawing.Point(10, 304);
            this.btnItinerarry.Name = "btnItinerarry";
            this.btnItinerarry.Size = new System.Drawing.Size(221, 44);
            this.btnItinerarry.TabIndex = 2;
            this.btnItinerarry.Text = "   ITINERARY BUILDER";
            this.btnItinerarry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItinerarry.UseVisualStyleBackColor = false;
            this.btnItinerarry.Click += new System.EventHandler(this.btnItinerarry_Click);
            this.btnItinerarry.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.btnItinerarry.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnHome.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 256);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(221, 44);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "   HOME";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 26);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(727, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.off__2_;
            this.pictureBox2.Location = new System.Drawing.Point(768, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // addUserControl2
            // 
            this.addUserControl2.AutoScroll = true;
            this.addUserControl2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserControl2.Location = new System.Drawing.Point(53, 26);
            this.addUserControl2.Name = "addUserControl2";
            this.addUserControl2.Size = new System.Drawing.Size(747, 693);
            this.addUserControl2.TabIndex = 6;
            // 
            // locationControl3
            // 
            this.locationControl3.AutoScroll = true;
            this.locationControl3.AutoScrollMinSize = new System.Drawing.Size(0, 980);
            this.locationControl3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.locationControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationControl3.Location = new System.Drawing.Point(53, 26);
            this.locationControl3.Name = "locationControl3";
            this.locationControl3.Size = new System.Drawing.Size(747, 693);
            this.locationControl3.TabIndex = 5;
            // 
            // hotalControl3
            // 
            this.hotalControl3.AutoScroll = true;
            this.hotalControl3.AutoScrollMinSize = new System.Drawing.Size(0, 980);
            this.hotalControl3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hotalControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotalControl3.Location = new System.Drawing.Point(53, 26);
            this.hotalControl3.Name = "hotalControl3";
            this.hotalControl3.Size = new System.Drawing.Size(747, 693);
            this.hotalControl3.TabIndex = 4;
            // 
            // plannerControl3
            // 
            this.plannerControl3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plannerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plannerControl3.Location = new System.Drawing.Point(53, 26);
            this.plannerControl3.Name = "plannerControl3";
            this.plannerControl3.Size = new System.Drawing.Size(747, 693);
            this.plannerControl3.TabIndex = 3;
            // 
            // dashBoardControl4
            // 
            this.dashBoardControl4.AutoScroll = true;
            this.dashBoardControl4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashBoardControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoardControl4.Location = new System.Drawing.Point(53, 26);
            this.dashBoardControl4.Name = "dashBoardControl4";
            this.dashBoardControl4.Size = new System.Drawing.Size(747, 693);
            this.dashBoardControl4.TabIndex = 2;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 719);
            this.Controls.Add(this.addUserControl2);
            this.Controls.Add(this.locationControl3);
            this.Controls.Add(this.hotalControl3);
            this.Controls.Add(this.plannerControl3);
            this.Controls.Add(this.dashBoardControl4);
            this.Controls.Add(this.panelMenue);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM-System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Base_Load);
            this.panelMenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnItinerarry;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panelMenue;
        private DashBoardControl dashBoardControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DashBoardControl dashBoardControl2;
        private PlannerControl plannerControl1;
        private HotalControl hotalControl1;
        private LocationControl locationControl1;
        private DashBoardControl dashBoardControl3;
        private PlannerControl plannerControl2;
        private HotalControl hotalControl2;
        private LocationControl locationControl2;
        private AddUserControl addUserControl1;
        private DashBoardControl dashBoardControl4;
        private PlannerControl plannerControl3;
        private HotalControl hotalControl3;
        private LocationControl locationControl3;
        private AddUserControl addUserControl2;
        private System.Windows.Forms.Label label1;
    }
}