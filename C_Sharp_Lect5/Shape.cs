using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect5
{
    public abstract class Shape
    {
       
       

        protected int width;
        protected int height;
        protected Color backgroundColor;

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

        public abstract int Area();


        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h) {
            height = h;
        }



        public virtual Color BackgroundColor
        {
            get {
                    backgroundColor = Color.White;
                    return backgroundColor;
                }
        }

    }
}
