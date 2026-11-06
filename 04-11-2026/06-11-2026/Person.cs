using System;
using System.Collections.Generic;
using System.Text;

namespace _06_11_2026
{
    internal class Person
    {
        public Person(string firstName, string lastName, string personNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonNumber = personNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonNumber { get; set; }

       

        public void Info()
        {
            Console.WriteLine($"{FirstName} {LastName} - {PersonNumber}");
        }
    }
}
