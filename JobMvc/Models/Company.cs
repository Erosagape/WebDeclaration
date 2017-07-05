using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class Company
    {
        public const string tbname = "Company";
        public string CustCode { get; set; }
        public string Branch { get; set; }
        public string CustGroup { get; set; }
        public string Title { get; set; }
        public string NameThai { get; set; }
        public string TaxNumber { get; set; }
        public string NameEng { get; set; }
        public string TAddress1 { get; set; }
        public string TAddress2 { get; set; }
        public string EAddress1 { get; set; }
        public string EAddress2 { get; set; }
        public string Phone { get; set; }
        public string FaxNumber { get; set; }
        public string TAddress { get; set; }
        public string TStreet { get; set; }
        public string TDistrict { get; set; }
        public string TSubProvince { get; set; }
        public string TProvince { get; set; }
        public string TPostCode { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string ManagerCode { get; set; }
        public string CSCodeIM { get; set; }
        public string CSCodeEX { get; set; }
        public string CSCodeOT { get; set; }
        public string GLAccountCode { get; set; }
        public string UsedLanguage { get; set; }
        public string BillToCustCode { get; set; }
        public string BillToBranch { get; set; }
        public string LevelGrade { get; set; }
        public string BillCondition { get; set; }
        public string MapText { get; set; }
        public string MapFileName { get; set; }
        public string CmpType { get; set; }
        public string CmpLevelExp { get; set; }
        public string CmpLevelImp { get; set; }
        public string LnNO { get; set; }
        public string AdjTaxCode { get; set; }
        public string BkAuthorNo { get; set; }
        public string BkAuthorCnn { get; set; }
        public string LtdPsWkName { get; set; }
        public string ConsStatus { get; set; }
        public string CommLevel { get; set; }
        public string DMailAddress { get; set; }
        public string PrivilegeOption { get; set; }
        public string Email { get; set; }
        public string SignPrivilege { get; set; }
        public string ImporterNo { get; set; }
        public string ExporterNo { get; set; }
        public string CustSignMail { get; set; }
        public string Tax13No { get; set; }
        public string TProvinceName { get; set; }
        public string AEOsReferenceNumber { get; set; }
        public string GDEXRptName { get; set; }
        public string GDIMRptName { get; set; }
        public string GOODSRptName { get; set; }

        public int CustType { get; set; }
        public int TermOfPayment { get; set; }
        public int MgrSeq { get; set; }
        public int Is19bis { get; set; }
        public int LevelNoExp { get; set; }
        public int LevelNoImp { get; set; }
        public int GoldCardNO { get; set; }
        public int CustomsBrokerSeq { get; set; }

        public Double CreditLimit { get; set; }
        public Double DutyLimit { get; set; }
        public Double CommRate { get; set; }

        public List<Company> get()
        {
            var rows = new List<Company>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader("select * from " + tbname))
                {
                    while (rd.Read())
                    {
                        var data = new Company();

                        try { data.CustCode = rd.GetString("CustCode"); } catch { }
                        try { data.Branch = rd.GetString("Branch"); } catch { }
                        try { data.CustGroup = rd.GetString("CustGroup"); } catch { }
                        try { data.Title = rd.GetString("Title"); } catch { }
                        try { data.NameThai = rd.GetString("NameThai"); } catch { }
                        try { data.TaxNumber = rd.GetString("TaxNumber"); } catch { }
                        try { data.NameEng = rd.GetString("NameEng"); } catch { }
                        try { data.TAddress1 = rd.GetString("TAddress1"); } catch { }
                        try { data.TAddress2 = rd.GetString("TAddress2"); } catch { }
                        try { data.EAddress1 = rd.GetString("EAddress1"); } catch { }
                        try { data.EAddress2 = rd.GetString("EAddress2"); } catch { }
                        try { data.Phone = rd.GetString("Phone"); } catch { }
                        try { data.FaxNumber = rd.GetString("FaxNumber"); } catch { }
                        try { data.TAddress = rd.GetString("TAddress"); } catch { }
                        try { data.TStreet = rd.GetString("TStreet"); } catch { }
                        try { data.TDistrict = rd.GetString("TDistrict"); } catch { }
                        try { data.TSubProvince = rd.GetString("TSubProvince"); } catch { }
                        try { data.TProvince = rd.GetString("TProvince"); } catch { }
                        try { data.TPostCode = rd.GetString("TPostCode"); } catch { }
                        try { data.LoginName = rd.GetString("LoginName"); } catch { }
                        try { data.LoginPassword = rd.GetString("LoginPassword"); } catch { }
                        try { data.ManagerCode = rd.GetString("ManagerCode"); } catch { }
                        try { data.CSCodeIM = rd.GetString("CSCodeIM"); } catch { }
                        try { data.CSCodeEX = rd.GetString("CSCodeEX"); } catch { }
                        try { data.BillCondition = rd.GetString("BillCondition"); } catch { }
                        try { data.MapText = rd.GetString("MapText"); } catch { }
                        try { data.MapFileName = rd.GetString("MapFileName"); } catch { }
                        try { data.CmpType = rd.GetString("CmpType"); } catch { }
                        try { data.CmpLevelExp = rd.GetString("CmpLevelExp"); } catch { }
                        try { data.CmpLevelImp = rd.GetString("CmpLevelImp"); } catch { }
                        try { data.LnNO = rd.GetString("LnNO"); } catch { }
                        try { data.AdjTaxCode = rd.GetString("AdjTaxCode"); } catch { }
                        try { data.BkAuthorNo = rd.GetString("BkAuthorNo"); } catch { }
                        try { data.BkAuthorCnn = rd.GetString("BkAuthorCnn"); } catch { }
                        try { data.CSCodeOT = rd.GetString("CSCodeOT"); } catch { }
                        try { data.GLAccountCode = rd.GetString("GLAccountCode"); } catch { }
                        try { data.UsedLanguage = rd.GetString("UsedLanguage"); } catch { }
                        try { data.BillToCustCode = rd.GetString("BillToCustCode"); } catch { }
                        try { data.BillToBranch = rd.GetString("BillToBranch"); } catch { }
                        try { data.LevelGrade = rd.GetString("LevelGrade"); } catch { }
                        try { data.LtdPsWkName = rd.GetString("LtdPsWkName"); } catch { }
                        try { data.ConsStatus = rd.GetString("ConsStatus"); } catch { }
                        try { data.CommLevel = rd.GetString("CommLevel"); } catch { }
                        try { data.DMailAddress = rd.GetString("DMailAddress"); } catch { }
                        try { data.PrivilegeOption = rd.GetString("PrivilegeOption"); } catch { }
                        try { data.Email = rd.GetString("Email"); } catch { }
                        try { data.SignPrivilege = rd.GetString("SignPrivilege"); } catch { }
                        try { data.ImporterNo = rd.GetString("ImporterNo"); } catch { }
                        try { data.ExporterNo = rd.GetString("ExporterNo"); } catch { }
                        try { data.CustSignMail = rd.GetString("CustSignMail"); } catch { }
                        try { data.Tax13No = rd.GetString("Tax13No"); } catch { }
                        try { data.TProvinceName = rd.GetString("TProvinceName"); } catch { }
                        try { data.AEOsReferenceNumber = rd.GetString("AEOsReferenceNumber"); } catch { }
                        try { data.GDEXRptName = rd.GetString("GDEXRptName"); } catch { }
                        try { data.GDIMRptName = rd.GetString("GDIMRptName"); } catch { }
                        try { data.GOODSRptName = rd.GetString("GOODSRptName"); } catch { }

                        try { data.CustType = rd.GetInt32("CustType"); } catch { }
                        try { data.TermOfPayment = rd.GetInt32("TermOfPayment"); } catch { }
                        try { data.MgrSeq = rd.GetInt32("MgrSeq"); } catch { }
                        try { data.Is19bis = rd.GetInt32("Is19bis"); } catch { }
                        try { data.LevelNoExp = rd.GetInt32("LevelNoExp"); } catch { }
                        try { data.LevelNoImp = rd.GetInt32("LevelNoImp"); } catch { }
                        try { data.GoldCardNO = rd.GetInt32("GoldCardNO"); } catch { }
                        try { data.CustomsBrokerSeq = rd.GetInt32("CustomsBrokerSeq"); } catch { }

                        try { data.CreditLimit = rd.GetDouble("CreditLimit"); } catch { }
                        try { data.DutyLimit = rd.GetDouble("DutyLimit"); } catch { }
                        try { data.CommRate = rd.GetDouble("CommRate"); } catch { }

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
                    string sql = string.Format("select * from " + tbname + " where CustCode='{0}' and Branch='{1}'", this.CustCode, this.Branch);
                    using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
                    {
                        var tb = dt.data;
                        var dr = tb.NewRow();
                        if (tb.Rows.Count > 0)
                        {
                            dr = tb.Rows[0];
                        }

                        dr["CustCode"] = this.CustCode;
                        dr["Branch"] = this.Branch;
                        dr["CustGroup"] = this.CustGroup;
                        dr["Title"] = this.Title;
                        dr["NameThai"] = this.NameThai;
                        dr["TaxNumber"] = this.TaxNumber;
                        dr["NameEng"] = this.NameEng;
                        dr["TAddress1"] = this.TAddress1;
                        dr["TAddress2"] = this.TAddress2;
                        dr["EAddress1"] = this.EAddress1;
                        dr["EAddress2"] = this.EAddress2;
                        dr["Phone"] = this.Phone;
                        dr["FaxNumber"] = this.FaxNumber;
                        dr["TAddress"] = this.TAddress;
                        dr["TStreet"] = this.TStreet;
                        dr["TDistrict"] = this.TDistrict;
                        dr["TSubProvince"] = this.TSubProvince;
                        dr["TProvince"] = this.TProvince;
                        dr["TPostCode"] = this.TPostCode;
                        dr["LoginName"] = this.LoginName;
                        dr["LoginPassword"] = this.LoginPassword;
                        dr["ManagerCode"] = this.ManagerCode;
                        dr["CSCodeIM"] = this.CSCodeIM;
                        dr["CSCodeEX"] = this.CSCodeEX;
                        dr["CSCodeOT"] = this.CSCodeOT;
                        dr["GLAccountCode"] = this.GLAccountCode;
                        dr["UsedLanguage"] = this.UsedLanguage;
                        dr["BillToCustCode"] = this.BillToCustCode;
                        dr["BillToBranch"] = this.BillToBranch;
                        dr["LevelGrade"] = this.LevelGrade;
                        dr["BillCondition"] = this.BillCondition;
                        dr["MapText"] = this.MapText;
                        dr["MapFileName"] = this.MapFileName;
                        dr["CmpType"] = this.CmpType;
                        dr["CmpLevelExp"] = this.CmpLevelExp;
                        dr["CmpLevelImp"] = this.CmpLevelImp;
                        dr["LnNO"] = this.LnNO;
                        dr["AdjTaxCode"] = this.AdjTaxCode;
                        dr["BkAuthorNo"] = this.BkAuthorNo;
                        dr["BkAuthorCnn"] = this.BkAuthorCnn;
                        dr["LtdPsWkName"] = this.LtdPsWkName;
                        dr["ConsStatus"] = this.ConsStatus;
                        dr["CommLevel"] = this.CommLevel;
                        dr["DMailAddress"] = this.DMailAddress;
                        dr["PrivilegeOption"] = this.PrivilegeOption;
                        dr["Email"] = this.Email;
                        dr["SignPrivilege"] = this.SignPrivilege;
                        dr["ImporterNo"] = this.ImporterNo;
                        dr["ExporterNo"] = this.ExporterNo;
                        dr["CustSignMail"] = this.CustSignMail;
                        dr["Tax13No"] = this.Tax13No;
                        dr["TProvinceName"] = this.TProvinceName;
                        dr["AEOsReferenceNumber"] = this.AEOsReferenceNumber;
                        dr["GDEXRptName"] = this.GDEXRptName;
                        dr["GDIMRptName"] = this.GDIMRptName;
                        dr["GOODSRptName"] = this.GOODSRptName;

                        dr["CreditLimit"] = this.CreditLimit;
                        dr["DutyLimit"] = this.DutyLimit;
                        dr["CommRate"] = this.CommRate;

                        dr["CustType"] = this.CustType;
                        dr["TermOfPayment"] = this.TermOfPayment;
                        dr["MgrSeq"] = this.MgrSeq;
                        dr["Is19bis"] = this.Is19bis;
                        dr["LevelNoExp"] = this.LevelNoExp;
                        dr["LevelNoImp"] = this.LevelNoImp;
                        dr["GoldCardNO"] = this.GoldCardNO;
                        dr["CustomsBrokerSeq"] = this.CustomsBrokerSeq;

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
            using (Connection cn = new Connection())
            {
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where CustCode='{0}' and Branch='{0}'", this.CustCode, this.Branch)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}