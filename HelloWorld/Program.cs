using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello juba");
            Console.WriteLine("I am Learning C#");
            Console.Write("It ");
            Console.WriteLine("is awesome!");
            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.\n");
            Console.WriteLine(3 + 3);

            string name = "Juba";
            Console.WriteLine(name + "\n");

            int myNum = 15;
            Console.WriteLine(myNum);

            int myNum2;
            myNum2 = 15;
            Console.WriteLine(myNum2);

            int myNum3 = 15;
            myNum3 = 20; // myNum is now 20
            Console.WriteLine(myNum3);

            string firstName = "Juba ";
            string lastName = "Abdel\n";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5, y = 4, z = 10;
            Console.WriteLine(x + y + z);

            Console.WriteLine();

            x = y = z = 50;
            Console.WriteLine(x + y + z);

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine("float  = " + f1);
            Console.WriteLine("double = " + d1);
            Console.WriteLine();

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            Console.WriteLine();

            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);


        }
    }
}
