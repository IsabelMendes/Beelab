namespace Exerciocio3.Migrations
{
    using Exerciocio3.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Exerciocio3.Models.Exerciocio3Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Exerciocio3.Models.Exerciocio3Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

   
            context.Products.AddOrUpdate(
            p => p.Id,
            new Product{Id = 1,nome = "produto 1",codigo = "COD1", descricao = "descrição produto 1", preco = 10, Url = "www.siecolasystems.com/produto1"},
            new Product {Id = 2, nome = "produto 2", codigo = "COD2", descricao = "descrição produto 2", preco = 20, Url = "www.siecolasystems.com/produto2"},
            new Product {Id = 3,nome = "produto 3",codigo = "COD3", descricao = "descrição produto 3", preco = 30, Url = "www.siecolasystems.com/produto3"}
            );
        }
    }
    }
