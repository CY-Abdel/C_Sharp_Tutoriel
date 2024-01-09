using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
}
