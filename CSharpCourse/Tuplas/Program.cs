using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {

            (int id, string name) product = (1, "Cerveza Stout");
            Console.WriteLine($"Id: {product.id} - Nombre: {product.name}");

            // los tuplas si son editables
            product.name = "Cerveza Porter";
            Console.WriteLine($"Id: {product.id} - Nombre: {product.name}");


            var person = (1, "Luke");
            Console.WriteLine($"Id: {person.Item1} - Nombre: {person.Item2}");

            var peoples = new[]
            {
                (1, "Anakin"),
                (2, "Luke"),
                (3, "Leia"),
                (4, "Han"),
            };

            Console.WriteLine("-- Personas ---");
            foreach (var people in peoples )
            {
                Console.WriteLine($"Id: {people.Item1} - Nombre: {people.Item2}");
            }

            (int id, string name)[] peoples2 = new[] 
            {
                (1, "Anakin"),
                (2, "Luke"),
                (3, "Leia"),
                (4, "Han"),
            };

            Console.WriteLine("-- Personas 2 ---");
            foreach (var people in peoples2)
            {
                Console.WriteLine($"Id: {people.id} - Nombre: {people.name}");
            }

            var cityInfo = getLocationMX();
            Console.WriteLine($"Lat: {cityInfo.lat} - Lng: {cityInfo.lng} -  Nombre: {cityInfo.name}");

            var (_,lng,_) = getLocationMX();
            Console.WriteLine($"Lng: {lng}");
        }

        public static (float lat, float lng, string name) getLocationMX()
        {
            float lat = 19.111214f;
            float lng = 99.141619f;
            string name = "CDMX";

            return (lat, lng, name);
        }

    }
}