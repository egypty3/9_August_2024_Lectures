using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Lect1_Console.Models
{
    class Blog
    {
        public  int BlogId  { get; set; }
        public string Url { get; set; }

        // Navigation properties
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
