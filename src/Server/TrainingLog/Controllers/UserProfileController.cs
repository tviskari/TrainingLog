using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingLog.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: UserProfile
        public ActionResult UserInfo()
        {
            return View();
        }
    }
}