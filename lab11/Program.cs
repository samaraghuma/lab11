using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person("randy", "detroit");

            Console.WriteLine(p.ToString());



            student s = new student("raghu", "ann arbor", ".NET", 2016, 00);

            Console.WriteLine(s.ToString());



            staff s2 = new staff("ian", "chicago", "GC", 00);

            Console.WriteLine(s2);
        }
    }
}
