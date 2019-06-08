namespace Exercicio2.Migrations
{
    using Exercicio2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Exercicio2.Models.Exercicio2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Exercicio2.Models.Exercicio2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(
                p => p.Id,
                new Product {Id = 1,nome = "produto 1",codigo = "COD1", descricao = "descrição produto 1", preco = 10, url = "adicionando url1" },
                new Product {Id = 2, nome = "produto 2",codigo = "COD2", descricao = "descrição produto 2", preco = 20, url = "adicionando url2" },
                new Product {Id = 3,nome = "produto 3",codigo = "COD3", descricao = "descrição produto 3", preco = 30, url = "adicionando url3" }
                );
        }
    }
}
