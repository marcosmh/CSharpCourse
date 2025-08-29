using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People anakin = new People()
            {
                Name = "Anakin",
                Age = 30
            };

            People luke = new People()
            {
                Name = "Luke",
                Age = 20
            };

            Console.WriteLine(People.Count);
            Console.WriteLine(People.GetCount());
        }


    }

    public static class A
    {
        public static void Same()
        {
            Console.WriteLine("Algo");
        }
    }

    public class People
    {
        public static int Count = 0;

        public string Name { get; set; }

        public int Age { get; set;  }


        public People()
        {
            Count++;
        }

        public static string GetCount()
        {
            return $"Esta clase de utilizado {Count} veces ";
        }

    }
} 