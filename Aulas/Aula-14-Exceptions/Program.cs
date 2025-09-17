
/*
 * 
 * Tratamento de Excepções
 * 
 * by lufer
 * 
 * Exception : SystemException | ApplicationException
 * 
 * 
 * h1: try-catch
 * h2: try-finally
 * h3: try-catch-finally
 * 
 * try{
 * }
 * catch(Exception e)
 * {
 * }
 * finnaly
 * {
 * }
 * 
 * throw
 *
 * */


using System;
using System.IO;
using System.Text;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ANALISAR ERROS DE EXECUÇÃO

            // acesso a posições indevidas de arrays
            // conversão errada de tipos de dados
            // operações numéricas inválidas

            //Ex1
            int a, b;

            int[] val = { 2, 3, 4 };

            //
            //a = int.Parse(args[0]);
            //b = int.Parse(args[1]);

            //a = int.Parse(Console.ReadLine());
            //int soma = a + b;
            //Console.WriteLine("{0} + {1} = {2}", a, b, soma);

            //Ex2
            //double x = (double)2 / 0;             //é suportado mas não serve para nada...
            //double d1 = DivideMal(2, 0);


            //Ex3
            //DateTime d1 = DateTime.Parse("120-12-2012");  //...Qual a exceção que é gerada?
            //DateTime d2 = NovaData("120-12-2012");
#endregion

            #region SUPORTAR_ERROS

            try
            {
                a = int.Parse(args[0]);
                b = int.Parse(args[1]);
                int soma = a + b;
                Console.WriteLine("{0} + {1} = {2}", a, b, soma);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Faltam parâmetros: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro: Não indicou dois números!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: {0}.", e.Message);
            }
            finally
            {
                Console.WriteLine("Finalmente...");
            }

            #endregion

            #region ERRO_CALCULOS

            //int aux;
            //try
            //{
            //    //ler valores
            //     aux= Divide(12, 0);
            //     Console.WriteLine("Divi=" + aux.ToString());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //return;

            #endregion

            #region ERRO_ARRAYS

            //int[] aux1 = new int[2];
            //int i=-1;

            //try
            //{
            //    //ler índice do array
            //    i = int.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //    i = 0;
            //}

            //try
            //{
            //    aux1[i] = 12;
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region ERRO_DATAS
            try
            {
                //DateTime d = DateTime.Parse("120-12-2012");
                DateTime d = NovaData("120-12-2012");
                Console.WriteLine("Data= " + d.ToString());
            }            
            catch (FormatException f)
            {
                Console.WriteLine("ERRO= " + f.Message);
            }
            catch (DataInvalidaException ee)         //minha exceção
            {
                Console.WriteLine("ERRO= " + ee.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO= " + ex.Message);
            }
            #endregion

            #region ERROS_FICHEIROS            
            System.IO.FileStream file = null;
            //System.IO.FileInfo fileinfo = new System.IO.FileInfo(@"C:\temp\file.txt");
            FileInfo fileInfo = new FileInfo(@"C:\temp\file.txt");
            try
            {
                using (StreamWriter sw = fileInfo.CreateText())
                {
                    sw.WriteLine("Viva o Benfica");
                }

                //using (StreamReader sr = fileInfo.OpenText())
                //{
                //    string s = "";
                //    while ((s = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(s);
                //    }
                //}

                //fileInfo.Delete();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // se OpenWrite falhou! 
                if (file != null)
                {
                    Console.WriteLine("Onde está o ficheiro?");
                    file.Close();
                }
            }

            #endregion

        }

        #region METODOS AUXILIARES

        /// <summary>
        /// Divisão sem controlo de erros...
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>         
        public static int DivideMal(int x, int y)
        {           
                return x / y;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>         
        public static int Divide(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException e)
            {
                
                throw new Exception("Nem penses dividir por Zero..." + e.Message);
            }

            //ou
            //if (y == 0)
            //    throw new System.DivideByZeroException();
            //return x / y;
        }


        /// <summary>
        /// Gerar uma nova data a partir de uma string
        /// </summary>
        /// <param name="d">valor da data</param>
        /// <returns></returns>
        public static DateTime NovaData(string d)
        {
            try
            {
                return (DateTime.Parse(d));
            }
            catch (Exception e)
            {
                //throw;               
                //throw new System.FormatException("Fui eu que gerei");
                //throw new DataInvalidaException();
                throw new DataInvalidaException("Insira uma data correta...o tripeiro!",e);
                //throw new DataInvalidaException("Insira uma data correta...ó tripeiro!", e);
            }
        }
        #endregion

    }
}
