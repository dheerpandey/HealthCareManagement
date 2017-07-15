using Queries.Core.Domain;
using Queries.Persistence;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Queries.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<HCMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HCMContext context)
        {
           
        }
    }
}
