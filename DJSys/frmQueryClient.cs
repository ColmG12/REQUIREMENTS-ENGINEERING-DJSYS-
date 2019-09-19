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
    public partial class frmQueryClient : Form
    {
        frmMainMenu parent;
        public frmQueryClient()
        {
            InitializeComponent();
        }

        public frmQueryClient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmQueryClient_Load(object sender, EventArgs e)
        {
            ListViewItem lst4 = new ListViewItem("12/04/19", 0);
            lst4.SubItems.Add("1");
            lst4.SubItems.Add("CLUB");
            lst4.SubItems.Add("€560");

            ListViewItem lst5 = new ListViewItem("22/07/19", 0);
            lst5.SubItems.Add("4");
            lst5.SubItems.Add("WEDD");
            lst5.SubItems.Add("€880");

            lstQueryClient1.Items.Add(lst4);
            lstQueryClient1.Items.Add(lst5);

            ListViewItem lst6 = new ListViewItem("17/03/2019", 0);
            lst6.SubItems.Add("3");
            lst6.SubItems.Add("STPD");
            lst6.SubItems.Add("€1200");

            ListViewItem lst7 = new ListViewItem("27/06/2019", 0);
            lst7.SubItems.Add("2");
            lst7.SubItems.Add("WEDD");
            lst7.SubItems.Add("€800");

            ListViewItem lst8 = new ListViewItem("31/10/2019", 0);
            lst8.SubItems.Add("7");
            lst8.SubItems.Add("HALO");
            lst8.SubItems.Add("€440");

            ListViewItem lst9 = new ListViewItem("24/12/2019", 0);
            lst9.SubItems.Add("9");
            lst9.SubItems.Add("XMAS");
            lst9.SubItems.Add("€1500");

            lstQueryClient2.Items.Add(lst6);
            lstQueryClient2.Items.Add(lst7);
            lstQueryClient2.Items.Add(lst8);
            lstQueryClient2.Items.Add(lst9);

            ListViewItem lst10 = new ListViewItem("02/05/2019", 0);
            lst10.SubItems.Add("8");
            lst10.SubItems.Add("ANVY");
            lst10.SubItems.Add("€350");

            lstQueryClient3.Items.Add(lst10);

            ListViewItem lst11 = new ListViewItem("24/04/2019", 0);
            lst11.SubItems.Add("2");
            lst11.SubItems.Add("BDAY");
            lst11.SubItems.Add("€300");

            ListViewItem lst12 = new ListViewItem("30/09/2019", 0);
            lst12.SubItems.Add("5");
            lst12.SubItems.Add("PBAR");
            lst12.SubItems.Add("€240");

            ListViewItem lst13 = new ListViewItem("31/12/2019", 0);
            lst13.SubItems.Add("1");
            lst13.SubItems.Add("NYEV");
            lst13.SubItems.Add("€1800");

            lstQueryClient4.Items.Add(lst11);
            lstQueryClient4.Items.Add(lst12);
            lstQueryClient4.Items.Add(lst13);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            grpMatchingClients.Visible = true;
        }

        private void optMatchingClient1_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryClient1.Visible = true;

            grpQueryClient2.Visible = false;

            grpQueryClient3.Visible = false;

            grpQueryClient4.Visible = false;
        }

        private void optMatchingClient2_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryClient1.Visible = false;

            grpQueryClient2.Visible = true;

            grpQueryClient3.Visible = false;

            grpQueryClient4.Visible = false;
        }

        private void optMatchingClient3_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryClient1.Visible = false;

            grpQueryClient2.Visible = false;

            grpQueryClient3.Visible = true;

            grpQueryClient4.Visible = false;
        }

        private void optMatchingClient4_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryClient1.Visible = false;

            grpQueryClient2.Visible = false;

            grpQueryClient3.Visible = false;

            grpQueryClient4.Visible = true;
        }

        private void btnQueryActiveBookings1_Click(object sender, EventArgs e)
        {
            grpQueryClientActiveBookings1.Visible = true;

            grpQueryClientActiveBookings2.Visible = false;

            grpQueryClientActiveBookings3.Visible = false;

            grpQueryClientActiveBookings4.Visible = false;
        }

        private void btnQueryActiveBookings2_Click(object sender, EventArgs e)
        {
            grpQueryClientActiveBookings1.Visible = false;

            grpQueryClientActiveBookings2.Visible = true;

            grpQueryClientActiveBookings3.Visible = false;

            grpQueryClientActiveBookings4.Visible = false;
        }

        private void btnQueryActiveBookings3_Click(object sender, EventArgs e)
        {
            grpQueryClientActiveBookings1.Visible = false;

            grpQueryClientActiveBookings2.Visible = false;

            grpQueryClientActiveBookings3.Visible = true;

            grpQueryClientActiveBookings4.Visible = false;
        }

        private void btnQueryActiveBookings4_Click(object sender, EventArgs e)
        {
            grpQueryClientActiveBookings1.Visible = false;

            grpQueryClientActiveBookings2.Visible = false;

            grpQueryClientActiveBookings3.Visible = false;

            grpQueryClientActiveBookings4.Visible = true;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose()
            parent.Show();
            this.Dispose();
        }
    }
}
