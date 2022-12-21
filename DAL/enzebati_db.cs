using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
namespace DAL
{
  public  class enzebati_db : DbContext
    {
        public enzebati_db() : base("m") { }
        public DbSet<enzebati> enzebat_std { get; set; }
    }
}
