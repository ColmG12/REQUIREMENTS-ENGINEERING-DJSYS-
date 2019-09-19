namespace DJSys
{
    partial class frmAddClient
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
            this.grpAddClient = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.grpAddClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddClient
            // 
            this.grpAddClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpAddClient.Controls.Add(this.lblStatus);
            this.grpAddClient.Controls.Add(this.txtStatus);
            this.grpAddClient.Controls.Add(this.dtpDateOfBirth);
            this.grpAddClient.Controls.Add(this.btnAddClient);
            this.grpAddClient.Controls.Add(this.lblSurname);
            this.grpAddClient.Controls.Add(this.lblDateOfBirth);
            this.grpAddClient.Controls.Add(this.lblContactNo);
            this.grpAddClient.Controls.Add(this.lblEmail);
            this.grpAddClient.Controls.Add(this.lblStreet);
            this.grpAddClient.Controls.Add(this.lblTown);
            this.grpAddClient.Controls.Add(this.lblCity);
            this.grpAddClient.Controls.Add(this.lblCounty);
            this.grpAddClient.Controls.Add(this.lblEircode);
            this.grpAddClient.Controls.Add(this.lblForename);
            this.grpAddClient.Controls.Add(this.txtEircode);
            this.grpAddClient.Controls.Add(this.txtCounty);
            this.grpAddClient.Controls.Add(this.txtCity);
            this.grpAddClient.Controls.Add(this.txtTown);
            this.grpAddClient.Controls.Add(this.txtStreet);
            this.grpAddClient.Controls.Add(this.txtEmail);
            this.grpAddClient.Controls.Add(this.txtContactNo);
            this.grpAddClient.Controls.Add(this.txtSurname);
            this.grpAddClient.Controls.Add(this.txtForename);
            this.grpAddClient.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddClient.Location = new System.Drawing.Point(143, 118);
            this.grpAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddClient.Name = "grpAddClient";
            this.grpAddClient.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddClient.Size = new System.Drawing.Size(812, 532);
            this.grpAddClient.TabIndex = 0;
            this.grpAddClient.TabStop = false;
            this.grpAddClient.Text = "Enter Client Details";
            this.grpAddClient.Enter += new System.EventHandler(this.grpAddClient_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(49, 423);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(281, 421);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.MaxLength = 9;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(489, 27);
            this.txtStatus.TabIndex = 23;
            this.txtStatus.Text = "A";
            this.txtStatus.Visible = false;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(281, 135);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(489, 27);
            this.dtpDateOfBirth.TabIndex = 2;
            this.dtpDateOfBirth.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(437, 468);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(200, 57);
            this.btnAddClient.TabIndex = 22;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(49, 102);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(93, 20);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Text = "Surname";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(49, 142);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(165, 20);
            this.lblDateOfBirth.TabIndex = 20;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(49, 174);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(141, 20);
            this.lblContactNo.TabIndex = 19;
            this.lblContactNo.Text = "Contact No.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(49, 209);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 20);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(49, 245);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(81, 20);
            this.lblStreet.TabIndex = 17;
            this.lblStreet.Text = "Street";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(49, 281);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(57, 20);
            this.lblTown.TabIndex = 16;
            this.lblTown.Text = "Town";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(49, 316);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 20);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(49, 352);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(81, 20);
            this.lblCounty.TabIndex = 14;
            this.lblCounty.Text = "County";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(49, 388);
            this.lblEircode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(93, 20);
            this.lblEircode.TabIndex = 13;
            this.lblEircode.Text = "Eircode";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(49, 66);
            this.lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(105, 20);
            this.lblForename.TabIndex = 11;
            this.lblForename.Text = "Forename";
            this.lblForename.Click += new System.EventHandler(this.lblForename_Click);
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(281, 385);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(489, 27);
            this.txtEircode.TabIndex = 9;
            this.txtEircode.TextChanged += new System.EventHandler(this.txtEircode_TextChanged);
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(281, 350);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounty.MaxLength = 15;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(489, 27);
            this.txtCounty.TabIndex = 8;
            this.txtCounty.TextChanged += new System.EventHandler(this.txtCounty_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(281, 314);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(489, 27);
            this.txtCity.TabIndex = 7;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(281, 278);
            this.txtTown.Margin = new System.Windows.Forms.Padding(4);
            this.txtTown.MaxLength = 50;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(489, 27);
            this.txtTown.TabIndex = 6;
            this.txtTown.TextChanged += new System.EventHandler(this.txtTown_TextChanged);
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(281, 242);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(489, 27);
            this.txtStreet.TabIndex = 5;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(281, 207);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(489, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(281, 171);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.MaxLength = 20;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(489, 27);
            this.txtContactNo.TabIndex = 3;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(281, 100);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.MaxLength = 35;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(489, 27);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(281, 64);
            this.txtForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtForename.MaxLength = 35;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(489, 27);
            this.txtForename.TabIndex = 0;
            this.txtForename.TextChanged += new System.EventHandler(this.txtForename_TextChanged);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(16, 677);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 105);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(424, 49);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientID.MaxLength = 5;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(132, 26);
            this.txtClientID.TabIndex = 24;
            this.txtClientID.Text = "166";
            this.txtClientID.TextChanged += new System.EventHandler(this.txtClientID_TextChanged);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(192, 53);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(117, 20);
            this.lblClientID.TabIndex = 25;
            this.lblClientID.Text = "Client ID";
            this.lblClientID.Click += new System.EventHandler(this.lblClientID_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.Location = new System.Drawing.Point(909, 677);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(145, 105);
            this.btnEmail.TabIndex = 26;
            this.btnEmail.Text = "Send Confirmation Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Visible = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 838);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.grpAddClient);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddClient";
            this.Text = "Add Client";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.grpAddClient.ResumeLayout(false);
            this.grpAddClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddClient;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnEmail;
    }
}