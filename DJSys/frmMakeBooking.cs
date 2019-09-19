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
    public partial class frmMakeBooking : Form
    {
        frmMainMenu parent;
        public frmMakeBooking()
        {
            InitializeComponent();
        }

        public frmMakeBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            grpMakeBooking.Visible = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            btnMakeBooking.Visible = true;
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
    }
}
