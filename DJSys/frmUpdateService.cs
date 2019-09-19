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
    public partial class frmUpdateService : Form
    {
        frmMainMenu parent;
        public frmUpdateService()
        {
            InitializeComponent();
        }

        public frmUpdateService(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmUpdateService_Load(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose();
            this.Close();
            parent.Visible = true;
        }

        private void optMatchingService1_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = true;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;
        
            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService2_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = true;
        }

        private void optMatchingService3_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = true;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService4_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = true;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService5_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = true;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService6_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = true;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService7_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = true;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService8_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = true;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService9_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = true;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService10_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = true;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService11_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = true;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService12_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = true;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService13_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = true;

            grpUpdateService14.Visible = false;

            grpUpdateService15.Visible = false;
        }

        private void optMatchingService14_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateService1.Visible = false;

            grpUpdateService2.Visible = false;

            grpUpdateService3.Visible = false;

            grpUpdateService4.Visible = false;

            grpUpdateService5.Visible = false;

            grpUpdateService6.Visible = false;

            grpUpdateService7.Visible = false;

            grpUpdateService8.Visible = false;

            grpUpdateService9.Visible = false;

            grpUpdateService10.Visible = false;

            grpUpdateService11.Visible = false;

            grpUpdateService12.Visible = false;

            grpUpdateService13.Visible = false;

            grpUpdateService14.Visible = true;

            grpUpdateService15.Visible = false;
        }

        private void btnUpdateService1_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID1.Text;

            String Description = txtUpdateDescription1.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate1.Value;

            if (!ValidateUpdateDescription1())
            {
                return;
            }



            nudUpdateBaseRate1.Value = 0;

            txtUpdateServiceStatus1.Visible = true;
            txtUpdateServiceID1.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus1.Clear();
            txtUpdateDescription1.Clear();
            txtUpdateServiceID1.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription1TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription1();
        }

        private bool ValidateUpdateDescription1()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription1.Text))
            {
                MessageBox.Show(this.txtUpdateDescription1.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription1.Focus();
                return false;
            }

            if (txtUpdateDescription1.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription1.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription1.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService2_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID2.Text;

            String Description = txtUpdateDescription2.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate2.Value;

            if (!ValidateUpdateDescription2())
            {
                return;
            }



            
            nudUpdateBaseRate2.Value = 0;

            txtUpdateServiceStatus2.Visible = true;
            txtUpdateServiceID2.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus2.Clear();
            txtUpdateDescription2.Clear();
            txtUpdateServiceID2.Clear();

        }

        private void UpdateDescription2TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription2();
        }

        private bool ValidateUpdateDescription2()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription2.Text))
            {
                MessageBox.Show(this.txtUpdateDescription2.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription2.Focus();
                return false;
            }

            if (txtUpdateDescription2.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription2.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription2.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService3_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID3.Text;

            String Description = txtUpdateDescription3.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate3.Value;

            if (!ValidateUpdateDescription3())
            {
                return;
            }



            
            nudUpdateBaseRate3.Value = 0;

            txtUpdateServiceStatus3.Visible = true;
            txtUpdateServiceID3.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus3.Clear();
            txtUpdateDescription3.Clear();
            txtUpdateServiceID3.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription3TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription3();
        }

        private bool ValidateUpdateDescription3()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription3.Text))
            {
                MessageBox.Show(this.txtUpdateDescription3.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription3.Focus();
                return false;
            }

            if (txtUpdateDescription3.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription3.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription3.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService4_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID4.Text;

            String Description = txtUpdateDescription4.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate4.Value;

            if (!ValidateUpdateDescription4())
            {
                return;
            }



            
            nudUpdateBaseRate4.Value = 0;

            txtUpdateServiceStatus4.Visible = true;
            txtUpdateServiceID4.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus4.Clear();
            txtUpdateDescription4.Clear();
            txtUpdateServiceID4.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription4TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription4();
        }

        private bool ValidateUpdateDescription4()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription4.Text))
            {
                MessageBox.Show(this.txtUpdateDescription4.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription4.Focus();
                return false;
            }

            if (txtUpdateDescription4.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription4.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription4.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService5_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID5.Text;

            String Description = txtUpdateDescription5.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate5.Value;

            if (!ValidateUpdateDescription5())
            {
                return;
            }



            
            nudUpdateBaseRate5.Value = 0;

            txtUpdateServiceStatus5.Visible = true;
            txtUpdateServiceID5.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus5.Clear();
            txtUpdateDescription5.Clear();
            txtUpdateServiceID5.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription5TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription5();
        }

        private bool ValidateUpdateDescription5()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription5.Text))
            {
                MessageBox.Show(this.txtUpdateDescription5.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription5.Focus();
                return false;
            }

            if (txtUpdateDescription5.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription5.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription5.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService6_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID6.Text;

            String Description = txtUpdateDescription6.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate6.Value;

            if (!ValidateUpdateDescription6())
            {
                return;
            }



            
            nudUpdateBaseRate6.Value = 0;

            txtUpdateServiceStatus6.Visible = true;
            txtUpdateServiceID6.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus6.Clear();
            txtUpdateDescription6.Clear();
            txtUpdateServiceID6.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription6TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription6();
        }

        private bool ValidateUpdateDescription6()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription6.Text))
            {
                MessageBox.Show(this.txtUpdateDescription6.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription6.Focus();
                return false;
            }

            if (txtUpdateDescription6.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription6.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription6.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService7_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID7.Text;

            String Description = txtUpdateDescription7.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate7.Value;

            if (!ValidateUpdateDescription7())
            {
                return;
            }



            
            nudUpdateBaseRate7.Value = 0;

            txtUpdateServiceStatus7.Visible = true;
            txtUpdateServiceID7.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus7.Clear();
            txtUpdateDescription7.Clear();
            txtUpdateServiceID7.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription7TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription7();
        }

        private bool ValidateUpdateDescription7()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription7.Text))
            {
                MessageBox.Show(this.txtUpdateDescription7.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription7.Focus();
                return false;
            }

            if (txtUpdateDescription7.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription7.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription7.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService8_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID8.Text;

            String Description = txtUpdateDescription8.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate8.Value;

            if (!ValidateUpdateDescription8())
            {
                return;
            }



            
            nudUpdateBaseRate8.Value = 0;

            txtUpdateServiceStatus8.Visible = true;
            txtUpdateServiceID8.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus8.Clear();
            txtUpdateDescription8.Clear();
            txtUpdateServiceID8.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription8TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription8();
        }

        private bool ValidateUpdateDescription8()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription8.Text))
            {
                MessageBox.Show(this.txtUpdateDescription8.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription8.Focus();
                return false;
            }

            if (txtUpdateDescription8.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription8.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription8.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService9_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID9.Text;

            String Description = txtUpdateDescription9.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate9.Value;

            if (!ValidateUpdateDescription9())
            {
                return;
            }



            
            nudUpdateBaseRate9.Value = 0;

            txtUpdateServiceStatus9.Visible = true;
            txtUpdateServiceID9.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus9.Clear();
            txtUpdateDescription9.Clear();
            txtUpdateServiceID9.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription9TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription9();
        }

        private bool ValidateUpdateDescription9()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription9.Text))
            {
                MessageBox.Show(this.txtUpdateDescription9.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription9.Focus();
                return false;
            }

            if (txtUpdateDescription9.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription9.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription9.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService10_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID10.Text;

            String Description = txtUpdateDescription10.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate10.Value;

            if (!ValidateUpdateDescription10())
            {
                return;
            }



            
            nudUpdateBaseRate10.Value = 0;

            txtUpdateServiceStatus10.Visible = true;
            txtUpdateServiceID10.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus10.Clear();
            txtUpdateDescription10.Clear();
            txtUpdateServiceID10.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription10TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription10();
        }

        private bool ValidateUpdateDescription10()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription10.Text))
            {
                MessageBox.Show(this.txtUpdateDescription10.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription10.Focus();
                return false;
            }

            if (txtUpdateDescription10.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription10.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription10.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService11_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID11.Text;

            String Description = txtUpdateDescription11.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate11.Value;

            if (!ValidateUpdateDescription11())
            {
                return;
            }



            
            nudUpdateBaseRate11.Value = 0;

            txtUpdateServiceStatus11.Visible = true;
            txtUpdateServiceID11.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus11.Clear();
            txtUpdateDescription11.Clear();
            txtUpdateServiceID11.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription11TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription11();
        }

        private bool ValidateUpdateDescription11()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription11.Text))
            {
                MessageBox.Show(this.txtUpdateDescription11.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription11.Focus();
                return false;
            }

            if (txtUpdateDescription11.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription11.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription11.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService12_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID12.Text;

            String Description = txtUpdateDescription12.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate12.Value;

            if (!ValidateUpdateDescription12())
            {
                return;
            }



            
            nudUpdateBaseRate12.Value = 0;

            txtUpdateServiceStatus12.Visible = true;
            txtUpdateServiceID12.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus12.Clear();
            txtUpdateDescription12.Clear();
            txtUpdateServiceID12.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription12TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription12();
        }

        private bool ValidateUpdateDescription12()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription12.Text))
            {
                MessageBox.Show(this.txtUpdateDescription12.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription12.Focus();
                return false;
            }

            if (txtUpdateDescription12.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription12.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription12.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService13_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID13.Text;

            String Description = txtUpdateDescription13.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate13.Value;

            if (!ValidateUpdateDescription13())
            {
                return;
            }



            
            nudUpdateBaseRate13.Value = 0;

            txtUpdateServiceStatus13.Visible = true;
            txtUpdateServiceID13.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus13.Clear();
            txtUpdateDescription13.Clear();
            txtUpdateServiceID13.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription13TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription13();
        }

        private bool ValidateUpdateDescription13()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription13.Text))
            {
                MessageBox.Show(this.txtUpdateDescription13.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription13.Focus();
                return false;
            }

            if (txtUpdateDescription13.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription13.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription13.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdateService14_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID14.Text;

            String Description = txtUpdateDescription14.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate14.Value;

            if (!ValidateUpdateDescription14())
            {
                return;
            }



            
            nudUpdateBaseRate14.Value = 0;

            txtUpdateServiceStatus14.Visible = true;
            txtUpdateServiceID14.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus14.Clear();
            txtUpdateDescription14.Clear();
            txtUpdateServiceID14.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription14TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription14();
        }

        private bool ValidateUpdateDescription14()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription14.Text))
            {
                MessageBox.Show(this.txtUpdateDescription14.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription14.Focus();
                return false;
            }

            if (txtUpdateDescription14.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription14.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription14.Focus();
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

        private void btnUpdateService15_Click(object sender, EventArgs e)
        {
            String ServiceID = txtUpdateServiceID15.Text;

            String Description = txtUpdateDescription15.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal BaseRate = nudUpdateBaseRate15.Value;

            if (!ValidateUpdateDescription15())
            {
                return;
            }



            
            nudUpdateBaseRate15.Value = 0;

            txtUpdateServiceStatus15.Visible = true;
            txtUpdateServiceID15.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtServiceID.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Service details logged" +
            Environment.NewLine + Environment.NewLine + "Service ID: " + ServiceID +
            Environment.NewLine + Environment.NewLine + "Description: " + Description +
            Environment.NewLine + Environment.NewLine + "Base Rate: €" + BaseRate);

            MessageBox.Show(text: "Service Updated");

            txtUpdateServiceStatus15.Clear();
            txtUpdateDescription15.Clear();
            txtUpdateServiceID15.Clear();

        }

        /*private void ServiceIDTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

        private void UpdateDescription15TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateUpdateDescription15();
        }

        private bool ValidateUpdateDescription15()
        {

            if (string.IsNullOrEmpty(txtUpdateDescription15.Text))
            {
                MessageBox.Show(this.txtUpdateDescription15.Text, "I am sorry but the Description field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription15.Focus();
                return false;
            }

            if (txtUpdateDescription15.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtUpdateDescription15.Text, "I am sorry, but the Description field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDescription15.Focus();
                return false;
            }

            return true;
        }
    }
    
    
}
