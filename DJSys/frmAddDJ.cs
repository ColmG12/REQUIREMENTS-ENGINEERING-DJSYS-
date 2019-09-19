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
    public partial class frmAddDJ : Form
    {
        frmMainMenu parent;
        public frmAddDJ()
        {
            InitializeComponent();
        }

        public frmAddDJ(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmAddDJ_Load(object sender, EventArgs e)
        {
            txtDJID.Visible = true;
        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // parent.Show();
            // this.Dispose();
            this.Close();
            parent.Visible = true;
        }

        private void btnAddDJ_Click(object sender, EventArgs e)
        {
            String DJID = txtDJID.Text;

            String Forename = txtDJForename.Text;

            String Surname = txtDJSurname.Text;

            DateTime Date = dtpDJDateOfBirth.Value;

            String Contact = txtDJContactNo.Text;

            String Email = txtDJEmail.Text;

            String Street = txtDJStreet.Text;

            String Town = txtDJTown.Text;

            String City = txtDJCity.Text;

            String County = txtDJCounty.Text;

            String Eircode = txtDJEircode.Text;

            //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            decimal HourlyRate = nudDJHourlyRate.Value;

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


            txtDJForename.Clear();
            txtDJSurname.Clear();
            txtDJContactNo.Clear();
            txtDJEmail.Clear();
            txtDJStreet.Clear();
            txtDJTown.Clear();
            txtDJCounty.Clear();
            txtDJCity.Clear();
            txtDJEircode.Clear();
            dtpDJDateOfBirth.Value = DateTime.Now;
            nudDJHourlyRate.Value = 0;

            txtDJStatus.Visible = true;


            // I need to check if the content is valid before adding it to the form
            //MessageBox item = new MessageBox(this.txtForename.Text);
            //this.textBox1.Items.Add(item);
            MessageBox.Show(text: "DJ details added" +
            Environment.NewLine + Environment.NewLine + "DJ ID: " + DJID +
            Environment.NewLine + Environment.NewLine + "Forename: " + Forename +
            Environment.NewLine + Environment.NewLine + "Surname: " + Surname +
            Environment.NewLine + Environment.NewLine + "Date of Birth: " + Date +
            Environment.NewLine + Environment.NewLine + "Contact No.: " + Contact +
            Environment.NewLine + Environment.NewLine + "Email: " + Email +
            Environment.NewLine + Environment.NewLine + "Street: " + Street +
            Environment.NewLine + Environment.NewLine + "Town: " + Town +
            Environment.NewLine + Environment.NewLine + "City: " + City +
            Environment.NewLine + Environment.NewLine + "County: " + County +
            Environment.NewLine + Environment.NewLine + "Eircode: " + Eircode +
            Environment.NewLine + Environment.NewLine + "Hourly Rate: €" + HourlyRate);

            MessageBox.Show(text: "DJ Registered");

            txtDJID.Clear();
            txtDJStatus.Clear();
            dtpDJDateOfBirth.Value = DateTime.Now;
            nudDJHourlyRate.Value = 0;

            btnDJEmail.Visible = true;


        }

        private void ForenameTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateForename();
        }

        private bool ValidateForename()
        {

            if (String.IsNullOrEmpty(txtDJForename.Text))
            {
                MessageBox.Show(this.txtDJForename.Text, "I am sorry but the Forename field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJForename.Focus();
                return false;
            }

            if (txtDJForename.Text.Contains(" "))
            {
                MessageBox.Show(this.txtDJForename.Text, "I am sorry but the Forename field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJForename.Focus();
                return false;
            }

            if (txtDJForename.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtDJForename.Text, "I am sorry, but the Forename field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJForename.Focus();
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

            if (string.IsNullOrEmpty(txtDJSurname.Text))
            {
                MessageBox.Show(this.txtDJSurname.Text, "I am sorry but the Surname field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJSurname.Focus();
                return false;
            }

            if (txtDJSurname.Text.Contains(" "))
            {
                MessageBox.Show(this.txtDJSurname.Text, "I am sorry but the Surname field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJSurname.Focus();
                return false;
            }

            if (txtDJSurname.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtDJSurname.Text, "I am sorry, but the Surname field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJSurname.Focus();
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
            if (dtpDJDateOfBirth.Value > (DateTime.Now.AddYears(-18)))

            {
                MessageBox.Show(this.dtpDJDateOfBirth.Text, "I am sorry, but you must be 18 or over to register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDJDateOfBirth.Focus();
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

            if (String.IsNullOrEmpty(txtDJContactNo.Text))
            {
                MessageBox.Show(this.txtDJContactNo.Text, "I am sorry but the contact number field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJContactNo.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateEmail()
        {
            if (!Regex.IsMatch(txtDJEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email must be valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJEmail.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(txtDJEmail.Text))
            {
                MessageBox.Show(this.txtDJEmail.Text, "I am sorry but the Email field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJEmail.Focus();
                return false;
            }

            if (txtDJEmail.Text.Contains(" "))
            {
                MessageBox.Show(this.txtDJEmail.Text, "I am sorry but the Email field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJEmail.Focus();
                return false;
            }

            return true;
        }


        private bool ValidateStreet()
        {

            if (String.IsNullOrEmpty(txtDJStreet.Text))
            {
                MessageBox.Show(this.txtDJStreet.Text, "I am sorry but the Street field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJStreet.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateTown()
        {

            if (String.IsNullOrEmpty(txtDJTown.Text))
            {
                MessageBox.Show(this.txtDJTown.Text, "I am sorry but the Town field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJTown.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateCity()
        {

            if (String.IsNullOrEmpty(txtDJCity.Text))
            {
                MessageBox.Show(this.txtDJCity.Text, "I am sorry but the City field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJCity.Focus();
                return false;
            }

            if (txtDJCity.Text.Contains(" "))
            {
                MessageBox.Show(this.txtDJCity.Text, "I am sorry but the City field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJCity.Focus();
                return false;
            }

            if (txtDJCity.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtDJCity.Text, "I am sorry, but the City field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJCity.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateCounty()
        {

            if (String.IsNullOrEmpty(txtDJCounty.Text))
            {
                MessageBox.Show(this.txtDJCounty.Text, "I am sorry but the County field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJCounty.Focus();
                return false;
            }

            if (txtDJCounty.Text.Contains(" "))
            {
                MessageBox.Show(this.txtDJCounty.Text, "I am sorry but the County field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJCounty.Focus();
                return false;
            }

            if (txtDJCounty.Text.Any(c => Char.IsNumber(c)))

            {
                MessageBox.Show(this.txtDJCounty.Text, "I am sorry, but the County field cannot have numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJCounty.Focus();
                return false;
            }


            return true;
        }

        private bool ValidateEircode()
        {

            if (String.IsNullOrEmpty(txtDJEircode.Text))
            {
                MessageBox.Show(this.txtDJEircode.Text, "I am sorry but the Eircode field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJEircode.Focus();
                return false;
            }

            if (txtDJEircode.Text.Contains(" "))
            {
                MessageBox.Show(this.txtDJEircode.Text, "I am sorry but the Eircode field cannot contain spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDJEircode.Focus();
                return false;
            }


            return true;
        }

        private void btnDJEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Confirmation email sent to DJ");
        }
    }
    
}
