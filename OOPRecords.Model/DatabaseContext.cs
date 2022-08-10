using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Text;

namespace OOPRecords.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string dbName) : base(dbName)
        {
            Database.SetInitializer(new Initializer());
        }
        public DbSet<Student> Students { get; set; }
    }
}
