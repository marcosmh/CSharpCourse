using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[6]
            {
                "Anakin",
                "Luke",
                "Leia",
                "Chewie",
                "R2D2",
                "C3PO"
            };


            for( int i = 0; i < friends.Length; i++ )
            {
                Console.WriteLine(i + " - Friends: " + friends[i]);
            }

            Console.WriteLine("---------");
            foreach (string nombre in friends)
            {
                Console.WriteLine("Nombre: -> " +nombre);
            }


        }
    }
}