using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Home_Frm : Form
    {
        public Home_Frm()
        {
            InitializeComponent();
        }

        // Summary: Loads data from the appropriate databases into the widget panels
        private void Home_Frm_Load(object sender, EventArgs e)
        {
            // Checks if any of the databases are empty
            // If they arent empty then we can call the appropriate loader
            if (DatabaseIsEmpty("PaySlips")) {}
            else { PaySlip_Window_Loader(); }

            if (DatabaseIsEmpty("Messages")) {}
            else { Message_Loader(); }

            if (DatabaseIsEmpty("OvertimeShifts")) {}
            else { Shift_Loader(); }
        }

        // Summary: Function that checks if a database is empty
        // Parameters: string "DatabaseName"
        // Returns: Bool (true/false)
        private bool DatabaseIsEmpty(string DatabaseName)
        {
            // Selects the count from the database entered when the function is called
            string Query = "SELECT COUNT(*) " +
                           $"FROM {DatabaseName}";
            // Calls the Database_Opperations_Class to execute the query
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "Read");

            // Checks if the count returned is 0
            if (int.Parse(Results[0, 0]) == 0)
            {
                // Returns true if count is 0
                return true;
            }
            // Returns true if count is more than 0
            else {  return false; }
        }

        // Summary: Loads the data from the payslips table in the database
        private void PaySlip_Window_Loader()
        {
            // Emptys any text from the text box
            Payslip_TxtBox.Text = "";

            // Selects the count from the payslips table where the employeeID is the same as the logged in user
            string query = "SELECT Count(*) " +
                           "FROM PaySlips " +
                           $"WHERE EmployeeID = '{LoginInfo.EmployeeID}'";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(query, "Read");
            int Count = int.Parse(Results[0, 0]);

            // Selects every field from the payslips table where the employeeID is the same as the logged in user
            query = "SELECT * " +
                    "FROM PaySlips " +
                    $"WHERE EmployeeID = '{ LoginInfo.EmployeeID}'";
            Results = Database_Opperations_Class.Connect_Read_Write(query, "Read");

            // Loops for the count of the number of rows in the table
            for (int x = 0; x < Count; x++)
            {
                // Formats all the data and adds it to the text box
                Payslip_TxtBox.Text = $"{Results[x, 1]} . {Results[x, 2]} . {Results[x, 3]} . {Results[x, 4]} . {Results[x, 5]} Hours \n\n{Payslip_TxtBox.Text}";
            }
        }

        // Summary: Loads the data from the messages table in the database
        private void Message_Loader()
        {
            // Selects the number of messages in the database
            string Query = "SELECT Count(*) " +
                           "FROM Messages";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

            // Creates an int to store how many times the loader will need to be looped and the index to start at
            int Loop_Count = 0;
            int Start_Index = 0;

            // Creates a string with the messages to add from the database
            string Messages_To_add = "";

            // If the count minus 9 >= 0, this means that there are more than 10 messages to load
            if (int.Parse(Results[0, 0]) - 9 >= 0)
            {            
                // The loop count is then set to 10 as we load 10 messages at a time 
                Loop_Count = 10;

                // The start index is set to the count - 10 (as the index value is always 1 less as it starts from 0)
                Start_Index = int.Parse(Results[0, 0]) - 10;
            }
            // If there are less than 10 messages 
            // We need to work out how many times to loop to avoid an index error
            else
            {
                // Loop count is set to the number of rows in the database
                Loop_Count = int.Parse(Results[0, 0]);

                // The start index is set to 0
                Start_Index = 0;
            }

            // Selects the message and employee name
            // From the employeeID of that message and stores them in a 2D array
            Query = "SELECT EmployeeDetails.FirstName, Messages.Message " +
                           "FROM Messages " +
                           "JOIN EmployeeDetails ON Messages.EmployeeId = EmployeeDetails.EmployeeId;";
            Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

            // Loops from x = 0 to x = Loop_Count
            for (int x = 0; x < Loop_Count; x++)
            {
                // Checks if the Name is the same as the name of the user 
                if (Results[Start_Index, 0] == LoginInfo.First_Name)
                {
                    // The message is added to string of all messages to add (You: 'Message')
                    Messages_To_add = $"{Messages_To_add} You: {Results[Start_Index, 1]} \n\n";
                }
                else
                {
                    // The message is added to string of all messages to add (Employee Name: 'Message')
                    Messages_To_add = $"{Messages_To_add} {Results[Start_Index, 0]}: {Results[Start_Index, 1]}\n\n";
                }
                // The index count is incrimented
                Start_Index++;
            }
            // The messages to add are added at the top of the text box
            Messages_RichTxtBox.Text = Messages_To_add + Messages_RichTxtBox.Text;
        }

        //Summary: Loads the data from the OvertimeShifts table in the database
        private void Shift_Loader()
        {
            // Initializes a new list to hold the details of a shift
            List<string> Shift_Details = new List<string>();

            // Selects the Day Date start time and hours from the overtimeshifts table where no employeeID has been specified
            string Query = "SELECT OvertimeShiftID, Date, Day, StartTime, Hours " +
                           "FROM OvertimeShifts " +
                           "WHERE EmployeeID IS NULL";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

            // An integer i is set to 0 so we can incriment the indexes
            int i = 0;

            // Loops for x = (Number of rows in database - 1) to x = (length - 6), so it loops 5 times.
            for (int x = Results.GetLength(0) - 1; x > (Results.GetLength(0) - 6) && x >= 0; x--)
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

                // Access' the label and button in the current row i
                Label Label = (Label)Shift_View_Tbl.GetControlFromPosition(0, i);
                Button Button = (Button)Shift_View_Tbl.GetControlFromPosition(1, i);

                // Updates the label with the string from the list
                Label.Text = Shift_Details[i];

                // Set the Tag property of the button to the shift ID
                Button.Tag = Results[x, 0];

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
                    // Execute the query to update the shift
                    Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");
                    if (Results[0, 0] == "")
                    {
                        MessageBox.Show("Accepted");

                        // Update the shift in the database using the shiftID
                        Query = "UPDATE OvertimeShifts " +
                                       $"SET EmployeeID = {LoginInfo.EmployeeID} " +
                                       $"WHERE OvertimeShiftID = {shiftID}";

                        // Execute the query to update the shift
                        Database_Opperations_Class.Connect_Read_Write(Query, "write");

                        Button.Text = "";
                        Label.Text = "Empty Shift";
                    }
                    else
                    {
                        MessageBox.Show("This shift has already been taken.\nPlease refresh this page to see updated view.");
                    }
                };
                // i is incrimented
                i++;
            }
        }
    }
}