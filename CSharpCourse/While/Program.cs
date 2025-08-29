using System;

namespace While
{
    class Program
    {

        static void Main(string[] args)
        {

            int i = 0;

            while(i < 10 )
            {
                Console.WriteLine("Interaccion de i: " + i);
                i++;
            }

            int j = 0;
            while( j < 100 )
            {
                if (j > 10)
                    break;

                Console.WriteLine("Interaccion de j: " + j);
                j++;

            }


            string[] friends = new string[6]
            {
                "Anakin",
                "Luke",
                "Leia",
                "Chewie",
                "R2D2",
                "C3PO"
            };

            Console.WriteLine("------");
            int x = 0;
            while( x < friends.Length )
            {
                Console.WriteLine(x + " - Friends: " + friends[x]);
                x++;
            }

            Console.WriteLine("------");
            bool run = false;
            do
            {
                Console.WriteLine("entro una vez");

            } while (run);

            Console.WriteLine("------>");
            int z = 0;
            do
            {
                Console.WriteLine(z + " - Friends: " + friends[z]);
                z++;

            } while ( z < friends.Length );



        }
    }
}