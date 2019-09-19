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
    public partial class frmShowDJSchedule : Form
    {
        frmMainMenu parent;
        public frmShowDJSchedule()
        {
            InitializeComponent();
        }

        public frmShowDJSchedule(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmShowDJSchedule_Load(object sender, EventArgs e)
        {
            ListViewItem lst1 = new ListViewItem("1", 0);
            lst1.SubItems.Add("Gerry");
            lst1.SubItems.Add("Byrne");
            lst1.SubItems.Add("03/09/1949");
            lst1.SubItems.Add("0875481394");
            lst1.SubItems.Add("byrnegerry49@gmail.com");
            lst1.SubItems.Add("14 The Mansions");
            lst1.SubItems.Add("Killarney");
            lst1.SubItems.Add("Kerry");
            lst1.SubItems.Add("Kerry");
            lst1.SubItems.Add("V31D836");
            lst1.SubItems.Add("€30");
            lst1.SubItems.Add("Active");

            ListViewItem lst2 = new ListViewItem("2", 0);
            lst2.SubItems.Add("Paul");
            lst2.SubItems.Add("Clay");
            lst2.SubItems.Add("18/01/1967");
            lst2.SubItems.Add("0861558742");
            lst2.SubItems.Add("djclay67@gmail.comm");
            lst2.SubItems.Add("28 Blanchard Street");
            lst2.SubItems.Add("Foynes");
            lst2.SubItems.Add("Limerick");
            lst2.SubItems.Add("Limerick");
            lst2.SubItems.Add("G39H027");
            lst2.SubItems.Add("€30");
            lst2.SubItems.Add("Active");

            ListViewItem lst3 = new ListViewItem("3", 0);
            lst3.SubItems.Add("Pat");
            lst3.SubItems.Add("Divley");
            lst3.SubItems.Add("15/07/1968");
            lst3.SubItems.Add("0866281298");
            lst3.SubItems.Add("divleypatdj@gmail.com");
            lst3.SubItems.Add("97 Sails Lane");
            lst3.SubItems.Add("Dingle");
            lst3.SubItems.Add("Kerry");
            lst3.SubItems.Add("Kerry");
            lst3.SubItems.Add("V43S348");
            lst3.SubItems.Add("€30");
            lst3.SubItems.Add("Active");

            ListViewItem lst4 = new ListViewItem("4", 0);
            lst4.SubItems.Add("Colm");
            lst4.SubItems.Add("Gallagher");
            lst4.SubItems.Add("12/10/1979");
            lst4.SubItems.Add("0871706203");
            lst4.SubItems.Add("colmg12@hotmail.com");
            lst4.SubItems.Add("Renagown Cross");
            lst4.SubItems.Add("Knocknagoshel");
            lst4.SubItems.Add("Kerry");
            lst4.SubItems.Add("Kerry");
            lst4.SubItems.Add("K39H397");
            lst4.SubItems.Add("€40");
            lst4.SubItems.Add("Active");

            ListViewItem lst5 = new ListViewItem("5", 0);
            lst5.SubItems.Add("Padraic");
            lst5.SubItems.Add("Higgins");
            lst5.SubItems.Add("09/02/1972");
            lst5.SubItems.Add("0863792704");
            lst5.SubItems.Add("Higginspadraic72@hotmail.com");
            lst5.SubItems.Add("8 Church Lawn");
            lst5.SubItems.Add("Blennerville");
            lst5.SubItems.Add("Kerry");
            lst5.SubItems.Add("Kerry");
            lst5.SubItems.Add("V92X3PP");
            lst5.SubItems.Add("€40");
            lst5.SubItems.Add("Active");

            ListViewItem lst6 = new ListViewItem("6", 0);
            lst6.SubItems.Add("Mark");
            lst6.SubItems.Add("Jones");
            lst6.SubItems.Add("21/09/1992");
            lst6.SubItems.Add("0871463892");
            lst6.SubItems.Add("markjonesdj@gmail.com");
            lst6.SubItems.Add("6 Tralee Road");
            lst6.SubItems.Add("Castleisland");
            lst6.SubItems.Add("Kerry");
            lst6.SubItems.Add("Kerry");
            lst6.SubItems.Add("V92EK74");
            lst6.SubItems.Add("€35");
            lst6.SubItems.Add("Active");

            ListViewItem lst7 = new ListViewItem("8", 0);
            lst7.SubItems.Add("Mike");
            lst7.SubItems.Add("Kelliher");
            lst7.SubItems.Add("9/03/1974");
            lst7.SubItems.Add("0851694283");
            lst7.SubItems.Add("djfatz@gmail.com");
            lst7.SubItems.Add("10 Feale Drive");
            lst7.SubItems.Add("Listowel");
            lst7.SubItems.Add("Kerry");
            lst7.SubItems.Add("Kerry");
            lst7.SubItems.Add("V38F274");
            lst7.SubItems.Add("€20");
            lst7.SubItems.Add("Active");

            ListViewItem lst8 = new ListViewItem("7", 0);
            lst8.SubItems.Add("Phil");
            lst8.SubItems.Add("O’Neill");
            lst8.SubItems.Add("02/08/1965");
            lst8.SubItems.Add("0864629897");
            lst8.SubItems.Add("phylio@hotmail.com");
            lst8.SubItems.Add("18 Lansdowne Road");
            lst8.SubItems.Add("Abbeyfeale");
            lst8.SubItems.Add("Limerick");
            lst8.SubItems.Add("Limerick");
            lst8.SubItems.Add("V93M384");
            lst8.SubItems.Add("€25");
            lst8.SubItems.Add("Active");

            ListViewItem lst9 = new ListViewItem("9", 0);
            lst9.SubItems.Add("Paul");
            lst9.SubItems.Add("Pendall");
            lst9.SubItems.Add("2/08/1965");
            lst9.SubItems.Add("0873647291");
            lst9.SubItems.Add("djpaulpendall@hotmail.com");
            lst9.SubItems.Add("94 Muswell Avenue");
            lst9.SubItems.Add("Tarbert");
            lst9.SubItems.Add("Kerry");
            lst9.SubItems.Add("Kerry");
            lst9.SubItems.Add("V27D278");
            lst9.SubItems.Add("€25");
            lst9.SubItems.Add("Active");

            ListViewItem lst10 = new ListViewItem("10", 0);
            lst10.SubItems.Add("Sammy");
            lst10.SubItems.Add("Porter");
            lst10.SubItems.Add("23/12/1993");
            lst10.SubItems.Add("0877293618");
            lst10.SubItems.Add("Sammyp93@gmail.com");
            lst10.SubItems.Add("3 The Gardenss");
            lst10.SubItems.Add("Knocknagree");
            lst10.SubItems.Add("Cork");
            lst10.SubItems.Add("Cork");
            lst10.SubItems.Add("L37S389");
            lst10.SubItems.Add("€35");
            lst10.SubItems.Add("Active");

            ListViewItem lst11 = new ListViewItem("11", 0);
            lst11.SubItems.Add("Mike");
            lst11.SubItems.Add("O’Neill");
            lst11.SubItems.Add("14/06/1983");
            lst11.SubItems.Add("0876951726");
            lst11.SubItems.Add("djmikeoneill@gmail.com");
            lst11.SubItems.Add("58 Ladywell");
            lst11.SubItems.Add("Ennis");
            lst11.SubItems.Add("Clare");
            lst11.SubItems.Add("Clare");
            lst11.SubItems.Add("C93J237");
            lst11.SubItems.Add("€20");
            lst11.SubItems.Add("Active");

            lstQueryDJSchedule.Items.Add(lst1);
            lstQueryDJSchedule.Items.Add(lst2);
            lstQueryDJSchedule.Items.Add(lst3);
            lstQueryDJSchedule.Items.Add(lst4);
            lstQueryDJSchedule.Items.Add(lst5);
            lstQueryDJSchedule.Items.Add(lst6);
            lstQueryDJSchedule.Items.Add(lst7);
            lstQueryDJSchedule.Items.Add(lst8);
            lstQueryDJSchedule.Items.Add(lst9);
            lstQueryDJSchedule.Items.Add(lst10);
            lstQueryDJSchedule.Items.Add(lst11);

            ListViewItem lst12 = new ListViewItem("11", 0);
            lst12.SubItems.Add("Mike");
            lst12.SubItems.Add("O’Neill");
            lst12.SubItems.Add("14/06/1983");
            lst12.SubItems.Add("0876951726");
            lst12.SubItems.Add("djmikeoneill@gmail.com");
            lst12.SubItems.Add("58 Ladywell");
            lst12.SubItems.Add("Ennis");
            lst12.SubItems.Add("Clare");
            lst12.SubItems.Add("Clare");
            lst12.SubItems.Add("C93J237");
            lst12.SubItems.Add("€20");
            lst12.SubItems.Add("Active");

            lstSelectedDJ1.Items.Add(lst12);

            ListViewItem lst13 = new ListViewItem("7", 0);
            lst13.SubItems.Add("Phil");
            lst13.SubItems.Add("O’Neill");
            lst13.SubItems.Add("02/08/1965");
            lst13.SubItems.Add("0864629897");
            lst13.SubItems.Add("phylio@hotmail.com");
            lst13.SubItems.Add("18 Lansdowne Road");
            lst13.SubItems.Add("Abbeyfeale");
            lst13.SubItems.Add("Limerick");
            lst13.SubItems.Add("Limerick");
            lst13.SubItems.Add("V93M384");
            lst13.SubItems.Add("€25");
            lst13.SubItems.Add("Active");

            lstSelectedDJ2.Items.Add(lst13);

            ListViewItem lst14 = new ListViewItem("11", 0);
            lst14.SubItems.Add("Mike");
            lst14.SubItems.Add("O’Neill");
            lst14.SubItems.Add("26");
            lst14.SubItems.Add("14/07/2019");
            lst14.SubItems.Add("19.00");
            lst14.SubItems.Add("23.00");
            lst14.SubItems.Add("4");
            lst14.SubItems.Add("Killarney Grand Hotel, Main Street, Killarney, Co. Kerry");
            lst14.SubItems.Add("D01CX89");
            lst14.SubItems.Add("24");
            lst14.SubItems.Add("CLUB");
            lst14.SubItems.Add("€20");
            lst14.SubItems.Add("€680");

            lstQueryDJActiveBookings1.Items.Add(lst14);

            ListViewItem lst15 = new ListViewItem("8", 0);
            lst15.SubItems.Add("Phil");
            lst15.SubItems.Add("O’Neill");
            lst15.SubItems.Add("167");
            lst15.SubItems.Add("17/03/2019");
            lst15.SubItems.Add("20.00");
            lst15.SubItems.Add("01.00");
            lst15.SubItems.Add("5");
            lst15.SubItems.Add("Killarney Grand Hotel, Main Street, Killarney, Co. Kerry");
            lst15.SubItems.Add("D01CX89");
            lst15.SubItems.Add("24");
            lst15.SubItems.Add("STPD");
            lst15.SubItems.Add("€25");
            lst15.SubItems.Add("€725");

            ListViewItem lst16 = new ListViewItem("8", 0);
            lst16.SubItems.Add("Phil");
            lst16.SubItems.Add("O’Neill");
            lst16.SubItems.Add("217");
            lst16.SubItems.Add("14/06/2019");
            lst16.SubItems.Add("22.00");
            lst16.SubItems.Add("02.00");
            lst16.SubItems.Add("4");
            lst16.SubItems.Add("The Mermaids Nightclub,William St, Listowel, Co. Kerry");
            lst16.SubItems.Add("A65F4E2");
            lst16.SubItems.Add("57");
            lst16.SubItems.Add("CLUB");
            lst16.SubItems.Add("€25");
            lst16.SubItems.Add("€460");

            ListViewItem lst17 = new ListViewItem("8", 0);
            lst17.SubItems.Add("Phil");
            lst17.SubItems.Add("O’Neill");
            lst17.SubItems.Add("269");
            lst17.SubItems.Add("06/07/2019");
            lst17.SubItems.Add("21.00");
            lst17.SubItems.Add("01.00");
            lst17.SubItems.Add("4");
            lst17.SubItems.Add("Listowel Arms, The Square, Listowel, Co.Kerry");
            lst17.SubItems.Add("D08W4C6");
            lst17.SubItems.Add("2");
            lst17.SubItems.Add("WEDD");
            lst17.SubItems.Add("€25");
            lst17.SubItems.Add("€640");

            ListViewItem lst18 = new ListViewItem("8", 0);
            lst18.SubItems.Add("Phil");
            lst18.SubItems.Add("O’Neill");
            lst18.SubItems.Add("368");
            lst18.SubItems.Add("30/10/2019");
            lst18.SubItems.Add("22.00");
            lst18.SubItems.Add("01.00");
            lst18.SubItems.Add("3");
            lst18.SubItems.Add("Sheehans Bar, Church View, Park, Knocknagree, Co. Cork");
            lst18.SubItems.Add("D04P9C4");
            lst18.SubItems.Add("86");
            lst18.SubItems.Add("HALO");
            lst18.SubItems.Add("€25");
            lst18.SubItems.Add("€375");

            lstQueryDJActiveBookings4.Items.Add(lst15);
            lstQueryDJActiveBookings4.Items.Add(lst16);
            lstQueryDJActiveBookings4.Items.Add(lst17);
            lstQueryDJActiveBookings4.Items.Add(lst18);
        }

        private void btnMainDJSchedule_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose()
            parent.Show();
            this.Dispose();
        }

        private void optMatchingDJSchedule1_CheckedChanged(object sender, EventArgs e)
        {
            grpSelectedDJ1.Visible = true;

            grpSelectedDJ2.Visible = false;

            grpQueryDJActiveBookings4.Visible = false;
        }

        private void optMatchingDJSchedule2_CheckedChanged(object sender, EventArgs e)
        {
            grpSelectedDJ1.Visible = false;

            grpSelectedDJ2.Visible = true;

            grpQueryDJActiveBookings1.Visible = false;
        }

        private void btnFindDJ_Click(object sender, EventArgs e)
        {
            grpMatchingDJsSchedule.Visible = true;
        }

        private void btnQueryDJActiveBookings1_Click(object sender, EventArgs e)
        {
            grpQueryDJActiveBookings1.Visible = true;

            grpQueryDJActiveBookings4.Visible = false;
        }

        private void btnQueryDJActiveBookings2_Click(object sender, EventArgs e)
        {
            grpQueryDJActiveBookings1.Visible = false;

            grpQueryDJActiveBookings4.Visible = true;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpQueryDJActiveBookings4_Enter(object sender, EventArgs e)
        {

        }
    }
}
