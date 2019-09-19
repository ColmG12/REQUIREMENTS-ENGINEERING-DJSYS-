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
    public partial class frmQueryService : Form
    {
        frmMainMenu parent;
        public frmQueryService()
        {
            InitializeComponent();
        }

        public frmQueryService(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmQueryService_Load(object sender, EventArgs e)
        {
            ListViewItem lst1 = new ListViewItem("46", 0);
            lst1.SubItems.Add("12/03/19");
            lst1.SubItems.Add("3");
            lst1.SubItems.Add("8");
            lst1.SubItems.Add("€560");

            ListViewItem lst2 = new ListViewItem("312", 0);
            lst2.SubItems.Add("22/07/19");
            lst2.SubItems.Add("4");
            lst2.SubItems.Add("8");
            lst2.SubItems.Add("€880");

            lstQueryService1.Items.Add(lst1);
            lstQueryService1.Items.Add(lst2);

            ListViewItem lst3 = new ListViewItem("53", 0);
            lst3.SubItems.Add("12/03/19");
            lst3.SubItems.Add("1");
            lst3.SubItems.Add("6");
            lst3.SubItems.Add("€560");

            ListViewItem lst4 = new ListViewItem("108", 0);
            lst4.SubItems.Add("22/07/19");
            lst4.SubItems.Add("6");
            lst4.SubItems.Add("4");
            lst4.SubItems.Add("€880");

            lstQueryService2.Items.Add(lst3);
            lstQueryService2.Items.Add(lst4);

            ListViewItem lst5 = new ListViewItem("7", 0);
            lst5.SubItems.Add("12/03/19");
            lst5.SubItems.Add("30");
            lst5.SubItems.Add("8");
            lst5.SubItems.Add("€560");

            ListViewItem lst6 = new ListViewItem("84", 0);
            lst6.SubItems.Add("22/07/19");
            lst6.SubItems.Add("40");
            lst6.SubItems.Add("2");
            lst6.SubItems.Add("€880");

            lstQueryService3.Items.Add(lst5);
            lstQueryService3.Items.Add(lst6);

            ListViewItem lst7 = new ListViewItem("19", 0);
            lst7.SubItems.Add("12/03/19");
            lst7.SubItems.Add("36");
            lst7.SubItems.Add("3");
            lst7.SubItems.Add("€560");

            ListViewItem lst8 = new ListViewItem("129", 0);
            lst8.SubItems.Add("22/07/19");
            lst8.SubItems.Add("44");
            lst8.SubItems.Add("5");
            lst8.SubItems.Add("€880");

            lstQueryService4.Items.Add(lst7);
            lstQueryService4.Items.Add(lst8);

            ListViewItem lst9 = new ListViewItem("64", 0);
            lst9.SubItems.Add("12/03/19");
            lst9.SubItems.Add("67");
            lst9.SubItems.Add("10");
            lst9.SubItems.Add("€560");

            ListViewItem lst10 = new ListViewItem("79", 0);
            lst10.SubItems.Add("22/07/19");
            lst10.SubItems.Add("14");
            lst10.SubItems.Add("7");
            lst10.SubItems.Add("€880");

            lstQueryService5A.Items.Add(lst9);
            lstQueryService5A.Items.Add(lst10);

            ListViewItem lst11 = new ListViewItem("23", 0);
            lst11.SubItems.Add("12/03/19");
            lst11.SubItems.Add("73");
            lst11.SubItems.Add("4");
            lst11.SubItems.Add("€560");

            ListViewItem lst12 = new ListViewItem("154", 0);
            lst12.SubItems.Add("22/07/19");
            lst12.SubItems.Add("4");
            lst12.SubItems.Add("9");
            lst12.SubItems.Add("€880");

            lstQueryService6.Items.Add(lst11);
            lstQueryService6.Items.Add(lst12);

            ListViewItem lst13 = new ListViewItem("16", 0);
            lst13.SubItems.Add("12/03/19");
            lst13.SubItems.Add("23");
            lst13.SubItems.Add("8");
            lst13.SubItems.Add("€560");

            ListViewItem lst14 = new ListViewItem("69", 0);
            lst14.SubItems.Add("22/07/19");
            lst14.SubItems.Add("81");
            lst14.SubItems.Add("11");
            lst14.SubItems.Add("€880");

            lstQueryService7.Items.Add(lst13);
            lstQueryService7.Items.Add(lst14);

            ListViewItem lst15 = new ListViewItem("204", 0);
            lst15.SubItems.Add("12/03/19");
            lst15.SubItems.Add("39");
            lst15.SubItems.Add("1");
            lst15.SubItems.Add("€560");

            ListViewItem lst16 = new ListViewItem("205", 0);
            lst16.SubItems.Add("22/07/19");
            lst16.SubItems.Add("54");
            lst16.SubItems.Add("2");
            lst16.SubItems.Add("€880");

            lstQueryService8A.Items.Add(lst15);
            lstQueryService8A.Items.Add(lst16);

            ListViewItem lst17 = new ListViewItem("35", 0);
            lst17.SubItems.Add("12/03/19");
            lst17.SubItems.Add("27");
            lst17.SubItems.Add("3");
            lst17.SubItems.Add("€560");

            ListViewItem lst18 = new ListViewItem("301", 0);
            lst18.SubItems.Add("22/07/19");
            lst18.SubItems.Add("38");
            lst18.SubItems.Add("4");
            lst18.SubItems.Add("€880");

            lstQueryService9A.Items.Add(lst17);
            lstQueryService9A.Items.Add(lst18);

            ListViewItem lst19 = new ListViewItem("5", 0);
            lst19.SubItems.Add("12/03/19");
            lst19.SubItems.Add("83");
            lst19.SubItems.Add("4");
            lst19.SubItems.Add("€560");

            ListViewItem lst20 = new ListViewItem("114", 0);
            lst20.SubItems.Add("22/07/19");
            lst20.SubItems.Add("4");
            lst20.SubItems.Add("5");
            lst20.SubItems.Add("€880");

            lstQueryService10.Items.Add(lst19);
            lstQueryService10.Items.Add(lst20);

            ListViewItem lst21 = new ListViewItem("26", 0);
            lst21.SubItems.Add("12/03/19");
            lst21.SubItems.Add("13");
            lst21.SubItems.Add("6");
            lst21.SubItems.Add("€560");

            ListViewItem lst22 = new ListViewItem("63", 0);
            lst22.SubItems.Add("22/07/19");
            lst22.SubItems.Add("2");
            lst22.SubItems.Add("7");
            lst22.SubItems.Add("€880");

            lstQueryService11A.Items.Add(lst21);
            lstQueryService11A.Items.Add(lst22);

            ListViewItem lst23 = new ListViewItem("34", 0);
            lst23.SubItems.Add("12/03/19");
            lst23.SubItems.Add("54");
            lst23.SubItems.Add("8");
            lst23.SubItems.Add("€560");

            ListViewItem lst24 = new ListViewItem("254", 0);
            lst24.SubItems.Add("22/07/19");
            lst24.SubItems.Add("105");
            lst24.SubItems.Add("9");
            lst24.SubItems.Add("€880");

            lstQueryService12.Items.Add(lst23);
            lstQueryService12.Items.Add(lst24);

            ListViewItem lst25 = new ListViewItem("6", 0);
            lst25.SubItems.Add("12/03/19");
            lst25.SubItems.Add("33");
            lst25.SubItems.Add("10");
            lst25.SubItems.Add("€560");

            ListViewItem lst26 = new ListViewItem("12", 0);
            lst26.SubItems.Add("22/07/19");
            lst26.SubItems.Add("44");
            lst26.SubItems.Add("11");
            lst26.SubItems.Add("€880");

            lstQueryService13A.Items.Add(lst25);
            lstQueryService13A.Items.Add(lst26);

            ListViewItem lst27 = new ListViewItem("28", 0);
            lst27.SubItems.Add("12/03/19");
            lst27.SubItems.Add("113");
            lst27.SubItems.Add("1");
            lst27.SubItems.Add("€560");

            ListViewItem lst28 = new ListViewItem("100", 0);
            lst28.SubItems.Add("22/07/19");
            lst28.SubItems.Add("96");
            lst28.SubItems.Add("2");
            lst28.SubItems.Add("€880");

            lstQueryService14A.Items.Add(lst27);
            lstQueryService14A.Items.Add(lst28);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void optQueryMatchingService1_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = true;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService2_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = true;
        }

        private void optQueryMatchingService3_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = true;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService4_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = true;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService5_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = true;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService6_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = true;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService7_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = true;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService8_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = true;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService9_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = true;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService10_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = true;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService11_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = true;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService12_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = true;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService13_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = true;

            grpQueryService14.Visible = false;

            grpQueryService15.Visible = false;
        }

        private void optQueryMatchingService14_CheckedChanged(object sender, EventArgs e)
        {
            grpQueryService1.Visible = false;

            grpQueryService3.Visible = false;

            grpQueryService4.Visible = false;

            grpQueryService5.Visible = false;

            grpQueryService6.Visible = false;

            grpQueryService7.Visible = false;

            grpQueryService8.Visible = false;

            grpQueryService9.Visible = false;

            grpQueryService10.Visible = false;

            grpQueryService11.Visible = false;

            grpQueryService12.Visible = false;

            grpQueryService13.Visible = false;

            grpQueryService14.Visible = true;

            grpQueryService15.Visible = false;
        }

        private void btnQueryService11_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = true;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService10_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = true;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService8_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = true;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService14_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = true;
        }

        private void btnQueryService12_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = true;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService15_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = true;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService13_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = true;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService1_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = true;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService5_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = true;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService6_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = true;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService7_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = true;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService3_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = true;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnQueryService4_Click(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = true;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = false;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose();
            this.Close();
            parent.Visible = true;
        }

        private void btnQueryService9_Click_1(object sender, EventArgs e)
        {
            grpQueryServiceActiveBookings1.Visible = false;

            grpQueryServiceActiveBookings2.Visible = false;

            grpQueryServiceActiveBookings3.Visible = false;

            grpQueryServiceActiveBookings4.Visible = false;

            grpQueryServiceActiveBookings5A.Visible = false;

            grpQueryServiceActiveBookings6.Visible = false;

            grpQueryServiceActiveBookings7.Visible = false;

            grpQueryServiceActiveBookings8A.Visible = false;

            grpQueryServiceActiveBookings9A.Visible = true;

            grpQueryServiceActiveBookings10.Visible = false;

            grpQueryServiceActiveBookings11A.Visible = false;

            grpQueryServiceActiveBookings12.Visible = false;

            grpQueryServiceActiveBookings13A.Visible = false;

            grpQueryServiceActiveBookings14A.Visible = false;
        }
    }
}
