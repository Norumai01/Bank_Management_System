using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Bank_Management_System_v2
{
    public class DataRepository
    {
        private readonly DatabaseHelper _databaseHelper;
        public DataRepository(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        
        // Query script and get data from SQL Database.
        public BankAccount GetData(string Email, string Password)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                connection.Open();
                string sql = "SELECT AccID, email, password, name, CheckingBal, SavingBal, MMABal, CDsBal, MuFundBal FROM Bank_System.dbo.BankAccount WHERE email = @Email AND password = @Password";

                return connection.QuerySingleOrDefault<BankAccount>(sql, new { email = Email, password = Password });
            }
        }
    }
}
