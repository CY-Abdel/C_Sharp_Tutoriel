using System;
using System.Collections.Generic;
using System.Linq;

// Liste (List)
List<int> liste = new List<int> { 1, 2, 3, 4, 5 };

// Ensemble (Set) - En C#, HashSet est souvent utilisé pour simuler un ensemble
HashSet<int> ensemble = new HashSet<int> { 1, 2, 3, 4, 5 };

// Dictionnaire (Map) - En C#, Dictionary est utilisé pour représenter un ensemble de paires clé-valeur
Dictionary<string, int> dictionnaire = new Dictionary<string, int>
        {
            { "Un", 1 },
            { "Deux", 2 },
            { "Trois", 3 }
        };

// Afficher les éléments de la liste
Console.WriteLine("Liste :");
foreach (var item in liste)
{
    Console.WriteLine(item);
}

Console.WriteLine();

// Afficher les éléments de l'ensemble
Console.WriteLine("\nEnsemble :");
foreach (var item in ensemble)
{
    Console.WriteLine(item);
}

Console.WriteLine();

// Afficher les éléments du dictionnaire
Console.WriteLine("\nDictionnaire :");
foreach (var pair in dictionnaire)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

Console.WriteLine();

// Équivalent des Streams Java en C# - LINQ (Language Integrated Query)
var resultat = liste.Where(x => x > 2)
                    .Select(x => x * 2)
                    .ToList();

// Afficher les résultats de la requête LINQ
Console.WriteLine("\nRésultat de la requête LINQ :");
foreach (var item in resultat)
{
    Console.WriteLine(item);
}



