using System;
using System.Collections.Generic;
using System.Linq;
using JobMvc.DataLayer;

namespace JobMvc.Models
{
    public class Currency
        {
            public const string tbname = "Currency";
            public int oid { get; set; }
            public string CurrencyCode { get; set; }
            public string CurrencyName { get; set; }
            public string CountryCode { get; set; }
            public List<Currency> get()
            {
                var rows = new List<Currency>();
                using (Connection cn = new Connection())
                {
                    using (var rd = cn.getDataReader("select * from " + tbname))
                    {
                        while (rd.Read())
                        {
                            rows.Add(new Currency()
                            {
                                oid = rd.GetInt32("oid"),
                                CurrencyCode=rd.GetString("CurrencyCode"),
                                CurrencyName=rd.GetString("CurrencyName"),
                                CountryCode=rd.GetString("CountryCode")
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
                            dr["CountryCode"] = this.CountryCode;
                            dr["CurrencyCode"] = this.CurrencyCode;
                            dr["CurrencyName"] = this.CurrencyName;

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
    public class Country
    {
        public int oid { get; set; }
        public string countryCode { get; set; }
        public string countryName { get; set; }
        public List<Country> getCountry_all()
        {
            List<Country> rows = new List<Country>();
            using (Connection cn = new Connection())
            {
                using (var rd = cn.getDataReader("select * from Country"))
                {
                    while (rd.Read())
                    {
                        rows.Add(new Country()
                        {
                            oid = rd.GetInt32("oid"),
                            countryCode = rd.GetString("countryCode"),
                            countryName = rd.GetString("countryName")
                        });
                    }
                    rd.Close();
                }
                cn.Close();
            }
            return rows;
        }
        public string deleteCountry(string oid)
        {
            string msg = "Delete Success";
            using(Connection cn =new Connection())
            {
                if(cn.ExecuteSQL(string.Format("delete from Country where oid={0}", oid))==false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
        public string saveCountry()
        {
            using (Connection cn = new Connection())
            {
                try
                {
                    string sql = string.Format("select * from Country where oid='{0}'", this.oid);
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
                        dr["countryCode"] = this.countryCode;
                        dr["countryName"] = this.countryName;
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
    }
    public class InterPort
    {
        public const string tbname = "InterPort";
        public int oid { get; set; }
        public string PortCode { get; set; }
        public string PortName { get; set; }
        public string CountryCode { get; set; }
        public List<InterPort> get()
        {
            var rows = new List<InterPort>();
            using (Connection cn = new Connection())
            {
                using (var rd = cn.getDataReader("select * from " + tbname))
                {
                    while (rd.Read())
                    {
                        rows.Add(new InterPort()
                        {
                            oid = rd.GetInt32("oid"),
                            PortCode = rd.GetString("PortCode"),
                            PortName = rd.GetString("PortName"),
                            CountryCode = rd.GetString("CountryCode")
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
                        dr["CountryCode"] = this.CountryCode;
                        dr["PortCode"] = this.PortCode;
                        dr["PortName"] = this.PortName;

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
    public class ExchangeRate
    {
        public const string tbname = "exchangerate";
        public int oid { get; set; }
        public string CurrencyCode { get; set; }
        public string RateType { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Status { get; set; }
        public double RateValue { get; set; }
        public List<ExchangeRate> get()
        {
            var lst = new List<ExchangeRate>();
            using (Connection cn = new Connection())
            {
                using (var rd = cn.getDataReader("select * from " + tbname))
                {
                    while (rd.Read())
                    {
                        lst.Add(new ExchangeRate()
                        {
                            oid=rd.GetInt32("oid"),
                            CurrencyCode=rd.GetString("CurrencyCode"),
                            RateType=rd.GetString("RateType"),
                            RateValue=rd.GetDouble("RateValue"),
                            DateBegin =rd.GetDateTime("DateBegin"),
                            DateEnd =rd.GetDateTime("DateEnd"),
                            LastUpdate= DateTime.UtcNow.AddHours(7).Date,
                            Status=rd.GetString("Status")
                        });
                    }
                }
            }
            return lst.ToList();
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
                        dr["CurrencyCode"] = this.CurrencyCode;
                        dr["DateBegin"] = this.DateBegin;
                        dr["DateEnd"] = this.DateEnd;
                        dr["RateType"] = this.RateType;
                        dr["LastUpdate"] = DateTime.UtcNow.AddHours(7).Date;
                        dr["RateValue"] = this.RateValue;
                        dr["Status"] = this.Status;
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