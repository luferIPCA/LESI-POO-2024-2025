/*
 * by lufer
 * 
 * Manipulação de Ficheiros
 * 
 * 
 * Streams: reading and writing BYTES
 *      : FileStream
 *      
 * Writers/Readers: reading and writing characters (text)
 *      : StreamReader/StreamWriter
 * 
 * 
 * */
using System;
using System.IO;

namespace FilesAndFolders
{
    class DoThings
    {
        /// <summary>
        /// Auxiliar
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string GetSize(double size)
        {
            var prefixes = new[] { "bytes", "KB", "MB", "GB", "TB", "PB", "EB" };
            int i;
            for (i = 0; size > 1000; i++)
            {
                size /= 1024;
            }
            return string.Format("{0:##0.##} {1}", size, prefixes[i]);
        }

        /// <summary>
        /// Grava um paragrafo em ficheiro de texto
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool SaveToFile(string fileName, string t)
        {
            //WriteAllText: cria ficheiro, grava e fecha
            //File.WriteAllText(fileName, t);

            if (File.Exists(fileName))
            {
                try
                {
                    //[com Stream]
                    //ou 
                    //StreamWriter sw = new StreamWriter(fileName, true);
                    StreamWriter sw = File.AppendText(fileName);
                    sw.WriteLine(t);
                    sw.Flush();
                    sw.Close();

                    //Usando Streams directamente
                    //FileStream sw = File.OpenWrite(fileName);
                    //ou 
                    //FileStream sw = new FileStream(fileName,FileMode.Open, FileAccess.Read);
                    //byte[] byteData = null;
                    //byteData = Encoding.ASCII.GetBytes(t);
                    //sw.Write(byteData, 0, byteData.Length);
                    //sw.Close();
                    return true;
                }
                catch (Exception e)
                {
                    //Console.Write("ERRO:" + e.Message);
                    return false;
                }
            }
            else
            { 
                StreamWriter sw = File.CreateText(fileName);
                sw.WriteLine(t);
                sw.Flush();
                sw.Close();
            }
            return false;
        }

        /// <summary>
        /// Grava muito texto em ficheiro de texto
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool SaveToFileMany(string fileName, string[] t)
        {
            if (File.Exists(fileName))
            {
                File.WriteAllLines(fileName, t);
                return true;
            }
            return false;
        }

    }
}
