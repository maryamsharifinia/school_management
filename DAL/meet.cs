using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
namespace DAL
{
   public class meet_db:DbContext
    {
        public meet_db() : base("m") { }

        public DbSet<meeting> meeting_teach { get; set; }
    }
}
