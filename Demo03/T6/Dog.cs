using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }
        public bool Hungry { get; set; }
        public bool Thirsty { get; set; }

        public Dog(string name)
      {
          Name = name;
      }

       

        public void PrintData()
        {
            Console.WriteLine("Dog information: ");
            Console.WriteLine("- name : " + Name);
            Console.WriteLine("- breed : " + Breed);
            Console.WriteLine("- age : " + Age);
            Console.WriteLine("- owner : " + Owner);
            Console.WriteLine("- hungry : " + Hungry);
            Console.WriteLine("- thirsty : " + Thirsty);
        }

        public override string ToString()
        {
            return "Name: " + Name + " Breed: " + Breed + " Age: " + Age + " Owner: " + Owner + " Hungry: " + Hungry + " Thirsty: " + Thirsty;
        }
    }
}
