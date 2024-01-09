using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
        public Couleur couleur { get; set; }

        public void carSound()
        {
            Console.WriteLine("Ford Mustang's sound");
        }
    }

}
