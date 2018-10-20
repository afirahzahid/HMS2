using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HostelManagementSystem.Controllers
{
    public class RtLogController : Controller
    {
        // GET: RtLog
        public ActionResult RtLogForm()
        {
            return View();
        }
    }
}