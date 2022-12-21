using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE; 

namespace DAL
{
    public class login : DbContext
    {
        public login() : base("m") { }
        public DbSet<use> usepass { get; set; }
    }
}
