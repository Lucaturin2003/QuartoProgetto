using System;

namespace AppOggetti
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthday, string name, string surname)
        {
            Birthdate = birthday;
            Name = name;
            Surname = surname;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365; 
                return years;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Person(new DateTime(2003, 5, 2), "Luca", "Turinn");
            Console.WriteLine(persona.Age);
            Console.WriteLine(persona.Name);
            Console.WriteLine(persona.Surname);
        }
    }

}