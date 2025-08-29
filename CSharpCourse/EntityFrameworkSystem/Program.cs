using BD;
using BD.Data;
using BD.Models;
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

            bool again = true;
            int op = 0;

            /*
            using (CsharpContext context = new CsharpContext(optionsBuilder.Options))
            {

                var beers = context.Beers.ToList();

                foreach (var beer in beers)
                {
                    Console.WriteLine($"Id: {beer.Id} - Name: {beer.Name} ");
                }

            }
            */

            do
            {
                ShowMenu();
                Console.WriteLine("Elige una opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Show(optionsBuilder);
                        break;
                    case 2:
                        Add(optionsBuilder);
                        break;
                    case 3:
                        Edit(optionsBuilder);
                        break;
                    case 4:
                        Delete(optionsBuilder);
                        break;
                    case 0:
                        again = false;
                        break;
                    default:
                        Console.WriteLine("No existe la opcion seleccionada.");
                        break;
                }


            } while (again);

        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n -------Menú--------");
            Console.WriteLine("1.- Mostrar");
            Console.WriteLine("2.- Agregar");
            Console.WriteLine("3.- Editar");
            Console.WriteLine("4.- Eliminar");
            Console.WriteLine("0.- Salir");

        }

        public static void Show(DbContextOptionsBuilder<CsharpContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("\n -- Lista de Cervezas -- ");

            using (CsharpContext context = new CsharpContext(optionsBuilder.Options))
            {
                //List<Beer> beers = context.Beers.OrderBy(b => b.Name).ToList();
                List<Beer> beers = (from b in context.Beers
                                   //where b.BrandId == 2
                                  orderby b.Name
                                  select b).ToList()
                                  ;

                foreach (var beer in beers)
                {
                    Console.WriteLine($"Id: {beer.Id} - Name: {beer.Name} - Marca: {beer.Brand.Name}  ");
                }

            }

        }

        public static void Add(DbContextOptionsBuilder<CsharpContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("\n -- Agregar Cerveza -- ");
            Console.WriteLine("Escribe el nombre de la cerveza");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la Marca");
            int brandId = int.Parse(Console.ReadLine());

            using (CsharpContext context = new CsharpContext(optionsBuilder.Options))
            {
                Beer beer = new Beer();
                beer.Name = name;
                beer.BrandId = brandId;

                context.Add(beer);
                context.SaveChanges();
                Console.WriteLine("La Cerveza se guardo correctamente!!");
            }            

        }

        public static void Edit(DbContextOptionsBuilder<CsharpContext> optionsBuilder)
        {
            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("\n -- Editar Cerveza -- ");

            Console.WriteLine("Escribe el id de la Cerveza a Editar: ");
            int id = int.Parse(Console.ReadLine());


            using (CsharpContext context = new CsharpContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);

                if (beer != null)
                {
                    Console.WriteLine("Escribe el nombre: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Escribe el id de la Marca: ");
                    int brandId = int.Parse(Console.ReadLine());

                    beer.Name = name;
                    beer.BrandId = brandId;

                    context.Entry(beer).State = EntityState.Modified;
                    context.SaveChanges();
                    Console.WriteLine("La Cerveza se editó correctamente!!");
                }
                else
                {
                    Console.WriteLine("La Cerveza no existe!!");
                }
            }

        }

        public static void Delete(DbContextOptionsBuilder<CsharpContext> optionsBuilder)
        {
            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("\n -- Eliminar Cerveza -- ");
            Console.WriteLine("Escribe el id de la Cerveza a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            using (CsharpContext context = new CsharpContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);

                if (beer != null)
                {
                    context.Remove(beer);
                    context.SaveChanges();
                    Console.WriteLine("La Cerveza se eliminó correctamente!!");
                }
                else
                {
                    Console.WriteLine("La Cerveza no existe!!");
                }
            }
                
        }

    }

}