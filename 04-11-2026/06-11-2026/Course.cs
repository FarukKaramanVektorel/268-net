using System;
using System.Collections.Generic;
using System.Text;

namespace _06_11_2026
{
    internal class Course
    {
        public string Name { get; set; }
        public int Credit { get; set; }

        public Teacher Teacher { get; set; }

        public static int Count { get; set; }
        public Course(string name, int credit, Teacher teacher)
        {
            Name = name;
            Credit = credit;
            Teacher = teacher;
            Count++;
        }

        public void Info()
        {
            Console.WriteLine($"Ders Adı: {Name}" +
                $", Kredisi: {Credit}" +
                $", Öğretmeni: {Teacher.FirstName} {Teacher.LastName}");
        }


    }
}
