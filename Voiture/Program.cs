
// Create a myCar object
using Voiture;

Car myCar = new Car();
myCar.couleur = Couleur.Bleu;

int myNum = (int)Couleur.Bleu;
Console.WriteLine(myNum);

Vehicle vehicle = new Vehicle();

myCar.carSound();
vehicle.carSound();

// Call the honk() method (From the Vehicle class) on the myCar object
myCar.honk();

// Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
Console.WriteLine(myCar.brand + " model :  " + myCar.modelName + " coleur : " + myCar.couleur);
