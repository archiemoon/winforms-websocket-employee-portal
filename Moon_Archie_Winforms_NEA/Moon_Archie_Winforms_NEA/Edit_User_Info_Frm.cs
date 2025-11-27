using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Edit_User_Info_Frm : Form
    {
        public string EmployeeIDs = "";
        public bool Password_Changed = false;
        public string SelectedID = "";
        public Edit_User_Info_Frm()
        {
            InitializeComponent();
        }

        private void Edit_User_Info_Frm_Load(object sender, EventArgs e)
        {
            Update_Database();
        }
        private void Update_Database()
        {
            string Query = "SELECT EmployeeID, Firstname, Surname, Email, PhoneNumber " +
                           "FROM EmployeeDetails ";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

            // List to store instances of a custom class containing employee details
            List<Employee_Search_Details> User_List = new List<Employee_Search_Details>();
            for (int x = 0; x < Results.GetLength(0); x++)
            {
                // Create a new Employee_Search_Details object and adds it to the list
                User_List.Add(new Employee_Search_Details(Results[x, 0], Results[x, 1], Results[x, 2], Results[x, 3], Results[x, 4]));
                EmployeeIDs += Results[x, 0];
            }
            // Set the DataSource of the DataGridView to the list of employee details
            Database_Users_GridView.DataSource = User_List;
            EmployeeID_Selector_NumericUpDown.Maximum = int.Parse(Results[(Results.GetLength(0) - 1), 0]);
        }

        private void Select_Btn_Click(object sender, EventArgs e)
        {
            Password_TxtBox.UseSystemPasswordChar = true;
            Update_Database();    
            // checks if the ID selected is valid
            bool ValidID = EmployeeIDs.Contains(EmployeeID_Selector_NumericUpDown.Value.ToString());
            if (ValidID == true)
            {
                Set_Fields_Enabled(true);
                SelectedID = EmployeeID_Selector_NumericUpDown.Value.ToString();
                // Loads the details of the selected employee into the fields in the form
                string Query = "SELECT FirstName, Surname, Username, Email, Password, PhoneNumber, Permission " +
                               "FROM EmployeeDetails " +
                               $"WHERE EmployeeID = '{SelectedID}'";
                string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");
                Name_TxtBox.Text = $"{Results[0, 0]} {Results[0, 1]}";
                Email_TxtBox.Text = Results[0, 3];
                PhoneNumber_TxtBox.Text = $"+44{Results[0, 5].Substring(2)}";
                Username_TxtBox.Text = Results[0, 2];
                Password_TxtBox.Text = "Password";
                if (Results[0, 6] == "M")
                {
                    Manager_Permision_RBtn.Checked = true;
                }
                else
                {
                    Employee_Permision_RBtn.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid EmployeeID.");
            }
        }

        private void New_Password_Btn_Click(object sender, EventArgs e)
        {
            // clears the placeholder and enables the password text field
            Password_TxtBox.Text = "";
            Password_TxtBox.ReadOnly = false;
            Password_TxtBox.UseSystemPasswordChar = false;
            Password_Changed = true;
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            Set_Fields_Enabled(false);
            Password_TxtBox.UseSystemPasswordChar = true;
            // Uses the data validation class to check each field is appropriate and the user can proceed to confirming their password
            bool ValidName = Data_Validation_Functions_Class.IsNumberOfWords(Name_TxtBox.Text, 2);
            bool ValidEmail = Data_Validation_Functions_Class.IsValidEmial(Email_TxtBox.Text);
            bool ValidPhoneNumber = Data_Validation_Functions_Class.IsValidPhoneNumber(PhoneNumber_TxtBox.Text);
            bool ValidUsername = Data_Validation_Functions_Class.IsBetweenLength(Username_TxtBox.Text, 5, 20);

            if (ValidName && ValidEmail && ValidPhoneNumber && ValidUsername)
            {
                // The confirm password panel becomes visible
                Confirm_Password_Pnl.Visible = true;
            }
            else
            {
                // If any validation checks return false an error message box is displayed 
                MessageBox.Show("One or more data fields is in incorrect format.\nPlease double check all fields are correct.\nPlease make sure your password contains:\nUppercase (1)\nSpecial Characters (1)\nNumbers (1)\nCharacters (5 - 20)");
            }
            Update_Btn.Visible = false;
        }

        private void Close_Confirm_Password_Btn_Click(object sender, EventArgs e)
        {
            Set_Fields_Enabled(true);
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
                // Splits the Name entered into the text box into firstname and surname
                string[] NameParts = Name_TxtBox.Text.Split(' ');

                // Firstname and surname variables are updated
                string FirstName = NameParts[0];
                string Surname = string.Join(" ", NameParts.Skip(1));

                string Query = "";
                // Checks if the password has been changed
                if (Password_Changed == true)
                {
                    bool ValidPassword = Data_Validation_Functions_Class.IsValidPassword(Password_TxtBox.Text, 5, 20);
                    if (ValidPassword == true)
                    {
                        Query = "SELECT Salt " +
                                "FROM EmployeeDetails " +
                                $"WHERE EmployeeID = '{SelectedID}'";
                        string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");
                        // The new password is hashed and stored locally
                        string New_Password = Password_Hasher_Class.HashPassword(Password_TxtBox.Text, Results[0, 0]);

                        // All changes are updated in the SQLite database and within the loginInfo static class
                        Query = "UPDATE EmployeeDetails " +
                                $"SET FirstName = '{FirstName}', Surname = '{Surname}', Username = '{Username_TxtBox.Text}', Password = '{Password}', PhoneNumber = '{PhoneNumber_TxtBox.Text.Substring(1)}', Permission = '{Permission}' " +
                                $"WHERE EmployeeID = '{SelectedID}'";
                        // The according query is performed
                        Database_Opperations_Class.Connect_Read_Write(Query, "write");

                        ClearAllFields();

                        MessageBox.Show("Changes updated succesfuly.");
                    }
                    else
                    {
                        MessageBox.Show("Your password seems to be missing something.\nPlease make sure it contains:\nUppercase (1)\nSpecial Characters (1)\nNumbers (1)\nCharacters (5 - 20)");
                    }
                }
                else
                {
                    // Query is the same as above but excludes the password
                    // The password isnt included in this query as it hasnt been changed
                    Query = $"UPDATE EmployeeDetails " +
                        $"SET FirstName = '{FirstName}', Surname = '{Surname}', Username = '{Username_TxtBox.Text}', PhoneNumber = '{PhoneNumber_TxtBox.Text.Substring(1)}', Permission = '{Permission}' " +
                        $"WHERE EmployeeID = '{SelectedID}'";

                    // The according query is performed
                    Database_Opperations_Class.Connect_Read_Write(Query, "write");

                    ClearAllFields();

                    MessageBox.Show("Changes updated succesfuly.");
                }
                Set_Fields_Enabled(true);
                Confirm_Password_Pnl.Visible = false;
                Confirm_Password_TxtBox.Text = "";
                Update_Btn.Visible = false;
                Update_Database();

            }
            else
            {
                // If the user's (the one adding the new user) password is incorrect an error message is displayed
                MessageBox.Show("Incorrect password - Please try again.");
                Confirm_Password_TxtBox.Text = "";
            }
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
        private void Set_Fields_Enabled(bool state)
        {
            Name_TxtBox.Enabled = state;
            Email_TxtBox.Enabled = state;
            PhoneNumber_TxtBox.Enabled = state;
            Username_TxtBox.Enabled = state;
            Password_TxtBox.Enabled = state;
            Manager_Permision_RBtn.Enabled = state;
            Employee_Permision_RBtn.Enabled = state;
            EmployeeID_Selector_NumericUpDown.Enabled = state;
            New_Password_Btn.Visible = state;
            Update_Btn.Visible = state;
            Select_Btn.Enabled = state;
        }
    }
}
