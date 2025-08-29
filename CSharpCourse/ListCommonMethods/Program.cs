using System;
using System.Collections.Generic;

namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                4,3,6,19
            };

            Show(numbers);
            numbers.Insert(0, 6);
            Show(numbers);

            if (numbers.Contains(33))
                Console.WriteLine("Existe");
            else
                Console.WriteLine("NO Existe");


            int pos = numbers.IndexOf(19);
            Console.WriteLine(pos);

            pos = numbers.IndexOf(100);
            Console.WriteLine(pos);

            numbers.Sort();
            Show(numbers);

            string name = "Anakin";
            name = name.ToUpper();
            Console.WriteLine(name);

            numbers.AddRange(new List<int>()
            {
                200,300,400
            });

            Show(numbers);

        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- Numeros --");
            foreach(var num in numbers)
            {
                Console.WriteLine("--> "+num);
            }
        }
    }

}