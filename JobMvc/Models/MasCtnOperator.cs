using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
	public class MasCtnOperator
	{
		public const string tbname = "MasCtnOperator";
		public int oid { get; set; }
		public string TaxNo { get; set; }
		public string CmpName { get; set; }

		public List<MasCtnOperator> get()
		{
			var rows = new List<MasCtnOperator>();
			using (Connection cn = new Connection())
			{
				using (var rd = cn.getDataReader("select * from " + tbname))
				{
					while (rd.Read())
					{
						rows.Add(new MasCtnOperator()
						{
							oid = rd.GetInt32("oid"),
							TaxNo = rd.GetString("TaxNo"),
							CmpName = rd.GetString("CmpName")
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
					string sql = string.Format("select * from " + tbname + " where oid='{0}'", this.oid);
					using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
					{
						var tb = dt.data;
						var dr = tb.NewRow();
						if (tb.Rows.Count > 0)
						{
							dr = tb.Rows[0];
						}
						else
						{
							dr["oid"] = 0;
						}
						dr["TaxNo"] = this.TaxNo;
						dr["CmpName"] = this.CmpName;

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
				if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where oid={0}", oid)) == false)
				{
					msg = cn.Message;
				}
			}
			return msg;
		}
	}
}