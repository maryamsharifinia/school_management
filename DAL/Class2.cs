using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
    public class nomre_dbb : DbContext
    {
        public nomre_dbb() : base("m") { }
        public DbSet<nomre> nomre_stdd { get; set; }
    }
}
