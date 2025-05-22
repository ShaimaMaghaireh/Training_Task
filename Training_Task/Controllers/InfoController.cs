using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
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
       
        public ActionResult name(int? id)
        {
            Info info = getinfo(id);
            return View(info);
        }

        public Info getinfo (int? id )
        {
          Info info = new Info();
           
            switch (id)
            {
                case 1:
                  info.Name = "Shaimaa";
                    info.Major = "Software Engineer";
                    info.Course = "Feild Training";
                    info.Age = 21;
                    info.Email = "example@gmail.com";
                    info.City = "Irbid";
                    info.University = "Ajloun National University";
                    break;

                case 2:
                    info.Name = "Rooa";
                    info.Major = "Computer Engineer";
                    info.Course = "Feild Training";
                    info.Age = 21;
                    info.Email = "example@gmail.com";
                    info.City = "Irbid";
                    info.University = "JUST";
                    break;

                case 3:
                    info.Name = "Hamzah";
                    info.Major = "Software Engineer";
                    info.Course = "Feild Training";
                    info.Age = 21;
                    info.Email = "example@gmail.com";
                    info.City = "Irbid";
                    info.University = "Al-Hussain Bin Talal";
                    break;

            }
            return info;
        }

       


    }
        }
