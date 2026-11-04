using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSystem
{
    internal class Employee
    {      

        public string  Name { get; set; }
        public string LastName { get; set; }
        public readonly double MAAS = 28075;
        public string EmployeeNumber { get; set; }
        public int WorkHours { get; set; }
        public Gorev Gorev { get; set; }// has a

        public Employee(string name, 
            string lastName, 
            string employeeNumber, 
            int workHours, Gorev gorev)// uses a
        {
            Name = name;
            LastName = lastName;            
            EmployeeNumber = employeeNumber;
            WorkHours = workHours;
            Gorev = gorev;
        }
        public double MaasHesapla()
        {
            double aSU = MAAS / 225;
            return aSU * WorkHours * Gorev.KatSayi;
        }

        public void Info()
        {
            Console.WriteLine($"Personel ID: {EmployeeNumber}, Ad: " +
                $"{Name} {LastName}, Görev: {Gorev.Name}, " +
                $"Maaş: {MaasHesapla():C2}");
        }
    }
}
