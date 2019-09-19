namespace DJSys
{
    partial class frmUpdateClient
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
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpUpdateClient = new System.Windows.Forms.GroupBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
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
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.grpUpdateMatchingClients = new System.Windows.Forms.GroupBox();
            this.optMatchingClient2 = new System.Windows.Forms.RadioButton();
            this.optMatchingClient1 = new System.Windows.Forms.RadioButton();
            this.txtMatchingClients2 = new System.Windows.Forms.TextBox();
            this.txtMatchingClients1 = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.grpUpdateClient2 = new System.Windows.Forms.GroupBox();
            this.dtpDateOfBirth2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus2 = new System.Windows.Forms.TextBox();
            this.txtClientID2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateClient2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEircode2 = new System.Windows.Forms.TextBox();
            this.txtCounty2 = new System.Windows.Forms.TextBox();
            this.txtCity2 = new System.Windows.Forms.TextBox();
            this.txtTown2 = new System.Windows.Forms.TextBox();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.txtSurname2 = new System.Windows.Forms.TextBox();
            this.txtContactNo2 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtForename2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpUpdateClient.SuspendLayout();
            this.grpUpdateMatchingClients.SuspendLayout();
            this.grpUpdateClient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEnterName
            // 
            this.txtEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterName.Location = new System.Drawing.Point(356, 15);
            this.txtEnterName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterName.MaxLength = 35;
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(416, 24);
            this.txtEnterName.TabIndex = 0;
            this.txtEnterName.Text = "Gallagher";
            this.txtEnterName.TextChanged += new System.EventHandler(this.txtEnterName_TextChanged);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(165, 15);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(141, 20);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter Name:";
            this.lblEnterName.Click += new System.EventHandler(this.lblEnterName_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(512, 47);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(100, 28);
            this.btnFindClient.TabIndex = 2;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // grpUpdateClient
            // 
            this.grpUpdateClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpUpdateClient.Controls.Add(this.dtpDateOfBirth);
            this.grpUpdateClient.Controls.Add(this.lblStatus);
            this.grpUpdateClient.Controls.Add(this.txtStatus);
            this.grpUpdateClient.Controls.Add(this.txtClientID);
            this.grpUpdateClient.Controls.Add(this.lblClientID);
            this.grpUpdateClient.Controls.Add(this.btnUpdateClient);
            this.grpUpdateClient.Controls.Add(this.lblSurname);
            this.grpUpdateClient.Controls.Add(this.lblDateOfBirth);
            this.grpUpdateClient.Controls.Add(this.lblContactNo);
            this.grpUpdateClient.Controls.Add(this.lblEmail);
            this.grpUpdateClient.Controls.Add(this.lblStreet);
            this.grpUpdateClient.Controls.Add(this.lblTown);
            this.grpUpdateClient.Controls.Add(this.lblCity);
            this.grpUpdateClient.Controls.Add(this.lblCounty);
            this.grpUpdateClient.Controls.Add(this.lblEircode);
            this.grpUpdateClient.Controls.Add(this.lblForename);
            this.grpUpdateClient.Controls.Add(this.txtEircode);
            this.grpUpdateClient.Controls.Add(this.txtCounty);
            this.grpUpdateClient.Controls.Add(this.txtCity);
            this.grpUpdateClient.Controls.Add(this.txtTown);
            this.grpUpdateClient.Controls.Add(this.txtStreet);
            this.grpUpdateClient.Controls.Add(this.txtSurname);
            this.grpUpdateClient.Controls.Add(this.txtContactNo);
            this.grpUpdateClient.Controls.Add(this.txtEmail);
            this.grpUpdateClient.Controls.Add(this.txtForename);
            this.grpUpdateClient.Location = new System.Drawing.Point(152, 254);
            this.grpUpdateClient.Margin = new System.Windows.Forms.Padding(4);
            this.grpUpdateClient.Name = "grpUpdateClient";
            this.grpUpdateClient.Padding = new System.Windows.Forms.Padding(4);
            this.grpUpdateClient.Size = new System.Drawing.Size(812, 497);
            this.grpUpdateClient.TabIndex = 3;
            this.grpUpdateClient.TabStop = false;
            this.grpUpdateClient.Text = "Client Details";
            this.grpUpdateClient.Visible = false;
            this.grpUpdateClient.Enter += new System.EventHandler(this.grpUpdateClient_Enter);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(230, 129);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(540, 25);
            this.dtpDateOfBirth.TabIndex = 30;
            this.dtpDateOfBirth.Value = new System.DateTime(1979, 10, 12, 0, 0, 0, 0);
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged_1);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(49, 388);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 20);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click_1);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(230, 386);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.MaxLength = 9;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(540, 25);
            this.txtStatus.TabIndex = 28;
            this.txtStatus.Text = "A";
            this.txtStatus.Visible = false;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // txtClientID
            // 
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(230, 31);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientID.MaxLength = 5;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(132, 26);
            this.txtClientID.TabIndex = 27;
            this.txtClientID.Text = "166";
            this.txtClientID.Visible = false;
            this.txtClientID.TextChanged += new System.EventHandler(this.txtClientID_TextChanged_1);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(49, 37);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(117, 20);
            this.lblClientID.TabIndex = 26;
            this.lblClientID.Text = "Client ID";
            this.lblClientID.Click += new System.EventHandler(this.lblClientID_Click_1);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(403, 432);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(200, 57);
            this.btnUpdateClient.TabIndex = 22;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(49, 100);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(93, 20);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Text = "Surname";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(49, 132);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(165, 20);
            this.lblDateOfBirth.TabIndex = 20;
            this.lblDateOfBirth.Text = "Date Of Birth";
            this.lblDateOfBirth.Click += new System.EventHandler(this.lblDateOfBirth_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(49, 164);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(141, 20);
            this.lblContactNo.TabIndex = 19;
            this.lblContactNo.Text = "Contact No.";
            this.lblContactNo.Click += new System.EventHandler(this.lblContactNo_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(49, 196);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 20);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(49, 228);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(81, 20);
            this.lblStreet.TabIndex = 17;
            this.lblStreet.Text = "Street";
            this.lblStreet.Click += new System.EventHandler(this.lblStreet_Click);
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(49, 260);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(57, 20);
            this.lblTown.TabIndex = 16;
            this.lblTown.Text = "Town";
            this.lblTown.Click += new System.EventHandler(this.lblTown_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(49, 292);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 20);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(49, 324);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(81, 20);
            this.lblCounty.TabIndex = 14;
            this.lblCounty.Text = "County";
            this.lblCounty.Click += new System.EventHandler(this.lblCounty_Click);
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(49, 356);
            this.lblEircode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(93, 20);
            this.lblEircode.TabIndex = 13;
            this.lblEircode.Text = "Eircode";
            this.lblEircode.Click += new System.EventHandler(this.lblEircode_Click);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(49, 68);
            this.lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(105, 20);
            this.lblForename.TabIndex = 11;
            this.lblForename.Text = "Forename";
            this.lblForename.Click += new System.EventHandler(this.lblForename_Click);
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(230, 352);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(541, 25);
            this.txtEircode.TabIndex = 9;
            this.txtEircode.Text = "V31D928";
            this.txtEircode.TextChanged += new System.EventHandler(this.txtEircode_TextChanged);
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(230, 320);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounty.MaxLength = 15;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(541, 25);
            this.txtCounty.TabIndex = 8;
            this.txtCounty.Text = "Kerry";
            this.txtCounty.TextChanged += new System.EventHandler(this.txtCounty_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(230, 288);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(541, 25);
            this.txtCity.TabIndex = 7;
            this.txtCity.Text = "Knocknagoshel";
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(230, 256);
            this.txtTown.Margin = new System.Windows.Forms.Padding(4);
            this.txtTown.MaxLength = 50;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(541, 25);
            this.txtTown.TabIndex = 6;
            this.txtTown.Text = "Boula";
            this.txtTown.TextChanged += new System.EventHandler(this.txtTown_TextChanged);
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(230, 224);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(541, 25);
            this.txtStreet.TabIndex = 5;
            this.txtStreet.Text = "The Cottage";
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(230, 96);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.MaxLength = 35;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(541, 25);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.Text = "Gallagher";
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(230, 160);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.MaxLength = 20;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(541, 25);
            this.txtContactNo.TabIndex = 2;
            this.txtContactNo.Text = "0871706203";
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(230, 192);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(541, 25);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "colmg12@hotmail.co.uk";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(230, 64);
            this.txtForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtForename.MaxLength = 35;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(541, 25);
            this.txtForename.TabIndex = 0;
            this.txtForename.Text = "Colm";
            this.txtForename.TextChanged += new System.EventHandler(this.txtForename_TextChanged);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(13, 774);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 105);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // grpUpdateMatchingClients
            // 
            this.grpUpdateMatchingClients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpUpdateMatchingClients.Controls.Add(this.optMatchingClient2);
            this.grpUpdateMatchingClients.Controls.Add(this.optMatchingClient1);
            this.grpUpdateMatchingClients.Controls.Add(this.txtMatchingClients2);
            this.grpUpdateMatchingClients.Controls.Add(this.txtMatchingClients1);
            this.grpUpdateMatchingClients.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateMatchingClients.Location = new System.Drawing.Point(294, 114);
            this.grpUpdateMatchingClients.Name = "grpUpdateMatchingClients";
            this.grpUpdateMatchingClients.Size = new System.Drawing.Size(526, 111);
            this.grpUpdateMatchingClients.TabIndex = 5;
            this.grpUpdateMatchingClients.TabStop = false;
            this.grpUpdateMatchingClients.Text = "Matching Clients";
            this.grpUpdateMatchingClients.Visible = false;
            this.grpUpdateMatchingClients.Enter += new System.EventHandler(this.grpMatchingClients_Enter);
            // 
            // optMatchingClient2
            // 
            this.optMatchingClient2.AutoSize = true;
            this.optMatchingClient2.Location = new System.Drawing.Point(461, 81);
            this.optMatchingClient2.Name = "optMatchingClient2";
            this.optMatchingClient2.Size = new System.Drawing.Size(17, 16);
            this.optMatchingClient2.TabIndex = 3;
            this.optMatchingClient2.TabStop = true;
            this.optMatchingClient2.UseVisualStyleBackColor = true;
            this.optMatchingClient2.CheckedChanged += new System.EventHandler(this.optMatchingClient2_CheckedChanged);
            // 
            // optMatchingClient1
            // 
            this.optMatchingClient1.AutoSize = true;
            this.optMatchingClient1.Location = new System.Drawing.Point(461, 53);
            this.optMatchingClient1.Name = "optMatchingClient1";
            this.optMatchingClient1.Size = new System.Drawing.Size(17, 16);
            this.optMatchingClient1.TabIndex = 2;
            this.optMatchingClient1.TabStop = true;
            this.optMatchingClient1.UseVisualStyleBackColor = true;
            this.optMatchingClient1.CheckedChanged += new System.EventHandler(this.optMatchingClient1_CheckedChanged);
            // 
            // txtMatchingClients2
            // 
            this.txtMatchingClients2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchingClients2.Location = new System.Drawing.Point(62, 72);
            this.txtMatchingClients2.Name = "txtMatchingClients2";
            this.txtMatchingClients2.Size = new System.Drawing.Size(416, 25);
            this.txtMatchingClients2.TabIndex = 1;
            this.txtMatchingClients2.Text = "Gallagher Michael";
            this.txtMatchingClients2.TextChanged += new System.EventHandler(this.txtMatchingClients2_TextChanged);
            // 
            // txtMatchingClients1
            // 
            this.txtMatchingClients1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchingClients1.Location = new System.Drawing.Point(62, 44);
            this.txtMatchingClients1.Name = "txtMatchingClients1";
            this.txtMatchingClients1.Size = new System.Drawing.Size(416, 25);
            this.txtMatchingClients1.TabIndex = 0;
            this.txtMatchingClients1.Text = "Gallagher Colm";
            this.txtMatchingClients1.TextChanged += new System.EventHandler(this.txtMatchingClients1_TextChanged);
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.Location = new System.Drawing.Point(909, 774);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(145, 105);
            this.btnEmail.TabIndex = 27;
            this.btnEmail.Text = "Send Confirmation Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Visible = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // grpUpdateClient2
            // 
            this.grpUpdateClient2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpUpdateClient2.Controls.Add(this.dtpDateOfBirth2);
            this.grpUpdateClient2.Controls.Add(this.label1);
            this.grpUpdateClient2.Controls.Add(this.txtStatus2);
            this.grpUpdateClient2.Controls.Add(this.txtClientID2);
            this.grpUpdateClient2.Controls.Add(this.label2);
            this.grpUpdateClient2.Controls.Add(this.btnUpdateClient2);
            this.grpUpdateClient2.Controls.Add(this.label3);
            this.grpUpdateClient2.Controls.Add(this.label4);
            this.grpUpdateClient2.Controls.Add(this.label5);
            this.grpUpdateClient2.Controls.Add(this.label6);
            this.grpUpdateClient2.Controls.Add(this.label7);
            this.grpUpdateClient2.Controls.Add(this.label8);
            this.grpUpdateClient2.Controls.Add(this.label9);
            this.grpUpdateClient2.Controls.Add(this.label10);
            this.grpUpdateClient2.Controls.Add(this.label11);
            this.grpUpdateClient2.Controls.Add(this.label12);
            this.grpUpdateClient2.Controls.Add(this.txtEircode2);
            this.grpUpdateClient2.Controls.Add(this.txtCounty2);
            this.grpUpdateClient2.Controls.Add(this.txtCity2);
            this.grpUpdateClient2.Controls.Add(this.txtTown2);
            this.grpUpdateClient2.Controls.Add(this.txtStreet2);
            this.grpUpdateClient2.Controls.Add(this.txtSurname2);
            this.grpUpdateClient2.Controls.Add(this.txtContactNo2);
            this.grpUpdateClient2.Controls.Add(this.txtEmail2);
            this.grpUpdateClient2.Controls.Add(this.txtForename2);
            this.grpUpdateClient2.Location = new System.Drawing.Point(152, 254);
            this.grpUpdateClient2.Margin = new System.Windows.Forms.Padding(4);
            this.grpUpdateClient2.Name = "grpUpdateClient2";
            this.grpUpdateClient2.Padding = new System.Windows.Forms.Padding(4);
            this.grpUpdateClient2.Size = new System.Drawing.Size(812, 497);
            this.grpUpdateClient2.TabIndex = 31;
            this.grpUpdateClient2.TabStop = false;
            this.grpUpdateClient2.Text = "Client Details";
            this.grpUpdateClient2.Visible = false;
            // 
            // dtpDateOfBirth2
            // 
            this.dtpDateOfBirth2.CustomFormat = "";
            this.dtpDateOfBirth2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth2.Location = new System.Drawing.Point(230, 129);
            this.dtpDateOfBirth2.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth2.Name = "dtpDateOfBirth2";
            this.dtpDateOfBirth2.Size = new System.Drawing.Size(540, 25);
            this.dtpDateOfBirth2.TabIndex = 30;
            this.dtpDateOfBirth2.Value = new System.DateTime(1966, 1, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 388);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status";
            // 
            // txtStatus2
            // 
            this.txtStatus2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus2.Location = new System.Drawing.Point(230, 386);
            this.txtStatus2.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus2.MaxLength = 9;
            this.txtStatus2.Name = "txtStatus2";
            this.txtStatus2.Size = new System.Drawing.Size(540, 25);
            this.txtStatus2.TabIndex = 28;
            this.txtStatus2.Text = "A";
            this.txtStatus2.Visible = false;
            // 
            // txtClientID2
            // 
            this.txtClientID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID2.Location = new System.Drawing.Point(230, 31);
            this.txtClientID2.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientID2.MaxLength = 5;
            this.txtClientID2.Name = "txtClientID2";
            this.txtClientID2.Size = new System.Drawing.Size(132, 26);
            this.txtClientID2.TabIndex = 27;
            this.txtClientID2.Text = "185";
            this.txtClientID2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Client ID";
            // 
            // btnUpdateClient2
            // 
            this.btnUpdateClient2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient2.Location = new System.Drawing.Point(343, 432);
            this.btnUpdateClient2.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateClient2.Name = "btnUpdateClient2";
            this.btnUpdateClient2.Size = new System.Drawing.Size(298, 57);
            this.btnUpdateClient2.TabIndex = 22;
            this.btnUpdateClient2.Text = "Update Client";
            this.btnUpdateClient2.UseVisualStyleBackColor = true;
            this.btnUpdateClient2.Click += new System.EventHandler(this.btnUpdateClient2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Contact No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Street";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Town";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 324);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "County";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 356);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Eircode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Forename";
            // 
            // txtEircode2
            // 
            this.txtEircode2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode2.Location = new System.Drawing.Point(230, 352);
            this.txtEircode2.Margin = new System.Windows.Forms.Padding(4);
            this.txtEircode2.MaxLength = 7;
            this.txtEircode2.Name = "txtEircode2";
            this.txtEircode2.Size = new System.Drawing.Size(541, 25);
            this.txtEircode2.TabIndex = 9;
            this.txtEircode2.Text = "V32H837";
            // 
            // txtCounty2
            // 
            this.txtCounty2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty2.Location = new System.Drawing.Point(230, 320);
            this.txtCounty2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounty2.MaxLength = 15;
            this.txtCounty2.Name = "txtCounty2";
            this.txtCounty2.Size = new System.Drawing.Size(541, 25);
            this.txtCounty2.TabIndex = 8;
            this.txtCounty2.Text = "Kerry";
            // 
            // txtCity2
            // 
            this.txtCity2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity2.Location = new System.Drawing.Point(230, 288);
            this.txtCity2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity2.MaxLength = 50;
            this.txtCity2.Name = "txtCity2";
            this.txtCity2.Size = new System.Drawing.Size(541, 25);
            this.txtCity2.TabIndex = 7;
            this.txtCity2.Text = "Listowel";
            // 
            // txtTown2
            // 
            this.txtTown2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown2.Location = new System.Drawing.Point(230, 256);
            this.txtTown2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTown2.MaxLength = 50;
            this.txtTown2.Name = "txtTown2";
            this.txtTown2.Size = new System.Drawing.Size(541, 25);
            this.txtTown2.TabIndex = 6;
            this.txtTown2.Text = "Lyreacrompane";
            // 
            // txtStreet2
            // 
            this.txtStreet2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet2.Location = new System.Drawing.Point(230, 224);
            this.txtStreet2.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet2.MaxLength = 50;
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(541, 25);
            this.txtStreet2.TabIndex = 5;
            this.txtStreet2.Text = "Renagown Cross";
            // 
            // txtSurname2
            // 
            this.txtSurname2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname2.Location = new System.Drawing.Point(230, 96);
            this.txtSurname2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname2.MaxLength = 35;
            this.txtSurname2.Name = "txtSurname2";
            this.txtSurname2.Size = new System.Drawing.Size(541, 25);
            this.txtSurname2.TabIndex = 4;
            this.txtSurname2.Text = "Gallagher";
            // 
            // txtContactNo2
            // 
            this.txtContactNo2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo2.Location = new System.Drawing.Point(230, 160);
            this.txtContactNo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo2.MaxLength = 20;
            this.txtContactNo2.Name = "txtContactNo2";
            this.txtContactNo2.Size = new System.Drawing.Size(541, 25);
            this.txtContactNo2.TabIndex = 2;
            this.txtContactNo2.Text = "0869382701";
            // 
            // txtEmail2
            // 
            this.txtEmail2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail2.Location = new System.Drawing.Point(230, 192);
            this.txtEmail2.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail2.MaxLength = 255;
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(541, 25);
            this.txtEmail2.TabIndex = 1;
            this.txtEmail2.Text = "mig66@gmail.com";
            // 
            // txtForename2
            // 
            this.txtForename2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename2.Location = new System.Drawing.Point(230, 64);
            this.txtForename2.Margin = new System.Windows.Forms.Padding(4);
            this.txtForename2.MaxLength = 35;
            this.txtForename2.Name = "txtForename2";
            this.txtForename2.Size = new System.Drawing.Size(541, 25);
            this.txtForename2.TabIndex = 0;
            this.txtForename2.Text = "Michael";
            // 
            // frmUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1778, 892);
            this.Controls.Add(this.grpUpdateClient2);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.grpUpdateMatchingClients);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.grpUpdateClient);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtEnterName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateClient";
            this.Text = "Update Client";
            this.Load += new System.EventHandler(this.frmUpdateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpUpdateClient.ResumeLayout(false);
            this.grpUpdateClient.PerformLayout();
            this.grpUpdateMatchingClients.ResumeLayout(false);
            this.grpUpdateMatchingClients.PerformLayout();
            this.grpUpdateClient2.ResumeLayout(false);
            this.grpUpdateClient2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox grpUpdateClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Button btnMain;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.GroupBox grpUpdateMatchingClients;
        private System.Windows.Forms.TextBox txtMatchingClients2;
        private System.Windows.Forms.TextBox txtMatchingClients1;
        private System.Windows.Forms.RadioButton optMatchingClient2;
        private System.Windows.Forms.RadioButton optMatchingClient1;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.GroupBox grpUpdateClient2;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus2;
        private System.Windows.Forms.TextBox txtClientID2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateClient2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEircode2;
        private System.Windows.Forms.TextBox txtCounty2;
        private System.Windows.Forms.TextBox txtCity2;
        private System.Windows.Forms.TextBox txtTown2;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.TextBox txtSurname2;
        private System.Windows.Forms.TextBox txtContactNo2;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtForename2;
    }
}