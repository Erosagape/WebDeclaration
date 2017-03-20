using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
	public class BankCode
	{
		public const string tbname = "BankCode";
		public string Code { get; set; }
		public string BName { get; set; }
		public string CustomsCode { get; set; }

		public List<BankCode> get()
		{
			var rows = new List<BankCode>();
			using (Connection cn = new Connection("cdp1"))
			{
				using (var rd = cn.getDataReader("select * from " + tbname))
				{
					while (rd.Read())
					{
						rows.Add(new BankCode()
						{
							Code = rd.GetString("Code"),
							BName = rd.GetString("BName"),
							CustomsCode = rd.GetString("CustomsCode")
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
						dr["BName"] = this.BName;
						dr["CustomsCode"] = this.CustomsCode;

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
			using (Connection cn = new Connection("cdp1"))
			{
				if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where Code='{0}", oid)) == false)
				{
					msg = cn.Message;
				}
			}
			return msg;
		}
	}
}