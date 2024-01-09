// See https://aka.ms/new-console-template for more information

using System.Drawing;

string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

Console.WriteLine();

txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"

Console.WriteLine();

string firstName = "juba ";
string lastName = "abdel";

string name = firstName + lastName;
Console.WriteLine(name);

Console.WriteLine();

name = string.Concat(firstName, lastName);
Console.WriteLine(name);

Console.WriteLine();

name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

Console.WriteLine();

int x = 10;
string y = "20";
string z = x + y;  // z will be 1020 (a string)
Console.WriteLine("z " + z);
Console.WriteLine();

string x2 = Convert.ToString(x);
y = "20";
z = x2 + y;  // z will be 1020 (a string)
Console.WriteLine("z " + z);

Console.WriteLine();

string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"
Console.WriteLine(myString[1]);  // Outputs "e"
Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

Console.WriteLine();

// Full name
name = "John Doe";

// Location of the letter D
int charPos = name.IndexOf("D");

// Get last name
lastName = name.Substring(charPos);

// Print the result
Console.WriteLine(lastName);

Console.WriteLine();

int day = 4;
switch (day)
{
    case 6:
        Console.WriteLine("Today is Saturday.");
        break;
    case 7:
        Console.WriteLine("Today is Sunday.");
        break;
    default:
        Console.WriteLine("Looking forward to the Weekend.");
        break;
}

// Outer loop
for (int i = 1; i <= 2; ++i)
{
    Console.WriteLine("Outer: " + i);  // Executes 2 times

    // Inner loop
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
    }
}

Console.WriteLine();

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string i in cars)
{
    Console.WriteLine(i);
}

Console.WriteLine();

// Sort a string
Array.Sort(cars);
foreach (string i in cars)
{
    Console.WriteLine(i);
}


Console.WriteLine();

int[] myNumbers = { 5, 1, 8, 9 };
Console.WriteLine(myNumbers.Max());  // returns the largest value
Console.WriteLine(myNumbers.Min());  // returns the smallest value
Console.WriteLine(myNumbers.Sum());  // returns the sum of elements