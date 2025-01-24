using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect5
{
    public class Shape
    {
        protected int width;
        protected int height;

        // default constructor
        public Shape()
        {
            
        }
        // parameterized constructor
        public Shape(int w, int h)
        {
            width = w;
            height = h;
        }
        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h) {
            height = h;
        }
    }
}
