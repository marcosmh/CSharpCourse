using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
	public abstract class DB
	{
		private string _connectionstring;

		protected SqlConnection _connection = new SqlConnection();



		public DB(string server, string db, string user, string password)
		{
			_connectionstring = $"Data Source={server}; Initial Catalog={db};" +
				$"User={user}; Password={password}; ";

		}

		public void Connect()
		{
			try
			{
                _connection = new SqlConnection(_connectionstring);
                _connection.Open();
                Console.WriteLine("Conexion Abierta.");
            }
			catch(SqlException e)
			{
				Console.WriteLine("Error al abrir la conexion a la base de datos. \n [ " + e + " ] ");
			}
			

        }

		public void Close()
		{
			try
			{

                if (_connection != null)
                {
					_connection.Close();
                    Console.WriteLine("Conexion Cerrada.");
                }

            }
			catch(SqlException e) {
                Console.WriteLine("Error al cerrar la conexion en la base de datos. \n [ " + e + " ] ");
            }

        }
		
    }
}

