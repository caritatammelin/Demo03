using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student();

            //Student students = new Student();
            //students[0] = student;
            students[0].Name = "Pekka";
            students[0].Age = 15;
            students[0].Class = 9;
            students[0].Absent = true;
            students[1].Name = "Anna";
            students[1].Age = 15;
            students[1].Class = 9;
            //students[1].Absent = true;
            students[2].Name = "Miia";
            students[2].Age = 15;
            students[2].Class = 9;
            //students[2].Absent = true;
            students[3].Name = "Kalle";
            students[3].Age = 15;
            students[3].Class = 9;
            students[3].Absent = true;
            students[4].Name = "Antti";
            students[4].Age = 15;
            students[4].Class = 9;
            //students[4].Absent = true;

            // students[0] = student;
            foreach (Student PrintData in students) ;
            //for (Student students = 0; i < students; i++) Console.WriteLine(students[i]);
            Console.ReadLine();
        }
    }
}
