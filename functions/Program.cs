// See https://aka.ms/new-console-template for more information

// Créer une instance de la classe MaClasse
using functions;

Functions.MyMethod();

Functions maInstance = new Functions();

Console.WriteLine(maInstance.color);

maInstance.MyMethod2();

Console.WriteLine(Functions.MyMethod3(3));

int z = Functions.MyMethod4(5, 3);
Console.WriteLine(z);