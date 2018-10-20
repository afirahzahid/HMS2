using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HostelManagementSystem.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult StaffForm()
        {
            return View();
        }
    }
}