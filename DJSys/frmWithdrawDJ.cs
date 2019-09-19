using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJSys
{
    public partial class frmWithdrawDJ : Form
    {
        frmMainMenu parent;
        public frmWithdrawDJ()
        {
            InitializeComponent();
        }

        public frmWithdrawDJ(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmWithdrawDJ_Load(object sender, EventArgs e)
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

            lstWithdrawDJ1.Items.Add(lst1);
            lstWithdrawDJ1.Items.Add(lst2);

            ListViewItem lst3 = new ListViewItem("", 0);
            lst1.SubItems.Add("");
            lst1.SubItems.Add("");
            lst1.SubItems.Add("");

            lstWithdrawDJ3.Items.Add(lst3);
        }

        private void btnFindDJ_Click(object sender, EventArgs e)
        {
            grpMatchingDJs.Visible = true;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose()
            parent.Show();
            this.Dispose();
        }

        private void txtDJEmail1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDJEircode1_TextChanged(object sender, EventArgs e)
        {

        }

        private void optMatchingDJ1_CheckedChanged(object sender, EventArgs e)
        {
            grpWithdrawDJ1.Visible = true;

            grpWithdrawDJ2.Visible = false;
        }

        private void optMatchingDJ2_CheckedChanged(object sender, EventArgs e)
        {
            grpWithdrawDJ1.Visible = false;

            grpWithdrawDJ2.Visible = true;
        }

        private void btnWithdrawDJPrintBookings1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Munster DJs" +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "Dear Gerry," +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "Please find below, a list of remaining bookings to be fulfilled before we can confirm your withdrawal." +
                Environment.NewLine + Environment.NewLine +
                "Thanks for the great service you have given the company to date. We hope to work with you again someday." +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "Kind regards," +
                Environment.NewLine + Environment.NewLine +
                "Munster DJs");

            txtDJStatus1.Visible = true;

            btnWithdrawDJ1.Visible = false;

            btnDJEmail.Visible = true;
        }

        private void btnDJEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Confirmation email sent to DJ");
        }

        private void btnFindDJ_Click_1(object sender, EventArgs e)
        {
            grpMatchingDJs.Visible = true;
        }

        private void btnDJActiveBookings1_Click(object sender, EventArgs e)
        {
            grpWithdrawDJActiveBookings1.Visible = true;

            grpWithdrawDJActiveBookings3.Visible = false;
        }

        private void grpWithdrawDJActiveBookings1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDJActiveBookings2_Click(object sender, EventArgs e)
        {
            grpWithdrawDJActiveBookings1.Visible = false;

            grpWithdrawDJActiveBookings3.Visible = true;
        }

        private void btnWithdrawDJPrintBookings3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Munster DJs" +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "Dear Michael," +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "As you have no bookings remaining to be fulfilled with the company, we can confirm your withdrawal." +
                Environment.NewLine + Environment.NewLine +
                "Thanks for the great service you have given the company to date. We hope to work with you again someday." +
                Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "Kind regards," +
                Environment.NewLine + Environment.NewLine +
                "Munster DJs");

            btnWithdrawDJ3.Visible = true;
            
        }

        private void btnWithdrawDJ3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "DJ Withdrawn");

            txtDJStatus2.Visible = true;

            btnDJEmail.Visible = true;
        }

        private void btnDJEmail_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Confirmation email sent to DJ");
        }
    }
}
