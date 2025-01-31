namespace C_Sharp_Lect6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // polymorphism
            List<ITransactions> transactions = new List<ITransactions>();

            transactions.Add(new Deposit(101, 1000, 5000));
            transactions.Add(new Withdraw(102, 1000, 2500));
            transactions.Add(new Deposit(103, 1000, 12000));

            // polymorphism
            ITransactions t1 = new Deposit(101, 1000, 5000);
            ITransactions t2 = new Withdraw(102, 1000, 2500);
            t1.showTransaction();
            t2.showTransaction();
        }

    }
}
