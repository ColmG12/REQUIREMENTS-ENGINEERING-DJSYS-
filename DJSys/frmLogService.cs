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
    public partial class frmLogService : Form
    {
        frmMainMenu parent;
        public frmLogService()
        {
            InitializeComponent();
        }

        public frmLogService(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void grpLogService_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogService_Load(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose();
            this.Close();
            parent.Visible = true;
        }

        private void nudBaseRate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLogService_Click(object sender, EventArgs e)
        {
            String ServiceID = txtServiceID.Text;

            String Description = txtDescription.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudBaseRate.Value;

            if (!ValidateServiceID())
            {
                return;
            }

            if (!ValidateDescription())
            {
                return;
            }

           

            txtServiceID.Clear();
            txtDescription.Clear();
            nudBaseRate.Value = 0;

            txtServiceStatus.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);
            
            MessageBox.Show(text: "Service Registered");

            txtServiceStatus.Clear();

        }

        private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateServiceID();
        }

        private bool ValidateServiceID()
        {

            if (String.IsNullOrEmpty(txtServiceID.Text))
            {
                MessageBox.Show(this.txtServiceID.Text, "I am sorry but the Service ID field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceID.Focus();
                return false;
            }

            if (txtServiceID.Text.Contains(" "))
            {
                MessageBox.Show(this.txtServiceID.Text, "I am sorry but the Service ID field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceID.Focus();
                return false;
            }

            if (txtServiceID.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtServiceID.Text, "I am sorry, but the Service ID field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceID.Focus();
                return false;
            }

            return true;
        }

        private void DescriptionTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateDescription();
        }

        private bool ValidateDescription()
        {

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show(this.txtDescription.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return false;
            }

            if (txtDescription.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtDescription.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return false;
            }

            return true;
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose();
            this.Close();
            parent.Visible = true;
        }
    }
    
}
