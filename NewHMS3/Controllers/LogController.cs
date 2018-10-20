using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HostelManagementSystem.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult LogForm()
        {
            return View();
        }
    }
}