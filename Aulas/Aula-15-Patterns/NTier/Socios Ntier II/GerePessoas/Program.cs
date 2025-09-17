/*
 * lufer
 * NTier
 * Lp2
 * 
 * Gerir Pessoas
 * 
 * Camada de Apresentação  | FrontEnd Layer
 * */


using System;
using ObjetosNegocio;   //Camada de Objetos de negócio
using RegrasNegocio;
using Excepcoes;
using System.Collections.Generic;

namespace GerePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aux;

            Console.WriteLine("Gerir Pessoas");
            PessoaSemLista p1 = new PessoaSemLista("Um Nome");
            //Pessoas.Add(p1);  //evitar aceder diretamente aos dados!!!

            A a = new A();


            try
            {
                aux = Regras.InserePessoaA(p1, a);

                //aux = Regras.InsereA(p1.nome, a);
                //Regras.InserePessoa(p1, 3);

                if (aux == true)
                    Console.WriteLine("Inserido: Nome: " + p1.nome);
                else
                    Console.WriteLine("Não foi Inserido: Nome: " + p1.nome);
            }
            catch (InsercaoException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
            
            
        }
    }


}
