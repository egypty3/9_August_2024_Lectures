using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect6
{
    public class Deposit : ITransactions
    {
        private int tCode;
        private int accNo;
        private double amount;
        private DateTime date;

        // default constructor
        public Deposit()
        {
           date = DateTime.Now;
        }

        // parameterized constructor
        public Deposit(int tCode, int accNo, double amount)
        {
            this.tCode = tCode;
            this.accNo = accNo;
            this.amount = amount;
            date = DateTime.Now;
        }
        public double getAmount()
        {
            return amount - (amount * 0.01);

        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Account Number: {0}", accNo);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
}
