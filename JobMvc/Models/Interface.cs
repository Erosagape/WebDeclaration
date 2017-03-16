using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobMvc.Models
{
    interface ICompany
    {
        string code { get; set; }
        string name { get; set; }
        string address { get; set; }
        string zipcode { get; set; }
        string country { get; set; }
        string contact { get; set; }
        string email { get; set; }
        string phone { get; set; }
        string fax { get; set; }
    }
    enum JobType
    {
        Import,Export,Domestic
    }
    enum ShipBy
    {
        Air,Sea,Car
    }
}