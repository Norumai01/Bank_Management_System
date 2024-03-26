using Bank_Management_System_v2;
using System;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static public void InterfaceMenu(BankAccount currentSession, string input)
    {
        string userInput = input.ToLower();

        if (userInput == "deposit")
        {
            currentSession.Deposit();
        }
        else if (userInput == "withdraw")
        {
            currentSession.Withdraw();
        }
        else if (userInput == "transfer")
        {
            currentSession.Transfer();
        }
        else if (userInput == "transaction history")
        {
            currentSession.ViewTransactionHistory();
        }
        else
        {
            Console.WriteLine("Wrong Input. Please type valid input.");
        }
    }
    static public void ViewMenu()
    {
        Console.WriteLine("Deposit");
        Console.WriteLine("Withdraw");
        Console.WriteLine("Transfer");
        Console.WriteLine("Transaction History");
        Console.WriteLine("Exit");
        Console.WriteLine("");
    }
    
    static public void Main()
    {
        BankAccount User_Session = new BankAccount();
        string connectionString = "Data Source=DESKTOP-7SAD67L\\SQLEXPRESS;Initial Catalog=Bank_System;Integrated Security=True;Encrypt=False";
        bool SessonOnOrOff = true;
        string UserStatus = "";

        // Login
        Console.WriteLine("Welcome to Bank!");
        User_Session.LoginInfo(connectionString);
        
        // Session start
        while (SessonOnOrOff) 
        {
            Console.Clear();
            User_Session.ViewBalance();
            Console.WriteLine($"Welcome, {User_Session.name}!");
            Console.WriteLine("What would you like to do today?");
            ViewMenu();
            UserStatus = Console.ReadLine().ToLower();
            
            if (UserStatus == "exit")
            {
                SessonOnOrOff = false;
                break;
            }
            else
            {
                InterfaceMenu(User_Session, UserStatus);
            }
  
        }
        User_Session.Logout();
    }
}
