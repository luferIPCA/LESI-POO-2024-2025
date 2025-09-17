/*
*	<copyright file="Person.cs" company="IPCA">
*		Copyright (c)  All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description> SINGLE RESPONSIBLITY PRINCIPLE </description>
**/
using System.Collections.Generic;

namespace IOC
{
    #region SRP_REVISÃO

    #region SEM_SRP
    /// <summary>
    /// Purpose: Person pode alterar quer pelos atributos, quer pela dependência de métodos
    /// Created by: lufer
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Person
    {
        string name;

        public Person(string o)
        {
            name = o;
        }

        //Outros métodos de Person

        /// <summary>
        /// Para além de attributes também tem Métodos de Gestão de vários objetos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool AddPerson(Person p)
        {
            Persons.listPersons.Add(p);    //ARRISCADO
            //SendEmail()...
            return true;
        }
    }

    public class Persons
    {
        public static List<Person> listPersons;

        static Persons()
        {
            listPersons = new List<Person>();
        }


    }
#endregion


    #region COM_SRP

    //Problema:
    //O que acontece se quiser acrescentar mais um atributo  (ex. email!) e alterar o médodo AddPerson
    //Viola o SRP!!!
    //Solução:

    public class PersonSRP
    {
        string name;
        public string email;

        public PersonSRP(string o)
        {
            name = o;
        }
        //outros Métodos normais de classe
    }



    public class PersonsSRP
    {
        static List<PersonSRP> listPersons;

        static PersonsSRP()
        {
            listPersons = new List<PersonSRP>();
        }

        public static bool AddPerson(PersonSRP p)
        {
            //testes
            listPersons.Add(p);
            return true;
        }
    }

    #endregion

    //Problema:
    //O que acontece caso o método AddPerson dependa doutros serviços, por exemplo, do serviço
    //de envio de email
    //Viola SRP!!
    //Solução

    #region COM_SRP_V2

    public class PersonsSRP_V2
    {

        static List<PersonSRP> listPersons;

        static PersonsSRP_V2()
        {
            listPersons = new List<PersonSRP>();
        }

        public static bool AddPerson(PersonSRP p)
        {
            //testes
            //Executa dois serviços!!!!!
            listPersons.Add(p);
            //PersonsServices.SendEmail(p.email); //Viola SRP...apenas se deve preocupar com a List
            return true;
        }
    }

    /// <summary>
    /// Nova Classe queviola SRP
    /// </summary>
    public class PersonsServices
    {

        public static bool AddPersonEmailService(PersonSRP p)
        {
            //testes
            PersonsSRP_V2.AddPerson(p);
            //testes
            SendEmail(p.email);
            return true;
        }

        //Send Email não tem a ver com Person...convém separar!!!
        public static bool SendEmail(string emailAddress)
        {
            return true;
        }
    }

    public class PersonsServicesFinal
    {

        public static bool AddPersonEmailService(PersonSRP p)
        {
            //testes
            PersonsSRP_V2.AddPerson(p);
            AuxiliaryServices.SendEmail(p.email);
            return true;
        }


    }

    public class AuxiliaryServices
    { 
        public static bool SendEmail(string emailAddress)
        {

            return true;
        }
    }
    #endregion

    #endregion
}
