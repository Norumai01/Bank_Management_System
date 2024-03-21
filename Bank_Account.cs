using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bank_Management_System_v2
{
    public class BankAccount
    {
        public int AccID { get; private set; }
        public string name { get; private set; } = string.Empty;
        public string email { get; private set; } = string.Empty;
        public string password { get; private set; } = string.Empty;
        public int CheckingBal { get; private set; }
        public int SavingBal { get; private set; }
        public int MMABal { get; private set; }
        public int CDsBal { get; private set; }
        public int MuFundBal { get; private set; }

        public void Deposit(decimal  amount)
        {

        }
        public void Withdraw(decimal amount)
        {

        }
        public void Transfer(decimal amount)
        {

        }
        public void ViewBalance()
        {
            // TODO: View current balance for the AccID. 
        }
        public void ViewTransactionHistory()
        {
            // TODO: View transaction history by matching AccID.
        }
        public void LoginInfo(string connectionString) 
        {
            Console.WriteLine("Welcome to Bank!");
            Console.WriteLine("Enter your email.");
            email = StringCheck(Console.ReadLine(), "email");

            Console.WriteLine("Enter your password");
            Console.ReadLine();
            password = StringCheck(Console.ReadLine(), "password");

            var databaseHelper = new DatabaseHelper(connectionString);
            var dataRepository = new DataRepository(databaseHelper);

            // TODO: Match account information through SQL
        }
        public void Logout()
        {
            // Log out and stop the program.
            Console.WriteLine("Have a good day!");
            System.Environment.Exit(0);
        }
        public string StringCheck(string input, string setting) 
        {
            string userInput = input;

            while (string.IsNullOrEmpty(userInput)) 
            {
                Console.WriteLine("Invalid " + setting + ". Please enter a valid " + setting + ".\n");
                userInput = Console.ReadLine();
            }
            return userInput;
        }

    }
}
