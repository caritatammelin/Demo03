using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Student
    {
        //properties
        public string Name { get; set; }
        public int Class { get; set; }
        public int Age { get; set; }
        public bool Absent { get; set; }

        /*public Student(string name)
        {
            Name = name;
        }*/

        public void PrintData()
        {
            Console.WriteLine("Student data : ");
            Console.WriteLine("- name : " + Name);
            Console.WriteLine("- age : " + Age);
            Console.WriteLine("- class : " + Class);
            Console.WriteLine("- absent : " + Absent);
        }
    }
}
