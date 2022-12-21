using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;

namespace DAL
{
    public class teacher_db : DbContext
    {
        public teacher_db() : base("m") { }

        public DbSet<teacher> teachers { get; set; }
    }
}
