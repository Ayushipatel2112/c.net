using System;
using oop_concept;
namespace oops_concept;
class Program
{
    public static void Main(string[] args)
    {
        // Instantiate the Vehical class with arguments ("ayushi", 2004)
        Vehical v1 = new Vehical("jupitar",2021);
   
        // Display the vehicle's details
        v1.display("Activa",2024);
        v1.get("Toyota",2030);

        Bike b1 = new Bike();
        b1.show();
    }
}