/*
 * by lufer
 * 
 * Manipulação de Ficheiros
 * 
 * 
 * Streams: reading and writing bytes
 *      : FileStream
 *      
 * Writers/Readers: reading and writing characters
 *      : StreamReader/StreamWriter
 * 
 * Preservar Collections
 * 
 * GitHub
 * https://github.com/mono/MonoGame/wiki/Tutorials:-Getting-Started-on-Windows-with-Visual-Studio
 * https://visualstudiogallery.msdn.microsoft.com/abafc7d6-dcaa-40f4-8a5e-d6724bdb980c
 * 
 * */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;   //serialização
using System.Xml.Serialization;

namespace FilesAndFolders
{
    #region APICULTURA_XML
    [Serializable]
    public class Colmeia
    {
        //[NonSerialized]
        int cod;
        //[NonSerialized]
        DateTime data;
        [NonSerialized]
        double custo;

        public Colmeia() { }
        public Colmeia(int i, DateTime d)
        {
            cod = i;
            data = d;
        }

        public int Code { set { cod = value; } get { return cod; } }
        //public int Code { set; get; }
        public DateTime Data { set { data = value; } get { return data; } }        
    }

    [Serializable]
    /// <summary>
    /// Descreve Apiários
    /// </summary>
    public class Apiario
    {
        public List<Colmeia> apiario;// = new List<Colmeia>();
        public string associacao;


        public static int GeraEx()
        {
            throw new NaoEstaAtentoException("Ups");
            return 2;
        }

        public Apiario()
        {
            apiario = new List<Colmeia>();
            associacao = "";
        }
        public Apiario(string assoc)
        {
            apiario = new List<Colmeia>();
            associacao = assoc;
        }
        public bool AddColmeia(Colmeia c)
        {
            //testar se ainda não existe
            if (!apiario.Contains(c))
            {
                apiario.Add(c);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Preservar
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public  bool SaveApiario(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, apiario);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }

        /// <summary>
        /// Preservar
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveApiarioXML(string fileName)
        {
            try
            {           
                XmlSerializer serializer = new XmlSerializer(typeof(List<Colmeia>));
                TextWriter textWriter = new StreamWriter(fileName);
                serializer.Serialize(textWriter, apiario);
                textWriter.Close();
                return true;
            }
            catch (IOException e)
            {
                //Console.Write("ERRO:" + e.Message);
                throw e;
            }
        }


        public void ClearApiario()
        {
            apiario.Clear();
        }

        /// <summary>
        /// Load Data
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public  bool LoadApiario(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    apiario = (List<Colmeia>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
                catch (Exception e)
                {

                }
            }
            return false;
        }

        public  bool LoadApiarioXML (string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    XmlSerializer xs = new XmlSerializer(typeof(List<Colmeia>));
                    apiario = (List<Colmeia>)xs.Deserialize(stream);
                   
                    return true;
                }
                catch (IOException e)
                {
                    //Console.Write("ERRO:" + e.Message);
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Auxiliar
        /// </summary>
        /// <param name="data"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool SaveStrings(List<string> data, string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (string line in data)
                file.WriteLine(line);
            file.Close();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string MyToString()
        {
            string s = "";
            foreach (Colmeia c in apiario)
            {
                s += String.Format("Id= {0} Data= {1}\n", c.Code, c.Data);
            }
            return s;
        }

    }

    [Serializable]
    /// <summary>
    /// Gere Aplicultura nacional (Federação Nacional de Apicultura)
    /// </summary>
    public class Apicultura
    {
        static Dictionary<string, Apiario> fnap = new Dictionary<string, Apiario>();

        public static bool AddApiario(string associacao, Apiario a)
        {
            //testar...
            fnap.Add(associacao,a);
            return true;
        }

        /// <summary>
        /// Preservar Apicultura
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool SaveApicultura(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, fnap);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                //Console.Write("ERRO:" + e.Message);
                throw e;
            }
        }

        /// <summary>
        /// Preservar
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool SaveApiculturaXML(string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Dictionary<string,Apiario>));
                TextWriter textWriter = new StreamWriter(fileName);
                serializer.Serialize(textWriter, fnap);
                textWriter.Close();
                return true;
            }
            catch (IOException e)
            {
                //Console.Write("ERRO:" + e.Message);
                throw e;
            }
        }


        public static void ClearApicultura()
        {
            fnap.Clear();
        }

        /// <summary>
        /// Load Data
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool LoadApicultura(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length>0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    fnap = (Dictionary<string,Apiario>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    //Console.Write("ERRO:" + e.Message);
                    throw e;
                }
            }
            return false;
        }

        public static bool LoadApiculturaXML(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    XmlSerializer xs = new XmlSerializer(typeof(Dictionary<string, Apiario>));
                    fnap = (Dictionary<string, Apiario>)xs.Deserialize(stream);
                    return true;
                }
                catch (IOException e)
                {
                    //Console.Write("ERRO:" + e.Message);
                    throw e;
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string MyToString()
        {
            string s = "";
            foreach (string c in fnap.Keys)
            {
                Apiario a = fnap[c];
                Console.WriteLine("Colmeias da {0}\n", a.associacao);
                foreach(Colmeia col in a.apiario)
                {
                    s += String.Format("Colmeia= {0} Data= {1}\n", col.Code, col.Data);
                }
            }
            return s;
        }

    }

    #endregion

    #region PESSOAS

    [Serializable]
    public class Pessoa
    {
        
        public int idade;   //cuidado!

        //atributo "perfil" é calculado!
        [NonSerialized]
        public int perfil;   //cuidado!


        public Pessoa(int i)
        {
            idade = i;
            perfil = idade * 2;
        }

        public override string ToString()
        {
            return "Idade = " + idade + " Perfil=" + perfil;
        }

    }

   [Serializable]
    public class Pessoas
    {
        const int MAX = 11;
        Hashtable dados = new Hashtable();   //private
        /// <summary>
        ///  Write the data to a bynary file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool Save(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, dados);      //hashtable
                s.Flush();
                s.Close();
                s.Dispose();
            }
            catch(Exception e)
            {
                throw; //algo se passou
            }
            return true;
        }

        public bool Load(string fileName)
        {
            try
            {
                //Hashtable aux = null;
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                dados = (Hashtable)b.Deserialize(s);
                s.Flush();
                s.Close();
                s.Dispose();
                return true;
            }
            catch
            {
                throw new Exception("Erro");
            }
        }

        public bool InsertPerson(Pessoa p)
        {
            if (!dados.ContainsValue(p))
            {
                //atributo é calculado!
                p.perfil = p.idade * 2;
                dados.Add(HashFunction(p), p);
                return true;
            }
            return false;
        }


        public bool Limpa()
        {
            dados.Clear();
            return true;
        }

        /// <summary>
        /// Função de Hash auxiliar
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int HashFunction(Pessoa p)
        {
            return (p.idade % MAX);
        }

        public void Show()
        {
            // show the result
            foreach (DictionaryEntry entry in dados)
            {
                Console.WriteLine("{0}={1}", entry.Key, ((Pessoa)entry.Value).ToString());
            }
        }

        public bool SetHashFields()
        {
            foreach (object i in dados.Keys)
            {

                ((Pessoa)dados[i]).perfil = ((Pessoa)dados[i]).idade * 2;
            }
            return true;
        }

        public void Sort()
        {

        }


    }
    #endregion

    #region OUTROS

    public class Varios
    {
        /// <summary>
        /// Show File contents with StreamReader
        /// Adaptado de https://www.c-sharpcorner.com/article/working-with-c-sharp-streamreader/
        /// </summary>
        /// <param name="s"></param>
        public static void ShowFile(string s)
        {
            string fileName = s;
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
    #endregion
}
