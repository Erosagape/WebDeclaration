using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class Branch
    {
        public const string tbname = "Branch";
        public int oid { get; set; }
        public string Code { get; set; }
        public string BrName { get; set; }

        public List<Branch> get()
        {
            var rows = new List<Branch>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader("select * from " + tbname))
                {
                    int irow = 0;
                    while (rd.Read())
                    {
                        rows.Add(new Branch()
                        {
                            oid = ++irow,
                            Code = rd.GetString("Code"),
                            BrName = rd.GetString("BrName")
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
                        dr["BrName"] = this.BrName;

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

        public string delete(string Code)
        {
            string msg = "Delete Success";
            using (Connection cn = new Connection("cdp1"))
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