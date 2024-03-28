using Bank_Management_System_v2;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static public void InterfaceMenu(BankAccount currentSession, string input)
    {
        string userInput = input.ToLower();
        string connectionString = "Data Source=DESKTOP-7SAD67L\\SQLEXPRESS;Initial Catalog=Bank_System;Integrated Security=True;Encrypt=False";

        if (userInput == "deposit")
        {
            Console.WriteLine("Enter how much would you like to deposit?");
            decimal DepoAmount = CheckDecimal(Console.ReadLine(), userInput);

            Console.WriteLine("Please enter which account would you like to deposit to?");
            string AccountDepo = isValidAccount(Console.ReadLine(), userInput);
            
            currentSession.Deposit(AccountDepo, DepoAmount);
            Console.Clear();
        }
        else if (userInput == "withdraw")
        {
            Console.WriteLine("Enter how much would you like to withdraw?");
            decimal WithAmount = CheckDecimal(Console.ReadLine(), userInput);

            Console.WriteLine("Please enter which account would you like to withdraw from?");
            string AccountWith = isValidAccount(Console.ReadLine(), userInput);

            currentSession.Withdraw(AccountWith, WithAmount);
            Console.Clear();
        }
        else if (userInput == "transfer")
        {
            Console.WriteLine("Enter how much would you like to transfer?");
            decimal TransAmount = CheckDecimal(Console.ReadLine(), userInput);

            Console.WriteLine("Please enter which account you would like to transfer from?");
            string AccountTrans1 = isValidAccount(Console.ReadLine(), userInput);

            Console.WriteLine("Please enter which account you would like to transfer to?");
            string AccountTrans2 = isValidAccount(Console.ReadLine(), userInput);

            currentSession.Transfer(AccountTrans1, AccountTrans2, TransAmount);
            Console.Clear();
        }
        else if (userInput == "transaction history")
        {
            Console.Clear();
            currentSession.ViewTransactionHistory(connectionString);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Wrong Input. Please type valid input.\n");
        }
    }
    static public decimal CheckDecimal(string input, string setting)
    {
        bool isValidInput = false;
        decimal number = 0;

        while (!isValidInput) 
        { 
            if (decimal.TryParse(input, out number))
            {
                number = Math.Round(decimal.Parse(input), 2);
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Input is not a valid decimal. Please type the amount you would like to " + setting + ".");
                input = Console.ReadLine();
            }
        }
        return number;
    }
    static public string isValidAccount(string input, string setting)
    {
        string userInput = input.ToLower();

        while (string.IsNullOrEmpty(userInput) || (userInput != "checking" && userInput != "saving" && userInput != "money market" && userInput != "cds" && userInput != "mutual fund"))
        {
            Console.WriteLine("Invalid account type. Please type a valid account, you like to " + setting + ".");
            userInput = Console.ReadLine().ToLower();
        }
        return userInput;
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
        User_Session.Logout(connectionString);
    }
}
