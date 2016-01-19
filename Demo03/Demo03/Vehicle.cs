using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Vehicle
    {
        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // method prints vehicle data
        public void PrintData()
        {
            Console.WriteLine("Vehicle data : ");
            Console.WriteLine("- name : " + Name);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- tyres : " + Tyres);
        }

        // method returns vehicle data
        public override string ToString()
        {
            return "Name: " + Name + " Speed: " + Speed + " Tyres: " + Tyres;
        }
    }
}
