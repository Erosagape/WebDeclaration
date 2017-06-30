using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class RFUNT
    {
        public const string tbname = "RFUNT";
        public string Code { get; set; }
        public string TName { get; set; }

        public List<RFUNT> get()
        {
            var rows = new List<RFUNT>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader("select * from " + tbname))
                {
                    while (rd.Read())
                    {
                        rows.Add(new RFUNT()
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
            using (Connection cn = new Connection())
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

        public string delete(string code)
        {
            string msg = "Delete Success";
            using (Connection cn = new Connection())
            {
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where Code='{0}'", Code)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}