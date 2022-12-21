using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
namespace DAL
{
    public class dbsearch
    {

        public object readall()
        {
            

            var q = from i in new db().information_std.ToList() select i;
            return q.ToList();
        }
        public object readsh()
        {
            var q = from i in new shahrie_db().shahrie_std.ToList() select i;
            return q.ToList();
        }

        public object readshh(string p)
        {
           // var q = from i in new shahrie_db().shahrie_std.ToList() select i;
           

            shahrie_db db = new shahrie_db();
          
            var q = from i in db.shahrie_std.ToList() where i.payeh == p && i.shahriepardakhti >= 5000000 select i;
            return q.ToList();
        }
        public object readshj(string p)
        {
            shahrie_db db = new shahrie_db();
  
            var q = from i in db.shahrie_std.ToList() where i.payeh == p && i.shahriepardakhtnashode >= 0 select i;
            return q.ToList();
        }
    }
}
