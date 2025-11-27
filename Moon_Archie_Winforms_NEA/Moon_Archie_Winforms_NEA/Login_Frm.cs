using System;
using System.Windows.Forms;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Login_Frm : Form
    {
        public int attempts = 0;
        public Login_Frm()
        {
            InitializeComponent();
        }
        private void Login_Frm_Load(object sender, EventArgs e)
        {
        }
        private void Password_Reset_PopUp_Lbl_Click(object sender, EventArgs e)
        {
            // shows the password reset prompt label
            Password_Reset_Info_Lbl.Visible = true;
        }
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if (attempts == 5)
            {
                MessageBox.Show("You have reached the maximun number of login attempts.");
                Username_TxtBox.Text = "";
                Password_TxtBox.Text = "";
            }
            else
            {
                // stores the entered details in variables
                string username = Username_TxtBox.Text;
                string password = Password_TxtBox.Text;

                // selects the count of how many entries in the database match the username and password entered 
                DBSQLite_Class.DBSQLite_Class db = new DBSQLite_Class.DBSQLite_Class(@"data source = MainDatabase.db");
                string query = "SELECT Count(*) FROM EmployeeDetails " +
                               "WHERE Username = '" + username + "'";
                string[,] results = db.GetRecords(query);

                query = "SELECT EmployeeID, FirstName, Surname, Username, Password, Salt, Email, PhoneNumber, Permission " +
                        "FROM EmployeeDetails " +
                        "WHERE Username = '" + username + "'";
                string[,] UserInfo = db.GetRecords(query);

                if (int.Parse(results[0, 0]) > 0 && password != "" && username != "")
                {
                    if (Password_Hasher_Class.VerifyPassword(password, UserInfo[0, 5], UserInfo[0, 4]) == true)
                    {
                        LoginInfo.EmployeeID = UserInfo[0, 0];
                        LoginInfo.First_Name = UserInfo[0, 1];
                        LoginInfo.Surname = UserInfo[0, 2];
                        LoginInfo.Username = UserInfo[0, 3];
                        LoginInfo.Password = UserInfo[0, 4];
                        LoginInfo.Salt = UserInfo[0, 5];
                        LoginInfo.Email = UserInfo[0, 6];
                        LoginInfo.PhoneNumber = UserInfo[0, 7];
                        LoginInfo.Permissions = UserInfo[0, 8];

                        Main_WindowToolbar Main_WindowToolbar = new Main_WindowToolbar();
                        this.Hide();
                        Main_WindowToolbar.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Login Failed - Please try again.");
                        Username_TxtBox.Text = "";
                        Password_TxtBox.Text = "";
                        attempts++;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Login Failed - Please try again.");
                    Username_TxtBox.Text = "";
                    Password_TxtBox.Text = "";
                    attempts++;
                    return;
                }
            }           
        }
        private void showPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword_CheckBox.Checked == true)
            {
                Password_TxtBox.UseSystemPasswordChar = false;
            }
            else
            {
                Password_TxtBox.UseSystemPasswordChar = true;
            }
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
