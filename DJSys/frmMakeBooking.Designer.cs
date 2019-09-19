namespace DJSys
{
    partial class frmMakeBooking
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
            this.btnFindClient = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.grpMakeBooking = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblEventStartTime = new System.Windows.Forms.Label();
            this.lblEventEndTime = new System.Windows.Forms.Label();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.grpMakeBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(504, 47);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(100, 28);
            this.btnFindClient.TabIndex = 8;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(157, 15);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(87, 17);
            this.lblEnterName.TabIndex = 7;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(348, 15);
            this.txtEnterName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnterName.MaxLength = 35;
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(416, 22);
            this.txtEnterName.TabIndex = 6;
            // 
            // grpMakeBooking
            // 
            this.grpMakeBooking.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpMakeBooking.Controls.Add(this.btnEnter);
            this.grpMakeBooking.Controls.Add(this.lblEventStartTime);
            this.grpMakeBooking.Controls.Add(this.lblEventEndTime);
            this.grpMakeBooking.Controls.Add(this.lblEventLocation);
            this.grpMakeBooking.Controls.Add(this.lblEircode);
            this.grpMakeBooking.Controls.Add(this.lblEventDate);
            this.grpMakeBooking.Controls.Add(this.txtEircode);
            this.grpMakeBooking.Controls.Add(this.txtSurname);
            this.grpMakeBooking.Controls.Add(this.txtDateOfBirth);
            this.grpMakeBooking.Controls.Add(this.txtContactNo);
            this.grpMakeBooking.Controls.Add(this.txtForename);
            this.grpMakeBooking.Location = new System.Drawing.Point(161, 162);
            this.grpMakeBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMakeBooking.Name = "grpMakeBooking";
            this.grpMakeBooking.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMakeBooking.Size = new System.Drawing.Size(812, 327);
            this.grpMakeBooking.TabIndex = 9;
            this.grpMakeBooking.TabStop = false;
            this.grpMakeBooking.Text = "Booking Details";
            this.grpMakeBooking.Visible = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(331, 241);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(124, 38);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblEventStartTime
            // 
            this.lblEventStartTime.AutoSize = true;
            this.lblEventStartTime.Location = new System.Drawing.Point(49, 100);
            this.lblEventStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventStartTime.Name = "lblEventStartTime";
            this.lblEventStartTime.Size = new System.Drawing.Size(113, 17);
            this.lblEventStartTime.TabIndex = 21;
            this.lblEventStartTime.Text = "Event Start Time";
            // 
            // lblEventEndTime
            // 
            this.lblEventEndTime.AutoSize = true;
            this.lblEventEndTime.Location = new System.Drawing.Point(49, 132);
            this.lblEventEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventEndTime.Name = "lblEventEndTime";
            this.lblEventEndTime.Size = new System.Drawing.Size(108, 17);
            this.lblEventEndTime.TabIndex = 20;
            this.lblEventEndTime.Text = "Event End Time";
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Location = new System.Drawing.Point(49, 164);
            this.lblEventLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(102, 17);
            this.lblEventLocation.TabIndex = 19;
            this.lblEventLocation.Text = "Event Location";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(49, 196);
            this.lblEircode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(56, 17);
            this.lblEircode.TabIndex = 13;
            this.lblEircode.Text = "Eircode";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(49, 68);
            this.lblEventDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(78, 17);
            this.lblEventDate.TabIndex = 11;
            this.lblEventDate.Text = "Event Date";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(180, 192);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(591, 22);
            this.txtEircode.TabIndex = 9;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(180, 96);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.MaxLength = 35;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(591, 22);
            this.txtSurname.TabIndex = 4;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(180, 128);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(591, 22);
            this.txtDateOfBirth.TabIndex = 3;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(180, 160);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactNo.MaxLength = 200;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(591, 22);
            this.txtContactNo.TabIndex = 2;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(180, 64);
            this.txtForename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtForename.MaxLength = 35;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(591, 22);
            this.txtForename.TabIndex = 0;
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Location = new System.Drawing.Point(456, 530);
            this.btnMakeBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(200, 57);
            this.btnMakeBooking.TabIndex = 23;
            this.btnMakeBooking.Text = "Make Booking";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            this.btnMakeBooking.Visible = false;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(13, 505);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 106);
            this.btnMain.TabIndex = 37;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 624);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.grpMakeBooking);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtEnterName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMakeBooking";
            this.Text = "Make Booking";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            this.grpMakeBooking.ResumeLayout(false);
            this.grpMakeBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.GroupBox grpMakeBooking;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblEventStartTime;
        private System.Windows.Forms.Label lblEventEndTime;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Button btnMain;
    }
}