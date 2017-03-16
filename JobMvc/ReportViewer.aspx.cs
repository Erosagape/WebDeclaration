using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobMvc
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showReport();
        }
        protected void showReport()
        {
            var qrystr = Request.QueryString["report"];
            if (qrystr != null)
            {
                switch (qrystr.ToLower())
                {
                    case "interport":
                        var country = "";
                        if (Request.QueryString["country"] != null)
                        {
                            country = Request.QueryString["country"];
                        }
                        report_InterPort(country);
                        break;
                }
            }
        }
        protected void report_InterPort(string countryCode)
        {
            var rpt = new rptInterPort();
            rpt.RequestParameters = false;
            rpt.Parameters["paramCountry"].Value = countryCode;
            ASPxDocumentViewer1.Report = rpt;
        }
    }
}