using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebApplication5;

namespace WebApplication5.Views.sam
{
    public class logindetails
    {
        [Required(ErrorMessage = "please enter username")]
        public string username { get; set; }

        [Required(ErrorMessage = "please enter Password")]
        public string Password { get; set; }


        [Required(ErrorMessage = "please enter mail id")]
        [EmailAddress(ErrorMessage ="invalid mailid")]
        public string mailid { get; set; }

    }
}
