using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace oop_concept
{
    public class Vehical
    {
        public string modelname;
        public int modelnumber;

        //Constructor with parameters
        public Vehical(string name, int number)
        {
            modelname = name;
            modelnumber = number;
        }

        // Method to display information
        public void display(string name,int number)
        {
            Console.WriteLine($"Model Name: {name} \nModel Number: {number}");
        }

        //Car interface
        public void get(string name,int number)
        {
            Console.WriteLine($"Model Name: {name} \nModel Number: {number}");
            
        }

    }

}
