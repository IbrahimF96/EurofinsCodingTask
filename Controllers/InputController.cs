using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EurofinsCodingTask.Models;

namespace EurofinsCodingTask.Controllers
{
    public class InputController : Controller
    {
        // GET: Input

        private ApplicationContext context;

        public InputController()
        {
            context = new ApplicationContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        public ActionResult Index(UserInput userInput)
        {
            ViewBag.Message = userInput.Message();
            return View("Index", userInput);
        }
        [HttpPost]
        public ActionResult OnSelectInput(UserInput userInput)
        {
            ViewBag.Message = userInput.Message();
            context.Inputs.Add(userInput);
            context.SaveChanges();
            return PartialView("UserDetails", userInput);
        }

        public ActionResult Database()
        {
            List<UserInput> Inputs = context.Inputs.ToList();
            return View("Database", Inputs);
        }
    }
}