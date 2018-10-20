using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HostelManagementSystem.Controllers
{
    public class StaffLogController : Controller
    {
        // GET: StaffLog
        public ActionResult StaffLogForm()
        {
            return View();
        }
    }
}