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
    public partial class frmAnalyseRevenueByService : Form
    {
        frmMainMenu parent;
        public frmAnalyseRevenueByService()
        {
            InitializeComponent();
        }

        public frmAnalyseRevenueByService(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmAnalyseRevenueByService_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose()
            parent.Show();
            this.Dispose();
        }

        private void optAnalyseByService2017_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(text: "2017 by Service" +
            Environment.NewLine + Environment.NewLine + "Anniversary: €12000" +
            Environment.NewLine + Environment.NewLine + "Bar Mitzvah: €1500" +
            Environment.NewLine + Environment.NewLine + "Birthday: €110000" +
            Environment.NewLine + Environment.NewLine + "Christening: €40000" +
            Environment.NewLine + Environment.NewLine + "Christmas: €16000" +
            Environment.NewLine + Environment.NewLine + "Corporate: €12000" +
            Environment.NewLine + Environment.NewLine + "Halloween: €6000" +
            Environment.NewLine + Environment.NewLine + "New Year's Eve: €8000" +
            Environment.NewLine + Environment.NewLine + "Nightclub: €150000" +
            Environment.NewLine + Environment.NewLine + "Private Function: €15000" +
            Environment.NewLine + Environment.NewLine + "Public House: €40000" +
            Environment.NewLine + Environment.NewLine + "St Patrick's Day: €8000" +
            Environment.NewLine + Environment.NewLine + "Weddingr: €160000");

            MessageBox.Show(text: "Select 'Print graph' to view in graph form");
        }

        private void btnPrintGraphAnalyseByService_Click(object sender, EventArgs e)
        {
            picAnalyseByService.Visible = true;
        }
    }
}
