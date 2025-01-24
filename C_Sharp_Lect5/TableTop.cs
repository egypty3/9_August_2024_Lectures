using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect5
{
    public class TableTop : Rectangle
    {
        private double cost = 70;

        public TableTop()
        {
        }
        public TableTop(int l, int w) : base(l, w)
        {
        }

        public TableTop(int l, int w, double c) : base(l, w)
        {
            this.cost = c;
        }

        public double GetCost()
        {
            double area = Area();
            return area * cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
}
