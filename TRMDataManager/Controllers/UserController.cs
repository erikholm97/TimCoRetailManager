using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TRMDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : Controller
    {                
        public ActionResult GetById(int id)
        {
            UserD
            return View();
        }
    }
}
