using System;

namespace ForEach
{
    class Progam
    {
        static void Main(string[] args)
        {
            var  numbers = new List<int>()
            {
                23,3,6,10,22,12
            };

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            var students = new List<People>()
            {
                new People() { Name = "Anakin", Country = "Tatooine" },
                new People() { Name = "Chew", Country = "Kashik" },
                new People() { Name = "Padme", Country = "Alderan" },
            };

            foreach(var student in students)
            {
                Console.WriteLine(student.Name+" --- "+student.Country);
            }

            Show(students);

            students.RemoveAt(0);

            Show(students);
        }

        static void Show(List<People> students)
        {
            Console.WriteLine("-- Personas ---");
            foreach(var people in students)
            {
                Console.WriteLine($"Nombre: ${people.Name}, Pais: ${people.Country} ");
            }
        }
    }

    public class People
    {
        public string Name { get; set; }

        public string Country { get; set; }

    }

}