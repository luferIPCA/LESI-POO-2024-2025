/*
*	<copyright file="Aula17_SRP.cs" company="IPCA">
*		Copyright (c)  All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description></description>
*	
*	See
*	https://www.c-sharpcorner.com/article/solid-single-responsibility-principle-with-c-sharp/
**/
using System.Collections.Generic;

namespace SRP
{
    #region BeforeChanges

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class EmployeeService
    {
        #region EmployeeData

        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        #region EmployeeMethods
        public bool EmployeeRegistration(EmployeeService employee)
        {
            if (!EmployeesData.Employees.Contains(employee))
            {
                EmployeesData.Employees.Add(employee);
                return true;
            }
            return false;
        }

        #endregion

    }
    public class EmployeesData
    {
        public static List<EmployeeService> Employees { get; set; } = new List<EmployeeService>();

    }

    #endregion

    #region AfterChanges_I

   
    public class EmployeesDataII
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();
    }
  
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }       //novo
    }
    #endregion

   
}
