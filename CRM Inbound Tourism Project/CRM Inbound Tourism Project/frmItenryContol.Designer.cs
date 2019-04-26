namespace CRM_Inbound_Tourism_Project
{
    partial class frmItenryContol
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbCategary = new System.Windows.Forms.ComboBox();
            this.cmbMeals = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doubleRoom = new System.Windows.Forms.TextBox();
            this.noOfDays = new System.Windows.Forms.TextBox();
            this.depature = new System.Windows.Forms.TextBox();
            this.singleRoom = new System.Windows.Forms.TextBox();
            this.childrends = new System.Windows.Forms.TextBox();
            this.arival = new System.Windows.Forms.TextBox();
            this.tripleRoom = new System.Windows.Forms.TextBox();
            this.noOfRooms = new System.Windows.Forms.TextBox();
            this.adults = new System.Windows.Forms.TextBox();
            this.tripId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(633, 445);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 23);
            this.btnUpdate.TabIndex = 167;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbCategary
            // 
            this.cmbCategary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategary.FormattingEnabled = true;
            this.cmbCategary.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cmbCategary.Location = new System.Drawing.Point(554, 409);
            this.cmbCategary.Name = "cmbCategary";
            this.cmbCategary.Size = new System.Drawing.Size(166, 21);
            this.cmbCategary.TabIndex = 166;
            // 
            // cmbMeals
            // 
            this.cmbMeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeals.FormattingEnabled = true;
            this.cmbMeals.Items.AddRange(new object[] {
            "Bed and Break Fast",
            "Half Board",
            "Full Board"});
            this.cmbMeals.Location = new System.Drawing.Point(315, 409);
            this.cmbMeals.Name = "cmbMeals";
            this.cmbMeals.Size = new System.Drawing.Size(166, 21);
            this.cmbMeals.TabIndex = 165;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 164;
            this.label12.Text = "Star Catergory";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 163;
            this.label13.Text = "Meal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 393);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 162;
            this.label14.Text = "Triple Room";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 161;
            this.label9.Text = "Double Room";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 160;
            this.label10.Text = "Single Room";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 159;
            this.label11.Text = "No of Rooms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 158;
            this.label6.Text = "No of Days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 157;
            this.label7.Text = "Childrends";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 156;
            this.label8.Text = "Adults";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 155;
            this.label5.Text = "Depature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 154;
            this.label4.Text = "Arrival";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 153;
            this.label3.Text = "Trip ID";
            // 
            // doubleRoom
            // 
            this.doubleRoom.Location = new System.Drawing.Point(554, 367);
            this.doubleRoom.Name = "doubleRoom";
            this.doubleRoom.Size = new System.Drawing.Size(166, 20);
            this.doubleRoom.TabIndex = 152;
            // 
            // noOfDays
            // 
            this.noOfDays.Location = new System.Drawing.Point(554, 327);
            this.noOfDays.Name = "noOfDays";
            this.noOfDays.Size = new System.Drawing.Size(166, 20);
            this.noOfDays.TabIndex = 151;
            // 
            // depature
            // 
            this.depature.Location = new System.Drawing.Point(554, 283);
            this.depature.Name = "depature";
            this.depature.Size = new System.Drawing.Size(166, 20);
            this.depature.TabIndex = 150;
            // 
            // singleRoom
            // 
            this.singleRoom.Location = new System.Drawing.Point(315, 367);
            this.singleRoom.Name = "singleRoom";
            this.singleRoom.Size = new System.Drawing.Size(166, 20);
            this.singleRoom.TabIndex = 149;
            // 
            // childrends
            // 
            this.childrends.Location = new System.Drawing.Point(315, 327);
            this.childrends.Name = "childrends";
            this.childrends.Size = new System.Drawing.Size(166, 20);
            this.childrends.TabIndex = 148;
            // 
            // arival
            // 
            this.arival.Location = new System.Drawing.Point(315, 283);
            this.arival.Name = "arival";
            this.arival.Size = new System.Drawing.Size(166, 20);
            this.arival.TabIndex = 147;
            // 
            // tripleRoom
            // 
            this.tripleRoom.Location = new System.Drawing.Point(80, 409);
            this.tripleRoom.Name = "tripleRoom";
            this.tripleRoom.Size = new System.Drawing.Size(166, 20);
            this.tripleRoom.TabIndex = 146;
            // 
            // noOfRooms
            // 
            this.noOfRooms.Location = new System.Drawing.Point(80, 367);
            this.noOfRooms.Name = "noOfRooms";
            this.noOfRooms.Size = new System.Drawing.Size(166, 20);
            this.noOfRooms.TabIndex = 145;
            // 
            // adults
            // 
            this.adults.Location = new System.Drawing.Point(80, 327);
            this.adults.Name = "adults";
            this.adults.Size = new System.Drawing.Size(166, 20);
            this.adults.TabIndex = 144;
            // 
            // tripId
            // 
            this.tripId.Location = new System.Drawing.Point(80, 283);
            this.tripId.Name = "tripId";
            this.tripId.ReadOnly = true;
            this.tripId.Size = new System.Drawing.Size(166, 20);
            this.tripId.TabIndex = 143;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 142;
            this.label2.Text = "Itenarary Control";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(666, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 141;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(61, 101);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(680, 151);
            this.dataGridView.TabIndex = 140;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(291, 71);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(369, 20);
            this.txtCustomerId.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 138;
            this.label1.Text = "Enter trip id (customer id ) :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(694, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 32);
            this.button1.TabIndex = 168;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmItenryContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbCategary);
            this.Controls.Add(this.cmbMeals);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doubleRoom);
            this.Controls.Add(this.noOfDays);
            this.Controls.Add(this.depature);
            this.Controls.Add(this.singleRoom);
            this.Controls.Add(this.childrends);
            this.Controls.Add(this.arival);
            this.Controls.Add(this.tripleRoom);
            this.Controls.Add(this.noOfRooms);
            this.Controls.Add(this.adults);
            this.Controls.Add(this.tripId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItenryContol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItenryContol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbCategary;
        private System.Windows.Forms.ComboBox cmbMeals;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doubleRoom;
        private System.Windows.Forms.TextBox noOfDays;
        private System.Windows.Forms.TextBox depature;
        private System.Windows.Forms.TextBox singleRoom;
        private System.Windows.Forms.TextBox childrends;
        private System.Windows.Forms.TextBox arival;
        private System.Windows.Forms.TextBox tripleRoom;
        private System.Windows.Forms.TextBox noOfRooms;
        private System.Windows.Forms.TextBox adults;
        private System.Windows.Forms.TextBox tripId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}