using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EHIProject.Models;

namespace EHIProject.DataConcreate
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base()
        {

        }

        public DbSet<MemberInfo> dataMemberInfo { get; set; }
       

    }

    public class DbContextOptions<T>
    {
    }
}
