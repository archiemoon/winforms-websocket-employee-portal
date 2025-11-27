using System;

namespace Moon_Archie_Winforms_NEA
{
    public class Database_Opperations_Class
    {
        public static string[,] Connect_Read_Write(string Query, string Opperation)
        {
            DBSQLite_Class.DBSQLite_Class db = new DBSQLite_Class.DBSQLite_Class(@"data source = MainDatabase.db");
            if (Opperation.ToLower() == "write")
            {
                db.UpdateInsertDeleteRecords(Query);
                string[,] Null_Return = { };
                return Null_Return;
            }
            else if (Opperation.ToLower() == "read")
            {
                string[,] results = db.GetRecords(Query);
                return results;
            }
            else { throw new Exception(); }
        }
    }
}
