using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeGenPocos;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.FirstName = "Rand";
            p.LastName = "OmGuy";
            p.Age = 30;
            Console.WriteLine("{0} {1} {2}; {3} ", p.FirstName, p.LastName, p.Age, p.FullName);
            Console.ReadKey();
        }
    }
}
