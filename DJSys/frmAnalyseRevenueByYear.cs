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
    public partial class frmAnalyseRevenueByYear : Form
    {
        frmMainMenu parent;
        public frmAnalyseRevenueByYear()
        {
            InitializeComponent();
        }

        public frmAnalyseRevenueByYear(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPrintGraphAnalyseByYear.Visible = true;
        }

        private void frmAnalyseRevenueByMonth_Load(object sender, EventArgs e)
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

        private void txtAnalyseByYear2017_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void optAnalyseByYear2017_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(text: "2017 by month" +
            Environment.NewLine + Environment.NewLine + "January: €20000" + 
            Environment.NewLine + Environment.NewLine + "February: €30000" + 
            Environment.NewLine + Environment.NewLine + "March: €60000" + 
            Environment.NewLine + Environment.NewLine + "April: €40000" +
            Environment.NewLine + Environment.NewLine + "May: €45000" + 
            Environment.NewLine + Environment.NewLine + "June: €50000" + 
            Environment.NewLine + Environment.NewLine + "July: €55000" + 
            Environment.NewLine + Environment.NewLine + "August: €65000" + 
            Environment.NewLine + Environment.NewLine + "September: €45000" + 
            Environment.NewLine + Environment.NewLine + "October: €50000" + 
            Environment.NewLine + Environment.NewLine + "November: €40000" + 
            Environment.NewLine + Environment.NewLine + "December: €90000");

            MessageBox.Show(text: "Select 'Print graph' to view in graph form");
        }

        private void btnPrintGraph_Click(object sender, EventArgs e)
        {
            picAnalyseByYear.Visible = true;
        }
    }
}
