using System.Data.SQLite;

namespace DBSQLite_Class
{

    internal class DBSQLite_Class
    {
        //Private attribute of the class to store the connection string.
        //Will be initialised when the constructor is called
        private string connString = "";

        //Class constructor
        public DBSQLite_Class(string connString)
        {
            //Assign the passed in string to the private attribute of the class connString
            //This string could be stored in the App.config (win form) or Web.config (web)
            //file of the project and referenced from there

            this.connString = connString;
        }
        //This method takes an sql statement and returns a 2d arrray to the calling procedure
        //which is populated with a data set that represents the results of the sql statement
        public string[,] GetRecords(string sqlString)
        {
            SQLiteConnection con = new System.Data.SQLite.SQLiteConnection(connString);

            con.Open();  // Open the connection to the database

            SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(sqlString, con);

            SQLiteDataReader reader = com.ExecuteReader();

            //Calling the FieldCount attribute of the reader object to get the number of 
            //columns/fields/attributes returned from the sql query
            int col_count = reader.FieldCount;
            //row_count will be used in the while loop to determine the number of records
            int row_count = 0;

            while (reader.Read())
            {
                //counting the number of rows/records returned
                row_count = row_count + 1;
            }
            reader.Close();

            //This 2 dimensional array is being initialised with the number of rows and columns
            //needed to store the results of the query
            string[,] records = new string[row_count, col_count];

            //Execute the sql again
            reader = com.ExecuteReader();

            int count = 0;

            //Loop through the reader and pupulate 2d array with the data set
            while (reader.Read())
            {
                for (int x = 0; x < col_count; x++)
                {
                    records[count, x] = reader.GetValue(x).ToString();
                }
                count++;
            }

            //close the reader and conn object
            reader.Close();
            con.Close();

            //return the the 2d array to the calling procedure
            return records;

        }

        //This method takes an sql (insert, update, delete) statement that modifies a table
        //and returns the number of rows/records affected to the calling procedure
        public bool UpdateInsertDeleteRecords(string sqlString)
        {
            bool success = false;
            System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection(connString);
            System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con);
            con.Open();  // Open the connection to the database

            com.CommandText = sqlString;
            com.ExecuteNonQuery();

            con.Close();
            success = true;
            return success;
        }
    }

}
