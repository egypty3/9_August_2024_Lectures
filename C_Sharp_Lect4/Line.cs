using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect4
{
    public class Line
    {
        private double length;   // Length of a line

        // default constructor
        public Line()
        {
            Console.WriteLine("Object is being created");
        }
        // parameterized constructor
        public Line(double len)
        {
            Console.WriteLine("Object is being created, length = {0}", len);
            length = len;
        }
        public void SetLength(double len)
        {
            length = len;
        }
        public double GetLength()
        {
            return length;
        }
    }
}
