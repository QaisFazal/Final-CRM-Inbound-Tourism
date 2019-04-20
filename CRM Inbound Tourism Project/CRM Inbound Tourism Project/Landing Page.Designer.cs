namespace CRM_Inbound_Tourism_Project
{
    partial class Landing_Page
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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation4 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing_Page));
            AnimatorNS.Animation animation5 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation6 = new AnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.pnlMarked = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.panelInAnimator = new AnimatorNS.Animator(this.components);
            this.logoAnimator = new AnimatorNS.Animator(this.components);
            this.pnlOutAnimator = new AnimatorNS.Animator(this.components);
            this.homeControl1 = new CRM_Inbound_Tourism_Project.HomeControl();
            this.dayToDayPlanControl1 = new CRM_Inbound_Tourism_Project.dayToDayPlanControl();
            this.hotalControl1 = new CRM_Inbound_Tourism_Project.HotalControl();
            this.addUserControl1 = new CRM_Inbound_Tourism_Project.AddUserControl();
            this.locationControl1 = new CRM_Inbound_Tourism_Project.LocationControl();
            this.itineraryBuilderControl1 = new CRM_Inbound_Tourism_Project.itineraryBuilderControl();
            this.panel1.SuspendLayout();
            this.pnlSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.homeControl1);
            this.panel1.Controls.Add(this.dayToDayPlanControl1);
            this.panel1.Controls.Add(this.hotalControl1);
            this.panel1.Controls.Add(this.addUserControl1);
            this.panel1.Controls.Add(this.locationControl1);
            this.panel1.Controls.Add(this.itineraryBuilderControl1);
            this.panel1.Controls.Add(this.pnlSlide);
            this.panelInAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.pnlOutAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(1, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 629);
            this.panel1.TabIndex = 0;
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.White;
            this.pnlSlide.Controls.Add(this.pnlMarked);
            this.pnlSlide.Controls.Add(this.button7);
            this.pnlSlide.Controls.Add(this.button6);
            this.pnlSlide.Controls.Add(this.button4);
            this.pnlSlide.Controls.Add(this.button5);
            this.pnlSlide.Controls.Add(this.button1);
            this.pnlSlide.Controls.Add(this.logo);
            this.panelInAnimator.SetDecoration(this.pnlSlide, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlSlide, AnimatorNS.DecorationType.None);
            this.pnlOutAnimator.SetDecoration(this.pnlSlide, AnimatorNS.DecorationType.None);
            this.pnlSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlide.ForeColor = System.Drawing.Color.Black;
            this.pnlSlide.Location = new System.Drawing.Point(0, 0);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(240, 629);
            this.pnlSlide.TabIndex = 0;
            this.pnlSlide.MouseLeave += new System.EventHandler(this.SidePanelMouseLevaer);
            this.pnlSlide.MouseHover += new System.EventHandler(this.SidePanelMouseHover);
            // 
            // pnlMarked
            // 
            this.pnlMarked.BackColor = System.Drawing.Color.Maroon;
            this.panelInAnimator.SetDecoration(this.pnlMarked, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlMarked, AnimatorNS.DecorationType.None);
            this.pnlOutAnimator.SetDecoration(this.pnlMarked, AnimatorNS.DecorationType.None);
            this.pnlMarked.Location = new System.Drawing.Point(3, 224);
            this.pnlMarked.Name = "pnlMarked";
            this.pnlMarked.Size = new System.Drawing.Size(5, 44);
            this.pnlMarked.TabIndex = 2;
            this.pnlMarked.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button7
            // 
            this.pnlOutAnimator.SetDecoration(this.button7, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.button7, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.button7, AnimatorNS.DecorationType.None);
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button7.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.add_user;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(13, 412);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 44);
            this.button7.TabIndex = 8;
            this.button7.Text = "      Add User";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.pnlOutAnimator.SetDecoration(this.button6, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.button6, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.button6, AnimatorNS.DecorationType.None);
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button6.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.location;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(13, 364);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 44);
            this.button6.TabIndex = 7;
            this.button6.Text = "      Locations";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.pnlOutAnimator.SetDecoration(this.button4, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.button4, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.button4, AnimatorNS.DecorationType.None);
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button4.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.hotels;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(13, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "      Hotels";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.pnlOutAnimator.SetDecoration(this.button5, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.button5, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.button5, AnimatorNS.DecorationType.None);
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(13, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "      Itinerary Builder";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.pnlOutAnimator.SetDecoration(this.button1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.button1, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.button1, AnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.home;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "      Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.pnlOutAnimator.SetDecoration(this.logo, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.logo, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.logo, AnimatorNS.DecorationType.None);
            this.logo.Location = new System.Drawing.Point(63, 55);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(110, 110);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlOutAnimator.SetDecoration(this.lblExit, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.lblExit, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.lblExit, AnimatorNS.DecorationType.None);
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(907, 6);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(12, 12);
            this.lblExit.TabIndex = 9;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelInAnimator.SetDecoration(this.pnlBorder, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlBorder, AnimatorNS.DecorationType.None);
            this.pnlOutAnimator.SetDecoration(this.pnlBorder, AnimatorNS.DecorationType.None);
            this.pnlBorder.Location = new System.Drawing.Point(239, 12);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1, 1000);
            this.pnlBorder.TabIndex = 6;
            // 
            // panelInAnimator
            // 
            this.panelInAnimator.AnimationType = AnimatorNS.AnimationType.Scale;
            this.panelInAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.panelInAnimator.DefaultAnimation = animation4;
            this.panelInAnimator.Interval = 15;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = AnimatorNS.AnimationType.ScaleAndRotate;
            this.logoAnimator.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(30);
            animation5.RotateCoeff = 0.5F;
            animation5.RotateLimit = 0.2F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation5;
            // 
            // pnlOutAnimator
            // 
            this.pnlOutAnimator.AnimationType = AnimatorNS.AnimationType.HorizBlind;
            this.pnlOutAnimator.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.pnlOutAnimator.DefaultAnimation = animation6;
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.White;
            this.pnlOutAnimator.SetDecoration(this.homeControl1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.homeControl1, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.homeControl1, AnimatorNS.DecorationType.None);
            this.homeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControl1.Location = new System.Drawing.Point(240, 0);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(684, 629);
            this.homeControl1.TabIndex = 6;
            this.homeControl1.Load += new System.EventHandler(this.homeControl1_Load);
            this.homeControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeMouseClicked);
            // 
            // dayToDayPlanControl1
            // 
            this.dayToDayPlanControl1.BackColor = System.Drawing.Color.White;
            this.pnlOutAnimator.SetDecoration(this.dayToDayPlanControl1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.dayToDayPlanControl1, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.dayToDayPlanControl1, AnimatorNS.DecorationType.None);
            this.dayToDayPlanControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayToDayPlanControl1.Location = new System.Drawing.Point(240, 0);
            this.dayToDayPlanControl1.Name = "dayToDayPlanControl1";
            this.dayToDayPlanControl1.Size = new System.Drawing.Size(684, 629);
            this.dayToDayPlanControl1.TabIndex = 5;
            // 
            // hotalControl1
            // 
            this.hotalControl1.AutoScroll = true;
            this.hotalControl1.AutoScrollMinSize = new System.Drawing.Size(0, 980);
            this.hotalControl1.BackColor = System.Drawing.Color.White;
            this.pnlOutAnimator.SetDecoration(this.hotalControl1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.hotalControl1, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.hotalControl1, AnimatorNS.DecorationType.None);
            this.hotalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotalControl1.Location = new System.Drawing.Point(240, 0);
            this.hotalControl1.Name = "hotalControl1";
            this.hotalControl1.Size = new System.Drawing.Size(684, 629);
            this.hotalControl1.TabIndex = 4;
            // 
            // addUserControl1
            // 
            this.addUserControl1.AutoScroll = true;
            this.addUserControl1.AutoScrollMinSize = new System.Drawing.Size(0, 980);
            this.addUserControl1.BackColor = System.Drawing.Color.White;
            this.pnlOutAnimator.SetDecoration(this.addUserControl1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.addUserControl1, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.addUserControl1, AnimatorNS.DecorationType.None);
            this.addUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserControl1.Location = new System.Drawing.Point(240, 0);
            this.addUserControl1.Name = "addUserControl1";
            this.addUserControl1.Size = new System.Drawing.Size(684, 629);
            this.addUserControl1.TabIndex = 3;
            // 
            // locationControl1
            // 
            this.locationControl1.AutoScroll = true;
            this.locationControl1.AutoScrollMinSize = new System.Drawing.Size(0, 980);
            this.locationControl1.BackColor = System.Drawing.Color.White;
            this.pnlOutAnimator.SetDecoration(this.locationControl1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.locationControl1, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.locationControl1, AnimatorNS.DecorationType.None);
            this.locationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationControl1.Location = new System.Drawing.Point(240, 0);
            this.locationControl1.Name = "locationControl1";
            this.locationControl1.Size = new System.Drawing.Size(684, 629);
            this.locationControl1.TabIndex = 2;
            // 
            // itineraryBuilderControl1
            // 
            this.itineraryBuilderControl1.AutoScroll = true;
            this.itineraryBuilderControl1.AutoScrollMinSize = new System.Drawing.Size(0, 980);
            this.itineraryBuilderControl1.BackColor = System.Drawing.Color.White;
            this.pnlOutAnimator.SetDecoration(this.itineraryBuilderControl1, AnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.itineraryBuilderControl1, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this.itineraryBuilderControl1, AnimatorNS.DecorationType.None);
            this.itineraryBuilderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itineraryBuilderControl1.Location = new System.Drawing.Point(240, 0);
            this.itineraryBuilderControl1.Name = "itineraryBuilderControl1";
            this.itineraryBuilderControl1.Size = new System.Drawing.Size(684, 629);
            this.itineraryBuilderControl1.TabIndex = 1;
            this.itineraryBuilderControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.itinryBuilderMouseClicked);
            // 
            // Landing_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(928, 655);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.panel1);
            this.logoAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.panelInAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.pnlOutAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Landing_Page";
            this.Text = "Landing_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Landing_Page_Load);
            this.panel1.ResumeLayout(false);
            this.pnlSlide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel pnlMarked;
      
        private System.Windows.Forms.Panel pnlBorder;
        private itineraryBuilderControl itineraryBuilderControl1;
        private AnimatorNS.Animator panelInAnimator;
        private AnimatorNS.Animator logoAnimator;
        private AnimatorNS.Animator pnlOutAnimator;
        private dayToDayPlanControl dayToDayPlanControl1;
        private HotalControl hotalControl1;
        private AddUserControl addUserControl1;
        private LocationControl locationControl1;
        private HomeControl homeControl1;
    }
}