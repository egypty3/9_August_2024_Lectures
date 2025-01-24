namespace C_Sharp_Lect5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TestingProperties();
            TestingInheritance();
        }

        private static void TestingProperties()
        {
            Student student = new Student();
            // student.code = 5001;
            student.Code = 4500;

            Console.WriteLine(student.Code);

            student.Address = "Wara Mahtet el Banzeen";
        }

        private static void TestingInheritance()
        {
            // parameterized constructor called here    
            //Shape shape = new Shape(3, 5);


            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.Display();

            Console.WriteLine("--------------------------");
            //Console.WriteLine(
            //        $"The rectangle area is : {rectangle.GetArea()}" 
            //    );

            TableTop tableTop = new TableTop(15, 20, 100);
            tableTop.Display();
        }
    }
}
