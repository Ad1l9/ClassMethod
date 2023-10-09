using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod.Models
{
    public class Student
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public ushort Point { get; set; }
        public bool IsGraduated { get; set; }

        public Student(string name, string surname, string group, byte point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;

            if (point <= 65)
                IsGraduated = false;
            else IsGraduated = true;
        }

        public void GetInfo()
        {
            Console.WriteLine(@$"
Name: {Name},
Surname: {Surname},
Group: {Group}
Point: {Point},
Is Graduated: {IsGraduated}
");
        }

        public void CheckGraduation()
        {
            if (IsGraduated) Console.WriteLine("Graduated");
            else Console.WriteLine("Not Graduated");
        }

        public void GetDiplomDeg()
        {
            if (Point <= 65)Console.WriteLine("No diploma");
            
            else if (Point <= 80) Console.WriteLine("General");
            
            else if (Point <= 90)Console.WriteLine("Honor");
            
            else Console.WriteLine("High honor");
        }

    }
}