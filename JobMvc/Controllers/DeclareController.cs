using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobMvc.Controllers
{
    public class DeclareController : Controller
    {
        // GET: Declare
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getDeclare_Header()
        {
            var data = new Declare_Header().get().ToList();
            string json = JsonConvert.SerializeObject(data);
            return Content(json, "application/json", System.Text.UTF8Encoding.UTF8);
        }
    }
}