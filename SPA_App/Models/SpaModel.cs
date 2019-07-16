namespace SPA_App.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SpaModel : DbContext
    {
        static  SpaModel()
        {
            Database.SetInitializer<SpaModel>(new MigrateDatabaseToLatestVersion<SpaModel, databaseMigration>("SpaModel"));
        }
        public SpaModel()
            : base("name=SpaModel")
        {

        }
        public virtual DbSet<person> persons { get; set; }


     
    }

 
}