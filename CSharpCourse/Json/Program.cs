using System;
using System.Text.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Pikantus",
                Brand = "Erdimger"
            };

            //string jsong = "{\"Name\": \"Pikantus\",\"Brand\": \"Erdimger\" } ";
            string json = JsonSerializer.Serialize(myBeer);
            Beer beer = JsonSerializer.Deserialize<Beer>(json);
            Console.WriteLine(json);
            Console.WriteLine(beer);

            Beer[] beers = new Beer[]
            {
                new Beer()
                {
                    Name = "Corona",
                    Brand = "Modelo"
                },
                new Beer()
                {
                    Name = "Tecate",
                    Brand = "Moctezuma"
                }
            };

            /*
            string jsong2 = "["+
            " {\"Name\": \"Corona\",\"Brand\": \"Modelo\" } " +
            " {\"Name\": \"Tecate\",\"Brand\": \"Moctezuma\" } " +
            "]";
            */

            Console.WriteLine("-----");
            string json2 = JsonSerializer.Serialize(beers);
            Beer[] cervezas = JsonSerializer.Deserialize<Beer[]>(json2);
            Console.WriteLine(json2);
            Console.WriteLine(cervezas);

        }
    }


    public class Beer
    {
        public string Name { get; set; }

        public string Brand { get; set; }

    }
} 