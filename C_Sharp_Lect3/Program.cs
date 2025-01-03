namespace C_Sharp_Lect3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsLeapYear();
            SimpleCalculator();
        }

        static void SimpleCalculator()
        {
            int num1, num2, opt;
            Console.Write("\n\n");
            Console.Write("A menu driven program for a simple calculator :\n");
            Console.Write("----------------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nHere are the options : \n");
            Console.Write("1-Addition.\n2-Subtraction.\n3-Multiplication.\n");
            Console.Write("4-Division.\n5-Exit.\n");
            Console.Write("Enter your choice : ");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.WriteLine("The sum of {0} and {1} is {2}.\n", num1, num2, num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("The difference of {0} and {1} is {2}.\n", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("The product of {0} and {1} is {2}.\n", num1, num2, num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("The division of {0} and {1} is {2}.\n", num1, num2, num1 / num2);
                    break;
                case 5:
                    Console.WriteLine("Exiting the program.\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice.\n");
                    break;
            }
        }
        static void IsLeapYear()
        {
            int chk_year;
            Console.Write("\n\n");
            Console.Write("Check weather a given year is leap year or not :\n");
            Console.Write("----------------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an year : ");
            chk_year = Convert.ToInt32( Console.ReadLine());

            if ((chk_year % 400) == 0)
                Console.WriteLine("{0} is a leap year, {1}.\n", chk_year,"Thanks");
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
        }
    }
}
