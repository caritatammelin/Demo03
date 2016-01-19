using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy");
            dog.Breed = "golden retriever";
            dog.Age = 9;
            dog.Owner = "Lily";
            dog.Thirsty = true;
            dog.PrintData();

            Dog edog = new Dog("Doge");
            edog.Breed = "shiba inu";
            edog.Age = 2;
            edog.Owner = "Rose";
            edog.Hungry = true;
            

            edog.PrintData();

            Console.WriteLine(dog.ToString());
            Console.WriteLine(edog.ToString());

            Console.ReadLine();
    
        }
    }
}
