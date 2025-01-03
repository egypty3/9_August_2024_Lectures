namespace C_Sharp_Lect3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsLeapYear();
            //SimpleCalculator();
            //ElectricityBill();
            //PrintAverageOfTenNumbers();
            PrintAPattern();
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
            chk_year = Convert.ToInt32(Console.ReadLine());

            if ((chk_year % 400) == 0)
                Console.WriteLine("{0} is a leap year, {1}.\n", chk_year, "Thanks");
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
        }

        static void ElectricityBill()
        {
            int customerId, consumptionInKW;
            string customerName;
            double billAmountAfterAddingEachStage = 0;

            Console.Write("\n\n");
            Console.Write("Calculate the electricity bill :\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input Customer ID : ");
            customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer : ");
            customerName = Console.ReadLine();
            Console.Write("Input the number of KiloWatts consumed by the customer : ");
            consumptionInKW = Convert.ToInt32(Console.ReadLine());

            if (consumptionInKW <= 199)
            {
                billAmountAfterAddingEachStage = consumptionInKW * 1.20;
            }
            else
            {
                billAmountAfterAddingEachStage = 199 * 1.20;
            }
            if (consumptionInKW >= 200) // if the consumption is greater than 260 kw
            {
                billAmountAfterAddingEachStage += (consumptionInKW - 199) * 1.50;
            }
            if (consumptionInKW >= 400) // if the consumption is greater than 535 kw
            {
                billAmountAfterAddingEachStage += (consumptionInKW - 399) * 1.80;
            }

            if (consumptionInKW >= 600)
            {
                billAmountAfterAddingEachStage += (consumptionInKW - 599) * 2.00;
            }



            double salesTax = billAmountAfterAddingEachStage * 0.14;
            double totalBill = billAmountAfterAddingEachStage + salesTax;

            Console.WriteLine("\nElectricity Bill\n");
            Console.WriteLine("Customer ID NO                       :{0}", customerId);
            Console.WriteLine("Customer Name                        :{0}", customerName);
            Console.WriteLine("KiloWatts Consumed                   :{0}", consumptionInKW);

            Console.WriteLine("Net Amount Paid By the Customer      :{0}", totalBill);


        }

        static void PrintAverageOfTenNumbers()
        {
            int counter, n, sum = 0, num;
            double avg;
            Console.Write("\n\n");
            Console.Write("Calculate the average of n numbers :\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the 10 numbers : \n");

            n = 10;

            for (counter = 1; counter <= n; counter++)
            {
                Console.Write("Number-{0} : ", counter);
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            avg = sum / n;
            Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n", sum, avg);
        }

        static void PrintAPattern()
        {
            // Print a pattern like this 
            /*
                  *
                 ***
                *****
               *******
              *********
               *******
                *****
                 ***
                  *
             */
            int i, j, n;
            Console.Write("\n\n");
            Console.Write("Display the pattern like a diamond :\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows for this pattern : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
