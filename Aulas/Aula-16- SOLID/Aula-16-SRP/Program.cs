/*
 * SOLID Design principles
 *  -  SRP: Single Responsibility Principle
 *  -  IOC: Inversion of Controll
 *  
 *  Ver: 
 *  - https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425
 *  - https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design
 *  - https://www.c-sharpcorner.com/article/solid-single-responsibility-principle-with-c-sharp/
 * lufer
 * */


using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {

            //SRP
            Circulo c = new Circulo(2);
            Quadrado q = new Quadrado(3);
            CalculaArea.AddShape(c);
            CalculaArea.AddShape(q);
            CalculaArea.ShowAreasScreen();
            //OutputResults.SendHTML(shapes);


            #region CouldViolateSRP

            EmployeeService employeeService = new EmployeeService
            {
                FirstName = "Passos",
                LastName = "Dias Aguiar Mota"
            };
            employeeService.EmployeeRegistration(employeeService);
            Console.ReadKey();

            #endregion

            #region YetDoesNotRespectSRP

            Employee employee = new Employee
            {
                FirstName = "Luis",
                LastName = "Ferreira",
                Email = "lufer@ipca.pt"
            };
            Console.ReadKey();

            #endregion

        }
    }
}
