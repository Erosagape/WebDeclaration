using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobMvc.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Invoice()
        {
            return View();
        }
        public ActionResult getDecInvoice_Header()
        {
            var data = new DecInvoice_Header().get();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}