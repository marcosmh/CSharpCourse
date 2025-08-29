using System;

namespace ExcepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Beer beer = new Beer()
                {
                    Name = "London Porter",
                    //Brand = "Fuller"
                };

                Console.WriteLine(beer);

            }
            catch(InvalidBeerException e)
            {
                Console.WriteLine("Error: \n[ "+ e +" ]");
            }
            
        }
    }

    public class InvalidBeerException : Exception
    {
        public InvalidBeerException() :
            base("La cerveza no tieme nombre o marca, por lo cual es invalidad")
        {

        }
    }

    public class Beer
    {
        public string Name { get; set; }

        public string Brand { get; set; }


        public override string ToString()
        {
            if (Name == null || Brand == null)
                throw new InvalidBeerException();

            return $"Cerveza: {Name} - Brand: {Brand}";
        }

    }
}