using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
	public class BeerBD : DB
	{
        
        public BeerBD(string server, string db, string user, string password) :
            base(server, db, user, password)
        {
            
        }

        public List<Beer> getAllBeers()
        {
            Connect();
            List<Beer> beers = new List<Beer>();
            string query = "SELECT Id, Name, BrandId FROM BEER";

            SqlCommand command = new SqlCommand(query,_connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);
                beers.Add(new Beer(id, name, brandId));
            }

            Close();
            int registros = beers.Count;

            if (registros > 0)
            {
                Console.WriteLine($"Se encontraron {registros} registros en la base de datos. ");
            } else
            {
                Console.WriteLine($"{registros} - No se encontraron registros en la base de datos ");
            }

            return beers;
        }

        public Beer getIdBeer(int id)
        {
            Connect();
            Beer beer = null;
            string query = "SELECT Id, Name, BrandId FROM BEER WHERE Id = @id";

            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int pkId = reader.GetInt32(0);
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);
                beer = new Beer(pkId, name, brandId);
            }

            Close();
            
            if (beer == null)
            {
                Console.WriteLine($"0 - No se encontraron registros en la base de datos ");
            }
            
            return beer;
        }

        public void Add(Beer beer)
        {
            Connect();
            string query = "INSERT INTO Beer(Name, BrandId) " +
                "VALUES(@name, @brandId) ";

            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.ExecuteNonQuery();
            Console.WriteLine("Se ha registrado una cerveza en la base de datos.");
            Close();
        }

        public void Edit(Beer beer)
        {
            Connect();
            string query = "UPDATE Beer SET Name = @name, BrandId = @brandId WHERE Id = @Id ";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@Id", beer.Id);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.ExecuteNonQuery();
            Console.WriteLine("Se ha editado una cerveza en la base de datos.");
            Close();
        }

        public void Delete(int id)
        {
            Connect();
            string query = "DELETE FROM Beer WHERE Id = @Id ";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            Console.WriteLine("Se ha eliminado una cerveza en la base de datos.");
            Close();
        }
    }
}

