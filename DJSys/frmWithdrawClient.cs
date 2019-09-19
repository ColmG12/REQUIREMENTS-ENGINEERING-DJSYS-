using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJSys
{
    public partial class frmWithdrawClient : Form
    {
        frmMainMenu parent;
        public frmWithdrawClient()
        {
            InitializeComponent();
        }

        public frmWithdrawClient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmWithdrawClient_Load(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=OAvMTu-LFgs
            ListViewItem lst1 = new ListViewItem("12/4/19", 0);
            lst1.SubItems.Add("1");
            lst1.SubItems.Add("CLUB");
            lst1.SubItems.Add("€560");

            ListViewItem lst2 = new ListViewItem("22/7/19", 0);
            lst2.SubItems.Add("4");
            lst2.SubItems.Add("WEDD");
            lst2.SubItems.Add("€880");

            lstWithdrawClient1.Items.Add(lst1);
            lstWithdrawClient1.Items.Add(lst2);

            ListViewItem lst3 = new ListViewItem("", 0);
            lst1.SubItems.Add("");
            lst1.SubItems.Add("");
            lst1.SubItems.Add("");

            lstWithdrawClient2.Items.Add(lst3);
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose()
            parent.Show();
            this.Dispose();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            grpMatchingClients.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void optMatchingClient1_CheckedChanged(object sender, EventArgs e)
        {
            grpWithdrawClient1.Visible = true;

            grpWithdrawClient2.Visible = false;

            


        }

        private void optMatchingClient2_CheckedChanged(object sender, EventArgs e)
        {
            grpWithdrawClient2.Visible = true;

            grpWithdrawClient1.Visible = false;

            

            
           
        }

        private void grpWithdrawClientActiveBookings1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnWithdrawClientPrintInvoice1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Munster DJs" +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "Dear Mr Gallagher," +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "The amount to be refunded to your account is €1440.  This will be deposited within 28 days." +
                Environment.NewLine + Environment.NewLine +
                "We hope to work with you again soon." +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "Kind regards," +
                Environment.NewLine + Environment.NewLine +
                "Munster DJs");

            btnWithdrawClient1.Visible = true;
        }

        private void btnWithdrawClient1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Client Withdrawn");

            txtStatus.Visible = true;
            

            btnEmail.Visible = true;
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Confirmation email sent to Client");
        }

        private void btnWithdrawClientPrintInvoice2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Munster DJs" +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "Dear Mr Gallagher," +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "As there are no future bookings on your account, your final balance is €0" +
                Environment.NewLine + Environment.NewLine +
                "We hope to work with you again soon." +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "Kind regards," +
                Environment.NewLine + Environment.NewLine +
                "Munster DJs");

            btnWithdrawClient2.Visible = true;
        }

        private void btnWithdrawClient2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Client Withdrawn");

            txtStatus.Visible = true;


            btnEmail.Visible = true;
        }

        private void grpWithdrawClientActiveBookings2_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnActiveBookings2_Click(object sender, EventArgs e)
        {
            grpWithdrawClientActiveBookings2.Visible = true;

            grpWithdrawClientActiveBookings1.Visible = false;
        }

        private void btnActiveBookings1_Click_1(object sender, EventArgs e)
        {
            grpWithdrawClientActiveBookings1.Visible = true;

            grpWithdrawClientActiveBookings2.Visible = false;
        }
    }
}
