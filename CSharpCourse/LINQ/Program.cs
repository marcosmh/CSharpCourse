using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer
                {
                    Name = "Corona", Country = "Mexico",
                },
                new Beer
                {
                    Name = "Delirium", Country = "Belgica",
                },
                new Beer
                {
                    Name = "Erdinger", Country = "Alemania",
                }

            };

            Console.WriteLine("\n-- Cervezas ---");
            foreach (var beer in beers)
                Console.WriteLine(beer);


            Console.WriteLine("\n----- LINQ ------");

            // select
            Console.WriteLine("\n--> Select");
            var beersName = from b in beers
                            select new
                            {
                                Name = b.Name,
                                Letters = b.Name.Length,
                                Fixed = 1
                            };

            Console.WriteLine("\n--> Select con Operaciones");
            foreach (var beer in beersName)
                Console.WriteLine($"{beer.Name} - {beer.Letters} - {beer.Fixed} ");


            var beersNameReal = from b in beersName
                                select new
                                {
                                    Name = b.Name
                                };

            Console.WriteLine("\n--> Select - solo los nombres");
            foreach (var beer in beersName)
                Console.WriteLine($"{beer.Name}");

            var beerMexico = from b in beers
                             where b.Country == "Mexico"
                             || b.Country == "Alemania"
                             select b;

            Console.WriteLine("\n--> Filtando paises");
            foreach (var beer in beerMexico)
                Console.WriteLine(beer);


            var orderedBeers = from b in beers
                               orderby b.Country
                               select b;


            Console.WriteLine("\n--> Select - ordenados por pais");
            foreach (var beer in orderedBeers)
                Console.WriteLine(beer);


        }
    }


    public class Beer
    {
        public string Name { get; set; }

        public string Country { get; set; }


        public override string ToString()
        {
            return $"Cerveza: {Name} - Country: {Country}";

        }

    }
}