namespace StorageBenchmarkManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StorageBenchmarkManager.Models.StorageBenchmarkManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StorageBenchmarkManager.Models.StorageBenchmarkManagerContext context)
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

            context.Products.AddOrUpdate(new Models.Product[]
            {
                new Models.Product() { ID = 1, Name = "Hat", Price = 15, Category = "Apparel" },
                new Models.Product() { ID = 2, Name = "Socks", Price = 5, Category = "Apparel" },
                new Models.Product() { ID = 3, Name = "Scarf", Price = 12, Category = "Apparel" },
                new Models.Product() { ID = 4, Name = "Yo-yo", Price = 4.95M, Category = "Toys" },
                new Models.Product() { ID = 1, Name = "Puzzle", Price = 8, Category = "Toys" },
            });

        }
    }
}
