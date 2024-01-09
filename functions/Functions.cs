using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Functions
    {
        public string color = "red";

        public static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        public void MyMethod2()
        {
            Console.WriteLine("I just got executed!");
        }

        public static int MyMethod3(int x)
        {
            return 5 + x;
        }

        public static int MyMethod4(int x, int y)
        {
            return x + y;
        }

    }
}
