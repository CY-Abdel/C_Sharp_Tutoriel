using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public enum Couleur
    {
        Rouge,
        Vert,
        Bleu
    }

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }

        public void carSound()
        {
            Console.WriteLine("Ford's sound");
        }
    }
}
