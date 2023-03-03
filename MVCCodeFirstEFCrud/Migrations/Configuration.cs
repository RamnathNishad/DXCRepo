namespace MVCCodeFirstEFCrud.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCCodeFirstEFCrud.Models.CustomerDBEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCCodeFirstEFCrud.Models.CustomerDBEntities";
        }

        protected override void Seed(MVCCodeFirstEFCrud.Models.CustomerDBEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
