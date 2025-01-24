using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lect5
{
    public class Student
    {
        private int code;
        private string name;
        private int age;

        // Full property
        public int Code
        {
            get
            {
                return code;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Code must be greater than 0");
                }
                if (value > 6000)
                {
                    throw new Exception("Code must be less than 6000");
                }
                if (value < 5000)
                {
                    throw new Exception("Code must be greater than 5000");
                }

                code = value;
            }
        }


        // Full property
        public string Name
        {
            // for reading the name filed
            get { return name; }
            // for writing the name field
            set
            {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("Name cannot be empty");
                    }
                    name = value; 
            }
        }

        // Quick property
        public string Address { get; set; }

    }
}
