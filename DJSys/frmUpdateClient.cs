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
    public partial class frmUpdateClient : Form
    {
        frmMainMenu parent;
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        public frmUpdateClient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {

        }

        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            grpUpdateMatchingClients.Visible = true;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose();
            this.Close();
            parent.Visible = true;
        }

        private void txtMatchingClients1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void optMatchingClient1_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateClient.Visible = true;

            grpUpdateClient2.Visible = false;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            String ClientID = txtClientID.Text;

            String Forename = txtForename.Text;

            String Surname = txtSurname.Text;

            DateTime Date = dtpDateOfBirth.Value;

            String Contact = txtContactNo.Text;

            String Email = txtEmail.Text;

            String Street = txtStreet.Text;

            String Town = txtTown.Text;

            String City = txtCity.Text;

            String County = txtCounty.Text;

            String Eircode = txtEircode.Text;







            if (!ValidateForename())
            {
                return;
            }

            if (!ValidateSurname())
            {
                return;
            }

            if (!ValidateDate())
            {
                return;
            }

            if (!ValidateContact())
            {
                return;
            }

            if (!ValidateEmail())
            {
                return;
            }

            if (!ValidateStreet())
            {
                return;
            }

            if (!ValidateTown())
            {
                return;
            }

            if (!ValidateCity())
            {
                return;
            }

            if (!ValidateCounty())
            {
                return;
            }

            if (!ValidateEircode())
            {
                return;
            }


            txtForename.Clear();
            txtSurname.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtCity.Clear();
            txtEircode.Clear();
            dtpDateOfBirth.Value = DateTime.Now;

            txtClientID.Visible = true;

            txtStatus.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtForename.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Client details updated" +
            Environment.NewLine + Environment.NewLine + "Client ID: " + ClientID +
            Environment.NewLine + Environment.NewLine + "Forename: " + Forename +
            Environment.NewLine + Environment.NewLine + "Surname: " + Surname +
            Environment.NewLine + Environment.NewLine + "Date of Birth: " + Date +
            Environment.NewLine + Environment.NewLine + "Contact No.: " + Contact +
            Environment.NewLine + Environment.NewLine + "Email: " + Email +
            Environment.NewLine + Environment.NewLine + "Street: " + Street +
            Environment.NewLine + Environment.NewLine + "Town: " + Town +
            Environment.NewLine + Environment.NewLine + "City: " + City +
            Environment.NewLine + Environment.NewLine + "County: " + County +
            Environment.NewLine + Environment.NewLine + "Eircode: " + Eircode);

            MessageBox.Show(text: "Client Updated");

            txtClientID.Clear();
            txtStatus.Clear();
            dtpDateOfBirth.Value = DateTime.Now;

            btnEmail.Visible = true;


        }

        private void ForenameTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateForename();
        }

        private bool ValidateForename()
        {

            if (String.IsNullOrEmpty(txtForename.Text))
            {
                MessageBox.Show(this.txtForename.Text, "I am sorry but the Forename field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return false;
            }

            if (txtForename.Text.Contains(" "))
            {
                MessageBox.Show(this.txtForename.Text, "I am sorry but the Forename field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return false;
            }

            if (txtForename.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtForename.Text, "I am sorry, but the Forename field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return false;
            }

            return true;
        }

        private void SurnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateSurname();
        }

        private bool ValidateSurname()
        {

            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show(this.txtSurname.Text, "I am sorry but the Surname field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return false;
            }

            if (txtSurname.Text.Contains(" "))
            {
                MessageBox.Show(this.txtSurname.Text, "I am sorry but the Surname field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return false;
            }

            if (txtSurname.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtSurname.Text, "I am sorry, but the Surname field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return false;
            }

            return true;
        }

        private void DateTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateDate();
        }

        private bool ValidateDate()
        {
            if (dtpDateOfBirth.Value > (DateTime.Now.AddYears(-18)))

            {
                MessageBox.Show(this.dtpDateOfBirth.Text, "I am sorry, but you must be 18 or over to register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateOfBirth.Focus();
                return false;
            }

            return true;
        }

        private void ContactTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateContact();
        }

        private bool ValidateContact()
        {

            if (String.IsNullOrEmpty(txtContactNo.Text))
            {
                MessageBox.Show(this.txtContactNo.Text, "I am sorry but the contact number field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNo.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateEmail()
        {
            if (!Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email must be valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show(this.txtEmail.Text, "I am sorry but the Email field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            if (txtEmail.Text.Contains(" "))
            {
                MessageBox.Show(this.txtEmail.Text, "I am sorry but the Email field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }


        private bool ValidateStreet()
        {

            if (String.IsNullOrEmpty(txtStreet.Text))
            {
                MessageBox.Show(this.txtStreet.Text, "I am sorry but the Street field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateTown()
        {

            if (String.IsNullOrEmpty(txtTown.Text))
            {
                MessageBox.Show(this.txtTown.Text, "I am sorry but the Town field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateCity()
        {

            if (String.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show(this.txtCity.Text, "I am sorry but the City field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return false;
            }

            if (txtCity.Text.Contains(" "))
            {
                MessageBox.Show(this.txtCity.Text, "I am sorry but the City field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return false;
            }

            if (txtCity.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtCity.Text, "I am sorry, but the City field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateCounty()
        {

            if (String.IsNullOrEmpty(txtCounty.Text))
            {
                MessageBox.Show(this.txtCounty.Text, "I am sorry but the County field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return false;
            }

            if (txtCounty.Text.Contains(" "))
            {
                MessageBox.Show(this.txtCounty.Text, "I am sorry but the County field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return false;
            }

            if (txtCounty.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtCounty.Text, "I am sorry, but the County field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateEircode()
        {

            if (String.IsNullOrEmpty(txtEircode.Text))
            {
                MessageBox.Show(this.txtEircode.Text, "I am sorry but the Eircode field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return false;
            }

            if (txtEircode.Text.Contains(" "))
            {
                MessageBox.Show(this.txtEircode.Text, "I am sorry but the Eircode field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return false;
            }


            return true;
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClientID_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void grpUpdateClient_Enter(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void lblContactNo_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblStreet_Click(object sender, EventArgs e)
        {

        }

        private void lblTown_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void lblCounty_Click(object sender, EventArgs e)
        {

        }

        private void lblEircode_Click(object sender, EventArgs e)
        {

        }

        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        private void txtEircode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCounty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpMatchingClients_Enter(object sender, EventArgs e)
        {

        }

        private void txtMatchingClients2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void optMatchingClient2_CheckedChanged(object sender, EventArgs e)
        {
            grpUpdateClient2.Visible = true;

            grpUpdateClient.Visible = false;
        }

        private void lblClientID_Click_1(object sender, EventArgs e)
        {

        }

        private void txtClientID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click_1(object sender, EventArgs e)
        {

        }

        private void lblEnterName_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateOfBirth_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Confirmation email sent to Client");
        }

        private void btnUpdateClient2_Click(object sender, EventArgs e)
        {
            String ClientID = txtClientID2.Text;

            String Forename = txtForename2.Text;

            String Surname = txtSurname2.Text;

            DateTime Date = dtpDateOfBirth2.Value;

            String Contact = txtContactNo2.Text;

            String Email = txtEmail2.Text;

            String Street = txtStreet2.Text;

            String Town = txtTown2.Text;

            String City = txtCity2.Text;

            String County = txtCounty2.Text;

            String Eircode = txtEircode2.Text;







            if (!ValidateForename2())
            {
                return;
            }

            if (!ValidateSurname2())
            {
                return;
            }

            if (!ValidateDate2())
            {
                return;
            }

            if (!ValidateContact2())
            {
                return;
            }

            if (!ValidateEmail2())
            {
                return;
            }

            if (!ValidateStreet2())
            {
                return;
            }

            if (!ValidateTown2())
            {
                return;
            }

            if (!ValidateCity2())
            {
                return;
            }

            if (!ValidateCounty2())
            {
                return;
            }

            if (!ValidateEircode2())
            {
                return;
            }


            txtForename2.Clear();
            txtSurname2.Clear();
            txtContactNo2.Clear();
            txtEmail2.Clear();
            txtStreet2.Clear();
            txtTown2.Clear();
            txtCounty2.Clear();
            txtCity2.Clear();
            txtEircode2.Clear();
            dtpDateOfBirth2.Value = DateTime.Now;

            txtClientID2.Visible = true;
            txtStatus2.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtForename.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "Client details updated" +
            Environment.NewLine + Environment.NewLine + "Client ID: " + ClientID +
            Environment.NewLine + Environment.NewLine + "Forename: " + Forename +
            Environment.NewLine + Environment.NewLine + "Surname: " + Surname +
            Environment.NewLine + Environment.NewLine + "Date of Birth: " + Date +
            Environment.NewLine + Environment.NewLine + "Contact No.: " + Contact +
            Environment.NewLine + Environment.NewLine + "Email: " + Email +
            Environment.NewLine + Environment.NewLine + "Street: " + Street +
            Environment.NewLine + Environment.NewLine + "Town: " + Town +
            Environment.NewLine + Environment.NewLine + "City: " + City +
            Environment.NewLine + Environment.NewLine + "County: " + County +
            Environment.NewLine + Environment.NewLine + "Eircode: " + Eircode);

            MessageBox.Show(text: "Client Updated");

            txtClientID2.Clear();
            txtStatus2.Clear();
            dtpDateOfBirth2.Value = DateTime.Now;

            btnEmail.Visible = true;


        }

        private void Forename2TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateForename2();
        }

        private bool ValidateForename2()
        {

            if (String.IsNullOrEmpty(txtForename2.Text))
            {
                MessageBox.Show(this.txtForename2.Text, "I am sorry but the Forename field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename2.Focus();
                return false;
            }

            if (txtForename2.Text.Contains(" "))
            {
                MessageBox.Show(this.txtForename2.Text, "I am sorry but the Forename field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename2.Focus();
                return false;
            }

            if (txtForename2.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtForename2.Text, "I am sorry, but the Forename field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename2.Focus();
                return false;
            }

            return true;
        }

        private void Surname2TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateSurname2();
        }

        private bool ValidateSurname2()
        {

            if (string.IsNullOrEmpty(txtSurname2.Text))
            {
                MessageBox.Show(this.txtSurname2.Text, "I am sorry but the Surname field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname2.Focus();
                return false;
            }

            if (txtSurname2.Text.Contains(" "))
            {
                MessageBox.Show(this.txtSurname2.Text, "I am sorry but the Surname field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname2.Focus();
                return false;
            }

            if (txtSurname2.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtSurname2.Text, "I am sorry, but the Surname field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname2.Focus();
                return false;
            }

            return true;
        }

        private void Date2TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateDate2();
        }

        private bool ValidateDate2()
        {
            if (dtpDateOfBirth2.Value > (DateTime.Now.AddYears(-18)))

            {
                MessageBox.Show(this.dtpDateOfBirth2.Text, "I am sorry, but you must be 18 or over to register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateOfBirth2.Focus();
                return false;
            }

            return true;
        }

        private void Contact2TextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateContact2();
        }

        private bool ValidateContact2()
        {

            if (String.IsNullOrEmpty(txtContactNo2.Text))
            {
                MessageBox.Show(this.txtContactNo2.Text, "I am sorry but the contact number field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNo2.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateEmail2()
        {
            if (!Regex.IsMatch(txtEmail2.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email must be valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail2.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(txtEmail2.Text))
            {
                MessageBox.Show(this.txtEmail2.Text, "I am sorry but the Email field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail2.Focus();
                return false;
            }

            if (txtEmail2.Text.Contains(" "))
            {
                MessageBox.Show(this.txtEmail2.Text, "I am sorry but the Email field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail2.Focus();
                return false;
            }

            return true;
        }


        private bool ValidateStreet2()
        {

            if (String.IsNullOrEmpty(txtStreet2.Text))
            {
                MessageBox.Show(this.txtStreet2.Text, "I am sorry but the Street field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet2.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateTown2()
        {

            if (String.IsNullOrEmpty(txtTown2.Text))
            {
                MessageBox.Show(this.txtTown2.Text, "I am sorry but the Town field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown2.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateCity2()
        {

            if (String.IsNullOrEmpty(txtCity2.Text))
            {
                MessageBox.Show(this.txtCity2.Text, "I am sorry but the City field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity2.Focus();
                return false;
            }

            if (txtCity2.Text.Contains(" "))
            {
                MessageBox.Show(this.txtCity2.Text, "I am sorry but the City field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity2.Focus();
                return false;
            }

            if (txtCity2.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtCity2.Text, "I am sorry, but the City field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity2.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateCounty2()
        {

            if (String.IsNullOrEmpty(txtCounty2.Text))
            {
                MessageBox.Show(this.txtCounty2.Text, "I am sorry but the County field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty2.Focus();
                return false;
            }

            if (txtCounty2.Text.Contains(" "))
            {
                MessageBox.Show(this.txtCounty2.Text, "I am sorry but the County field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty2.Focus();
                return false;
            }

            if (txtCounty2.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtCounty2.Text, "I am sorry, but the County field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty2.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateEircode2()
        {

            if (String.IsNullOrEmpty(txtEircode2.Text))
            {
                MessageBox.Show(this.txtEircode2.Text, "I am sorry but the Eircode field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode2.Focus();
                return false;
            }

            if (txtEircode2.Text.Contains(" "))
            {
                MessageBox.Show(this.txtEircode2.Text, "I am sorry but the Eircode field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode2.Focus();
                return false;
            }


            return true;
        }
    }
    
}
    

