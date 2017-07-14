using System;
using System.Collections.Generic;

namespace JobMvc.DataLayer
{
    public static class DBContext
    {
        public static List<Branch> getBranch()
        {
            return new Branch().get();
        }
        public static List<RFUNT> getUnit()
        {
            return new RFUNT().get();
        }
        public static List<RFICC> getCountry()
        {
            return new RFICC().get();
        }
        public static List<CurrencyCode> getCurrency()
        {
            return new CurrencyCode().get();
        }
        public static List<Company> getCompany()
        {
            return new Company().get();
        }
        public static List<Consignee> getConsignee()
        {
            return new Consignee().get();
        }
        public static List<DecInvoice_Header> getInvHeader()
        {
            return new DecInvoice_Header().get();
        }
        public static List<DecInvoice_Detail> getInvDetail(string RefNo, string InvNo)
        {
            var data = new DecInvoice_Detail().get(string.Format(" where RefNO='{0}' and InvNO='{1}'", RefNo, InvNo));
            return data;
        }
    }
    public static class _Dummy
    {
        public static List<Branch> getBranch()
        {
            List<Branch> data = new List<Branch>();
            data.Add(new Branch()
            {
                Code = "00",
                BrName = "สำนักงานใหญ่"
            });
            data.Add(new Branch()
            {
                Code = "01",
                BrName = "แหลมฉบัง"
            });
            return data;
        }
        public static List<DecInvoice_Header> getInvNo()
        {
            List<DecInvoice_Header> data = new List<DecInvoice_Header>();
            data.Add(new DecInvoice_Header()
            {
                InvNO = "Inv0001",
                RefNO = "DAJD000000001",
                TrackingNO = "A08010000341",
                InvDate = Convert.ToDateTime("2017-05-01"),
                PoNo = "PO0001"
            });
            data.Add(new DecInvoice_Header()
            {
                InvNO = "Inv0002",
                RefNO = "DAJD000000002",
                TrackingNO = "A08200343434",
                InvDate = Convert.ToDateTime("2017-06-23"),
                PoNo = "PO0002"
            });
            return data;
        }
        public static List<string> getTermofTrade()
        {
            List<string> data = new List<string>() { "FOB", "CIF" ,"T/T","D/T","EXW" };
            return data;
        }
        public static List<CurrencyCode> getCurrency()
        {
            List<CurrencyCode> data = new List<CurrencyCode>();
            data.Add(new CurrencyCode()
            {
                Code = "THB",
                TName = "Thai Baht"
            });
            data.Add(new CurrencyCode()
            {
                Code = "USD",
                TName = "US Dollars"
            });
            data.Add(new CurrencyCode()
            {
                Code = "JPY",
                TName = "Japanese Yen"
            });
            return data;
        }
        public static List<string> getUnit()
        {
            return new List<string>() { "C62", "PCS", "KGS", "GRS", "BX", "CTN", "SHP" };
        }
        public static Dictionary<string, string> getCommLevel()
        {
            var data = new Dictionary<string, string>();
            data.Add("WO", "Wholeseller");
            data.Add("RT", "Retail");
            return data;
        }
        public static Dictionary<string, string> getCommStatus()
        {
            var data = new Dictionary<string, string>();
            data.Add("AG", "Agent");
            data.Add("DI", "Distributor");
            data.Add("CO", "Consignee");
            data.Add("MA", "Manufacturer");
            data.Add("TR", "Transporter");
            data.Add("FW", "Forwarder");
            data.Add("VN", "Vender");
            data.Add("OT", "Others");
            return data;
        }
        public static Dictionary<string, string> getDutyCalMethod()
        {
            var data = new Dictionary<string, string>();
            data.Add("W", "Weight");
            data.Add("Q", "Quantity");
            return data;
        }
    }
}