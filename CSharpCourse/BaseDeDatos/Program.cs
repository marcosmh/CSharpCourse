using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            BeerBD db = null;
            bool again = true;
            int op = 0;

            try
            {
                db = new BeerBD("localhost", "CsharpBD", "sa", "Admindba$");

                do
                {
                    ShowMenu();
                    Console.WriteLine("Elige una opcion: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Show(db);
                            break;
                        case 2:
                            Add(db);
                            break;
                        case 3:
                            Edit(db);
                            break;
                        case 4:
                            Delete(db);
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
            catch(SqlException e)
            {
                var msg = "Ha ocurrido un error en la base.\n";
                Console.WriteLine(msg + " [ " + e + " ] ");
            }
            
            
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
        public static void Show(BeerBD db)
        {
            Console.Clear();
            List<Beer> beers = db.getAllBeers();

            Console.WriteLine("\n -- Lista de Cervezas -- ");
            foreach (var beer in beers)
            {
                Console.WriteLine($"Id: {beer.Id} - Name: {beer.Name} ");
            }

        }

        public static void Add(BeerBD db)
        {
            Console.Clear();
            Console.WriteLine("\n -- Agregar Cerveza -- ");
            Console.WriteLine("Escribe el nombre de la cerveza");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la Marca");
            int brandId = int.Parse(Console.ReadLine());

            Beer beer = new Beer(name,brandId);
            db.Add(beer);
            Console.WriteLine("La Cerveza se guardo correctamente!!");

        }

        public static void Edit(BeerBD db)
        {
            Console.Clear();
            Show(db);
            Console.WriteLine("\n -- Editar Cerveza -- ");

            Console.WriteLine("Escribe el id de la Cerveza a Editar: ");
            int id = int.Parse(Console.ReadLine());
            
            Beer beer = db.getIdBeer(id);

            if(beer != null)
            {
                Console.WriteLine("Escribe el nombre: ");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe el id de la Marca: ");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId = brandId;

                db.Edit(beer);
                Console.WriteLine("La Cerveza se editó correctamente!!");
            }
            else
            {
                Console.WriteLine("La Cerveza no existe!!");
            }

           
        }

        public static void Delete(BeerBD db)
        {
            Console.Clear();
            Show(db);
            Console.WriteLine("\n -- Eliminar Cerveza -- ");
            Console.WriteLine("Escribe el id de la Cerveza a eliminar: ");
            int id = int.Parse(Console.ReadLine());
            Beer beer = db.getIdBeer(id);

            if(beer != null)
            {
                db.Delete(id);
                Console.WriteLine("La Cerveza se eliminó correctamente!!");
            }
            else
            {
                Console.WriteLine("La Cerveza no existe!!");
            }

        }

    }
}