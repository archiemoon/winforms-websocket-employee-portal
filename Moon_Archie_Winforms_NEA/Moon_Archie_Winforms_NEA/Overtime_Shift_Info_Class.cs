namespace Moon_Archie_Winforms_NEA
{
    internal class Overtime_Shift_Info_Class
    {
        public string EmployeeID { get; }
        public string Day { get; }
        public string Start_Time { get; }
        public string Hours { get; }

        public Overtime_Shift_Info_Class(string EmployeeID, string Day, string Start_Time, string Hours)
        {
            this.EmployeeID = EmployeeID;
            this.Day = Day;
            this.Start_Time = Start_Time;
            this.Hours = Hours;
        }
    }
}
