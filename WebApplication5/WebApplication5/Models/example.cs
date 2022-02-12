using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class example : Controller
    {
        public IActionResult form1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form1(string t1, string t2, string chk1)
        {
            ViewData["fname"] = t1;
            ViewData["lname"] = t2;
            if (chk1 != null)
                ViewData["workexp"] = "fresher";
            else
                ViewData["workexp"] = "experianced";
            return View();


        }
    }
}
