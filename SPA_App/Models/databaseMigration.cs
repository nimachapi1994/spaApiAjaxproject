using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace SPA_App.Models
{
    public class databaseMigration:DbMigrationsConfiguration<SpaModel>
    {
        public databaseMigration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "SPA_App.Models.SpaModel";
        }
    }
}