using System;
using System.Collections.Generic;
using System.Text;

namespace _06_11_2026
{
    // Child Class => Student
    // Base Class => Person
    internal class Student:Person // is a
    {

        public Course[] Courses=new Course[0]; // has a
        const int MAX_CREDI = 12;

        public Student(string firstName, string lastName, string personNumber) : base(firstName, lastName, personNumber)
        {
          

        }


        public void CourseAdd(Course course)// uses a
        {
            if (TotalCredit(Courses)+course.Credit >= MAX_CREDI)
            {
                Console.WriteLine("Alabileceğiniz maximum kredi sınırına ulaştınız...");
                return;
            }
            Array.Resize(ref Courses,Courses.Length+1);
            Courses[Courses.Length-1] = course;
            Console.WriteLine($"{ Courses.Length - 1}. ders Eklendi: {course.Name}");

        }

        private int TotalCredit(Course[] courses)
        {
            int result = 0;
            for (int i = 0; i < courses.Length; i++)
            {
                result += courses[i].Credit;
            }
            return result;
        }
    }
}
