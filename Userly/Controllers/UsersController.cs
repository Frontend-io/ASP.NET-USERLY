using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Users.Models;

namespace Userly.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Users()
        
        {
            //Create a new instance of User
            var user = new User()
            {
                Name = "Jefferson Iyobosa",
                Age = 24,
                Occupation = "Student",
                Id = 1
            };
            return View(user);
        }

        public ActionResult EditUser()
        {
            ViewBag.Message = "Edit a user here";
            ViewBag.Title = "Edit users";

            return View();
        }
    }
}