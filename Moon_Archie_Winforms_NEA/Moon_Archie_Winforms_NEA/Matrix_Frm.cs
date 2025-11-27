using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Matrix_Frm : Form
    {
        // Constants defininf grid dimensions and global string
        private const int NumColumns = 33;
        private const int ColumnWidth = 20;
        private const int FirstColumnWidth = 55;
        private int NumRows = 0;

        private string SelectedDay = "";
        private string StringToSave = "";

        public Matrix_Frm()
        {
            InitializeComponent();
        }

        private TextBox[,] TextBoxes;

        private void Matrix_Frm_Load(object sender, EventArgs e)
        {
        }

        private void CreateDynamicGrid(int rows)
        {
            Random random = new Random();

            NumRows = rows;

            // The 2D array of TextBoxes that holds the grid
            TextBoxes = new TextBox[NumColumns, NumRows];

            // Loops through each row 
            for (int row = 0; row < NumRows; row++)
            {
                string generatedString = "";
                if (CheckForSavedRota(SelectedDay) == true)
                {
                    // if no rota is saved in the databse we generate a new string for each row
                    generatedString = GenerateString(random);
                    StringToSave = StringToSave + ":" + generatedString;
                }
                else
                {
                    // if there is a saved rota we get each rows string from the database
                    string Query = "SELECT Rota " +
                                   "FROM DailyRotas " +
                                   $"WHERE Day = '{SelectedDay}'";
                    string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");
                    string Rota = Results[0, 0];

                    string[] substrings = Rota.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                    generatedString = substrings[row];
                }
                // Loops through each column
                for (int col = 0; col < NumColumns; col++)
                {
                    // Calculates the x-coordinate based on the index of the column 
                    // This is as the first column will have larger text boxes meaning the second column will need to be adjusted acordingly
                    int xCoordinate = col == 0 ? col * FirstColumnWidth : FirstColumnWidth + col * ColumnWidth;

                    // Creates a new text box
                    TextBox textBox = new TextBox
                    {
                        // Sets the size based on weather its the first column or not 
                        Size = new Size(col == 0 ? FirstColumnWidth : ColumnWidth, 0),

                        // Sets the location of each text box 
                        Location = new Point(xCoordinate, (row * 21) + 20),

                        // Sets the name for each text box with the x and y coordinates
                        Name = $"TextBox_{col}_{row}",
                    };
                    Controls.Add(textBox);

                    // Stores it in the 2D array so it can be manipulated if needed
                    TextBoxes[col, row] = textBox;
                    ChangeTextOfTextBox(col, row, generatedString[col].ToString());
                }
            }
        }
        private void ChangeTextOfTextBox(int col, int row, string newText)
        {
            // Makes sure the column and row entered wont throw an index error
            if (col >= 0 && col < NumColumns && row >= 0 && row < NumRows)
            {
                // Sets the text of the specified text box in the 2D array to the given text
                TextBoxes[col, row].Text = newText;
            }
        }
        private void ChangeBackColorOfTextBox(int col, int row, Color newColor)
        {
            if (col >= 0 && col < NumColumns && row >= 0 && row < NumRows)
            {
                TextBoxes[col, row].BackColor = newColor;
            }
        }
        private void Load_Employee_Names_and_Generate(string Day)
        {
            // Selects the firstname from the given employeeID that is ascociated with all shifts, overtime and contracted, on a given day 
            string Query = "SELECT EmployeeDetails.FirstName " +
                           "FROM EmployeeDetails " +
                           "JOIN ContractedShifts ON EmployeeDetails.EmployeeID = ContractedShifts.EmployeeID " +
                           $"WHERE ContractedShifts.Day = '{Day}' " +
                           "UNION ALL " +
                           "SELECT EmployeeDetails.FirstName " +
                           "FROM EmployeeDetails " +
                           "JOIN OvertimeShifts ON EmployeeDetails.EmployeeID = OvertimeShifts.EmployeeID " +
                           $"WHERE OvertimeShifts.Day = '{Day}'";
            string[,] results = Database_Opperations_Class.Connect_Read_Write(Query, "Read");

            CreateDynamicGrid(results.Length);

            for (int i = 0; i < results.Length; i++)
            {
                // Calls the change text function for the text boxes in the first column and sets them to the name of the employee
                ChangeTextOfTextBox(0, i, results[i, 0]);
            }
        }
        private void BlockOut_TextBoxes(string Day)
        {
            // The query that selects the start time and ammount of hours for every shift on a given day
            string Query = "SELECT StartTime, Hours " +
                           "FROM ContractedShifts " +
                           $"WHERE Day = '{Day}' " +
                           "UNION ALL " +
                           "SELECT StartTime, Hours " +
                           "FROM OvertimeShifts " +
                           $"WHERE Day = '{Day}'";
            string[,] results = Database_Opperations_Class.Connect_Read_Write(Query, "Read");

            // Loops through each row in the results array
            for (int i = 0; i < results.GetLength(0); i++)
            {
                // Calculates the value for the starting index for each shift based off the start time
                // Performs: ( Start time - Earliest start time ) * 2 to get the apropriate index
                double StartIndex = (double.Parse(results[i, 0]) - 6.5) * 2;

                results[i, 0] = StartIndex.ToString();

                // Calculates the end index for the shift
                // Each index (box) is 30 mins worth so the end is start index (calculated above) + (number of hours * 2)
                StartIndex = (double.Parse(results[i, 0]) + (double.Parse(results[i, 1])) * 2) + 1;

                results[i, 1] = StartIndex.ToString();

            }
            // Loops through each row in the results array
            for (int i = 0; i < results.GetLength(0); i++)
            {
                // Sets the boxes from index 0 to the start index to DarkGrey
                for (int j = 1; j <= int.Parse(results[i, 0]); j++)
                {
                    ChangeBackColorOfTextBox(j, i, Color.DarkGray);
                    ChangeTextOfTextBox(j, i, "");
                }
                // Sets the boxes from the end index to the final index to DarkGrey
                for (int k = int.Parse(results[i, 1]); k <= 32; k++)
                {
                    ChangeBackColorOfTextBox(k, i, Color.DarkGray);
                    ChangeTextOfTextBox(k, i, "");
                }
            }
        }
        private void ClearGrid()
        {
            List<TextBox> textBoxList = new List<TextBox>();

            foreach (Control control in Controls)
            {
                // Check if the control is a text box
                TextBox textBox = control as TextBox;
                if (textBox != null)
                {
                    // If it is it adds it to our list
                    textBoxList.Add(textBox);
                }
            }
            // Loops through each textbox in the list 
            foreach (var textBox in textBoxList)
            {
                // Removes the text box from the controls and UI
                Controls.Remove(textBox);

                // Disposes of any additional resources used by the text box
                textBox.Dispose();
            }
        }
        public string GenerateString(Random random)
        {
            char[] characters = { '0', '1', '5', '6' };
            string result = "";

            for (int i = 0; i < 33; i++)
            {
                char nextChar;

                // If the previous two characters were non-zero numbers, the next character must be '0'
                if (i >= 3 && result[i - 1] != '0' && result[i - 2] != '0' && result[i - 3] != '0')
                {
                    nextChar = '0';
                }
                else
                {
                    nextChar = characters[random.Next(characters.Length)];
                }

                // Ensure there are no consecutive identical numbers
                if (i > 0 && result[i - 1] == nextChar)
                {
                    // Generate a new character until it's different from the previous one
                    while (result[i - 1] == nextChar)
                    {
                        nextChar = characters[random.Next(characters.Length)];
                    }
                }

                // Append the character to the result
                result += nextChar;
            }

            return result;
        }
        public bool CheckForSavedRota(string Day)
        {
            // Selects the count from the database entered when the function is called
            string Query = "SELECT Rota " +
                           "FROM DailyRotas " +
                           $"WHERE Day = '{Day}'";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

            // Checks if the count returned is 0
            if (string.IsNullOrEmpty(Results[0, 0]))
            {
                // Returns true if count is 0
                return true;
            }
            // Returns true if count is more than 0
            else { return false; }
        }
        private void MakeButtonsVisible()
        {
            Save_Btn.Visible = true;
            ReGenerate_Btn.Visible = true;
            Time_Title_Pnl.Visible = true;
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (StringToSave != "")
            {
                // if there is a rota to save we save it to the database and then reset it so we know there is a saved one
                string Query = "UPDATE DailyRotas " +
                               $"SET Rota = '{StringToSave}' " +
                               $"WHERE Day ='{SelectedDay}'";
                Database_Opperations_Class.Connect_Read_Write(Query, "write");
                StringToSave = "";
            }
            else
            {
                MessageBox.Show("The current rota is already saved.");
            }
        }

        private void ReGenerate_Btn_Click(object sender, EventArgs e)
        {
            // deletes any saved rotas on the selected day
            string Query = "UPDATE DailyRotas " +
                           "SET Rota = NULL " +
                           $"WHERE day = '{SelectedDay}'";
            Database_Opperations_Class.Connect_Read_Write(Query, "write");

            // generates a new grid or random numbers
            ClearGrid();
            Load_Employee_Names_and_Generate(SelectedDay);
            BlockOut_TextBoxes(SelectedDay);
        }

        private void Monday_Matrix_Btn_Click(object sender, EventArgs e)
        {
            SelectedDay = "Mon";
            StringToSave = "";
            MakeButtonsVisible();
            ClearGrid();
            Load_Employee_Names_and_Generate(SelectedDay);
            BlockOut_TextBoxes(SelectedDay);
        }
        private void Tuesday_Matrix_Btn_Click(object sender, EventArgs e)
        {
            SelectedDay = "Tue";
            StringToSave = "";
            MakeButtonsVisible();
            ClearGrid();
            Load_Employee_Names_and_Generate(SelectedDay);
            BlockOut_TextBoxes(SelectedDay);
        }
        private void Wednesday_Matrix_Btn_Click(object sender, EventArgs e)
        {
            SelectedDay = "Wed";
            StringToSave = "";
            MakeButtonsVisible();
            ClearGrid();
            Load_Employee_Names_and_Generate(SelectedDay);
            BlockOut_TextBoxes(SelectedDay);
        }
        private void Thursday_Matrix_Btn_Click(object sender, EventArgs e)
        {
            SelectedDay = "Thu";
            StringToSave = "";
            MakeButtonsVisible();
            ClearGrid();
            Load_Employee_Names_and_Generate(SelectedDay);
            BlockOut_TextBoxes(SelectedDay);
        }
        private void Friday_Matrix_Btn_Click(object sender, EventArgs e)
        {
            SelectedDay = "Fri";
            StringToSave = "";
            MakeButtonsVisible();
            ClearGrid();
            Load_Employee_Names_and_Generate(SelectedDay);
            BlockOut_TextBoxes(SelectedDay);
        }
        private void Saturday_Matrix_Btn_Click(object sender, EventArgs e)
        {
            SelectedDay = "Sat";
            StringToSave = "";
            MakeButtonsVisible();
            ClearGrid();
            Load_Employee_Names_and_Generate(SelectedDay);
            BlockOut_TextBoxes(SelectedDay);
        }
        private void Sunday_Matrix_Btn_Click(object sender, EventArgs e)
        {
            SelectedDay = "Sun";
            StringToSave = "";
            MakeButtonsVisible();
            ClearGrid();
            Load_Employee_Names_and_Generate(SelectedDay);
            BlockOut_TextBoxes(SelectedDay);
        }
    }
}
