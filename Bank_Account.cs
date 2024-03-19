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
    public class Bank_Account
    {
        public int AccountID { get; private set; }
        public string name { get; private set; } = string.Empty;
        public string email { get; private set; } = string.Empty;
        public string password { get; private set; } = string.Empty;
        public int CheckingAccount { get; private set; }
        public int SavingAccount { get; private set; }
        public int MoneyMarketAccount { get; private set; }
        public int CertificateDepositAccount { get; private set; }
        public int MutualFundAccount { get; private set; }

        /*public Bank_Account(int ID, string name, string email, string pass)
        {
            AccountID = ID;
            this.name = name;
            this.email = email;
            this.password = pass;
        }*/
        public void Deposit(decimal  amount)
        {

        }
        public void Withdraw(decimal amount)
        {

        }
        public void Transfer(decimal amount)
        {

        }
        public void LoginInfo() 
        {
            Console.WriteLine("Welcome to Bank!");
            Console.WriteLine("Enter your email.");
            email = StringCheck(Console.ReadLine(), "email");

            Console.WriteLine("Enter your password");
            Console.ReadLine();
            password = StringCheck(Console.ReadLine(), "password");
        }
        public string StringCheck(string input, string setting) 
        {
            string userInput = input;

            while (string.IsNullOrEmpty(userInput)) 
            {
                Console.WriteLine("Invalid " + setting + ". Please enter a valid " + setting + ".");
                userInput = Console.ReadLine();
            }
            // TODO: Add SQL communication to identify valid email and password.
            return userInput;
        }

    }
    /*public class CheckingAccount : Bank_Account { }
    public class SavingAccount : Bank_Account 
    {

    }
    public class MoneyMarketAccount : Bank_Account 
    { 
    
    }
    public class CertOfDeposit : Bank_Account 
    {
        
    }
    public class MutualFund : Bank_Account
    {

    }*/
}
