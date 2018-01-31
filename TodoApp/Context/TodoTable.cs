using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TodoApp.Models;

namespace TodoApp.Context
{
    public class TodoTable : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
    }
}