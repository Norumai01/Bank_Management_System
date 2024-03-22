using Bank_Management_System_v2;
using System;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static public void Main()
    {
        BankAccount User_Session = new BankAccount();
        string connectionString = "Data Source=DESKTOP-7SAD67L\\SQLEXPRESS;Initial Catalog=Bank_System;Integrated Security=True;Encrypt=False";

        User_Session.LoginInfo(connectionString);
        Console.WriteLine(User_Session.AccID); // Test
    }
}
