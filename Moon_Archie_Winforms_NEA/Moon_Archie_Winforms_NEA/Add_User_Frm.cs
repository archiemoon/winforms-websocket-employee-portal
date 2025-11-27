using System;
using System.Windows.Forms;
using Winforms;
using System.Linq;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Add_User_Frm : Form
    {
        public Add_User_Frm()
        {
            InitializeComponent();
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            // Uses the data validation class to check each field is appropriate and the user can proceed to confirming their password
            bool ValidName = Data_Validation_Functions_Class.IsNumberOfWords(Name_TxtBox.Text, 2);
            bool ValidEmail = Data_Validation_Functions_Class.IsValidEmial(Email_TxtBox.Text);
            bool ValidPhoneNumber = Data_Validation_Functions_Class.IsValidPhoneNumber(PhoneNumber_TxtBox.Text);
            bool ValidUsername = Data_Validation_Functions_Class.IsBetweenLength(Username_TxtBox.Text, 5, 20);
            bool ValidPassword = Data_Validation_Functions_Class.IsValidPassword(Password_TxtBox.Text, 5, 20);

            bool NoneSelected = true;

            foreach (RadioButton radioButton in Permission_GroupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    NoneSelected = false;
                    break;
                }
            }

            if (ValidName && ValidEmail && ValidPhoneNumber && ValidUsername && ValidPassword && NoneSelected != true)
            {
                // The confirm password panel becomes visible
                Confirm_Password_Pnl.Visible = true;
            }
            else
            {
                // If any validation checks return false an error message box is displayed 
                MessageBox.Show("One or more data fields is in incorrect format.\nPlease double check all fields are correct.\nPlease make sure your password contains:\nUppercase (1)\nSpecial Characters (1)\nNumbers (1)\nCharacters (5 - 20)");
            }
        }
        private void Close_Confirm_Password_Btn_Click(object sender, EventArgs e)
        {
            // The panel becomes invisible and the text field is cleared
            Confirm_Password_Pnl.Visible = false;
            Confirm_Password_TxtBox.Text = "";
        }
        private void Confirm_Password_Btn_Click(object sender, EventArgs e)
        {
            string Password = Confirm_Password_TxtBox.Text;
            // Checks if the password entered by the person adding the user is correct
            if (Password_Hasher_Class.VerifyPassword(Password, LoginInfo.Salt, LoginInfo.Password) == true)
            {               
                // Gets the permision selected for the new user and stores it as a string
                string Permission = "";
                if (Employee_Permision_RBtn.Checked == true)
                {
                    Permission = "E";
                }
                else if (Manager_Permision_RBtn.Checked == true)
                {
                    Permission = "M";
                }

                // Splits the name entered into first name and surname and stores each seperatley 
                string[] NameParts = Name_TxtBox.Text.Split(' ');
                string FirstName = NameParts[0];
                string Surname = string.Join(" ", NameParts.Skip(1));

                // Generates a new random salt for the user 
                string Salt = Password_Hasher_Class.GenerateRandomSalt();

                // The query that adds the new user to the database 
                // The hashed password is only calculated here when it is added so its not stored within the code
                string Query = "INSERT INTO EmployeeDetails (FirstName, Surname, Username, Password, Salt, Email, PhoneNumber, Permission) " +
                               $"VALUES ('{FirstName}', '{Surname}', '{Username_TxtBox.Text}', '{Password_Hasher_Class.HashPassword(Password_TxtBox.Text, Salt)}', '{Salt}' , '{Email_TxtBox.Text}', '{PhoneNumber_TxtBox.Text.Remove(0, 1)}', '{Permission}')";
                Database_Opperations_Class.Connect_Read_Write(Query, "write");

                // Shows a name box showing the new user has been added succesfuly
                MessageBox.Show($"{Name_TxtBox.Text} Succesfuly added.");

                ClearAllFields();

                Confirm_Password_Pnl.Visible = false;
            }
            else
            {
                // If the user's (the one adding the new user) password is incorrect an error message is displayed
                MessageBox.Show("Incorrect password - Please try again.");
                Confirm_Password_TxtBox.Text = "";
            }
        }
        private void Add_User_Frm_Load(object sender, EventArgs e)
        {

        }     
        private void ClearAllFields()
        {
            // Subroutine that can be called to clear every field in the form
            Name_TxtBox.Text = ""; 
            Username_TxtBox.Text = ""; 
            Password_TxtBox.Text = ""; 
            Email_TxtBox.Text = "";
            Confirm_Password_TxtBox.Text = "";
            PhoneNumber_TxtBox.Text = "+44"; 
            Manager_Permision_RBtn.Checked = false; 
            Employee_Permision_RBtn.Checked = false;
        }
    }
}
