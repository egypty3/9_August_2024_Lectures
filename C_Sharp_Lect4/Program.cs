using System.Data.SqlClient;

namespace C_Sharp_Lect4
{
    

    public class Program
    {

        static void Main(string[] args)
        {
            // StructuresExample();
            //EnumExample();
            //ClassExample1();
            //ClassConstructorExample();

            //ConnectToDBExample();
        }

        static void StructuresExample()
        {
            Book book1 = new Book(); // Declare Book1 of type Book
            Book book2 = new Book(); // Declare Book2 of type Book

            // book1 specification
            book1.book_id = 6495407;
            book1.author = "Abu Adel";
            book1.title = "learn C# in 24 hours";
            book1.subject = "C# Programming Tutorial";


            // book2 specification
            book2.book_id = 6495700;
            book2.author = "Noha Ali";
            book2.title = "El Bacaloria El Gedida";
            book2.subject = "Egyptian Bacaloria";

            // print Book1 info
            Console.WriteLine("Book 1 ID : {0}", book1.book_id);
            Console.WriteLine("Book 1 Title : {0}", book1.title);
            Console.WriteLine("Book 1 Author : {0}", book1.author);
            Console.WriteLine("Book 1 Subject : {0}", book1.subject);
          
        }

        static void EnumExample()
        {
          int WeekdayStart = (int) Days.Sat;

            Console.ForegroundColor = ConsoleColor.Cyan;

          Console.WriteLine("Sat: {0}", WeekdayStart);
        }

        static void ClassExample1()
        {
            Console.WriteLine("Total boxes created: {0}", Box.GetCountOfBoxes());

            Box box1 = new Box(6,7,5);   // Declare Box1 of type Box
            Box box2 = new Box(600,5,-4);   // Declare Box2 of type Box
            
            //double volume = 0.0;    // Store the volume of a box here

            //// box 1 specification
            //box1.height = 50000000000.0;
            //box1.length = -6.0;
            //box1.breadth = 7.0;

            //box1.SetLength(6.0);
            //box1.SetBreadth(7.0);
            //box1.SetHeight(5.0);


            //// box 2 specification
            //box2.height = 10.0;
            //box2.length = 12.0;
            //box2.breadth = 13.0;

            //box2.SetLength(600.0);
            //box2.SetBreadth(76.0);
            //box2.SetHeight(-5.0);

            // volume of box 1
            //volume = box1.GetHeight() * box1.GetBreadth() * box1.GetLength();
            
            Console.WriteLine("Volume of Box1 : {0}", box1.GetVolume());
            // volume of box 2
            //volume = box2.GetHeight() * box2.GetBreadth() * box2.GetLength();
            Console.WriteLine("Volume of Box2 : {0}", box2.GetVolume());

            Console.WriteLine("Total boxes created: {0}", Box.GetCountOfBoxes());
        }

        static void ClassConstructorExample()
        {
            Line line = new Line(6);
            //line.SetLength(6.0);
            Console.WriteLine("Length of line : {0}", line.GetLength());
        }

        static void ConnectToDBExample()
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
           //conn.ConnectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        }
    }
}
