using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect5
{
    public class Triangle : Shape
    {
        public override int Area()
        {
            // I can access width and height here cause they are protected
            return width * height / 2;
        }

        public override Color BackgroundColor
        {
            get
            {
                backgroundColor = Color.Blue;
                return BackgroundColor;
            }
        }
    }
}
