using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDotNetCoreGraphQL.Infra
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opcoes):base(opcoes)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
