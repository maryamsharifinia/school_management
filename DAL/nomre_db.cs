using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE; 
namespace DAL
{
  public  class nomre_db : DbContext
    {
        public nomre_db() : base("m") { }
        public DbSet<nomre> nomre_std { get; set; }
    }
}
