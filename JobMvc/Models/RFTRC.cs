using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class RFTRC
    {
        public const string tbname = "RFTRC";
        public string TariffClass { get; set; }
        public string TariffDescThai { get; set; }
        public string TariffDescEng { get; set; }
        public string CompIndicator { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? LastUpdate { get; set; }

        public List<RFTRC> get(string filter="")
        {
            var rows = new List<RFTRC>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader(string.Format("select * from " + tbname + " where TariffClass like '{0}%'",filter)))
                {
                    while (rd.Read())
                    {
                        var data = new RFTRC();

                            try { data.TariffClass = rd.GetString("TariffClass"); } catch {}
                            try { data.TariffDescThai = rd.GetString("TariffDescThai"); } catch {}
                            try { data.TariffDescEng = rd.GetString("TariffDescEng"); } catch {}
                            try { data.CompIndicator = rd.GetString("CompIndicator"); } catch {}
                            try { data.StartDate = rd.GetDateTime("StartDate"); } catch {}
                            try { data.FinishDate = rd.GetDateTime("FinishDate"); } catch {}
                            try { data.LastUpdate = rd.GetDateTime("LastUpdate"); } catch {}
     
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
                    string sql = string.Format("select * from " + tbname + " where TariffClass='{0}'", this.TariffClass);
                    using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
                    {
                        var tb = dt.data;
                        var dr = tb.NewRow();
                        if (tb.Rows.Count > 0)
                        {
                            dr = tb.Rows[0];
                        }
                        dr["TariffClass"] = this.TariffClass;
                        dr["TariffDescThai"] = this.TariffDescThai;
                        dr["TariffDescEng"] = this.TariffDescEng;
                        dr["CompIndicator"] = this.CompIndicator;
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

        public string delete()
        {
            string msg = "Delete Success";
            using (Connection cn = new Connection("cdp1"))
            {
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where TariffClass='{0}'", this.TariffClass)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}