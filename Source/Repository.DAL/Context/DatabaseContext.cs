using Repository.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repository.DAL.Context
{
    class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ConnDB")
        {
            Database.SetInitializer<DatabaseContext>(null);
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
