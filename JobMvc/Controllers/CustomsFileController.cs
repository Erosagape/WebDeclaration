using System.Linq;
using JobMvc.Models;
using System.Web.Mvc;

namespace JobMvc.Controllers
{
    public class CustomsFileController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Country()
        {
            ViewBag.Title = "Country Management";
            return View();
        }
        public ActionResult getCountry()
        {
            var data = new Country();
            var model = data.getCountry_all();
            return Json(model.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult setCountry(Country data)
        {
            string msg = data.saveCountry();
            return Content(msg);
        }
        public ActionResult Currency()
        {
            ViewBag.Title = "Currency Management";
            return View();
        }
        public ActionResult getCurrency()
        {
            var data = new Currency();
            var model = data.get();
            if (Request.QueryString["countryCode"] != null)
            {
                model = model.Where(e => e.CountryCode.Equals(Request.QueryString["countryCode"])).ToList();
            }
            return Json(model.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult setCurrency(Currency data)
        {
            string msg = data.save();
            return Content(msg);
        }
        public ActionResult deleteCurrency(string oid)
        {
            var data = new Currency();
            return Content(data.delete(oid));
        }
        public ActionResult InterPort()
        {
            ViewBag.Title = "InterPort Management";
            return View();
        }
        public ActionResult getInterPort()
        {
            var data = new InterPort();
            var model = data.get();
            if (Request.QueryString["country"] != null)
            {
                model = model.Where(e => e.CountryCode.Equals(Request.QueryString["country"])).ToList();
            }
            return Json(model.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult setInterPort(InterPort data)
        {
            string msg = data.save();
            return Content(msg);
        }
        public ActionResult deleteInterPort(string oid)
        {
            var data = new InterPort();
            return Content(data.delete(oid));
        }
        public ActionResult ExchangeRate()
        {
            ViewBag.Title = "Exchange Rates";
            ViewBag.cType = Request.QueryString["type"];
            ViewBag.cCode = Request.QueryString["currencyCode"];
            ViewBag.cName = Request.QueryString["currencyName"];
            return View();
        }
        public ActionResult getExchangeRate(string currencyCode,string type)
        {
            var data = new ExchangeRate().get();
            if(type!="") data = data.Where(e => e.RateType.Equals(type)).ToList();
            if(currencyCode!="") data = data.Where(e => e.CurrencyCode.Equals(currencyCode)).ToList();
            return Json(data.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult setExchangeRate(ExchangeRate data)
        {
            string msg = data.save();
            return Content(msg);
        }
        public ActionResult deleteExchangeRate(string oid)
        {
            var data = new ExchangeRate();
            return Content(data.delete(oid));
        }
    }
}