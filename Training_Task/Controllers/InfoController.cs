using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training_Task.Models;

namespace Training_Task.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        public ActionResult Index()
        {
            Info myInfo = new Info();
            myInfo.Name = "Shaima Maghaireh";
            myInfo.University = "Ajloun National University";
            myInfo.Major = "Software Engineering";
            myInfo.Course = "Field Training";
            myInfo.Age = 21;
            myInfo.Skills = "ASP.NET, C#, HTML, CSS";
            myInfo.Email = "example@gmail.com";
            myInfo.City = "Irbid";
            return View(myInfo);
        }
    }
}