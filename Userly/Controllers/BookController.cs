using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Books.Models;

namespace Userly.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Books
        public ActionResult GetBookData()
        
        {
            //Create a new instance of User
            var user = new Book()
            {
                Title = "Someone to watch over me",
                BookNumber = 24,
                Genre = "Student",
                Year = 2019,
                Id = 0,
                Author = "Jefferson"
            };
            return View(user);
        }

        // GET: View book information
        public ActionResult ViewBook(string title  , int bookId )
        {
            ViewBag.title = "You are viewing the book with title ";
            return View();
        }

    }
}