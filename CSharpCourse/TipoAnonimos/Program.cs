using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var anakin = new
            {
                Name = "Anakin",
                Country =  "Tatooine"
            };

            Console.WriteLine($"Nombre: {anakin.Name} - Country: {anakin.Country}. ");

            var beers = new[]
            {
                new { Name = "Red", Brand =  "Belirium" },
                new { Name = "London Porter", Brand =  "Fullers" },
            };

            Console.WriteLine("-- Cervezas ----");
            foreach (var beer in beers)
            {
                Console.WriteLine($"Nombre: {beer.Name} - Country: {beer.Brand}. ");
            }
            
        }
    }
}