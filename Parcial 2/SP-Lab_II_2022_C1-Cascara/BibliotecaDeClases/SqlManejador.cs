using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class SqlManejador
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public SqlManejador()
        {
            conexion = new SqlConnection("Server=.;Database=SP_2D_2022_C1;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public int Insertar(Alumno alumno)
        {
            int rows = 0;
            try
            {
                conexion.Open();
                if(alumno.Dni >=10000000 && alumno.Dni <= 45000000 && !string.IsNullOrEmpty(alumno.NombreCompleto)
                    && alumno.NotaPrimerParcial >= 1 && alumno.NotaPrimerParcial <= 10 && alumno.NotaSegundoParcial >= 1 && alumno.NotaSegundoParcial <= 10 )
                {
                    comando.CommandText = $"INSERT INTO dbo.Alumnos (Dni, NombreCompleto, NotaUno, NotaDos, CalificacionFinal) VALUES (@dni, @nombre, @notaUno, @notaDos, @CalificacionFinal)";
                    comando.Parameters.AddWithValue("@dni", alumno.Dni);
                    comando.Parameters.AddWithValue("@nombre", alumno.NombreCompleto);
                    comando.Parameters.AddWithValue("@notaUno", alumno.NotaPrimerParcial);
                    comando.Parameters.AddWithValue("@notaDos", alumno.NotaSegundoParcial);
                    comando.Parameters.AddWithValue("@CalificacionFinal", alumno.CalificacionFinal);
                    rows = comando.ExecuteNonQuery();
                }
                else
                {
                throw new DatosNoValidosException("Error, uno de los parametros no es valido");
                }
            }
            finally
            {
                conexion.Close();
            }

            return rows;
        }
    }
}
