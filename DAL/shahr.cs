using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
namespace DAL
{
   public class shahrie_db:DbContext
    {
        public shahrie_db() : base("m") { }

        public DbSet<shahriee> shahrie_std { get; set; }
    }
}
