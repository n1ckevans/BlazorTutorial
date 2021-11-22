using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "Ryhtmn Guitar" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "Lead Guitar"});
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Bass Guitar" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Drums" });


            modelBuilder.Entity<Employee>().HasData(
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
                });

            modelBuilder.Entity<Employee>().HasData(
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
                });

            modelBuilder.Entity<Employee>().HasData(
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
               });

            modelBuilder.Entity<Employee>().HasData(
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
               });

        }

    }
}
