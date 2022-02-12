using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class emp
    {
        public emp()
        {
            dtobj = new Dept();
        }    
        public int eid { get; set; }
        public string ename { get; set; }
        public string edesig { get; set; }
        public Dept dtobj { get; set; }
    }
    public class Dept
    {
        public string dname { get; set; }
        public int noemp { get; set; }
    }
    
}
