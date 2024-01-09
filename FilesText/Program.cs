//
using System;
using System.IO;  // include the System.IO namespace

Console.WriteLine("lecture et ecriture de fichiers");
Console.WriteLine();

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"Le répertoire de travail actuel est : {currentDirectory}");

// Définir le nouveau répertoire de travail
string newDirectory = @"D:\Users\juba_\source\repos\HelloWorld\FilesText";
Directory.SetCurrentDirectory(newDirectory);

// Afficher le nouveau répertoire de travail
currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"Le nouveau répertoire de travail est : {currentDirectory}");

Console.WriteLine();

string writeText = "Hello World!";  // Create a text string
File.WriteAllText("file1.txt", writeText);  // Create a file and write the contents of writeText to it


string readText = File.ReadAllText("file1.txt"); // Read the contents of the file
Console.WriteLine(readText); // Output the content

Console.WriteLine();

string additionalContent = "\nContenu à ajouter à la fin du fichier.";
File.AppendAllText("file1.txt", additionalContent);

readText = File.ReadAllText("file1.txt"); // Read the contents of the file
Console.WriteLine(readText); // Output the content

Console.WriteLine();

/* *********         STREAM WRITTER         ********* */

using (StreamWriter writer = new StreamWriter("file2.txt"))
{
    for (int i = 1; i <= 10; i++)
    {
        writer.WriteLine("Ligne : " + i);
    }
}

Console.WriteLine();

/* *********         STREAM READER         ********* */
using (StreamReader reader = new StreamReader("file2.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}