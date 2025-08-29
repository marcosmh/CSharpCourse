using BD;
using BD.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFrameworkSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            DbContextOptionsBuilder<CsharpContext> optionsBuilder = new DbContextOptionsBuilder<CsharpContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=CsharpBD;User=sa;Password=Admindba$;Encrypt=False;");

            using (CsharpContext context = new CsharpContext(optionsBuilder.Options))
            {

                var beers = context.Beers.ToList();

                foreach (var beer in beers)
                {
                    Console.WriteLine($"Id: {beer.Id} - Name: {beer.Name} ");
                }

            }

        }

    }

}