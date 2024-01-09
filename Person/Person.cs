using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonNamespace
{
    class Person
    {

        private string name; // field

        // Create a class constructor with a parameter
        public Person(string initialName)
        {
            name = initialName;
        }

        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }
}
