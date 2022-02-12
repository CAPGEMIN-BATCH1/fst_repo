using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Models
{
    public class citymodel
    {
        public int value { get; set; }
        public string text { get; set; }
        public Boolean ischecked { get; set; }

        public List<citymodel> cities { get; set; }
    }
}
