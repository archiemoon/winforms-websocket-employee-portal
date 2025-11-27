namespace Moon_Archie_Winforms_NEA
{
    internal class Employee_Search_Details
    {
        public string EmployeeID { get; }
        public string FirstName { get; }
        public string Surname { get; }
        public string Email { get; }
        public string PhoneNumber { get; }

        public Employee_Search_Details(string EmployeeID, string FirstName, string Surname, string Email, string PhoneNumber)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }
    }
}
