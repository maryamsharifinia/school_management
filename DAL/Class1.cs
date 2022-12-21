using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;


namespace DAL
{
    public class db : DbContext
    {
        public db() : base("m") { }

        public DbSet<information_std> information_std { get; set; }
        
    }



}
