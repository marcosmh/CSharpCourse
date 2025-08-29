using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            var beers = new List<Beer>()
            {
                new Beer()
                {
                    Name = "Corona", Country = "Mexico",
                },
                new Beer()
                {
                    Name = "Delirium", Country = "Belgica",
                },
                new Beer()
                {
                    Name = "Erdinger", Country = "Alemania",
                },
                new Beer()
                {
                    Name = "Minerva", Country = "Mexico",
                }

            };

            var countries = new List<Country>()
            {
                new Country()
                {
                    Name = "Mexico", Continent = "America"
                },
                new Country()
                {
                    Name = "Belgica", Continent = "Europa"
                },
                new Country()
                {
                    Name = "Alemania", Continent = "Europa"
                }
            };


            var beerWithContinent = from b in beers
                                    join c in countries
                                    on b.Country equals c.Name
                                    select new { b.Name, b.Country, c.Continent };

            foreach(var beer in beerWithContinent)
            {
                Console.WriteLine($"{beer.Name} - {beer.Country} - {beer.Continent} ");
            }


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

    public class Country
    {
        public string Name { get; set; }

        public string Continent { get; set; }


        public override string ToString()
        {
            return $"Pais: {Name} - Continente: {Continent}";

        }

    }
}