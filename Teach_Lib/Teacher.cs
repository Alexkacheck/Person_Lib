using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach_Lib
{
    public class Teacher : Person_Lib.Person
    {
        public List<Studentici_Library.Student> StudentsList { get; set; }

        public Teacher(string fullName, int years) : base(fullName, years)
        {
            StudentsList = new List<Studentici_Library.Student>();
        }

        public void AddStudent(Studentici_Library.Student student)
        {
            StudentsList.Add(student);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Студенты:");

            foreach (var student in StudentsList)
            {
                student.DisplayInfo();
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Студенты: {StudentsList.Count}";
        }
        // Дополнительные методы, если необходимо
    }
}
