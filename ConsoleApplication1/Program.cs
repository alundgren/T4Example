using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.FirstName = "1";
            p.LastName = "2";
            p.Age = 3;
            Console.WriteLine("{0} {1} {2}", p.FirstName, p.LastName, p.Age);
            Console.ReadKey();
        }
    }
}
