using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);

            Employee e1 = 
               new Employee
               {
                   EmployeeId = 1,
                   FirstName = "John",
                   LastName = "Lennon",
                   Email = "John@beatles.com",
                   DateOfBirth = new DateTime(1969, 04, 20),
                   Gender = Gender.Male,
                   DepartmentId = 1,
                   PhotoPath = "images/john.jpg"
               };

            Employee e2 =
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "George",
                    LastName = "Harrison",
                    Email = "Geroge@beatles.com",
                    DateOfBirth = new DateTime(1969, 04, 20),
                    Gender = Gender.Male,
                    DepartmentId = 2,
                    PhotoPath = "images/george.jpg"
                };

             Employee e3 =
                new Employee
               {
                   EmployeeId = 3,
                   FirstName = "Paul",
                   LastName = "McCartney",
                   Email = "Paul@beatles.com",
                   DateOfBirth = new DateTime(1969, 04, 20),
                   Gender = Gender.Male,
                   DepartmentId = 3,
                   PhotoPath = "images/paul.jpg"
               };

            Employee e4 =
               new Employee
               {
                   EmployeeId = 4,
                   FirstName = "Ringo",
                   LastName = "Starr",
                   Email = "Ringo@beatles.com",
                   DateOfBirth = new DateTime(1969, 04, 20),
                   Gender = Gender.Male,
                   DepartmentId = 4,
                   PhotoPath = "images/ringo.jpg"
               };


            

            Employees = new List<Employee> {e1, e2, e3, e4 };

        }


    }
}
