using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class JuegoDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static JuegoDAO()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static void Eliminar(int codigoJuego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";
                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Modificar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "UPDATE JUEGOS SET PRECIO = @PRECIO, NOMBRE = @NOMBRE, GENERO = @GENERO WHERE CODIGO_JUEGO = @CODIGO";
                comando.Parameters.AddWithValue("@PRECIO", juego.Precio);
                comando.Parameters.AddWithValue("@NOMBRE", juego.Nombre);
                comando.Parameters.AddWithValue("@GENERO", juego.Genero);
                comando.Parameters.AddWithValue("@CODIGO", juego.CodigoJuego);
                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Guardar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO JUEGOS (CODIGO_USUARIO, NOMBRE, PRECIO, GENERO) VALUES (@CODIGO_USUARIO, @NOMBRE, @PRECIO, @GENERO)";
                comando.Parameters.AddWithValue("@CODIGO_USUARIO", juego.CodigoUsuario);
                comando.Parameters.AddWithValue("@NOMBRE", juego.Nombre);
                comando.Parameters.AddWithValue("@PRECIO", juego.Precio);
                comando.Parameters.AddWithValue("@GENERO", juego.Genero);
                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> biblioteca = new List<Biblioteca>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT U.USERNAME, J.CODIGO_JUEGO, J.GENERO, J.NOMBRE FROM USUARIOS U INNER JOIN JUEGOS J ON U.CODIGO_USUARIO = J.CODIGO_USUARIO";
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        biblioteca.Add(new Biblioteca(Convert.ToInt32(dataReader["CODIGO_JUEGO"]), dataReader["GENERO"].ToString(),
                                                        dataReader["NOMBRE"].ToString(), dataReader["USERNAME"].ToString()));
                    }
                }

                return biblioteca;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static Juego LeerPorId(int codigoJuego)
        {
            Juego auxJuego = null;
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        auxJuego = new Juego(Convert.ToInt32(dataReader["CODIGO_JUEGO"]), Convert.ToInt32(dataReader["CODIGO_USUARIO"]),
                            dataReader["GENERO"].ToString(), dataReader["NOMBRE"].ToString(), Convert.ToDouble(dataReader["PRECIO"]));
                    }
                }

                return auxJuego;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
