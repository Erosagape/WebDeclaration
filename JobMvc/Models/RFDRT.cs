using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
	public class RFDRT
	{
		public const string tbname = "RFDRT";
		public string TRFCLS { get; set; }
		public string TRFSEQ { get; set; }
		public string DTYCDE { get; set; }
        public double DTYYRTE { get; set; }
        public double DTYSPE { get; set; }
		public string SPECDE { get; set; }
		public string ANONUM { get; set; }
		public string ANODES { get; set; }
		public string DSCTRS1 { get; set; }
		public string DSCTRS2 { get; set; }
		public string UIDCTEAMN { get; set; }
		public string PRVCDE { get; set; }
		public DateTime DTEANO { get; set; }
		public DateTime DTESTR { get; set; }
		public DateTime DTEFIN { get; set; }
		public DateTime DTECTEAMN { get; set; }
		public DateTime TMECTEAMN { get; set; }

		public List<RFDRT> get(string filter)
		{
			var rows = new List<RFDRT>();
			using (Connection cn = new Connection("cdp1"))
			{
				using (var rd = cn.getDataReader("select TRFCLS,TRFSEQ,DTYCDE,SPECDE,DTYYRTE,DTYSPE,PRVCDE from " + tbname + " where TRFCLS like '" + filter +"%'"))
				{
					while (rd.Read())
					{
                        RFDRT data = new RFDRT();
                        
                        try { data.TRFCLS = rd.GetString("TRFCLS"); } catch {}
                        try { data.TRFSEQ = rd.GetString("TRFSEQ"); } catch {}
                        try { data.DTYCDE = rd.GetString("DTYCDE"); } catch {}
                        try { data.SPECDE = rd.GetString("SPECDE"); } catch {}
                        try { data.DTYYRTE = rd.GetDouble("DTTYRTE"); } catch { }
                        try { data.DTYSPE = rd.GetDouble("DTYSPE"); } catch { }
                        try { data.ANONUM = rd.GetString("ANONUM"); } catch {}
                        try { data.ANODES = rd.GetString("ANODES"); } catch {}
                        try { data.DSCTRS1 = rd.GetString("DSCTRS1"); } catch {}
                        try { data.DSCTRS2 = rd.GetString("DSCTRS2"); } catch {}
                        try { data.UIDCTEAMN = rd.GetString("UIDCTEAMN"); } catch {}                        
                        try { data.DTEANO = rd.GetDateTime("DTEANO"); } catch {}
                        try { data.DTESTR = rd.GetDateTime("DTESTR"); } catch {}
                        try { data.DTEFIN = rd.GetDateTime("DTEFIN"); } catch {}
                        try { data.DTECTEAMN = rd.GetDateTime("DTECTEAMN"); } catch {}
                        try { data.TMECTEAMN = rd.GetDateTime("TMECTEAMN"); } catch {}
                        try { data.PRVCDE = rd.GetString("PRVCDE"); } catch {}
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
					string sql = string.Format("select * from " + tbname + " where TRFCLS='{0}' and TRFSEQ='{1}' and DTYCDE='{2}'", this.TRFCLS,this.TRFSEQ,this.DTYCDE);
					using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
					{
						var tb = dt.data;
						var dr = tb.NewRow();
						if (tb.Rows.Count > 0)
						{
							dr = tb.Rows[0];
						}
						dr["TRFCLS"] = this.TRFCLS;
						dr["TRFSEQ"] = this.TRFSEQ;
						dr["DTYCDE"] = this.DTYCDE;
						dr["SPECDE"] = this.SPECDE;
						dr["ANONUM"] = this.ANONUM;
						dr["ANODES"] = this.ANODES;
						dr["DSCTRS1"] = this.DSCTRS1;
						dr["DSCTRS2"] = this.DSCTRS2;
						dr["UIDCTEAMN"] = this.UIDCTEAMN;
						dr["PRVCDE"] = this.PRVCDE;
						dr["DTEANO"] = this.DTEANO;
						dr["DTESTR"] = this.DTESTR;
						dr["DTEFIN"] = this.DTEFIN;
						dr["DTECTEAMN"] = this.DTECTEAMN;
						dr["TMECTEAMN"] = this.TMECTEAMN;

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

		public string delete(RFDRT data)
		{
			string msg = "Delete Success";
			using (Connection cn = new Connection("cdp1"))
			{
				if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where TRFCLS='{0}' and TRFSEQ='{1}' and DTYCDE='{2}'", data.TRFCLS,data.TRFSEQ,data.DTYCDE)) == false)
				{
					msg = cn.Message;
				}
			}
			return msg;
		}
	}
}