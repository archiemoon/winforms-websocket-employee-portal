using System;
using System.Windows.Forms;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class PaySlip_Window : Form
    {
        public PaySlip_Window()
        {
            InitializeComponent();
        }

        private void PaySlip_Window_Load(object sender, EventArgs e)
        {
            Site_CheckBox.CheckOnClick = false;
            Template_CheckBox.CheckOnClick = false;
            Position_CheckBox.CheckOnClick = false;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            // checks if all the fields are in the correct format
            bool Hours_Is_Double;
            try
            {
                double.Parse(Hours_Worked_TxtBox.Text);
                Hours_Is_Double = true;
            }
            catch
            {
                Hours_Is_Double = false;
            }
            if (Position_CheckBox.SelectedIndex.ToString() == "-1" || Template_CheckBox.SelectedIndex.ToString() == "-1" || Site_CheckBox.SelectedIndex.ToString() == "-1" || Hours_Is_Double != true)
            {
                MessageBox.Show("This doesnt look right,\nPlease fill in all fields correctly.");
            }
            else
            {
                Confirm_Password_Pnl.Visible = true;
            }
        }

        private void Confirm_Password_Btn_Click(object sender, EventArgs e)
        {
            // makes the user enter their password in order to be able to submit the payslip
            string password = Confirm_Password_TxtBox.Text;
            if (Password_Hasher_Class.VerifyPassword(password, LoginInfo.Salt, LoginInfo.Password))
            {
                Submit_Btn.Enabled = true;
                Confirm_Password_TxtBox.Text = "";
                Confirm_Password_Btn.Visible = false; Confirm_Password_Lbl.Visible = false; Confirm_Password_TxtBox.Visible = false;
            }
            else
            {
                // shows an error message if they get the password wrong
                MessageBox.Show("Incorrect password; Please try again.");
                Confirm_Password_TxtBox.Text = "";
            }
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            // gets each of the selected fields from the radio buttons
            string Position;
            if (Position_CheckBox.SelectedIndex.ToString() == "0") { Position = "Lifeguard"; }
            else { Position = "Swim School Assistant Instructor"; }

            string Template;
            if (Template_CheckBox.SelectedIndex.ToString() == "0") { Template = "Casual"; }
            else { Template = "Contracted"; }

            string Site;
            if (Site_CheckBox.SelectedIndex.ToString() == "0") { Site = "Splashpoint"; }
            else { Site = "Wadurs"; }

            // adds the payslip to the database
            DBSQLite_Class.DBSQLite_Class db = new DBSQLite_Class.DBSQLite_Class(@"data source = MainDatabase.db");
            string query = "INSERT INTO PaySlips (EmployeeID, Date, Position, Template, Site, HoursWorked) " +
                           "VALUES ('" + LoginInfo.EmployeeID + "', '" + Date_Picker.Text + "', '" + Position +"', '" + Template +"', '" + Site +"', '" + Hours_Worked_TxtBox.Text + "');";
            db.UpdateInsertDeleteRecords(query);

            // Clear all the fields and makes the submit button invisible
            ClearFields();
            Submit_Btn.Visible = false;
        }
        private void ClearFields()
        {
            Hours_Worked_TxtBox.Text = "";
            Position_CheckBox.SelectedIndex = -1;
            Template_CheckBox.SelectedIndex = -1;
            Site_CheckBox.SelectedIndex = -1;
        }
        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
