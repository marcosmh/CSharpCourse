using System;
using System.IO;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("/Users/markcode/Desktop/holaMundo/hola.txt");
                Console.WriteLine(content);
                //string content2 = File.ReadAllText("/Users/markcode/Desktop/holaMundo/pato.txt");
                //Console.WriteLine(content2);

                throw new Exception("Ha ocurrido un error inexperado.");

            }
            catch(FileNotFoundException fe)
            {
                Console.WriteLine("No se encuentra el archivo. \n [ " + fe + "+ ] ");
            }
            catch(Exception ex)
            {
                Console.WriteLine("No ocurrido un error. \n [ " + ex + " ] ");
            }
            finally
            {
                Console.WriteLine("Este fragmento de codigo siempre se ejecuta.");
            }
            
        }

    }
}