using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect6
{
    public class Withdraw : ITransactions
    {
        private int tCode;
        private int accNo;
        private double amount;
        private DateTime date;

        // default constructor
        public Withdraw()
        {
            date = DateTime.Now;
        }
        // parameterized constructor
        public Withdraw(int tCode, int accNo, double moneyWithdrawn)
        {
            this.tCode = tCode;
            this.accNo = accNo;
            this.amount -= moneyWithdrawn;
            date = DateTime.Now;
        }
        public double getAmount()
        {
            return amount - (amount * 0.02);
        }

        public void showTransaction()
        {
            
            Console.WriteLine("Withdraw transaction code: {0}", tCode);
            Console.WriteLine("Account Number: {0}", accNo);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
}
