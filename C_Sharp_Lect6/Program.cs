namespace C_Sharp_Lect6
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Deposit t1 = new Deposit(101, 1000, 5000);
              Deposit t2 = new Deposit(102, 1000, 2500);
              t1.showTransaction();
              t2.showTransaction();
              
        }
    }
}
