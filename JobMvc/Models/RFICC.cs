using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class RFICC
    {
        public const string tbname = "RFICC";
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CurrencyCode { get; set; }
        public string WTOCountry { get; set; }
        public string Continent { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? LastUpdate { get; set; }

        public List<RFICC> get()
        {
            var rows = new List<RFICC>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader("select * from " + tbname))
                {
                    while (rd.Read())
                    {
                        var data = new RFICC();

                        data.CountryCode = rd.GetString("CountryCode");
                        data.CountryName = rd.GetString("CountryName");
                        data.CurrencyCode = rd.GetString("CurrencyCode");
                        data.WTOCountry = rd.GetString("WTOCountry");
                        data.Continent = rd.GetString("Continent");
                        try { data.StartDate = rd.GetDateTime("StartDate"); } catch { }
                        try { data.FinishDate = rd.GetDateTime("FinishDate"); } catch { }
                        try { data.LastUpdate = rd.GetDateTime("LastUpdate"); } catch { }

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
            using (Connection cn = new Connection())
            {
                try
                {
                    string sql = string.Format("select * from " + tbname + " where CountryCode='{0}'", this.CountryCode);
                    using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
                    {
                        var tb = dt.data;
                        var dr = tb.NewRow();
                        if (tb.Rows.Count > 0)
                        {
                            dr = tb.Rows[0];
                        }
                        dr["CountryCode"] = this.CountryCode;
                        dr["CountryName"] = this.CountryName;
                        dr["CurrencyCode"] = this.CurrencyCode;
                        dr["WTOCountry"] = this.WTOCountry;
                        dr["Continent"] = this.Continent;
                        dr["StartDate"] = this.StartDate;
                        dr["FinishDate"] = this.FinishDate;
                        dr["LastUpdate"] = this.LastUpdate;

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

        public string delete(string oid)
        {
            string msg = "Delete Success";
            using (Connection cn = new Connection())
            {
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where CountryCode='{0}'", oid)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}