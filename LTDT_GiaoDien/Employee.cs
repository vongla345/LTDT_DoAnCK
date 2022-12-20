using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Employee
    {
        string name;

        public Employee(string _name = "null")
        {
            this.name = _name;
        }   

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

       
    }
}
