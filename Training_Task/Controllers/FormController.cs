using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MvcFormExample.Models;

namespace Training_Task.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(UserInputViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View("DisplayData", model);
            }
            // Pass the data to the new page (view)
           return View("DisplayData", model);
        }
    }
}