﻿using System;
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
    public partial class frmChangeBooking : Form
    {
        frmMainMenu parent;
        public frmChangeBooking()
        {
            InitializeComponent();
        }

        public frmChangeBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmChangeBooking_Load(object sender, EventArgs e)
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
    }
}
