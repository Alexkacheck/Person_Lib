using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentici_Library
{
    public class Student : Person_Lib.Person
    {
        public int StudentId { get; set; }

        public Student(string fullName, int years, int studentId) : base(fullName, years)
        {
            StudentId = studentId;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Студента ID: {StudentId}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Студента ID: {StudentId}";
        }
        // Дополнительные методы, если необходимо
    }
}
