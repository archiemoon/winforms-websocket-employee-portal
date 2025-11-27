using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Shifts_Frm : Form
    {
        public int Shift_Loader_Start_Index;
        public int Shift_Loader_End_Index;
        public int Shift_Loader_Shift_Count;
        public string Selected_Day;
        public Shifts_Frm()
        {
            InitializeComponent();
        }
        private void Monday_Shifts_Btn_Click(object sender, EventArgs e)
        {
            Selected_Day = "Mon";
            TableLayoutPanel_Clear();
            Main_Control_Pnl.Visible = true;
            Initialize_Shift_Loader("Mon");
            Shift_Loader("Mon");
        }
        private void Tuesday_Shifts_Btn_Click(object sender, EventArgs e)
        {
            Selected_Day = "Tue";
            TableLayoutPanel_Clear();
            Main_Control_Pnl.Visible = true;
            Initialize_Shift_Loader("Tue");
            Shift_Loader("Tue");
        }
        private void Wednesday_Shifts_Btn_Click(object sender, EventArgs e)
        {
            Selected_Day = "Wed";
            TableLayoutPanel_Clear();
            Main_Control_Pnl.Visible = true;
            Initialize_Shift_Loader("Wed");
            Shift_Loader("Wed");
        }
        private void Thursday_Shifts_Btn_Click(object sender, EventArgs e)
        {
            Selected_Day = "Thu";
            TableLayoutPanel_Clear();
            Main_Control_Pnl.Visible = true;
            Initialize_Shift_Loader("Thu");
            Shift_Loader("Thu");
        }
        private void Friday_Shifts_Btn_Click(object sender, EventArgs e)
        {
            Selected_Day = "Fri";
            TableLayoutPanel_Clear();
            Main_Control_Pnl.Visible = true;
            Initialize_Shift_Loader("Fri");
            Shift_Loader("Fri");
        }
        private void Saturday_Shifts_Btn_Click(object sender, EventArgs e)
        {
            Selected_Day = "Sat";
            TableLayoutPanel_Clear();
            Main_Control_Pnl.Visible = true;
            Initialize_Shift_Loader("Sat");
            Shift_Loader("Sat");
        }
        private void Sunday_Shifts_Btn_Click(object sender, EventArgs e)
        {
            Selected_Day = "Sun";
            TableLayoutPanel_Clear();
            Main_Control_Pnl.Visible = true;
            Initialize_Shift_Loader("Sun");
            Shift_Loader("Sun");
        }
        private void Shifts_Frm_Load(object sender, EventArgs e)
        {
        }
        private void TableLayoutPanel_Clear()
        {
            foreach (Control control in Shift_View_Tbl.Controls)
            {
                // Clear the text of all controls
                control.Text = "";

                // Check if the control is a button
                if (control is Button)
                {
                    control.Enabled = false;
                }
            }
        }
        private void Initialize_Shift_Loader(string Day)
        {
            string Query = "SELECT OvertimeShiftID, Date, Day, StartTime, Hours " +
                           "FROM OvertimeShifts " +
                           $"WHERE EmployeeID IS NULL AND Day = '{Day}'";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");
            Shift_Loader_Shift_Count = Results.GetLength(0) - 1;

            // Decides weather we can load all of the shifts as there is 10 or less
            if (Shift_Loader_Shift_Count <= 9)
            {
                Shift_Loader_Start_Index = 0;
                Shift_Loader_End_Index = Shift_Loader_Shift_Count;
                Page_Down_Btn.Enabled = false;
                Page_Up_Btn.Enabled = false;
            }
            // or weather we load the first just 10
            else
            {
                Shift_Loader_Start_Index = 0;
                Shift_Loader_End_Index = 9;
                Page_Down_Btn.Enabled = true;
            }
        }
        private void Shift_Loader(string Day)
        {
            // Selects the Day Date start time and hours from the overtimeshifts table where no employeeID has been specified
            string Query = "SELECT OvertimeShiftID, Date, Day, StartTime, Hours " +
                           "FROM OvertimeShifts " +
                           $"WHERE EmployeeID IS NULL AND Day = '{Day}'";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

            List<string> Shift_Details = new List<string>();

            int i = 0;

            for (int x = Shift_Loader_Start_Index; x <= Shift_Loader_End_Index;  x++)
            {
                // Gets the integer value of the time
                int Hours = (int)double.Parse(Results[x, 3]);

                // Gets the decimal value of the time
                double DecimalPart = double.Parse(Results[x, 3]) - Hours;

                // Calculate minutes from the decimal value
                int Minutes = (int)(DecimalPart * 60);

                // Formats the hours and minutes into HH:mm format
                string FormattedTime = string.Format("{0:00}:{1:00}", Hours, Minutes);

                // Adds the database fields and the formatted time into the list
                Shift_Details.Add($"{Results[x, 1]} | {Results[x, 2]} | Start Time: {FormattedTime} | {Results[x, 4]} Hours");

                Label Label = (Label)Shift_View_Tbl.GetControlFromPosition(0, i);
                Button Button = (Button)Shift_View_Tbl.GetControlFromPosition(1, i);

                Label.Text = Shift_Details[i];

                Button.Tag = Results[x, 0];
                Button.Enabled = true;

                // Update button Text and handle the click event
                Button.Text = "Accept";
                Button.Click += (sender, e) =>
                {
                    // Get the shift ID from the Tag property of the button
                    string shiftID = Button.Tag.ToString();

                    // Selects the EmployeeID from the OvertimeShifts table Where the shiftID is equal to the one chosen
                    Query = "SELECT EmployeeID " +
                                   "FROM OvertimeShifts " +
                                   $"WHERE OvertimeShiftID = {shiftID}";
                    Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");
                    if (Results[0, 0] == "")
                    {
                        MessageBox.Show("Accepted");

                        // Update the shift in the database using the shiftID
                        Query = "UPDATE OvertimeShifts " +
                                       $"SET EmployeeID = {LoginInfo.EmployeeID} " +
                                       $"WHERE OvertimeShiftID = {shiftID}";
                        Database_Opperations_Class.Connect_Read_Write(Query, "write");

                        Main_Control_Pnl.Visible = false;
                    }
                };
                i++;
            }
        }
        private void Page_Down_Btn_Click(object sender, EventArgs e)
        {
            Page_Up_Btn.Enabled = true;
            Page_Down_Btn.Enabled = false;
            // Loads the second set of 10
            Shift_Loader_Start_Index = 10;
            Shift_Loader_End_Index = Shift_Loader_Shift_Count;
            TableLayoutPanel_Clear();
            Shift_Loader(Selected_Day);
        }
        private void Page_Up_Btn_Click(object sender, EventArgs e)
        {
            Page_Down_Btn.Enabled = true;
            Page_Up_Btn.Enabled = false;
            // Loads the first 10
            Shift_Loader_Start_Index = 0;
            Shift_Loader_End_Index = 9;
            TableLayoutPanel_Clear();
            Shift_Loader(Selected_Day);
        }
    }
}
