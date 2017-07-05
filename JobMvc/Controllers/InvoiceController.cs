using System.Web.Mvc;
using JobMvc.DataLayer;
namespace JobMvc.Controllers
{
    public class InvoiceController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getBranch()
        {
            return Json(DBContext.getBranch(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getInvList()
        {
            //return Json(_Dummy.getInvNo(), JsonRequestBehavior.AllowGet);
            return Json(DBContext.getInvHeader(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getIncoTerm()
        {
            return Json(_Dummy.getTermofTrade(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getCurrency()
        {
            return Json(DBContext.getCurrency(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getUnit()
        {
            return Json(DBContext.getUnit(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getCountry()
        {
            return Json(DBContext.getCountry(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getCompany()
        {
            return Json(DBContext.getCompany(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getCommLevel()
        {
            return Json(_Dummy.getCommLevel(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getCommStatus()
        {
            return Json(_Dummy.getCommStatus(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getDutyCalMethod()
        {
            return Json(_Dummy.getDutyCalMethod(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getConsignee()
        {
            return Json(DBContext.getConsignee(), JsonRequestBehavior.AllowGet);
        }
    }
}