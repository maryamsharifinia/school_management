using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
namespace DAL
{
   public class hozur_db : DbContext
    {
        public hozur_db() : base("m") { }
        public DbSet<hozurghyab> hozur_std { get; set; }
    }
}
