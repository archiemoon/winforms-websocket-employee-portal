using System;
using System.Linq;
using System.Windows.Forms;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Account_Frm : Form
    {
        // Stores weather the password has been changed 
        public static bool Password_Changed = false;
        public Account_Frm()
        {
            InitializeComponent();
        }
        private void Account_Frm_Load(object sender, EventArgs e)
        {
            // All the data is loaded into the account details fields from the static logininfo class
            // Some fields are formatted
            Name_TxtBox.Text = LoginInfo.First_Name + " " + LoginInfo.Surname;
            Email_TxtBox.Text = LoginInfo.Email;
            PhoneNumber_TxtBox.Text = "+" + LoginInfo.PhoneNumber;
            Username_TxtBox.Text = LoginInfo.Username;
            // A placeholder string otherwise the field will show the hashed string which is far too long
            Password_TxtBox.Text = "Password";
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            // Uses the data validation class to check each field is appropriate and can be added to the database
            bool ValidName = Data_Validation_Functions_Class.IsNumberOfWords(Name_TxtBox.Text, 2);
            bool ValidEmail = Data_Validation_Functions_Class.IsValidEmial(Email_TxtBox.Text);
            bool ValidPhoneNumber = Data_Validation_Functions_Class.IsValidPhoneNumber(PhoneNumber_TxtBox.Text);
            bool ValidUsername = Data_Validation_Functions_Class.IsBetweenLength(Username_TxtBox.Text, 5, 20);

            // Checks if all the booleans are true 
            if (ValidName && ValidEmail && ValidPhoneNumber && ValidUsername)
            {
                // Any pressed edit buttons become visible again and Text fields become read only
                Set_Edit_Btn_Visibility(true);
                Enable_TxtBox_Fields(false);

                Save_Btn.Visible = false;

                // The password text box reverts back to SystemPasswordChar
                Password_TxtBox.UseSystemPasswordChar = true;

                // Splits the Name entered into the text box into firstname and surname
                string[] NameParts = Name_TxtBox.Text.Split(' ');

                // Firstname and surname variables are updated
                string FirstName = NameParts[0];
                string Surname = string.Join(" ", NameParts.Skip(1));

                string Query;
                // Checks if the password has been changed
                if (Password_Changed == true)
                {
                    bool ValidPassword = Data_Validation_Functions_Class.IsValidPassword(Password_TxtBox.Text, 5, 20);
                    if (ValidPassword)
                    {
                        // The new password is hashed and stored locally
                        string Password = Password_Hasher_Class.HashPassword(Password_TxtBox.Text, LoginInfo.Salt);

                        // All changes are updated in the SQLite database and within the loginInfo static class
                        Query = $"UPDATE EmployeeDetails " +
                            $"SET FirstName = '{FirstName}', Surname = '{Surname}', Username = '{Username_TxtBox.Text}', Password = '{Password}', PhoneNumber = '{PhoneNumber_TxtBox.Text.Substring(1)}' " +
                            $"WHERE Username = '{LoginInfo.Username}' AND Password = '{LoginInfo.Password}'";
                        Database_Opperations_Class.Connect_Read_Write(Query, "write");

                        // The remaining data is also updated in the static class, regardless of if its changed
                        LoginInfo.Email = Email_TxtBox.Text;
                        LoginInfo.PhoneNumber = PhoneNumber_TxtBox.Text.Substring(1);
                        LoginInfo.Username = Username_TxtBox.Text;
                        LoginInfo.First_Name = FirstName;
                        LoginInfo.Surname = Surname;

                        // Password text box is set back to placeholder string
                        Password_TxtBox.Text = "Password";

                        LoginInfo.Password = Password;
                    }
                    else
                    {
                        MessageBox.Show("One or more data fields is in incorrect format.\nPlease double check all fields are correct.\nPlease make sure your password contains:\nUppercase (1)\nSpecial Characters (1)\nNumbers (1)\nCharacters (5 - 20)");

                    }
                }
                else
                {
                    // Query is the same as above but excludes the password
                    // The password isnt included in this query as it hasnt been changed
                    Query = $"UPDATE EmployeeDetails " +
                        $"SET FirstName = '{FirstName}', Surname = '{Surname}', Username = '{Username_TxtBox.Text}', PhoneNumber = '{PhoneNumber_TxtBox.Text.Substring(1)}' " +
                        $"WHERE Username = '{LoginInfo.Username}' AND Password = '{LoginInfo.Password}'";
                    // The according query is performed
                    Database_Opperations_Class.Connect_Read_Write(Query, "write");

                    // The remaining data is also updated in the static class, regardless of if its changed
                    LoginInfo.Email = Email_TxtBox.Text;
                    LoginInfo.PhoneNumber = PhoneNumber_TxtBox.Text.Substring(1);
                    LoginInfo.Username = Username_TxtBox.Text;
                    LoginInfo.First_Name = FirstName;
                    LoginInfo.Surname = Surname;

                    // Password text box is set back to placeholder string
                    Password_TxtBox.Text = "Password";
                }
            }
            else
            {
                // If any validation checks return false an error message box is displayed 
                MessageBox.Show("One or more data fields is in incorrect format.\nPlease double check all fields are correct.\nPlease make sure your password contains:\nUppercase (1)\nSpecial Characters (1)\nNumbers (1)\nCharacters (5 - 20)");
            }
        }
        private void EditName_Btn_Click(object sender, EventArgs e)
        {
            // enables the name text box for editing
            EditName_Btn.Visible = false;
            Save_Btn.Visible = true;
            Name_TxtBox.Enabled = true;
        }
        private void EditEmail_Btn_Click(object sender, EventArgs e)
        {
            // enables the email text box for editing
            EditEmail_Btn.Visible = false;
            Save_Btn.Visible = true;
            Email_TxtBox.Enabled = true;
        }
        private void EditPhoneNumber_Btn_Click(object sender, EventArgs e)
        {
            // enables the PhoneNumber text box for editing
            EditPhoneNumber_Btn.Visible = false;
            Save_Btn.Visible = true;
            PhoneNumber_TxtBox.Enabled = true;
        }
        private void EditUsername_Btn_Click(object sender, EventArgs e)
        {
            // enables the username text box for editing
            EditUsername_Btn.Visible = false;
            Save_Btn.Visible = true;
            Username_TxtBox.Enabled = true;
        }
        private void EditPassword_Btn_Click(object sender, EventArgs e)
        {
            // enables the password text box for editing
            EditPassword_Btn.Visible = false;
            Confirm_Password_Pnl.Visible = true;
        }

        ///
        // Code bellow is for the confirm password panel and its controls
        ///

        private void Close_Confirm_Password_Btn_Click(object sender, EventArgs e)
        {
            Confirm_Password_Pnl.Visible = false;
            Confirm_Password_TxtBox.Text = "";
            Save_Btn.Visible = false;
            EditPassword_Btn.Visible = true;
        }
        private void Confirm_Password_Btn_Click(object sender, EventArgs e)
        {
            // Uses the verify function to compare the password they entered to the stored one 
            string Password = Confirm_Password_TxtBox.Text;
            
            if (Password_Hasher_Class.VerifyPassword(Password, LoginInfo.Salt, LoginInfo.Password))
            {
                Password_Changed = true;
                Save_Btn.Visible = true;
                Confirm_Password_TxtBox.Text = "";
                Confirm_Password_Pnl.Visible = false;
                Password_TxtBox.Text = Password;

                // Reveals the hidden password and allows it to be edited
                Password_TxtBox.UseSystemPasswordChar = false;
                Password_TxtBox.Enabled = true;
            }
            else
            {
                // Displays an error message if the passwords do not match 
                MessageBox.Show("Incorrect password; Please try again.");
                Confirm_Password_TxtBox.Text = "";
            }
        }
        private void Set_Edit_Btn_Visibility(bool state)
        {
            // Makes all edit buttons visible or invisible 
            EditName_Btn.Visible = state; 
            EditEmail_Btn.Visible = state; 
            EditPhoneNumber_Btn.Visible = state; 
            EditPassword_Btn.Visible = state; 
            EditUsername_Btn.Visible = state;
        }
        private void Enable_TxtBox_Fields(bool state)
        {
            // Makes all text boxes enabled or read only
            Name_TxtBox.Enabled = state; 
            Email_TxtBox.Enabled = state; 
            PhoneNumber_TxtBox.Enabled = state; 
            Username_TxtBox.Enabled = state; 
            Password_TxtBox.Enabled = state;
        }
    }
}
