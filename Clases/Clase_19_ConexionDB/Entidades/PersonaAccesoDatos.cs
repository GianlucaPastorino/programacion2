using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static PersonaAccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog=CLASE19_DB;Integrated Security=True"; // "Ruta" a la que se va a conectar
            connection = new SqlConnection(connectionString);
            command = new SqlCommand(); // Comando se utiliza para hacer las consultas.
            command.CommandType = System.Data.CommandType.Text; // Nuestro tipo de comando va a ser de tipo texto plano.  
            command.Connection = connection; // Le paso a mi comando cómo se va a conectar (con mi obj connection).
        }

        public static void Guardar(string nombre) // INSERT
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Personas (Nombre) VALUES (@Nombre)";
                command.Parameters.AddWithValue("@Nombre", nombre);
                int rows = command.ExecuteNonQuery(); // Devuelve cantidad de filas afectadas (aparte de ejecutar la consulta).
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(string nuevoNombre, int id) // UPDATE
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Personas SET Nombre = @Nombre WHERE ID = @ID";
                command.Parameters.AddWithValue("@Nombre", nuevoNombre);
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery(); // Devuelve cantidad de filas afectadas (aparte de ejecutar la consulta).
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(int id) // DELETE
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM Personas WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery(); // Devuelve cantidad de filas afectadas (aparte de ejecutar la consulta).
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                connection.Open(); // Abro la conexión a la db.
                command.CommandText = "SELECT * FROM Personas"; // Texto de mi consulta.

                using (SqlDataReader dataReader = command.ExecuteReader()) // Uso ExecuteReader porque mi consulta me tiene que retornar registros de la tabla.
                {
                    while (dataReader.Read()) // Me lee de a un registro de mi tabla.
                    {
                        personas.Add(new Persona(dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["ID"])));
                        // Dato de la columna Nombre y dato de la columan ID.
                    }
                }

                return personas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close(); // Cierro la conexión a la bd.
            }
        }

        public static Persona Leer(int id)
        {
            Persona persona = null;

            try
            {
                command.Parameters.Clear(); // Limpio la lista de parámetros porque es estático.
                connection.Open(); // Abro la conexión a la db.
                command.CommandText = $"SELECT * FROM Personas WHERE ID = @ID"; // Texto de mi consulta.
                command.Parameters.AddWithValue("@ID", id); // Parametrizo para evitar inyección SQL.

                using (SqlDataReader dataReader = command.ExecuteReader()) // Uso ExecuteReader porque mi consulta me tiene que retornar registros de la tabla.
                {
                    while (dataReader.Read())
                    {
                        persona = new Persona(dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["ID"]));
                        // Dato de la columna Nombre y dato de la columan ID.
                    }
                }

                return persona;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close(); // Cierro la conexión a la bd.
            }
        }
    }
}
