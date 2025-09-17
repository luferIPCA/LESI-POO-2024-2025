/*
 * by lufer
 * 
 * Adaptado de C# Unleshead
 * Manipulação de Ficheiros e Pastas
 * 
 * Ver: 
 * http://msdn.microsoft.com/en-us/library/k3352a4t%28v=vs.110%29.aspx
 * http://csharp.net-informations.com/file/csharp-file-class.htm
 * 
 * Streams: reading and writing bytes
 *      : FileStream | Stream
 *      
 * Writers/Readers: reading and writing characters
 *      : StreamReader/StreamWriter
 * 
 * 
 * */

using System;

namespace FilesAndFolders
{

    enum X
    {
        A,
        B,
        C
    }
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                int x1 = Apiario.GeraEx();
            }
            catch (NaoEstaAtentoException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int x = int.Parse(Console.ReadLine());
            } 
            catch(FormatException f)
            {
                Console.WriteLine("Atento 1!!" + f.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Atento 2!!" + e.Message);
            }


            #region Enumerados (REVISÔES)

            //foreach (X foo in Enum.GetValues(typeof(X)))
            //{
            //    Console.WriteLine(foo + "= " + ((int)foo).ToString());

            //}

            //foreach (string foo in Enum.GetNames(typeof(X)))
            //{
            //    Console.WriteLine(foo);
            //}

            #endregion

            #region Drives

            //foreach (var drive in DriveInfo.GetDrives())
            //{
            //    Console.WriteLine("{0} - {1}", drive.Name, drive.DriveType);
            //    if (drive.IsReady)
            //    {
            //        Console.WriteLine(drive.DriveFormat);
            //        Console.WriteLine(string.IsNullOrEmpty(drive.VolumeLabel) ? "(no label)" : drive.VolumeLabel);
            //        Console.WriteLine("{0} free of {1}", DoThings.GetSize(drive.TotalFreeSpace), DoThings.GetSize(drive.TotalSize));
            //    }
            //    else
            //    {
            //        Console.WriteLine("(No disk present)");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Folders

            //Console.Write("Path: ");
            //var path = Console.ReadLine();
            //Console.WriteLine();
            //var folder = new DirectoryInfo(path);
            //if (folder.Exists)
            //{
            //    Console.WriteLine("Full name: " + folder.FullName);
            //    Console.WriteLine("Name: " + folder.Name);
            //    Console.WriteLine("Created: " + folder.CreationTime);
            //    Console.WriteLine("Parent: " + folder.Parent.FullName);
            //    Console.WriteLine("Root: " + folder.Root);
            //}


            //try
            //{
            //    if (folder.Exists)
            //    {
            //        foreach (var exe in folder.EnumerateFiles("*.exe", SearchOption.AllDirectories))
            //            Console.WriteLine(exe.FullName);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region TextFiles

            bool b = DoThings.SaveToFile(@"d:\temp\Campeao.txt", "O Benfica é o maior");

            #endregion

            #region File and Collections

            Pessoas p = new Pessoas();
            p.InsertPerson(new Pessoa(12));
            p.InsertPerson(new Pessoa(13));
            p.InsertPerson(new Pessoa(14));
            p.Show();           //É possível?
            //p.Sort();           //É possível?
            //Preserva Hashtable
            p.Save(@"d:\temp\hashData.bin");

            //limpa Hashtable
            p.Limpa();
            p.Show();
            p.Load(@"d:\temp\hashData.bin");
            p.Show();
            Console.ReadKey();
            p.SetHashFields();
            p.Show();

            #endregion

            #region Files and Generics

            #region Colmeias

            Colmeia c1 = new Colmeia(1, DateTime.Now);
            Apiario a = new Apiario("APIMIL");
            a.AddColmeia(c1);
            a.AddColmeia(new Colmeia(2, DateTime.Now));
            a.AddColmeia(new Colmeia(3, DateTime.Now));
            a.AddColmeia(new Colmeia(4, DateTime.Now));

            Console.WriteLine("Inicio Apiario ");
            Console.WriteLine(a.MyToString());

            a.SaveApiario(@"d:\temp\apiario.bin");
            a.SaveApiarioXML(@"d:\temp\apiario.xml");

            a.ClearApiario();

            Console.WriteLine("Apiario Limpo ");
            Console.WriteLine(a.MyToString());

            try
            {
                a.LoadApiario(@"d:\temp\apiario.bin");
            }
            catch(Exception e)
            {

            }

            Console.WriteLine("Fim Apiario ");
            Console.WriteLine(a.MyToString());

            a.ClearApiario();

            Console.WriteLine("Apiario XML ");
            a.LoadApiarioXML(@"d:\temp\apiario.xml");
            Console.WriteLine(a.MyToString());
            
            #endregion

            #region Apicultura

            Apicultura.AddApiario("APIMIL", a);
            Console.WriteLine(Apicultura.MyToString());
            Apicultura.SaveApicultura(@"d:\temp\fnap.bin"); 
            Apicultura.ClearApicultura();

            Console.WriteLine("Apiario Limpo ");
            Console.WriteLine(Apicultura.MyToString());

            Console.WriteLine("Apiario em Ficheiro:");
            Apicultura.LoadApicultura(@"d:\temp\fnap.bin");
            Console.WriteLine(Apicultura.MyToString());


            #endregion


            #endregion

            Console.ReadKey();
        }
    }
}
