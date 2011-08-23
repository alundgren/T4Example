using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenPocos
{
    public partial class Person
    {
        public string FullName 
        {
            get 
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
