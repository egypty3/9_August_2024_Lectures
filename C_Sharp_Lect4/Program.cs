namespace C_Sharp_Lect4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // StructuresExample();
            EnumExample();
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
         
        }
    }
}
