using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect4
{
    public class Box
    {
        private double length;
        private double breadth;
        private double height;

        static private int countOfBoxes = 0;

        // default constructor
        public Box()
        {
            countOfBoxes++;
        }
        // parameterized constructor
        public Box(double len, double bre, double hei)
        {
            countOfBoxes++;

            this.SetLength(len);
            this.SetBreadth(bre);
            this.SetHeight(hei);
        }

        static public int GetCountOfBoxes()
        {
            return countOfBoxes;
        }

        public void SetLength(double len)
        {
            if (len < 0)
            {
                length = 1;
            }
            else if (len > 100)
            {
                length = 100;
            }
            else
            {
                length = len;
            }
        }
        public void SetBreadth(double bre)
        {
            if (bre < 0)
            {
                breadth = 1;
            }
            else if (bre > 100)
            {
                breadth = 100;
            }
            else
            {
                breadth = bre;
            }
        }

        public void SetHeight(double hei)
        {
            if (hei < 0)
            {
                height = 1;
            }
            else if (hei > 100)
            {
                height = 100;
            }
            else
            {
                height = hei;
            }
        }
        public double GetLength()
        {
            return length;
        }
        public double GetBreadth()
        {
            return breadth;
        }
        public double GetHeight()
        {
            return height;
        }

        public double GetVolume()
        {
            return length * breadth * height;
        }
    }
}
