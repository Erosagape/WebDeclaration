using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class CurrencyCode
    {
        public const string tbname = "CurrencyCode";
        public string Code { get; set; }
        public string TName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public List<CurrencyCode> get()
        {
            var rows = new List<CurrencyCode>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader("select * from " + tbname))
                {
                    while (rd.Read())
                    {
                        rows.Add(new CurrencyCode()
                        {
                            Code = rd.GetString("Code"),
                            TName = rd.GetString("TName")
                        });
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
                        dr["Code"] = this.Code;
                        dr["TName"] = this.TName;

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
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where Code='{0}'", oid)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}