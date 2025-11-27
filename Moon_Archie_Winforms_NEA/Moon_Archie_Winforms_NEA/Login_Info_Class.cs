namespace Winforms
{
    internal class LoginInfo
    {
        //database info stored at login
        public static string EmployeeID { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Salt { get; set; }
        public static string First_Name { get; set; }
        public static string Surname { get; set; }
        public static string Email { get; set; }
        public static string PhoneNumber { get; set; }
        public static string Permissions { get; set; }
    }
}
