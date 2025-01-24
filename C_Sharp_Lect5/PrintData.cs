using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect5
{
    public class PrintData
    {
        public void Print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        public void Print(double d)
        {
            Console.WriteLine("Printing double: {0}", d);
        }
        public void Print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }
}
