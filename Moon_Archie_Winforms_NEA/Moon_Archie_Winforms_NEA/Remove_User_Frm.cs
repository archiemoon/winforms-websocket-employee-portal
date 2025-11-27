using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Remove_User_Frm : Form
    {
        public string EmployeeIDs = "";
        public Remove_User_Frm()
        {
            InitializeComponent();
        }

        private void Remove_User_Frm_Load(object sender, EventArgs e)
        {
            Update_DataGrid_View();
        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            // The confirm password panel becomes visible
            Confirm_Password_Pnl.Visible = true;
            Remove_Btn.Enabled = false;
        }

        private void Close_Confirm_Password_Btn_Click(object sender, EventArgs e)
        {
            // The panel becomes invisible and the text field is cleared
            Confirm_Password_Pnl.Visible = false;
            Confirm_Password_TxtBox.Text = "";
            Remove_Btn.Enabled = true;
        }

        private void Confirm_Password_Btn_Click(object sender, EventArgs e)
        {
            bool ValidID = EmployeeIDs.Contains(EmployeeID_Selector_NumericUpDown.Value.ToString());

            string Password = Confirm_Password_TxtBox.Text;
            // Checks if the password entered by the person adding the user is correct
            if (Password_Hasher_Class.VerifyPassword(Password, LoginInfo.Salt, LoginInfo.Password) == true && ValidID == true)
            {
                string Query = "DELETE FROM EmployeeDetails " +
                               $"WHERE EmployeeID = '{EmployeeID_Selector_NumericUpDown.Value}';" +
                               "DELETE FROM Messages " +
                               $"WHERE EmployeeID = '{EmployeeID_Selector_NumericUpDown.Value}';" +
                               "DELETE FROM ContractedShifts " +
                               $"WHERE EmployeeID = '{EmployeeID_Selector_NumericUpDown.Value}';" +
                               "DELETE FROM OvertimeShifts " +
                               $"WHERE EmployeeID = '{EmployeeID_Selector_NumericUpDown.Value}';" +
                               "DELETE FROM PaySlips " +
                               $"WHERE EmployeeID = '{EmployeeID_Selector_NumericUpDown.Value}';";
                Database_Opperations_Class.Connect_Read_Write(Query, "write");

                // Shows a confirmation that the user has been removed
                MessageBox.Show($"User has been succesfuly deleted.");

                // Updates the Data grid view to show the updated list of employees
                Update_DataGrid_View();

                // Resets the ID selector the the default
                EmployeeID_Selector_NumericUpDown.Value = 1;

                // Makes the confirm password panel invisible again 
                Confirm_Password_Pnl.Visible = false;
                Confirm_Password_TxtBox.Text = "";
                Remove_Btn.Enabled = true;
            }
            else
            {
                // If the user's (the one adding the new user) password is incorrect an error message is displayed
                MessageBox.Show("Incorrect password Or invalid ID selected\nPlease try again.");
                Confirm_Password_TxtBox.Text = "";
            }
        }
        private void Update_DataGrid_View()
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

                // adds the employees id to the list of valid ID's
                EmployeeIDs += Results[x, 0];
            }
            // Set the DataSource of the DataGridView to the list of employee details
            Database_Users_GridView.DataSource = User_List;
            EmployeeID_Selector_NumericUpDown.Maximum = int.Parse(Results[(Results.GetLength(0) - 1), 0]);
        }
    }
}
