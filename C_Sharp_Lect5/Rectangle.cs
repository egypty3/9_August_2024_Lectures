using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect5
{
    public class Rectangle : Shape
    {

        // default constructor
        public Rectangle()
        {

        }
        // parameterized constructor
        public Rectangle(int w, int h) : base(w, h)
        {

        }
        public override int Area()
        {
            // I can access width and height here cause they are protected
            return width * height;
        }

        public void Display()
        {
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Area: {0}", Area());
        }

        public override Color BackgroundColor
        {
            get
            {
                backgroundColor = Color.Gray;
                return BackgroundColor;
            }
        }
    }
}
