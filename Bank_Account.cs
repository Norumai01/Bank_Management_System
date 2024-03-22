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
            // TODO: Deposit from a specfic account type.
        }
        public void Withdraw(decimal amount)
        {
            // TODO: Withdraw from a specfic account type.
        }
        public void Transfer(decimal amount)
        {
            // TODO: Transfer money between different account types.
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
            this.email = StringCheck(Console.ReadLine(), "email");

            Console.WriteLine("Enter your password");
            Console.ReadLine();
            this.password = StringCheck(Console.ReadLine(), "password");


            // TODO: Match account information through SQL
            RefreshAccInfo(email, password, connectionString);
        }
        public void RefreshAccInfo(string email, string password, string connectionString)
        {
            var databaseHelper = new DatabaseHelper(connectionString);
            var dataRepository = new DataRepository(databaseHelper);
            BankAccount account = dataRepository.GetData(email, password); 
 
            if (account != null)
            {
                this.AccID = account.AccID;
                this.name = account.name;
                this.email = account.email;
                this.password = account.password;
                this.CheckingBal = account.CheckingBal;
                this.SavingBal = account.SavingBal;
                this.MMABal = account.MMABal;
                this.CDsBal = account.CDsBal;
                this.MuFundBal = account.MuFundBal;
            }
            else
            {
                Console.WriteLine("Account email or password does not exist.");
                Console.WriteLine("Re-enter your email or password.");
                //LoginInfo(connectionString);
            }
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
