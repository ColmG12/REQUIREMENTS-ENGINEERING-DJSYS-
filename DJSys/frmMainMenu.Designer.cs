namespace DJSys
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picColmGBusinessCard = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWithdrawClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueryClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueryService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDJs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddDJ = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWithdrawDJ = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowDJSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseRevenueByYear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseRevenueByService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picColmGBusinessCard)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // picColmGBusinessCard
            // 
            this.picColmGBusinessCard.Image = ((System.Drawing.Image)(resources.GetObject("picColmGBusinessCard.Image")));
            this.picColmGBusinessCard.Location = new System.Drawing.Point(0, 33);
            this.picColmGBusinessCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picColmGBusinessCard.Name = "picColmGBusinessCard";
            this.picColmGBusinessCard.Size = new System.Drawing.Size(1051, 523);
            this.picColmGBusinessCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picColmGBusinessCard.TabIndex = 0;
            this.picColmGBusinessCard.TabStop = false;
            this.picColmGBusinessCard.Click += new System.EventHandler(this.picColmGBusinessCard_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClient,
            this.mnuServices,
            this.mnuDJs,
            this.mnuBookings,
            this.mnuAdmin,
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1067, 28);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // mnuClient
            // 
            this.mnuClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddClient,
            this.mnuUpdateClient,
            this.mnuWithdrawClient,
            this.mnuQueryClient});
            this.mnuClient.Name = "mnuClient";
            this.mnuClient.Size = new System.Drawing.Size(59, 24);
            this.mnuClient.Text = "Client";
            // 
            // mnuAddClient
            // 
            this.mnuAddClient.Name = "mnuAddClient";
            this.mnuAddClient.Size = new System.Drawing.Size(190, 26);
            this.mnuAddClient.Text = "Add Client";
            this.mnuAddClient.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // mnuUpdateClient
            // 
            this.mnuUpdateClient.Name = "mnuUpdateClient";
            this.mnuUpdateClient.Size = new System.Drawing.Size(190, 26);
            this.mnuUpdateClient.Text = "Update Client";
            this.mnuUpdateClient.Click += new System.EventHandler(this.mnuUpdateClient_Click);
            // 
            // mnuWithdrawClient
            // 
            this.mnuWithdrawClient.Name = "mnuWithdrawClient";
            this.mnuWithdrawClient.Size = new System.Drawing.Size(190, 26);
            this.mnuWithdrawClient.Text = "Withdraw Client";
            this.mnuWithdrawClient.Click += new System.EventHandler(this.mnuWithdrawClient_Click);
            // 
            // mnuQueryClient
            // 
            this.mnuQueryClient.Name = "mnuQueryClient";
            this.mnuQueryClient.Size = new System.Drawing.Size(190, 26);
            this.mnuQueryClient.Text = "Query Client";
            this.mnuQueryClient.Click += new System.EventHandler(this.mnuQueryClient_Click);
            // 
            // mnuServices
            // 
            this.mnuServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogService,
            this.mnuUpdateService,
            this.mnuQueryService});
            this.mnuServices.Name = "mnuServices";
            this.mnuServices.Size = new System.Drawing.Size(74, 24);
            this.mnuServices.Text = "Services";
            // 
            // mnuLogService
            // 
            this.mnuLogService.Name = "mnuLogService";
            this.mnuLogService.Size = new System.Drawing.Size(184, 26);
            this.mnuLogService.Text = "Log Service";
            this.mnuLogService.Click += new System.EventHandler(this.mnuLogService_Click);
            // 
            // mnuUpdateService
            // 
            this.mnuUpdateService.Name = "mnuUpdateService";
            this.mnuUpdateService.Size = new System.Drawing.Size(184, 26);
            this.mnuUpdateService.Text = "Update Service";
            this.mnuUpdateService.Click += new System.EventHandler(this.mnuUpdateService_Click);
            // 
            // mnuQueryService
            // 
            this.mnuQueryService.Name = "mnuQueryService";
            this.mnuQueryService.Size = new System.Drawing.Size(184, 26);
            this.mnuQueryService.Text = "Query Service";
            this.mnuQueryService.Click += new System.EventHandler(this.mnuQueryService_Click);
            // 
            // mnuDJs
            // 
            this.mnuDJs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddDJ,
            this.mnuWithdrawDJ,
            this.mnuShowDJSchedule});
            this.mnuDJs.Name = "mnuDJs";
            this.mnuDJs.Size = new System.Drawing.Size(43, 24);
            this.mnuDJs.Text = "DJs";
            // 
            // mnuAddDJ
            // 
            this.mnuAddDJ.Name = "mnuAddDJ";
            this.mnuAddDJ.Size = new System.Drawing.Size(204, 26);
            this.mnuAddDJ.Text = "Add DJ";
            this.mnuAddDJ.Click += new System.EventHandler(this.mnuAddDJ_Click);
            // 
            // mnuWithdrawDJ
            // 
            this.mnuWithdrawDJ.Name = "mnuWithdrawDJ";
            this.mnuWithdrawDJ.Size = new System.Drawing.Size(204, 26);
            this.mnuWithdrawDJ.Text = "Withdraw DJ";
            this.mnuWithdrawDJ.Click += new System.EventHandler(this.mnuWithdrawDJ_Click);
            // 
            // mnuShowDJSchedule
            // 
            this.mnuShowDJSchedule.Name = "mnuShowDJSchedule";
            this.mnuShowDJSchedule.Size = new System.Drawing.Size(204, 26);
            this.mnuShowDJSchedule.Text = "Show DJ Schedule";
            this.mnuShowDJSchedule.Click += new System.EventHandler(this.mnuShowDJSchedule_Click);
            // 
            // mnuBookings
            // 
            this.mnuBookings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeBooking,
            this.mnuCancelBooking,
            this.mnuChangeBooking});
            this.mnuBookings.Name = "mnuBookings";
            this.mnuBookings.Size = new System.Drawing.Size(82, 24);
            this.mnuBookings.Text = "Bookings";
            // 
            // mnuMakeBooking
            // 
            this.mnuMakeBooking.Name = "mnuMakeBooking";
            this.mnuMakeBooking.Size = new System.Drawing.Size(193, 26);
            this.mnuMakeBooking.Text = "Make Booking";
            this.mnuMakeBooking.Click += new System.EventHandler(this.mnuMakeBooking_Click);
            // 
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Size = new System.Drawing.Size(193, 26);
            this.mnuCancelBooking.Text = "Cancel Booking";
            this.mnuCancelBooking.Click += new System.EventHandler(this.mnuCancelBooking_Click);
            // 
            // mnuChangeBooking
            // 
            this.mnuChangeBooking.Name = "mnuChangeBooking";
            this.mnuChangeBooking.Size = new System.Drawing.Size(193, 26);
            this.mnuChangeBooking.Text = "Change Booking";
            this.mnuChangeBooking.Click += new System.EventHandler(this.mnuChangeBooking_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnalyseRevenueByYear,
            this.mnuAnalyseRevenueByService});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(65, 24);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuAnalyseRevenueByYear
            // 
            this.mnuAnalyseRevenueByYear.Name = "mnuAnalyseRevenueByYear";
            this.mnuAnalyseRevenueByYear.Size = new System.Drawing.Size(266, 26);
            this.mnuAnalyseRevenueByYear.Text = "Analyse Revenue by Year";
            this.mnuAnalyseRevenueByYear.Click += new System.EventHandler(this.mnuAnalyseRevenueByMonth_Click);
            // 
            // mnuAnalyseRevenueByService
            // 
            this.mnuAnalyseRevenueByService.Name = "mnuAnalyseRevenueByService";
            this.mnuAnalyseRevenueByService.Size = new System.Drawing.Size(266, 26);
            this.mnuAnalyseRevenueByService.Text = "Analyse Revenue by Service";
            this.mnuAnalyseRevenueByService.Click += new System.EventHandler(this.mnuAnalyseRevenueByService_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(45, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.picColmGBusinessCard);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainMenu";
            this.Text = "DJSys - MainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picColmGBusinessCard)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picColmGBusinessCard;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem mnuAddClient;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem mnuWithdrawClient;
        private System.Windows.Forms.ToolStripMenuItem mnuQueryClient;
        private System.Windows.Forms.ToolStripMenuItem mnuServices;
        private System.Windows.Forms.ToolStripMenuItem mnuLogService;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateService;
        private System.Windows.Forms.ToolStripMenuItem mnuQueryService;
        private System.Windows.Forms.ToolStripMenuItem mnuDJs;
        private System.Windows.Forms.ToolStripMenuItem mnuBookings;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuAddDJ;
        private System.Windows.Forms.ToolStripMenuItem mnuWithdrawDJ;
        private System.Windows.Forms.ToolStripMenuItem mnuShowDJSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseRevenueByYear;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseRevenueByService;
    }
}

