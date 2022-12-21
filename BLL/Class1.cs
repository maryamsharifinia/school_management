using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
using DAL;
namespace BLL
{
    public class bl_std
    {
        public void create1(information_std s)
        {
            function bll = new function();
            bll.creat_std(s);

        }
        public void createenz(enzebati s)
        {
            function bll = new function();
            bll.creat_enz(s);

        }
        public void create_log(use s)
        {
            function bll = new function();
            bll.log_in(s);

        }
        public bool exist_log(string s, string s1)
        {
            function bll = new function();
            return bll.exist(s, s1);

        }
        public void createmeet(meeting s)
        {
            function bll = new function();
            bll.creat_meet(s);

        }
        public void createteach(teacher s)
        {
            function bll = new function();
            bll.creat_teach(s);

        }
        public void createhozur(hozurghyab s)
        {
            function bll = new function();
            bll.creat_hozur(s);

        }
        public void createshahrie(shahriee s)
        {
            function bll = new function();
            bll.creat_shahrie(s);
        }
        public void upshahrie(int id,shahriee s)
        {
            function bll = new function();
            bll.update_shar(id,s);
        }
        public void createbedehi(bedehii s)
        {
            function bll = new function();
            bll.creat_bedehi(s);
        }
        public void remove(int s)
        {
            function bll = new function();
            bll.delete(s);
        }
        public void createnomre(nomre s)
        {
            function bll = new function();
            bll.creat_noomre(s);
        }
        public void cearatmeet(meeting s)
        {
            function bll = new function();
            bll.creat_meet(s);



        }
        public object read_allstudent()
        {
            db db = new db();
            dbsearch s = new dbsearch();
            s.readall();
            var q = from i in db.information_std.ToList() select i;
            return q.ToList();
        }
        public object serch_information(string text_name, string text_family, string text_paye, string text_kod)
        {
            db db = new db();
            students s = new students();

            List<information_std> d = new List<information_std>();
            foreach (var item in db.information_std)
            {
                if (text_name.Contains(item.name_std) ||
                    text_family.Contains(item.familly_std) ||
                    text_kod.Contains(item.kodemeli) ||
                    text_paye.Contains(item.payeh))
                {
                    d.Add(item);
                }

            }

            return d.ToList();
        }
        public object read_allteacher()
        {
            teacher_db db = new teacher_db();
            dbsearch s = new dbsearch();

            var q = from i in db.teachers.ToList() select i;
            return q.ToList();
        }
        public object serch_information_teach(string text_name, string text_family, string text_paye, string text_kod)
        {
            teacher_db db = new teacher_db();


            List<teacher> d = new List<teacher>();
            foreach (var item in db.teachers)
            {
                if (text_name.Contains(item.name_teach) ||
                    text_family.Contains(item.familly_teach) ||
                    text_kod.Contains(item.kodemeli_teach) ||
                    text_paye.Contains(item.payeh))
                {
                    d.Add(item);
                }

            }

            return d.ToList();
        }
        public object kelsbandi(string text_name)
        {
            db db = new db();
            List<information_std> d = new List<information_std>();
            foreach (var item in db.information_std)
            {
                if (text_name.Contains(item.payeh))
                {
                    d.Add(item);
                }

            }

            return d.ToList();
        }
        public object kelsbandikol()
        {
            db db = new db();
            List<information_std> d = new List<information_std>();
            foreach (var item in db.information_std)
            {
                    d.Add(item);
                
            }
            return d.ToList();
        }
        public object serchname(string text_name, string text_family)
        {
            db db = new db();

            List<information_std> d = new List<information_std>();
            foreach (var item in db.information_std)
            {
                if (text_name.Contains(item.name_std) ||
                    text_family.Contains(item.familly_std))

                {
                    d.Add(item);
                }

            }

            return d.ToList();
        }
        public object serchhozur(string h,string d2)
        {
            hozur_db db = new hozur_db();

            List<hozurghyab> d = new List<hozurghyab>();
            foreach (var item in db.hozur_std)
            {
                if (h == item.payeh && d2==item.tarikh)
                    d.Add(item);
            }
            return d.ToList();
        }
        public object serchhozurk(string h)
        {
            hozur_db db = new hozur_db();

            List<hozurghyab> d = new List<hozurghyab>();
            foreach (var item in db.hozur_std)
            {if(h==item.tarikh)
                  d.Add(item);
             
                  
            }
            return d.ToList();
        }
        public object serchkarname_nfpk(string text_name, string text_family, string paye, string kod)
        {
            nomre_dbb db = new nomre_dbb();
            List<nomre> d = new List<nomre>();
            foreach (var item in db.nomre_stdd)
            {
                if (text_name==(item.name_std) ||
                    text_family==(item.familly_std) ||
                    paye==(item.payeh) ||
                    kod==(item.kodemeli ))
                {
                    d.Add(item);
                }
            }
           return d.ToList();
        }
        public object serchbe(string text_name, string text_family, string kod)
        {
            bedhi_db db = new bedhi_db();
            List<bedehii> d = new List<bedehii>();
            foreach (var item in db.bedehi_std)
            {
                if (text_name==item.name_std ||
                    text_family==item.familly_std||
                    kod==item.kodemeli)
                    
                {
                    d.Add(item);
                }
            }
            return d.ToList();
        }
        public object serchjalasek()
        {
            meet_db db = new meet_db();
            List<meeting> d = new List<meeting>();
            foreach (var item in db.meeting_teach)
            {
                    d.Add(item);
            }
            return d.ToList();
        }
        public object serchevz(string kod)
        {
            enzebati_db db = new enzebati_db();
            List<enzebati> d = new List<enzebati>();
            foreach (var item in db.enzebat_std)
            {
                if(kod==item.kodemeli)
                d.Add(item);
            }
            return d.ToList();
        }
        public object serchjalase(string h)
        {
            meet_db db = new meet_db();
            List<meeting> d = new List<meeting>();
            foreach (var item in db.meeting_teach)
            {
                if (h == item.tarikh_meet)
                    d.Add(item);

            }
            return d.ToList();
        }
        public object serch_shahr(string text_name, string text_family, string text_paye, string text_kod)
        {
            shahrie_db db = new shahrie_db();
           

            List<shahriee> d = new List<shahriee>();
            foreach (var item in db.shahrie_std)
            {
                if (text_name.Contains(item.name_std) ||
                    text_family.Contains(item.familly_std) ||
                    text_kod.Contains(item.kodemeli) ||
                    text_paye.Contains(item.payeh))
                {
                    d.Add(item);
                }

            }

            return d.ToList();
        }
        public object read_shat(string p)
        {
           // shahrie_db db = new shahrie_db();
           dbsearch s = new dbsearch();

            //  var q = from i in db.shahrie_std.ToList() where i.payeh==p && i.shahriepardakhti>=5000000 select i ;
            return s.readshh(p);
        }
        public object read_shat_n(string p)
        {
           
            dbsearch s = new dbsearch();

            return s.readshj(p);
        }
        //public void up_enz(string id, nomre s)
        //{
        //    function bll = new function();
        //    bll.update_enz(id, s);
        //}
    }
}    
    
