using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;
using WebApplication5.Views.viewmodel;
using System.ComponentModel.DataAnnotations;
    

using WebApplication5.Views.sam;
using System.Text;


namespace WebApplication5.Controllers
{
    public class sam : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult display()
        {
            ViewData["info1"] = System.DateTime.Now.ToLongDateString();
            ViewData["product"] = "p001,lap,75000";
            return View();
        }
        public IActionResult getcust()
        {
            customer obj = new customer();
            obj.cid = 1;
            obj.cname = "sss";
            obj.email = "satya@gmail.com";
            return View(obj);
        }
        public IActionResult getcustdet()
        {
            return View();
        }
        public
         IActionResult displaydet()
        {
            customer cobj = new customer();
            cobj.cid = int.Parse(Request.Form["t1"].ToString());
            cobj.cname = Request.Form["t2"].ToString();
            cobj.email = Request.Form["t3"].ToString();
            return View(cobj);
        }
        public IActionResult logindet()
        {
            return View();
        }
        public IActionResult loginview()
        {
            logincs sobj = new logincs();
            sobj.cusername = Request.Form["txtusername"].ToString();
            sobj.cpassword = Request.Form["txtpassword"].ToString();

            if (sobj.cusername == "satya" && sobj.cpassword == "Satya@123")
                ViewData["res"] = "login success";
            else
                ViewData["res"] = "login failed";
            return View("logindet");
        }
        public IActionResult addform()
        {
            return View();
        }
        public IActionResult addnos()
        {
            int x = int.Parse(Request.Form["no1"].ToString());
            int y = int.Parse(Request.Form["no2"].ToString());
            int z = x + y;
            ViewData["sum"] = z;
            ViewData["no1"] = x;
            ViewData["no2"] = y;
            return View("addform");



        }
        public IActionResult printdet()
        {
            emp obj = new emp();
            obj.eid = 1;
            obj.ename = "satya";
            obj.edesig = "HR";
            obj.dtobj.dname = "hr dept";
            obj.dtobj.noemp = 5;
            return View(obj);
        }
        public IActionResult printstu()
        {
            student st = new student() { regno = 1, name = "sam", mailid = "sam@gmail.com" };
            course cs = new course() { cname = "full stack .net", cdur = 4 };


            stu_course csobj = new stu_course()
            {
                studentobj = st,
                courseobj = cs
            };
            return View(csobj);
        }




        public IActionResult form2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form2(satyastu stobj)
        {
            ViewData["fname"] = stobj.fname;
            ViewData["lname"] = stobj.lname;
            if (stobj.workexp == true)
                ViewData["workexp"] = "fresher";
            else
                ViewData["workexp"] = "exp";
            return View();

        }

        public IActionResult regform()
        {
            return View();
        }
        public IActionResult regform2()
        {
            return View();
        }
        public IActionResult form3()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form3(logindetails det)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }
        public IActionResult printradio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult printradio(userdata obj)
        {
            ViewData["type"] = obj.jobtype;
            ViewData["mode"] = obj.jobmode;
            return View();
        }
        public IActionResult dispdd1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult dispdd1(userdet obj)
        {
            ViewData["cname"] = obj.selectname;
            return View();
        }
        public IActionResult discheck()

        {

            List<citymodel> obj = new List<citymodel>() {


              
               new citymodel{value=1,text = "banglr", ischecked=true},
               new citymodel{value= 2,text = "pune", ischecked=false},
               new citymodel{value= 3,text = "chennai", ischecked=false},
               new citymodel{value= 4,text = "hyd", ischecked=false}
           };
            citymodel cmodel = new citymodel();
            cmodel.cities = obj;
            return View(cmodel);
        }
        [HttpPost]
        public IActionResult discheck(citymodel obj)
        {
            StringBuilder str = new StringBuilder();
            foreach (var city in obj.cities)
            {
                if (city.ischecked)
                {
                    str.Append(city.text + ",");
                }
            }
            ViewData["jobloc"] = str;
            return View("joblocation");


        }
        public IActionResult createcookie()
        {
            string username = Request.Cookies["UserName"];
            return View("createcookie",username);
        }
        [HttpPost]
        public IActionResult createcookie(string t1)
        {
            string username = t1;
            CookieOptions option = new CookieOptions();
            option.Expires = System.DateTime.Now.AddMinutes(30);
            Response.Cookies.Append("UserName", username, option);
            return View("createcookie");
        }
       public IActionResult deletecookie()
       {
            Response.Cookies.Delete("UserName");
            return View("createcookie");
        }
        public IActionResult stdata()
        {
            HttpContext.Session.SetString("emp_details", "e011116,ssss,s/w developer");
            HttpContext.Session.SetInt32("pro_details", 56300);
            return View();
        }
        public IActionResult readdata()
        {
            ViewData["empdet"] = HttpContext.Session.GetString("emp_details");
            ViewData["prodet"] = HttpContext.Session.GetInt32("pro_details");
            return View();
        }
        public IActionResult printdd()
        {
            ViewData["data1"] = "this is view data storage";
            return View();
        }

        public IActionResult pract()
        {
            return View();
        }
        [HttpPost]
        public IActionResult pract(practice det)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }

    }
    
}
