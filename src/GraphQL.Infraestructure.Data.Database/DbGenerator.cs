using GraphQL.Infraestructure.Data.Database.Entity.Campany;
using GraphQL.Infraestructure.Data.Database.Entity.Department;
using GraphQL.Infraestructure.Data.Database.Entity.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace GraphQL.Infraestructure.Data.Database
{
    public class DbGenerator
    {
        /// <summary>
        /// Inicialize memory database
        /// </summary>
        public static void Inicialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlogContext(serviceProvider.GetRequiredService<DbContextOptions<BlogContext>>()))
            {
                if (context.Companies.Any())
                {
                    return;
                }

                try
                {
                    context.Companies.AddRange(
                    new CompanyEntity()
                    {
                        Id = 1,
                        CNPJ = "70.870.665/0001-31",
                        City = "São Paulo",
                        Name = "Centro de Tecnologia",
                        Phone = "(11) 3568-5498",
                        Site = "centroti.com.br"
                    },
                    new CompanyEntity()
                    {
                        Id = 2,
                        CNPJ = "84.940.770/0001-04",
                        City = "Rio de Janeiro",
                        Name = "Loja de Informatica",
                        Phone = "(21) 3355-9900",
                        Site = "sualojadeinformatica.com.br"
                    },
                    new CompanyEntity()
                    {
                        Id = 3,
                        CNPJ = "33.679.103/0001-89",
                        City = "Campinas",
                        Name = "Pinho TI LTDA",
                        Phone = "(31) 4455-6587",
                        Site = "pinhoti.com.br"
                    }
                    );

                    context.Departments.AddRange(
                                new DepartmentEntity()
                                {
                                    CompanyId = 1,
                                    Id = 1,
                                    Name = "RH"
                                },
                                new DepartmentEntity()
                                {
                                    CompanyId = 1,
                                    Id = 2,
                                    Name = "Financeiro"
                                },
                                new DepartmentEntity()
                                {
                                    CompanyId = 1,
                                    Id = 3,
                                    Name = "Tecnologia"
                                },
                                new DepartmentEntity()
                                {
                                    CompanyId = 2,
                                    Id = 4,
                                    Name = "RH"
                                },
                                new DepartmentEntity()
                                {
                                    CompanyId = 2,
                                    Id = 5,
                                    Name = "Financeiro"
                                },
                                new DepartmentEntity()
                                {
                                    CompanyId = 2,
                                    Id = 6,
                                    Name = "Tecnologia"
                                },
                                new DepartmentEntity()
                                {
                                    CompanyId = 3,
                                    Id = 7,
                                    Name = "RH"
                                },
                                new DepartmentEntity()
                                {
                                    CompanyId = 3,
                                    Id = 8,
                                    Name = "Financeiro"
                                },
                                new DepartmentEntity()
                                {
                                    CompanyId = 3,
                                    Id = 9,
                                    Name = "Tecnologia"
                                });


                    context.Employees.AddRange(
                        new EmployeeEntity()
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Name = "Ana Silva",
                            Email = "anasilva@gmail.com",
                            Salary = 2500
                        },
                        new EmployeeEntity()
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Name = "Bia Oliveira",
                            Email = "bia@gmail.com",
                            Salary = 1800
                        },
                        new EmployeeEntity()
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Name = "Carla Gomes",
                            Email = "carla@gmail.com",
                            Salary = 1900
                        },
                        new EmployeeEntity()
                        {
                            Id = 4,
                            DepartmentId = 4,
                            Name = "Guilherme Santos",
                            Email = "guilher@gmail.com",
                            Salary = 5000
                        },
                        new EmployeeEntity()
                        {
                            Id = 5,
                            DepartmentId = 5,
                            Name = "Carlos Andrade",
                            Email = "carlos@gmail.com",
                            Salary = 7500
                        },
                        new EmployeeEntity()
                        {
                            Id = 6,
                            DepartmentId = 6,
                            Name = "João Silva",
                            Email = "jsilva@gmail.com",
                            Salary = 3000
                        },
                        new EmployeeEntity()
                        {
                            Id = 7,
                            DepartmentId = 7,
                            Name = "José Oliveira",
                            Email = "joliveira@gmail.com",
                            Salary = 3500
                        },
                        new EmployeeEntity()
                        {
                            Id = 8,
                            DepartmentId = 8,
                            Name = "André Silva",
                            Email = "andresil@gmail.com",
                            Salary = 8000
                        },
                        new EmployeeEntity()
                        {
                            Id = 9,
                            DepartmentId = 9,
                            Name = "Renata Santos",
                            Email = "resantos@gmail.com",
                            Salary = 6500
                        },
                        new EmployeeEntity()
                        {
                            Id = 10,
                            DepartmentId = 1,
                            Name = "Rodrigo Oliveira",
                            Email = "roliveir@gmail.com",
                            Salary = 25000
                        },
                        new EmployeeEntity()
                        {
                            Id = 11,
                            DepartmentId = 1,
                            Name = "Maria da Silva",
                            Email = "masilva@gmail.com",
                            Salary = 1500
                        });

                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}
