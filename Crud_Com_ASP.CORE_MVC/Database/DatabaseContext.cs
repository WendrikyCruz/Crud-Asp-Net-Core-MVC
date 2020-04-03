using Crud_Com_ASP.CORE_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Com_ASP.CORE_MVC.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
             Database.EnsureCreated();
        }

    }
}
