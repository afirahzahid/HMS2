using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HostelManagementSystem.Controllers
{
    public class AdminLogController : Controller
    {
        // GET: AdminLog
        public ActionResult AdminLogForm()
        {
            return View();
        }
    }
}