using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_Lib;
using Studentici_Library;
using Teach_Lib;

namespace MainApp
{
    class Program
    {
        static void Main()
        {
            // Создаем объекты
            Person individual = new Person("Чечетко Александр Михайлович", 23);
            Student scholar = new Student("Булкин Василий Петрович", 18, 1);
            Teacher instructor = new Teacher("Ян Петр Алексеевич", 55);

            // Выводим информацию о каждом объекте
            Console.WriteLine("Человек:");
            individual.DisplayInfo();

            Console.WriteLine("\nСтудент:");
            scholar.DisplayInfo();

            Console.WriteLine("\nУчитель:");
            instructor.AddStudent(scholar);
            instructor.DisplayInfo();

            // Пример использования операторов == и !=
            Person anotherIndividual = new Person("Саша", 30);
            Console.WriteLine($"\nРавны ли индивид и другой индивид? {individual == anotherIndividual}");
            Console.WriteLine($"Разве индивид и другой индивид не равны? {individual != anotherIndividual}");
        }
    }
}