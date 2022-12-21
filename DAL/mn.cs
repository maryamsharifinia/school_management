using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
namespace DAL
{
    public class meet_dbb : DbContext
    {
        public meet_dbb() : base("m") { }

        public DbSet<meeting> meeting_teach { get; set; }
    }
}
