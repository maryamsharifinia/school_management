using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
namespace DAL
{
  public  class bedhi_db : DbContext
    {
        public bedhi_db() : base("m") { }
        public DbSet<bedehii> bedehi_std { get; set; }
    }
}
