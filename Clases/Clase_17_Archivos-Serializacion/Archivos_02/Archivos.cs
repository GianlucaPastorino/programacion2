using System;
using System.IO;

namespace Archivos_02
{
    public static class Archivo
    {

        static string path;

        static Archivo()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos\";
        }

        public static void Escribir(string datos)
        {
            string nombreArchivo = path + "Archivos_02_" + DateTime.Now.ToString("HH_mm_ss") + ".txt";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                datos += "\nejemplo numero 2";
                File.WriteAllText(nombreArchivo, datos); // Recibe la ruta completa y lo que quiero escribir. Otra forma de hacer lo de StreamWriter.
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }


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
                        if (path.Contains("Archivos_02"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        informacionRecuperada = File.ReadAllText(archivo); // Lee todo el texto de la ruta indicada
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
