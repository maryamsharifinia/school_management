using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class function
    {
        public void creat_std(information_std h)
        {
            db db1 = new db();
            db1.information_std.Add(h);
            db1.SaveChanges();
        }
        public void creat_hozur(hozurghyab v)
        {
            hozur_db db1 = new hozur_db();
            db1.hozur_std.Add(v);
            db1.SaveChanges();
        }
        public void creat_shahrie(shahriee v1)
        {
            shahrie_db db1 = new shahrie_db();
            db1.shahrie_std.Add(v1);
            db1.SaveChanges();
        }
        public void creat_bedehi(bedehii v1)
        {
            bedhi_db db1 = new bedhi_db();
            db1.bedehi_std.Add(v1);
            db1.SaveChanges();
        }
        public void creat_enz(enzebati b)
        {
            enzebati_db db1 = new enzebati_db();
            db1.enzebat_std.Add(b);
            db1.SaveChanges();
        }
        public void creat_noomre(nomre b)
        {
            nomre_dbb db1 = new nomre_dbb();
            db1.nomre_stdd.Add(b);
            db1.SaveChanges();
        }
        public void creat_teach(teacher t)
        {
            teacher_db db1 = new teacher_db();
            db1.teachers.Add(t);
            db1.SaveChanges();
        }
        public void creat_meet(meeting m)
        {
            meet_dbb db2 = new meet_dbb();
            db2.meeting_teach.Add(m);
            db2.SaveChanges();
        }
        public void log_in(use u)
        {
            login db1 = new login();
            db1.usepass.Add(u);
            db1.SaveChanges();
        }
        public bool exist(string h,string j)
        {
            login log = new login();
            var q = log.usepass.Where(i => i.username == h && i.password == j);
            if(q.Count()==1)
            {
                return true;
            }
            
            return false;
        }
        public void delete(int id)
        {
            bedhi_db db1 = new bedhi_db();
            var q = db1.bedehi_std.Where(i => i.id == id);
            if(q.Count()==1)
            {
                db1.bedehi_std.Remove(q.Single());
                db1.SaveChanges();
            }
        }
        public void update_shar(int idd,shahriee newh)
        {
            shahrie_db db = new shahrie_db();
            var q = db.shahrie_std.Where(i => i.id == idd);
            if(q.Count()==1)
            {
                shahriee s = new shahriee();
                s = q.Single();
                s.shahriepardakhti = newh.shahriepardakhti;
                s.shahriepardakhtnashode = newh.shahriepardakhtnashode;
                db.SaveChanges();
            }
        }
        //public void update_enz(string idd,nomre newh)
        //{
        //    nomre_db db = new nomre_db();
        //    var q = db.nomre_std.Where(i => i.kodemeli == idd);
        //    if (q.Count() == 1)
        //    {
        //        nomre n = new nomre();
        //        n = q.Single();
        //        n.enzebat = newh.enzebat;
        //        db.SaveChanges();
        //    }
        //}
    }
}
