using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Upload_Shifts_Frm : Form
    {
        public Upload_Shifts_Frm()
        {
            InitializeComponent();
        }

        private void Upload_Shifts_Frm_Load(object sender, EventArgs e)
        {
            Update_Database_View();
        }
        private void Update_Database_View()
        {
            string Query = "SELECT EmployeeID, Day, StartTime, Hours " +
                           "FROM OvertimeShifts " +
                           "WHERE EmployeeID IS NULL";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

            // List to store instances of a custom class containing the shifts details
            List<Overtime_Shift_Info_Class> Shifts_List = new List<Overtime_Shift_Info_Class>();
            for (int x = 0; x < Results.GetLength(0); x++)
            {
                // Create a new Overtime_Shift_Info object and adds it to the list
                Shifts_List.Add(new Overtime_Shift_Info_Class(Results[x, 0], Results[x, 1], Results[x, 2], Results[x, 3]));
            }
            // Set the DataSource of the DataGridView to the list of the shifts details
            Current_Shifts_DataGridView.DataSource = Shifts_List;
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            // Delets all the shifts from the database
            string Query = "DELETE FROM OvertimeShifts ";
            Database_Opperations_Class.Connect_Read_Write(Query, "write");
            Update_Database_View();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            // Formatts all the data so its ready for the database
            string Selected_Day_Time = Date_Time_Picker.Value.ToString("ddd HH:mm");
            
            string[] Day_Time = Selected_Day_Time.Split(' ');        
            string Time = Day_Time[1];

            string[] Time_Parts = Time.Split(':');
            int hours = int.Parse(Time_Parts[0]);
            int minutes = int.Parse(Time_Parts[1]);

            decimal Hours = Hours_NumericUpDown.Value;

            // stores the formatted inputs
            string Selected_Hours = Hours.ToString("0.0").TrimEnd('0').TrimEnd('.');
            string Selected_Time = (hours + (minutes / 60.0)).ToString();
            string Selected_Day = Day_Time[0];

            // Adds the shift to the database
            string Query = "INSERT INTO OvertimeShifts (Hours, Day, StartTime, Date) " +
                               $"VALUES ('{Selected_Hours}', '{Selected_Day}', '{Selected_Time}', '{Date_Time_Picker.Value.ToString().Substring(0, Date_Time_Picker.Value.ToString().Length - 12)}')";
            Database_Opperations_Class.Connect_Read_Write(Query, "write");

            Update_Database_View();
        }
    }
}
