using System;
using System.Windows.Forms;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Pay_Calculator_Frm : Form
    {
        PaySlip_Window PaySlip_Window = new PaySlip_Window();

        public Pay_Calculator_Frm()
        {
            InitializeComponent();
        }

        private void new_Payslip_Btn_Click(object sender, EventArgs e)
        {
            // adds the new payslip form into the mini window
            PaySlip_Window.SendToBack();
            PaySlip_Window.BringToFront();
            PaySlip_Window.Show();
        }

        private void Pay_Calculator_Frm_Load(object sender, EventArgs e)
        {
            Payslip_TxtBox.Text = "";
            DBSQLite_Class.DBSQLite_Class db = new DBSQLite_Class.DBSQLite_Class(@"data source = MainDatabase.db");
            string query = "SELECT Count(*) " +
                           "FROM PaySlips " +
                           "WHERE EmployeeID = '" + LoginInfo.EmployeeID + "'";
            string[,] results = db.GetRecords(query);
            int count = int.Parse(results[0, 0]);

            query = "SELECT * " +
                    "FROM PaySlips " +
                    "WHERE EmployeeID = '" + LoginInfo.EmployeeID + "'";
            results = db.GetRecords(query);

            // gets all the data from the database and formats it into a string showing the details of each payslip
            for (int x = 0; x < count; x++)
            {
                Payslip_TxtBox.Text = results[x, 1] + " . " + results[x, 2] + " . " + results[x, 3] + " . " + results[x, 4] + " . " + results[x, 5] + " Hours \n\n" + Payslip_TxtBox.Text;
            }

            PaySlip_Window.TopLevel = false;
            Payslip_View_Pnl.Controls.Add(PaySlip_Window);
        }
    }
}
