using System;

namespace SentenciasIfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;
            bool areHaveMoney = true;

            if(areYouHungry && areHaveMoney && isOpenRestaturant("Lonches pepe", 11))
            {
                Console.WriteLine("Come algo.");
            }
            else
            {
                Console.WriteLine("Descansa..");
            }

        }

        static bool isOpenRestaturant(string name, int hour = 0)
        {
            if(name == "Lonches pepe" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if(name == "Lonches 24 Horas")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}