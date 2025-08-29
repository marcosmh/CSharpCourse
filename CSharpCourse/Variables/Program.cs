// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");

            int number1 = 1;
            int number2 = 2;

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            number1 = 3;
            Console.WriteLine(number1);

            int number3 = number1 + number2;
            Console.WriteLine("La suma de numero es: " + number3);


        }
    }
}
