

using System.Security.Cryptography.X509Certificates;

namespace _1159_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class BankAccount
        {
            private int _balance;
            private string _preNumber;
            private string accountNumber;
            private int _bankCode;


            public BankAccount(int balance, string preNumber, string accountNumber, int bankCode, string bank)
            {
                _balance = balance;
                _preNumber = preNumber;
                this.accountNumber = accountNumber;
                _bankCode = bankCode;
                Bank = bank;
            }
            
            public void FullAccountName(string accountNumber)
            {
                Console.WriteLine(accountNumber);
                Console.WriteLine(_bankCode);
            }
        

            public string Bank { get; set; }

            public void deposit(int amount) 
            {
                _balance = _balance + amount;
            }

            public int withdrawl(int amount)
            {
                
                if (_balance < -1000)
                {
                    Console.WriteLine("transaction failed");
                }
                _balance = _balance - amount;
                
                return _balance;
                

            }
            

        }
    }
}