using System.Data.Entity;

namespace Repository.DAL.Context
{
    class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ConnDB")
        {

        }
    }
}
