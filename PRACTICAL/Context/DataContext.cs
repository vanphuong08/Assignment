using PRACTICAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PRACTICAL.Context
{
    public class DataContext:DbContext
    {
        public DataContext() : base("connection") { }
        public DbSet<Employee> Employees { get; set; }

    }
}