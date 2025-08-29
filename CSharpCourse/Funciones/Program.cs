using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;

            Show();
            sumar(a, b);
            multiplicar(9, 7);
        }

        static int multiplicar(int num1, int num2)
        {
            int multi = num1 * num2;

            return multi;

        }

        static void sumar(int a, int b)
        {
            int suma = a + b;

            Console.WriteLine("La suma es : " + suma);
        }

        static void Show()
        {
            Console.WriteLine("Hola soy un texto que se imprime");

        }

    }
}