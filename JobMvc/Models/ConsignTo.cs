using System.Collections.Generic;
using System;
using JobMvc.DataLayer;

namespace JobMvc
{
    public class ConsignTo
    {
        public const string tbname = "ConsignTo";
        public string ConCode { get; set; }
        public string ConTo { get; set; }
        public string NameEng { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TaxNumber { get; set; }
        public string CountryCode { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string DestinationPort { get; set; }
        public string Phone { get; set; }
        public string FaxNumber { get; set; }
        public string EMailAddress { get; set; }
        public string Address3 { get; set; }

        public List<ConsignTo> get(string filter = "")
        {
            var rows = new List<ConsignTo>();
            using (Connection cn = new Connection("cdp1"))
            {
                string wherec = filter == "" ? "" : " where ConCode='" + filter + "'";
                using (var rd = cn.getDataReader("select * from " + tbname + wherec))
                {
                    while (rd.Read())
                    {
                        var data = new ConsignTo();

                        try { data.TaxNumber = rd.GetString("TaxNumber"); } catch { }
                        try { data.ConCode = rd.GetString("ConCode"); } catch { }
                        try { data.ConTo = rd.GetString("ConTo"); } catch { }
                        try { data.NameEng = rd.GetString("NameEng"); } catch { }
                        try { data.Address1 = rd.GetString("Address1"); } catch { }
                        try { data.Address2 = rd.GetString("Address2"); } catch { }
                        try { data.CountryCode = rd.GetString("CountryCode"); } catch { }
                        try { data.ZipCode = rd.GetString("ZipCode"); } catch { }
                        try { data.CityName = rd.GetString("CityName"); } catch { }
                        try { data.DestinationPort = rd.GetString("DestinationPort"); } catch { }
                        try { data.Phone = rd.GetString("Phone"); } catch { }
                        try { data.FaxNumber = rd.GetString("FaxNumber"); } catch { }
                        try { data.EMailAddress = rd.GetString("EMailAddress"); } catch { }
                        try { data.Address3 = rd.GetString("Address3"); } catch { }

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
            using (Connection cn = new Connection("cdp"))
            {
                try
                {
                    string sql = string.Format("select * from " + tbname + " where TaxNumber='{0}'", this.TaxNumber);
                    using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
                    {
                        var tb = dt.data;
                        var dr = tb.NewRow();
                        if (tb.Rows.Count > 0)
                        {
                            dr = tb.Rows[0];
                        }
                        dr["TaxNumber"] = this.TaxNumber;
                        dr["ConCode"] = this.ConCode;
                        dr["ConTo"] = this.ConTo;
                        dr["NameEng"] = this.NameEng;
                        dr["Address1"] = this.Address1;
                        dr["Address2"] = this.Address2;
                        dr["CountryCode"] = this.CountryCode;
                        dr["ZipCode"] = this.ZipCode;
                        dr["CityName"] = this.CityName;
                        dr["DestinationPort"] = this.DestinationPort;
                        dr["Phone"] = this.Phone;
                        dr["FaxNumber"] = this.FaxNumber;
                        dr["EMailAddress"] = this.EMailAddress;
                        dr["Address3"] = this.Address3;

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
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where TaxNumber='{0}'", this.TaxNumber)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}