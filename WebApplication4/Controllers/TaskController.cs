using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Task()
        {
            return View();
        }
    }
}