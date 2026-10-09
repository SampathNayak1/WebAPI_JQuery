using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIExample.Models
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext() : base("DBCS") { }
        public DbSet<Emp> Emps { get; set; }
    }
}