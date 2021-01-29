using Microsoft.EntityFrameworkCore;
using netcore_personaforms.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_personaforms.Persistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<T_SKUList> T_SKUList { get; set; }
    }
}
