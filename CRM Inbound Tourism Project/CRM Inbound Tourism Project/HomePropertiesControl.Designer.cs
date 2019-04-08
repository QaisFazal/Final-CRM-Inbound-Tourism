namespace CRM_Inbound_Tourism_Project
{
    partial class HomePropertiesControl
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
            this.lblPassportNo = new System.Windows.Forms.Label();
            this.lblDepatureDate = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblPassportNo
            // 
            this.lblPassportNo.AutoSize = true;
            this.lblPassportNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassportNo.Location = new System.Drawing.Point(64, 85);
            this.lblPassportNo.Name = "lblPassportNo";
            this.lblPassportNo.Size = new System.Drawing.Size(122, 16);
            this.lblPassportNo.TabIndex = 7;
            this.lblPassportNo.Text = "Passport Number:";
            // 
            // lblDepatureDate
            // 
            this.lblDepatureDate.AutoSize = true;
            this.lblDepatureDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepatureDate.Location = new System.Drawing.Point(290, 52);
            this.lblDepatureDate.Name = "lblDepatureDate";
            this.lblDepatureDate.Size = new System.Drawing.Size(110, 16);
            this.lblDepatureDate.TabIndex = 6;
            this.lblDepatureDate.Text = "Depature Date :";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(64, 52);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(94, 16);
            this.lblArrivalDate.TabIndex = 5;
            this.lblArrivalDate.Text = "Arrival Date :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(63, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 1);
            this.panel1.TabIndex = 8;
            // 
            // HomePropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPassportNo);
            this.Controls.Add(this.lblDepatureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.lblName);
            this.Name = "HomePropertiesControl";
            this.Size = new System.Drawing.Size(565, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassportNo;
        private System.Windows.Forms.Label lblDepatureDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
    }
}
