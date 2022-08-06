using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_01
{
    public static class Archivo
    {

        static string path;

        static Archivo()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // La ruta va a ser el escritorio de la pc en la que esté corriendo el programa.
            path += @"\Archivos-Serializacion\"; // Nombre de la carpeta que le quiero concatenar al path (al escritorio).
        }

        // CREACIÓN/ESCRITURA DE ARCHIVO.
        public static void Escribir(string datos)
        {
            string nombreArchivo = path + "Archivos_01_" + DateTime.Now.ToString("HH_mm_ss") + ".txt";
            try
            {
                if (!Directory.Exists(path)) // Chequeo que la carpeta en la que quiero guardar exista
                {
                    Directory.CreateDirectory(path); // Si no existe la creo
                }

                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                    // Clase para escribir archivos. Le paso la ruta + el nombre del archivo. Si no existe lo crea. Si existe lo pisa.
                    // Si existe pero le paso un segundo parámetro en "true", me agrega el contenido al final de la última linea del archivo.
                {

                    datos += "\nejemplo numero 1";
                    sw.WriteLine(datos);
                    sw.WriteLine("\n-----------------------------");
                    sw.WriteLine("\nlA FECHA ES: ");
                    sw.WriteLine(DateTime.Now.ToString());


                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        // LECTURA Y RECUPERACIÓN DE DATOS.
        public static string Leer()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            try
            {

                if (Directory.Exists(path))
                {
                    // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains("Archivos_01"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        using (StreamReader sr = new StreamReader(archivo))
                        {
                            string line;
                            // Lee y muestra lineas desde el archivo hasta el fin del mismo.

                            while ((line = sr.ReadLine()) != null)
                            {
                                informacionRecuperada += "\n" + line;
                            }
                            // informacionRecuperada = sr.ReadToEnd(); hace lo mismo que el while
                        }
                    }
                }

                return informacionRecuperada;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

    }
}
