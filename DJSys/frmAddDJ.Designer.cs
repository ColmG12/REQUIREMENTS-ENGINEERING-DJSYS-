namespace DJSys
{
    partial class frmAddDJ
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
            this.btnDJEmail = new System.Windows.Forms.Button();
            this.lblDJStatus = new System.Windows.Forms.Label();
            this.txtDJStatus = new System.Windows.Forms.TextBox();
            this.dtpDJDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddDJ = new System.Windows.Forms.Button();
            this.lblDJSurname = new System.Windows.Forms.Label();
            this.lblDJDateOfBirth = new System.Windows.Forms.Label();
            this.lblDJContactNo = new System.Windows.Forms.Label();
            this.lblDJEmail = new System.Windows.Forms.Label();
            this.lblDJStreet = new System.Windows.Forms.Label();
            this.lblDJTown = new System.Windows.Forms.Label();
            this.lblDJCity = new System.Windows.Forms.Label();
            this.lblDJCounty = new System.Windows.Forms.Label();
            this.txtDJID = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblDJEircode = new System.Windows.Forms.Label();
            this.lblDJForename = new System.Windows.Forms.Label();
            this.txtDJCounty = new System.Windows.Forms.TextBox();
            this.txtDJCity = new System.Windows.Forms.TextBox();
            this.txtDJTown = new System.Windows.Forms.TextBox();
            this.txtDJStreet = new System.Windows.Forms.TextBox();
            this.txtDJEmail = new System.Windows.Forms.TextBox();
            this.txtDJContactNo = new System.Windows.Forms.TextBox();
            this.txtDJSurname = new System.Windows.Forms.TextBox();
            this.txtDJForename = new System.Windows.Forms.TextBox();
            this.lblDJID = new System.Windows.Forms.Label();
            this.txtDJEircode = new System.Windows.Forms.TextBox();
            this.grpAddDJ = new System.Windows.Forms.GroupBox();
            this.nudDJHourlyRate = new System.Windows.Forms.NumericUpDown();
            this.lblDJHourlyRate = new System.Windows.Forms.Label();
            this.grpAddDJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDJHourlyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDJEmail
            // 
            this.btnDJEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDJEmail.Location = new System.Drawing.Point(1031, 720);
            this.btnDJEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnDJEmail.Name = "btnDJEmail";
            this.btnDJEmail.Size = new System.Drawing.Size(145, 105);
            this.btnDJEmail.TabIndex = 31;
            this.btnDJEmail.Text = "Send Confirmation Email";
            this.btnDJEmail.UseVisualStyleBackColor = true;
            this.btnDJEmail.Visible = false;
            this.btnDJEmail.Click += new System.EventHandler(this.btnDJEmail_Click);
            // 
            // lblDJStatus
            // 
            this.lblDJStatus.AutoSize = true;
            this.lblDJStatus.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJStatus.Location = new System.Drawing.Point(49, 462);
            this.lblDJStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJStatus.Name = "lblDJStatus";
            this.lblDJStatus.Size = new System.Drawing.Size(81, 20);
            this.lblDJStatus.TabIndex = 24;
            this.lblDJStatus.Text = "Status";
            // 
            // txtDJStatus
            // 
            this.txtDJStatus.Location = new System.Drawing.Point(281, 455);
            this.txtDJStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJStatus.MaxLength = 9;
            this.txtDJStatus.Name = "txtDJStatus";
            this.txtDJStatus.Size = new System.Drawing.Size(489, 27);
            this.txtDJStatus.TabIndex = 23;
            this.txtDJStatus.Text = "A";
            this.txtDJStatus.Visible = false;
            // 
            // dtpDJDateOfBirth
            // 
            this.dtpDJDateOfBirth.CustomFormat = "";
            this.dtpDJDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDJDateOfBirth.Location = new System.Drawing.Point(281, 135);
            this.dtpDJDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDJDateOfBirth.Name = "dtpDJDateOfBirth";
            this.dtpDJDateOfBirth.Size = new System.Drawing.Size(489, 27);
            this.dtpDJDateOfBirth.TabIndex = 2;
            this.dtpDJDateOfBirth.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // btnAddDJ
            // 
            this.btnAddDJ.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDJ.Location = new System.Drawing.Point(439, 527);
            this.btnAddDJ.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDJ.Name = "btnAddDJ";
            this.btnAddDJ.Size = new System.Drawing.Size(200, 57);
            this.btnAddDJ.TabIndex = 22;
            this.btnAddDJ.Text = "Add DJ";
            this.btnAddDJ.UseVisualStyleBackColor = true;
            this.btnAddDJ.Click += new System.EventHandler(this.btnAddDJ_Click);
            // 
            // lblDJSurname
            // 
            this.lblDJSurname.AutoSize = true;
            this.lblDJSurname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJSurname.Location = new System.Drawing.Point(49, 102);
            this.lblDJSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJSurname.Name = "lblDJSurname";
            this.lblDJSurname.Size = new System.Drawing.Size(93, 20);
            this.lblDJSurname.TabIndex = 21;
            this.lblDJSurname.Text = "Surname";
            // 
            // lblDJDateOfBirth
            // 
            this.lblDJDateOfBirth.AutoSize = true;
            this.lblDJDateOfBirth.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJDateOfBirth.Location = new System.Drawing.Point(49, 142);
            this.lblDJDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJDateOfBirth.Name = "lblDJDateOfBirth";
            this.lblDJDateOfBirth.Size = new System.Drawing.Size(165, 20);
            this.lblDJDateOfBirth.TabIndex = 20;
            this.lblDJDateOfBirth.Text = "Date Of Birth";
            // 
            // lblDJContactNo
            // 
            this.lblDJContactNo.AutoSize = true;
            this.lblDJContactNo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJContactNo.Location = new System.Drawing.Point(49, 174);
            this.lblDJContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJContactNo.Name = "lblDJContactNo";
            this.lblDJContactNo.Size = new System.Drawing.Size(141, 20);
            this.lblDJContactNo.TabIndex = 19;
            this.lblDJContactNo.Text = "Contact No.";
            // 
            // lblDJEmail
            // 
            this.lblDJEmail.AutoSize = true;
            this.lblDJEmail.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJEmail.Location = new System.Drawing.Point(49, 209);
            this.lblDJEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJEmail.Name = "lblDJEmail";
            this.lblDJEmail.Size = new System.Drawing.Size(69, 20);
            this.lblDJEmail.TabIndex = 18;
            this.lblDJEmail.Text = "Email";
            // 
            // lblDJStreet
            // 
            this.lblDJStreet.AutoSize = true;
            this.lblDJStreet.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJStreet.Location = new System.Drawing.Point(49, 245);
            this.lblDJStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJStreet.Name = "lblDJStreet";
            this.lblDJStreet.Size = new System.Drawing.Size(81, 20);
            this.lblDJStreet.TabIndex = 17;
            this.lblDJStreet.Text = "Street";
            // 
            // lblDJTown
            // 
            this.lblDJTown.AutoSize = true;
            this.lblDJTown.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJTown.Location = new System.Drawing.Point(49, 281);
            this.lblDJTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJTown.Name = "lblDJTown";
            this.lblDJTown.Size = new System.Drawing.Size(57, 20);
            this.lblDJTown.TabIndex = 16;
            this.lblDJTown.Text = "Town";
            // 
            // lblDJCity
            // 
            this.lblDJCity.AutoSize = true;
            this.lblDJCity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJCity.Location = new System.Drawing.Point(49, 316);
            this.lblDJCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJCity.Name = "lblDJCity";
            this.lblDJCity.Size = new System.Drawing.Size(57, 20);
            this.lblDJCity.TabIndex = 15;
            this.lblDJCity.Text = "City";
            // 
            // lblDJCounty
            // 
            this.lblDJCounty.AutoSize = true;
            this.lblDJCounty.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJCounty.Location = new System.Drawing.Point(49, 352);
            this.lblDJCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJCounty.Name = "lblDJCounty";
            this.lblDJCounty.Size = new System.Drawing.Size(81, 20);
            this.lblDJCounty.TabIndex = 14;
            this.lblDJCounty.Text = "County";
            // 
            // txtDJID
            // 
            this.txtDJID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDJID.Location = new System.Drawing.Point(476, 30);
            this.txtDJID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJID.MaxLength = 5;
            this.txtDJID.Name = "txtDJID";
            this.txtDJID.Size = new System.Drawing.Size(132, 26);
            this.txtDJID.TabIndex = 29;
            this.txtDJID.Text = "1";
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(13, 720);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 105);
            this.btnMain.TabIndex = 28;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblDJEircode
            // 
            this.lblDJEircode.AutoSize = true;
            this.lblDJEircode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJEircode.Location = new System.Drawing.Point(49, 388);
            this.lblDJEircode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJEircode.Name = "lblDJEircode";
            this.lblDJEircode.Size = new System.Drawing.Size(93, 20);
            this.lblDJEircode.TabIndex = 13;
            this.lblDJEircode.Text = "Eircode";
            // 
            // lblDJForename
            // 
            this.lblDJForename.AutoSize = true;
            this.lblDJForename.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJForename.Location = new System.Drawing.Point(49, 66);
            this.lblDJForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJForename.Name = "lblDJForename";
            this.lblDJForename.Size = new System.Drawing.Size(105, 20);
            this.lblDJForename.TabIndex = 11;
            this.lblDJForename.Text = "Forename";
            // 
            // txtDJCounty
            // 
            this.txtDJCounty.Location = new System.Drawing.Point(281, 350);
            this.txtDJCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJCounty.MaxLength = 15;
            this.txtDJCounty.Name = "txtDJCounty";
            this.txtDJCounty.Size = new System.Drawing.Size(489, 27);
            this.txtDJCounty.TabIndex = 8;
            // 
            // txtDJCity
            // 
            this.txtDJCity.Location = new System.Drawing.Point(281, 314);
            this.txtDJCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJCity.MaxLength = 50;
            this.txtDJCity.Name = "txtDJCity";
            this.txtDJCity.Size = new System.Drawing.Size(489, 27);
            this.txtDJCity.TabIndex = 7;
            // 
            // txtDJTown
            // 
            this.txtDJTown.Location = new System.Drawing.Point(281, 278);
            this.txtDJTown.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJTown.MaxLength = 50;
            this.txtDJTown.Name = "txtDJTown";
            this.txtDJTown.Size = new System.Drawing.Size(489, 27);
            this.txtDJTown.TabIndex = 6;
            // 
            // txtDJStreet
            // 
            this.txtDJStreet.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDJStreet.Location = new System.Drawing.Point(281, 242);
            this.txtDJStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJStreet.MaxLength = 50;
            this.txtDJStreet.Name = "txtDJStreet";
            this.txtDJStreet.Size = new System.Drawing.Size(489, 27);
            this.txtDJStreet.TabIndex = 5;
            // 
            // txtDJEmail
            // 
            this.txtDJEmail.Location = new System.Drawing.Point(281, 207);
            this.txtDJEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJEmail.MaxLength = 255;
            this.txtDJEmail.Name = "txtDJEmail";
            this.txtDJEmail.Size = new System.Drawing.Size(489, 27);
            this.txtDJEmail.TabIndex = 4;
            // 
            // txtDJContactNo
            // 
            this.txtDJContactNo.Location = new System.Drawing.Point(281, 171);
            this.txtDJContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJContactNo.MaxLength = 20;
            this.txtDJContactNo.Name = "txtDJContactNo";
            this.txtDJContactNo.Size = new System.Drawing.Size(489, 27);
            this.txtDJContactNo.TabIndex = 3;
            // 
            // txtDJSurname
            // 
            this.txtDJSurname.Location = new System.Drawing.Point(281, 100);
            this.txtDJSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJSurname.MaxLength = 35;
            this.txtDJSurname.Name = "txtDJSurname";
            this.txtDJSurname.Size = new System.Drawing.Size(489, 27);
            this.txtDJSurname.TabIndex = 1;
            // 
            // txtDJForename
            // 
            this.txtDJForename.Location = new System.Drawing.Point(281, 64);
            this.txtDJForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJForename.MaxLength = 35;
            this.txtDJForename.Name = "txtDJForename";
            this.txtDJForename.Size = new System.Drawing.Size(489, 27);
            this.txtDJForename.TabIndex = 0;
            // 
            // lblDJID
            // 
            this.lblDJID.AutoSize = true;
            this.lblDJID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJID.Location = new System.Drawing.Point(244, 34);
            this.lblDJID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJID.Name = "lblDJID";
            this.lblDJID.Size = new System.Drawing.Size(69, 20);
            this.lblDJID.TabIndex = 30;
            this.lblDJID.Text = "DJ ID";
            // 
            // txtDJEircode
            // 
            this.txtDJEircode.Location = new System.Drawing.Point(281, 385);
            this.txtDJEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtDJEircode.MaxLength = 7;
            this.txtDJEircode.Name = "txtDJEircode";
            this.txtDJEircode.Size = new System.Drawing.Size(489, 27);
            this.txtDJEircode.TabIndex = 9;
            // 
            // grpAddDJ
            // 
            this.grpAddDJ.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpAddDJ.Controls.Add(this.nudDJHourlyRate);
            this.grpAddDJ.Controls.Add(this.lblDJHourlyRate);
            this.grpAddDJ.Controls.Add(this.lblDJStatus);
            this.grpAddDJ.Controls.Add(this.txtDJStatus);
            this.grpAddDJ.Controls.Add(this.dtpDJDateOfBirth);
            this.grpAddDJ.Controls.Add(this.btnAddDJ);
            this.grpAddDJ.Controls.Add(this.lblDJSurname);
            this.grpAddDJ.Controls.Add(this.lblDJDateOfBirth);
            this.grpAddDJ.Controls.Add(this.lblDJContactNo);
            this.grpAddDJ.Controls.Add(this.lblDJEmail);
            this.grpAddDJ.Controls.Add(this.lblDJStreet);
            this.grpAddDJ.Controls.Add(this.lblDJTown);
            this.grpAddDJ.Controls.Add(this.lblDJCity);
            this.grpAddDJ.Controls.Add(this.lblDJCounty);
            this.grpAddDJ.Controls.Add(this.lblDJEircode);
            this.grpAddDJ.Controls.Add(this.lblDJForename);
            this.grpAddDJ.Controls.Add(this.txtDJEircode);
            this.grpAddDJ.Controls.Add(this.txtDJCounty);
            this.grpAddDJ.Controls.Add(this.txtDJCity);
            this.grpAddDJ.Controls.Add(this.txtDJTown);
            this.grpAddDJ.Controls.Add(this.txtDJStreet);
            this.grpAddDJ.Controls.Add(this.txtDJEmail);
            this.grpAddDJ.Controls.Add(this.txtDJContactNo);
            this.grpAddDJ.Controls.Add(this.txtDJSurname);
            this.grpAddDJ.Controls.Add(this.txtDJForename);
            this.grpAddDJ.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddDJ.Location = new System.Drawing.Point(195, 99);
            this.grpAddDJ.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddDJ.Name = "grpAddDJ";
            this.grpAddDJ.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddDJ.Size = new System.Drawing.Size(812, 592);
            this.grpAddDJ.TabIndex = 27;
            this.grpAddDJ.TabStop = false;
            this.grpAddDJ.Text = "Enter DJ Details";
            // 
            // nudDJHourlyRate
            // 
            this.nudDJHourlyRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDJHourlyRate.Location = new System.Drawing.Point(281, 421);
            this.nudDJHourlyRate.Name = "nudDJHourlyRate";
            this.nudDJHourlyRate.Size = new System.Drawing.Size(489, 27);
            this.nudDJHourlyRate.TabIndex = 10;
            // 
            // lblDJHourlyRate
            // 
            this.lblDJHourlyRate.AutoSize = true;
            this.lblDJHourlyRate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJHourlyRate.Location = new System.Drawing.Point(49, 427);
            this.lblDJHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDJHourlyRate.Name = "lblDJHourlyRate";
            this.lblDJHourlyRate.Size = new System.Drawing.Size(141, 20);
            this.lblDJHourlyRate.TabIndex = 26;
            this.lblDJHourlyRate.Text = "Hourly Rate";
            // 
            // frmAddDJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 838);
            this.Controls.Add(this.btnDJEmail);
            this.Controls.Add(this.txtDJID);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblDJID);
            this.Controls.Add(this.grpAddDJ);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddDJ";
            this.Text = "Add DJ";
            this.Load += new System.EventHandler(this.frmAddDJ_Load);
            this.grpAddDJ.ResumeLayout(false);
            this.grpAddDJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDJHourlyRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDJEmail;
        private System.Windows.Forms.Label lblDJStatus;
        private System.Windows.Forms.TextBox txtDJStatus;
        private System.Windows.Forms.DateTimePicker dtpDJDateOfBirth;
        private System.Windows.Forms.Button btnAddDJ;
        private System.Windows.Forms.Label lblDJSurname;
        private System.Windows.Forms.Label lblDJDateOfBirth;
        private System.Windows.Forms.Label lblDJContactNo;
        private System.Windows.Forms.Label lblDJEmail;
        private System.Windows.Forms.Label lblDJStreet;
        private System.Windows.Forms.Label lblDJTown;
        private System.Windows.Forms.Label lblDJCity;
        private System.Windows.Forms.Label lblDJCounty;
        private System.Windows.Forms.TextBox txtDJID;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblDJEircode;
        private System.Windows.Forms.Label lblDJForename;
        private System.Windows.Forms.TextBox txtDJCounty;
        private System.Windows.Forms.TextBox txtDJCity;
        private System.Windows.Forms.TextBox txtDJTown;
        private System.Windows.Forms.TextBox txtDJStreet;
        private System.Windows.Forms.TextBox txtDJEmail;
        private System.Windows.Forms.TextBox txtDJContactNo;
        private System.Windows.Forms.TextBox txtDJSurname;
        private System.Windows.Forms.TextBox txtDJForename;
        private System.Windows.Forms.Label lblDJID;
        private System.Windows.Forms.TextBox txtDJEircode;
        private System.Windows.Forms.GroupBox grpAddDJ;
        private System.Windows.Forms.Label lblDJHourlyRate;
        private System.Windows.Forms.NumericUpDown nudDJHourlyRate;
    }
}