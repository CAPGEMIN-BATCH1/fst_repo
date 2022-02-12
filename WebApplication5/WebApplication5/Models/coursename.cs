using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public enum coursename
    {
        ASP,JAVA,MVC,AJAX,MVCORE
    }
    public class userdet
    {
        public coursename selectname { get; set; }
    }
}
