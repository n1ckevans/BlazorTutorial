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

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Haywood",
                LastName = "Jablowme",
                Email = "dicknobber@poop.com",
                DateOfBirth = new DateTime(1969, 04, 20),
                Gender = Gender.Male,
                Department = new Department
                {
                    DepartmentId = 1,
                    DepartmentName = "Green Room"
                }
                ,
                PhotoPath = "images/john.jpg"

            };


            Employee e2 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Linda",
                LastName = "Asshat",
                Email = "allupinthatass@poop.com",
                DateOfBirth = new DateTime(1969, 04, 20),
                Gender = Gender.Female,
                Department = new Department
                {
                    DepartmentId = 2,
                    DepartmentName = "Glory Hole"
                }
               ,
                PhotoPath = "images/linda.jpg"

            };

            Employees = new List<Employee> {e1, e2 };

        }


    }
}
