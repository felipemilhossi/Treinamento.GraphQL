using GraphQL.Infraestructure.Data.Database.Entity;
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

                context.Companies.AddRange(
                    new Company()
                    {
                        Id = 1,
                        CNPJ = "70.870.665/0001-31",
                        City = "São Paulo",
                        Name = "Centro de Tecnologia",
                        Phone = "(11) 3568-5498",
                        Site = "centroti.com.br"
                    },
                    new Company()
                    {
                        Id = 2,
                        CNPJ = "84.940.770/0001-04",
                        City = "Rio de Janeiro",
                        Name = "Loja de Informatica",
                        Phone = "(21) 3355-9900",
                        Site = "sualojadeinformatica.com.br"
                    },
                    new Company()
                    {
                        Id = 3,
                        CNPJ = "33.679.103/0001-89",
                        City = "Campinas",
                        Name = "Pinho TI LTDA",
                        Phone = "(31) 4455-6587",
                        Site = "pinhoti.com.br"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
