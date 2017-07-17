using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class RFTRS
    {
        public const string tbname = "RFTRS";
        public string TariffClass { get; set; }
        public string TariffStatCode { get; set; }
        public string GoodsUnitCode { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public string Desc3 { get; set; }
        public string Desc4 { get; set; }
        public string Desc5 { get; set; }
        public string StatDescThai { get; set; }
        public string StatDescEng { get; set; }
        public string AnnualNo { get; set; }
        public DateTime? AnnualDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? LastUpDate { get; set; }

        public List<RFTRS> get(string filter="")
        {
            var rows = new List<RFTRS>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader(string.Format("select * from " + tbname + " where TariffClass like '{0}%'",filter)))
                {
                    while (rd.Read())
                    {
                        var data = new RFTRS();
                        
                        try { data.TariffClass = rd.GetString("TariffClass"); } catch {}
                        try { data.TariffStatCode = rd.GetString("TariffStatCode"); } catch {}
                        try { data.GoodsUnitCode = rd.GetString("GoodsUnitCode"); } catch {}
                        try { data.Desc1 = rd.GetString("Desc1"); } catch {}
                        try { data.Desc2 = rd.GetString("Desc2"); } catch {}
                        try { data.Desc3 = rd.GetString("Desc3"); } catch {}
                        try { data.Desc4 = rd.GetString("Desc4"); } catch {}
                        try { data.Desc5 = rd.GetString("Desc5"); } catch {}
                        try { data.StatDescThai = rd.GetString("StatDescThai"); } catch {}
                        try { data.StatDescEng = rd.GetString("StatDescEng"); } catch {}
                        try { data.AnnualNo = rd.GetString("AnnualNo"); } catch {}
                        try { data.AnnualDate = rd.GetDateTime("AnnualDate"); } catch {}
                        try { data.StartDate = rd.GetDateTime("StartDate"); } catch {}
                        try { data.FinishDate = rd.GetDateTime("FinishDate"); } catch {}
                        try { data.LastUpDate = rd.GetDateTime("LastUpDate"); } catch {}
                        
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
                    string sql = string.Format("select * from " + tbname + " where TariffClass='{0}' and TariffStatCode='{1}'", this.TariffClass, this.TariffStatCode);
                    using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
                    {
                        var tb = dt.data;
                        var dr = tb.NewRow();
                        if (tb.Rows.Count > 0)
                        {
                            dr = tb.Rows[0];
                        }
                        dr["TariffClass"] = this.TariffClass;
                        dr["TariffStatCode"] = this.TariffStatCode;
                        dr["GoodsUnitCode"] = this.GoodsUnitCode;
                        dr["Desc1"] = this.Desc1;
                        dr["Desc2"] = this.Desc2;
                        dr["Desc3"] = this.Desc3;
                        dr["Desc4"] = this.Desc4;
                        dr["Desc5"] = this.Desc5;
                        dr["StatDescThai"] = this.StatDescThai;
                        dr["StatDescEng"] = this.StatDescEng;
                        dr["AnnualNo"] = this.AnnualNo;
                        dr["AnnualDate"] = this.AnnualDate;
                        dr["StartDate"] = this.StartDate;
                        dr["FinishDate"] = this.FinishDate;
                        dr["LastUpDate"] = this.LastUpDate;

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
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where TariffClass='{0}' and TariffStatCode='{1}'", this.TariffClass, this.TariffStatCode)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}