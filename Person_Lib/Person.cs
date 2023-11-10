using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Lib
{
    // класс представляющий человека
    public class Person
    {
        // Свойства для имени и возраста
        public string FullName { get; set; }
        public int Years { get; set; }

        // Конструктор для установки имени и возраста 
        public Person(string fullName, int years)
        {
            FullName = fullName;
            Years = years;
        }

        //  вывод информации о человеке
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя: {FullName}, Возвраст: {Years}");
        }

        // Переопределение метода ToString для  представления в виде строки
        public override string ToString()
        {
            return $"Имя: {FullName}, Возвраст: {Years}";
        }

        // Переопределение метода Equals для сравнения объектов типа Personn 
        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                // Сравнение по имени и возрасту
                return FullName == otherPerson.FullName && Years == otherPerson.Years;
            }
            return false;
        }

        // Переопределение мето GetHashCode для работы с коллекциями
        public override int GetHashCode()
        {
            // Комбинирование хэшей имени и возраста
            return (FullName, Years).GetHashCode();
        }
        // Оператор == для удобного сравнения двух объектов Person
        public static bool operator ==(Person person1, Person person2)
        {
            return person1?.Equals(person2) ?? false;
        }

        // Оператор != для удобного сравнения двух объектов Person
        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
