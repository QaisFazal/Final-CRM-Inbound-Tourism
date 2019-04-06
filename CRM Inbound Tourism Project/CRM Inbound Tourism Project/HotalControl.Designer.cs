namespace CRM_Inbound_Tourism_Project
{
    partial class HotalControl
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
            this.lblHotelName = new System.Windows.Forms.Label();
            this.lblHotelLocation = new System.Windows.Forms.Label();
            this.lblHotelStatus = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvHotel = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddDeatils = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHotelName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbHotelStatus = new System.Windows.Forms.ComboBox();
            this.cmbHotelLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHotelLocation1 = new System.Windows.Forms.ComboBox();
            this.cmbHotelStatus1 = new System.Windows.Forms.ComboBox();
            this.txtHotelName1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.BackColor = System.Drawing.Color.White;
            this.lblHotelName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.Location = new System.Drawing.Point(48, 70);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(94, 17);
            this.lblHotelName.TabIndex = 51;
            this.lblHotelName.Text = "Hotel Name :";
            // 
            // lblHotelLocation
            // 
            this.lblHotelLocation.AutoSize = true;
            this.lblHotelLocation.BackColor = System.Drawing.Color.White;
            this.lblHotelLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelLocation.Location = new System.Drawing.Point(48, 115);
            this.lblHotelLocation.Name = "lblHotelLocation";
            this.lblHotelLocation.Size = new System.Drawing.Size(111, 17);
            this.lblHotelLocation.TabIndex = 55;
            this.lblHotelLocation.Text = "Hotel Location :";
            // 
            // lblHotelStatus
            // 
            this.lblHotelStatus.AutoSize = true;
            this.lblHotelStatus.BackColor = System.Drawing.Color.White;
            this.lblHotelStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelStatus.Location = new System.Drawing.Point(48, 159);
            this.lblHotelStatus.Name = "lblHotelStatus";
            this.lblHotelStatus.Size = new System.Drawing.Size(92, 17);
            this.lblHotelStatus.TabIndex = 57;
            this.lblHotelStatus.Text = "Hotel Status :";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(195, 95);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(202, 20);
            this.tbSearch.TabIndex = 61;
            // 
            // dgvHotel
            // 
            this.dgvHotel.BackgroundColor = System.Drawing.Color.White;
            this.dgvHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotel.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgvHotel.Location = new System.Drawing.Point(95, 519);
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.Size = new System.Drawing.Size(711, 228);
            this.dgvHotel.TabIndex = 63;
            this.dgvHotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotel_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(713, 797);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 27);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEdit.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(669, 400);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 27);
            this.btnEdit.TabIndex = 64;
            this.btnEdit.Text = "        UPDATE";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSearch.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(403, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 27);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Text = "     SEARCH HOTEL";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddDeatils
            // 
            this.btnAddDeatils.BackColor = System.Drawing.Color.White;
            this.btnAddDeatils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeatils.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDeatils.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAddDeatils.Image = global::CRM_Inbound_Tourism_Project.Properties.Resources.add;
            this.btnAddDeatils.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDeatils.Location = new System.Drawing.Point(197, 219);
            this.btnAddDeatils.Name = "btnAddDeatils";
            this.btnAddDeatils.Size = new System.Drawing.Size(155, 27);
            this.btnAddDeatils.TabIndex = 59;
            this.btnAddDeatils.Text = "ADD DETAILS";
            this.btnAddDeatils.UseVisualStyleBackColor = false;
            this.btnAddDeatils.Click += new System.EventHandler(this.btnAddDeatils_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 85;
            this.label1.Text = "HOTEL";
            // 
            // tbHotelName
            // 
            this.tbHotelName.BackColor = System.Drawing.Color.White;
            this.tbHotelName.BorderColorFocused = System.Drawing.Color.Sienna;
            this.tbHotelName.BorderColorIdle = System.Drawing.Color.SaddleBrown;
            this.tbHotelName.BorderColorMouseHover = System.Drawing.Color.Sienna;
            this.tbHotelName.BorderThickness = 1;
            this.tbHotelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHotelName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbHotelName.ForeColor = System.Drawing.Color.Black;
            this.tbHotelName.isPassword = false;
            this.tbHotelName.Location = new System.Drawing.Point(197, 70);
            this.tbHotelName.Margin = new System.Windows.Forms.Padding(4);
            this.tbHotelName.Name = "tbHotelName";
            this.tbHotelName.Size = new System.Drawing.Size(155, 20);
            this.tbHotelName.TabIndex = 86;
            this.tbHotelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 35);
            this.panel2.TabIndex = 92;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(44, 945);
            this.flowLayoutPanel1.TabIndex = 93;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(840, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 945);
            this.panel3.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbHotelLocation);
            this.panel1.Controls.Add(this.cmbHotelStatus);
            this.panel1.Controls.Add(this.tbHotelName);
            this.panel1.Controls.Add(this.lblHotelName);
            this.panel1.Controls.Add(this.lblHotelLocation);
            this.panel1.Controls.Add(this.lblHotelStatus);
            this.panel1.Controls.Add(this.btnAddDeatils);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(44, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 290);
            this.panel1.TabIndex = 95;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(44, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(796, 32);
            this.panel4.TabIndex = 96;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.cmbHotelLocation1);
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cmbHotelStatus1);
            this.panel5.Controls.Add(this.txtHotelName1);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.tbSearch);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(44, 357);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(796, 484);
            this.panel5.TabIndex = 97;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 12;
            this.bunifuElipse2.TargetControl = this.panel5;
            // 
            // cmbHotelStatus
            // 
            this.cmbHotelStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotelStatus.FormattingEnabled = true;
            this.cmbHotelStatus.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbHotelStatus.Location = new System.Drawing.Point(197, 158);
            this.cmbHotelStatus.Name = "cmbHotelStatus";
            this.cmbHotelStatus.Size = new System.Drawing.Size(155, 21);
            this.cmbHotelStatus.TabIndex = 0;
            // 
            // cmbHotelLocation
            // 
            this.cmbHotelLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotelLocation.FormattingEnabled = true;
            this.cmbHotelLocation.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbHotelLocation.Location = new System.Drawing.Point(197, 111);
            this.cmbHotelLocation.Name = "cmbHotelLocation";
            this.cmbHotelLocation.Size = new System.Drawing.Size(155, 21);
            this.cmbHotelLocation.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Enter hotel name to search :";
            // 
            // cmbHotelLocation1
            // 
            this.cmbHotelLocation1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotelLocation1.FormattingEnabled = true;
            this.cmbHotelLocation1.Location = new System.Drawing.Point(479, 396);
            this.cmbHotelLocation1.Name = "cmbHotelLocation1";
            this.cmbHotelLocation1.Size = new System.Drawing.Size(155, 21);
            this.cmbHotelLocation1.TabIndex = 93;
            // 
            // cmbHotelStatus1
            // 
            this.cmbHotelStatus1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotelStatus1.FormattingEnabled = true;
            this.cmbHotelStatus1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbHotelStatus1.Location = new System.Drawing.Point(478, 446);
            this.cmbHotelStatus1.Name = "cmbHotelStatus1";
            this.cmbHotelStatus1.Size = new System.Drawing.Size(155, 21);
            this.cmbHotelStatus1.TabIndex = 88;
            // 
            // txtHotelName1
            // 
            this.txtHotelName1.BackColor = System.Drawing.Color.White;
            this.txtHotelName1.BorderColorFocused = System.Drawing.Color.Sienna;
            this.txtHotelName1.BorderColorIdle = System.Drawing.Color.SaddleBrown;
            this.txtHotelName1.BorderColorMouseHover = System.Drawing.Color.Sienna;
            this.txtHotelName1.BorderThickness = 1;
            this.txtHotelName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHotelName1.Enabled = false;
            this.txtHotelName1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHotelName1.ForeColor = System.Drawing.Color.Black;
            this.txtHotelName1.isPassword = false;
            this.txtHotelName1.Location = new System.Drawing.Point(179, 396);
            this.txtHotelName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtHotelName1.Name = "txtHotelName1";
            this.txtHotelName1.Size = new System.Drawing.Size(155, 20);
            this.txtHotelName1.TabIndex = 92;
            this.txtHotelName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "Hotel Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Hotel Location :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "Hotel Status :";
            // 
            // HotalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 980);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvHotel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "HotalControl";
            this.Size = new System.Drawing.Size(883, 799);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label lblHotelLocation;
        private System.Windows.Forms.Label lblHotelStatus;
        internal System.Windows.Forms.Button btnAddDeatils;
        private System.Windows.Forms.TextBox tbSearch;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvHotel;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbHotelName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ComboBox cmbHotelStatus;
        private System.Windows.Forms.ComboBox cmbHotelLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHotelLocation1;
        private System.Windows.Forms.ComboBox cmbHotelStatus1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHotelName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
