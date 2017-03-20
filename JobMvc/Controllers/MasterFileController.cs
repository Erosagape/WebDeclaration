using System.Linq;
using JobMvc.Models;
using System.Web.Mvc;

namespace JobMvc.Controllers
{
    public class MasterFileController : Controller
    {
        public ActionResult BankCode()
        {
            ViewBag.Title = "Bank Management";
            return View();
        }
        public ActionResult getBankCode()
        {
            var data=new BankCode();
            var model=data.get();
            return Json(model.ToList(),JsonRequestBehavior.AllowGet);
        }
        public ActionResult setBankCode(BankCode data)
        {
            string msg=data.save();
            return Content(msg);
        }
        public ActionResult deleteBankCode(string oid)
        {
            string msg=new BankCode().delete(oid);
            return Content(msg);
        }
        public ActionResult BookAccount()
        {
            ViewBag.Title = "Bank Accounts Management";
            return View();
        }
        public ActionResult getBookAccount()
        {
            var data = new BookAccount();
            var model = data.get();
            return Json(model.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult setBookAccount(BookAccount data)
        {
            string msg = data.save();
            return Content(msg);
        }
        public ActionResult deleteBookAccount(BookAccount data)
        {
            string msg = data.delete();
            return Content(msg);
        }
    }
}