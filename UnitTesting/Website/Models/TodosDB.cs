using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class TodosDB : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodosDB() : base("UnitTesting")
        {
            
        }
    }
}