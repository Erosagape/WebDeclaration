using System.Web.Mvc;
using JobMvc.DataLayer;
using Newtonsoft.Json;
using System.Linq;

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
        public ActionResult getPaymentTerm()
        {
            return Json(_Dummy.getPaymentTerm(), JsonRequestBehavior.AllowGet);
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
        public ActionResult getInvDetail(string refno, string invno)
        {
            return Json(DBContext.getInvDetail(refno, invno), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getRFDRT(string filter)
        {
            string json = JsonConvert.SerializeObject(DBContext.getRFDRT(filter).ToList());
            return Content(json, "application/json", System.Text.UTF8Encoding.UTF8);
        }
        public ActionResult getRFTRS(string filter)
        {
            string json = JsonConvert.SerializeObject(DBContext.getRFTRS(filter).ToList());
            return Content(json, "application/json", System.Text.UTF8Encoding.UTF8);
        }
        public ActionResult getRFTRC(string filter)
        {
            string json = JsonConvert.SerializeObject(DBContext.getRFTRC(filter).ToList());
            return Content(json, "application/json", System.Text.UTF8Encoding.UTF8);
        }
        public ActionResult getNotifyParty(string concode)
        {
            return Json(DBContext.getNotifyParty(concode), JsonRequestBehavior.AllowGet);
        }
        public ActionResult saveHeader(DecInvoice_Header data)
        {
            //string json = JsonConvert.SerializeObject(data);
            string json = data.save();
            return Content(json, "application/text", System.Text.Encoding.UTF8);
        }
        public ActionResult saveDetail(DecInvoice_Detail data)
        {
            //string json = JsonConvert.SerializeObject(data);
            string json = data.save();
            return Content(json, "application/text", System.Text.Encoding.UTF8);
        }
    }
}