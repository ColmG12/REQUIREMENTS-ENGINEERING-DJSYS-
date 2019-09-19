namespace DJSys
{
    partial class frmCancelBooking
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
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnPrintRefundDetails = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(449, 106);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(145, 84);
            this.btnCancelBooking.TabIndex = 11;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnPrintRefundDetails
            // 
            this.btnPrintRefundDetails.Location = new System.Drawing.Point(449, 341);
            this.btnPrintRefundDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintRefundDetails.Name = "btnPrintRefundDetails";
            this.btnPrintRefundDetails.Size = new System.Drawing.Size(145, 84);
            this.btnPrintRefundDetails.TabIndex = 12;
            this.btnPrintRefundDetails.Text = "Print Refund Details";
            this.btnPrintRefundDetails.UseVisualStyleBackColor = true;
            this.btnPrintRefundDetails.Visible = false;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(13, 435);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 106);
            this.btnMain.TabIndex = 37;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnPrintRefundDetails);
            this.Controls.Add(this.btnCancelBooking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCancelBooking";
            this.Text = "Cancel Booking";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnPrintRefundDetails;
        private System.Windows.Forms.Button btnMain;
    }
}