using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class Consignee
    {
        public const string tbname = "Consignee";
        public string TaxNumber { get; set; }
        public string Code { get; set; }
        public string NameEng { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public string DestinationPort { get; set; }
        public string Phone { get; set; }
        public string FaxNumber { get; set; }
        public string CommFormName { get; set; }
        public string PackFormName { get; set; }
        public string CustFormName { get; set; }
        public string CommStyle { get; set; }
        public string CustStyle { get; set; }
        public string PackStyle { get; set; }
        public string TAddress { get; set; }
        public string TDistrict { get; set; }
        public string TSubProvince { get; set; }
        public string TProvince { get; set; }
        public string TPostCode { get; set; }
        public string DMailAddress { get; set; }
        public string TProvinceName { get; set; }

        public List<Consignee> get()
        {
            var rows = new List<Consignee>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader("select * from " + tbname))
                {
                    while (rd.Read())
                    {
                        var data = new Consignee();

                        try { data.TaxNumber = rd.GetString("TaxNumber"); } catch { }
                        try { data.Code = rd.GetString("Code"); } catch { }
                        try { data.NameEng = rd.GetString("NameEng"); } catch { }
                        try { data.Address1 = rd.GetString("Address1"); } catch { }
                        try { data.Address2 = rd.GetString("Address2"); } catch { }
                        try { data.CityName = rd.GetString("CityName"); } catch { }
                        try { data.ZipCode = rd.GetString("ZipCode"); } catch { }
                        try { data.CountryCode = rd.GetString("CountryCode"); } catch { }
                        try { data.DestinationPort = rd.GetString("DestinationPort"); } catch { }
                        try { data.Phone = rd.GetString("Phone"); } catch { }
                        try { data.FaxNumber = rd.GetString("FaxNumber"); } catch { }
                        try { data.CommFormName = rd.GetString("CommFormName"); } catch { }
                        try { data.PackFormName = rd.GetString("PackFormName"); } catch { }
                        try { data.CustFormName = rd.GetString("CustFormName"); } catch { }
                        try { data.CommStyle = rd.GetString("CommStyle"); } catch { }
                        try { data.CustStyle = rd.GetString("CustStyle"); } catch { }
                        try { data.PackStyle = rd.GetString("PackStyle"); } catch { }
                        try { data.TAddress = rd.GetString("TAddress"); } catch { }
                        try { data.TDistrict = rd.GetString("TDistrict"); } catch { }
                        try { data.TSubProvince = rd.GetString("TSubProvince"); } catch { }
                        try { data.TProvince = rd.GetString("TProvince"); } catch { }
                        try { data.TPostCode = rd.GetString("TPostCode"); } catch { }
                        try { data.DMailAddress = rd.GetString("DMailAddress"); } catch { }
                        try { data.TProvinceName = rd.GetString("TProvinceName"); } catch { }

                        rows.Add(data);
                    }
                    rd.Close();
                }
                cn.Close();
            }
            return rows;
        }

        public string save()
        {
            using (Connection cn = new Connection("cdp1"))
            {
                try
                {
                    string sql = string.Format("select * from " + tbname + " where Code='{0}'", this.Code);
                    using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
                    {
                        var tb = dt.data;
                        var dr = tb.NewRow();
                        if (tb.Rows.Count > 0)
                        {
                            dr = tb.Rows[0];
                        }
                        dr["TaxNumber"] = this.TaxNumber;
                        dr["Code"] = this.Code;
                        dr["NameEng"] = this.NameEng;
                        dr["Address1"] = this.Address1;
                        dr["Address2"] = this.Address2;
                        dr["CityName"] = this.CityName;
                        dr["ZipCode"] = this.ZipCode;
                        dr["CountryCode"] = this.CountryCode;
                        dr["DestinationPort"] = this.DestinationPort;
                        dr["Phone"] = this.Phone;
                        dr["FaxNumber"] = this.FaxNumber;
                        dr["CommFormName"] = this.CommFormName;
                        dr["PackFormName"] = this.PackFormName;
                        dr["CustFormName"] = this.CustFormName;
                        dr["CommStyle"] = this.CommStyle;
                        dr["CustStyle"] = this.CustStyle;
                        dr["PackStyle"] = this.PackStyle;
                        dr["TAddress"] = this.TAddress;
                        dr["TDistrict"] = this.TDistrict;
                        dr["TSubProvince"] = this.TSubProvince;
                        dr["TProvince"] = this.TProvince;
                        dr["TPostCode"] = this.TPostCode;
                        dr["DMailAddress"] = this.DMailAddress;
                        dr["TProvinceName"] = this.TProvinceName;

                        if (dr.RowState.Equals(System.Data.DataRowState.Detached)) tb.Rows.Add(dr);
                        dt.update();
                    }
                    return "Save Successfully";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
        }

        public string delete()
        {
            string msg = "Delete Success";
            using (Connection cn = new Connection("cdp1"))
            {
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where Code='{0}'", this.Code)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}