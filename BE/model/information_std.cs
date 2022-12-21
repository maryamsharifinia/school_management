using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class information_std:students
    {
        public string fathername_std { set; get; }
        public int fatherphonnumber { set; get; }
        public int motherphonnumber { set; get; }
        public int homenumber { set; get; }
        public string tozihat { set; get; }
        public string address { set; get; }
        public string postkode { set; get; }
    }
}
