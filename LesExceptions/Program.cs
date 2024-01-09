// See https://aka.ms/new-console-template for more information
Console.WriteLine("Les Exceptions");
Console.WriteLine();

try
{
    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
    Console.WriteLine("e.Message = " + e.Message);
}

Console.WriteLine();

try
{
    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong.");
}

Console.WriteLine();

try
{
    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong.");
}
finally
{
    Console.WriteLine("The 'try catch' is finished.");
}