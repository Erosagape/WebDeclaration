using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class DecInvoice_Header
    {
        public const string tbname = "DecInvoice_Header";
        public string BranchCode { get; set; }
        public string RefNO { get; set; }
        public string InvNO { get; set; }
        public string TrackingNO { get; set; }
        public string CmpCode { get; set; }
        public string CmpTaxNumber { get; set; }
        public string CmpBranch { get; set; }
        public string SellerStatus { get; set; }
        public string ConsigneeStatus { get; set; }
        public string CommercialLevel { get; set; }
        public string BuyerCode { get; set; }
        public string BuyerName { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string Subprovince { get; set; }
        public string Province { get; set; }
        public string Postcode { get; set; }
        public string EmailAddr { get; set; }
        public string ConsigneeAddr { get; set; }
        public string PurchaseCountry { get; set; }
        public string NotifyPartyCode { get; set; }
        public string NotifyPartyName { get; set; }
        public string NotifyPartyAddr { get; set; }
        public string NotifyPartyEMail { get; set; }
        public string DestinationCountry { get; set; }
        public string IncoTerms { get; set; }
        public string InvCurrency { get; set; }
        public string NetWUnit { get; set; }
        public string CurExpOther { get; set; }
        public string CurExplanding { get; set; }
        public string CurExpInland { get; set; }
        public string CurExpPack { get; set; }
        public string CurExpFwd { get; set; }
        public string CurExpShp { get; set; }
        public string CurExpFrg { get; set; }
        public string CurExpIns { get; set; }
        public string AvgExpOther { get; set; }
        public string AvgExpInland { get; set; }
        public string AvgExplanding { get; set; }
        public string AvgExpFwd { get; set; }
        public string AvgExpPack { get; set; }
        public string AvgExpShp { get; set; }
        public string AvgExpFrg { get; set; }
        public string AvgExpIns { get; set; }
        public string RecByUser { get; set; }
        public string UIDTransmit { get; set; }
        public string SignBy { get; set; }
        public string FileToSend { get; set; }
        public string PoNo { get; set; }
        public string PaymentTerm { get; set; }
        public string OtherChargeDesc { get; set; }
        public string SelfCertRemark { get; set; }
        public string AEOsReferNo { get; set; }
        public string NotifyStreet { get; set; }
        public string NotifyDistrict { get; set; }
        public string NotifySubProvince { get; set; }
        public string NotifyProvince { get; set; }
        public string NotifyPostCode { get; set; }
        public DateTime InvDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime RecDate { get; set; }
        public DateTime RecTime { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime SignTime { get; set; }
        public int DocStatus { get; set; }
        public int AvgExp2Free { get; set; }
        public int ResponseStatus { get; set; }
        public int IsCancel { get; set; }
        public int InvoiceType { get; set; }
        public int IsNotAutoCal { get; set; }
        public Double InvCurRate { get; set; }
        public Double TotalNetW { get; set; }
        public Double TotalInvoice { get; set; }
        public Double TotalInvTHB { get; set; }
        public Double CurExpOtherRate { get; set; }
        public Double TotalExpOther { get; set; }
        public Double TotalExpOtherTHB { get; set; }
        public Double CurExplandingRate { get; set; }
        public Double TotalExplanding { get; set; }
        public Double TotalExplandingTHB { get; set; }
        public Double CurExpInlandRate { get; set; }
        public Double TotalExpInland { get; set; }
        public Double TotalExpInlandTHB { get; set; }
        public Double CurExpPackRate { get; set; }
        public Double TotalExpPack { get; set; }
        public Double TotalExpPackTHB { get; set; }
        public Double CurExpFwdRate { get; set; }
        public Double TotalExpForward { get; set; }
        public Double TotalExpForwardTHB { get; set; }
        public Double CurExpShpRate { get; set; }
        public Double TotalExpShipping { get; set; }
        public Double TotalExpShippingTHB { get; set; }
        public Double CurExpFrgRate { get; set; }
        public Double TotalExpFreight { get; set; }
        public Double TotalExpFreightTHB { get; set; }
        public Double CurExpInsRate { get; set; }
        public Double TotalExpInsurance { get; set; }
        public Double TotalExpInsuranceTHB { get; set; }
        public Double TotalIncreasedPrice { get; set; }
        public Double TotalIncreasedPriceTHB { get; set; }

        public List<DecInvoice_Header> get()
        {
            var rows = new List<DecInvoice_Header>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader("select * from " + tbname))
                {
                    while (rd.Read())
                    {
                        var data = new DecInvoice_Header();

                        try { data.BranchCode = rd.GetString("BranchCode"); } catch { }
                        try { data.RefNO = rd.GetString("RefNO"); } catch { }
                        try { data.InvNO = rd.GetString("InvNO"); } catch { }
                        try { data.TrackingNO = rd.GetString("TrackingNO"); } catch { }
                        try { data.CmpCode = rd.GetString("CmpCode"); } catch { }
                        try { data.CmpTaxNumber = rd.GetString("CmpTaxNumber"); } catch { }
                        try { data.CmpBranch = rd.GetString("CmpBranch"); } catch { }
                        try { data.SellerStatus = rd.GetString("SellerStatus"); } catch { }
                        try { data.ConsigneeStatus = rd.GetString("ConsigneeStatus"); } catch { }
                        try { data.CommercialLevel = rd.GetString("CommercialLevel"); } catch { }
                        try { data.BuyerCode = rd.GetString("BuyerCode"); } catch { }
                        try { data.BuyerName = rd.GetString("BuyerName"); } catch { }
                        try { data.Street = rd.GetString("Street"); } catch { }
                        try { data.District = rd.GetString("District"); } catch { }
                        try { data.Subprovince = rd.GetString("Subprovince"); } catch { }
                        try { data.Province = rd.GetString("Province"); } catch { }
                        try { data.Postcode = rd.GetString("Postcode"); } catch { }
                        try { data.EmailAddr = rd.GetString("EmailAddr"); } catch { }
                        try { data.ConsigneeAddr = rd.GetString("ConsigneeAddr"); } catch { }
                        try { data.PurchaseCountry = rd.GetString("PurchaseCountry"); } catch { }
                        try { data.NotifyPartyCode = rd.GetString("NotifyPartyCode"); } catch { }
                        try { data.NotifyPartyName = rd.GetString("NotifyPartyName"); } catch { }
                        try { data.NotifyPartyAddr = rd.GetString("NotifyPartyAddr"); } catch { }
                        try { data.NotifyPartyEMail = rd.GetString("NotifyPartyEMail"); } catch { }
                        try { data.CurExpInland = rd.GetString("CurExpInland"); } catch { }
                        try { data.CurExpPack = rd.GetString("CurExpPack"); } catch { }
                        try { data.CurExpFwd = rd.GetString("CurExpFwd"); } catch { }
                        try { data.CurExpShp = rd.GetString("CurExpShp"); } catch { }
                        try { data.CurExpFrg = rd.GetString("CurExpFrg"); } catch { }
                        try { data.CurExpIns = rd.GetString("CurExpIns"); } catch { }
                        try { data.AvgExpOther = rd.GetString("AvgExpOther"); } catch { }
                        try { data.AvgExpInland = rd.GetString("AvgExpInland"); } catch { }
                        try { data.AvgExplanding = rd.GetString("AvgExplanding"); } catch { }
                        try { data.AvgExpFwd = rd.GetString("AvgExpFwd"); } catch { }
                        try { data.DestinationCountry = rd.GetString("DestinationCountry"); } catch { }
                        try { data.IncoTerms = rd.GetString("IncoTerms"); } catch { }
                        try { data.InvCurrency = rd.GetString("InvCurrency"); } catch { }
                        try { data.NetWUnit = rd.GetString("NetWUnit"); } catch { }
                        try { data.CurExpOther = rd.GetString("CurExpOther"); } catch { }
                        try { data.CurExplanding = rd.GetString("CurExplanding"); } catch { }
                        try { data.AvgExpPack = rd.GetString("AvgExpPack"); } catch { }
                        try { data.AvgExpShp = rd.GetString("AvgExpShp"); } catch { }
                        try { data.AvgExpFrg = rd.GetString("AvgExpFrg"); } catch { }
                        try { data.AvgExpIns = rd.GetString("AvgExpIns"); } catch { }
                        try { data.RecByUser = rd.GetString("RecByUser"); } catch { }
                        try { data.UIDTransmit = rd.GetString("UIDTransmit"); } catch { }
                        try { data.SignBy = rd.GetString("SignBy"); } catch { }
                        try { data.FileToSend = rd.GetString("FileToSend"); } catch { }
                        try { data.PoNo = rd.GetString("PoNo"); } catch { }
                        try { data.PaymentTerm = rd.GetString("PaymentTerm"); } catch { }
                        try { data.OtherChargeDesc = rd.GetString("OtherChargeDesc"); } catch { }
                        try { data.SelfCertRemark = rd.GetString("SelfCertRemark"); } catch { }
                        try { data.AEOsReferNo = rd.GetString("AEOsReferNo"); } catch { }
                        try { data.NotifyStreet = rd.GetString("NotifyStreet"); } catch { }
                        try { data.NotifyDistrict = rd.GetString("NotifyDistrict"); } catch { }
                        try { data.NotifySubProvince = rd.GetString("NotifySubProvince"); } catch { }
                        try { data.NotifyProvince = rd.GetString("NotifyProvince"); } catch { }
                        try { data.NotifyPostCode = rd.GetString("NotifyPostCode"); } catch { }

                        try { data.InvDate = rd.GetDateTime("InvDate"); } catch { }
                        try { data.DepartureDate = rd.GetDateTime("DepartureDate"); } catch { }
                        try { data.RecDate = rd.GetDateTime("RecDate"); } catch { }
                        try { data.RecTime = rd.GetDateTime("RecTime"); } catch { }
                        try { data.SignDate = rd.GetDateTime("SignDate"); } catch { }
                        try { data.SignTime = rd.GetDateTime("SignTime"); } catch { }

                        try { data.DocStatus = rd.GetInt32("DocStatus"); } catch { }
                        try { data.AvgExp2Free = rd.GetInt32("AvgExp2Free"); } catch { }
                        try { data.ResponseStatus = rd.GetInt32("ResponseStatus"); } catch { }
                        try { data.IsCancel = rd.GetInt32("IsCancel"); } catch { }
                        try { data.InvoiceType = rd.GetInt32("InvoiceType"); } catch { }
                        try { data.IsNotAutoCal = rd.GetInt32("IsNotAutoCal"); } catch { }

                        try { data.InvCurRate = rd.GetDouble("InvCurRate"); } catch { }
                        try { data.TotalNetW = rd.GetDouble("TotalNetW"); } catch { }
                        try { data.TotalInvoice = rd.GetDouble("TotalInvoice"); } catch { }
                        try { data.TotalInvTHB = rd.GetDouble("TotalInvTHB"); } catch { }
                        try { data.CurExpOtherRate = rd.GetDouble("CurExpOtherRate"); } catch { }
                        try { data.TotalExpOther = rd.GetDouble("TotalExpOther"); } catch { }
                        try { data.TotalExpOtherTHB = rd.GetDouble("TotalExpOtherTHB"); } catch { }
                        try { data.CurExplandingRate = rd.GetDouble("CurExplandingRate"); } catch { }
                        try { data.TotalExplanding = rd.GetDouble("TotalExplanding"); } catch { }
                        try { data.TotalExplandingTHB = rd.GetDouble("TotalExplandingTHB"); } catch { }
                        try { data.CurExpInlandRate = rd.GetDouble("CurExpInlandRate"); } catch { }
                        try { data.TotalExpInland = rd.GetDouble("TotalExpInland"); } catch { }
                        try { data.TotalExpInlandTHB = rd.GetDouble("TotalExpInlandTHB"); } catch { }
                        try { data.CurExpPackRate = rd.GetDouble("CurExpPackRate"); } catch { }
                        try { data.TotalExpPack = rd.GetDouble("TotalExpPack"); } catch { }
                        try { data.TotalExpPackTHB = rd.GetDouble("TotalExpPackTHB"); } catch { }
                        try { data.CurExpFwdRate = rd.GetDouble("CurExpFwdRate"); } catch { }
                        try { data.TotalExpForward = rd.GetDouble("TotalExpForward"); } catch { }
                        try { data.TotalExpForwardTHB = rd.GetDouble("TotalExpForwardTHB"); } catch { }
                        try { data.CurExpShpRate = rd.GetDouble("CurExpShpRate"); } catch { }
                        try { data.TotalExpShipping = rd.GetDouble("TotalExpShipping"); } catch { }
                        try { data.TotalExpShippingTHB = rd.GetDouble("TotalExpShippingTHB"); } catch { }
                        try { data.CurExpFrgRate = rd.GetDouble("CurExpFrgRate"); } catch { }
                        try { data.TotalExpFreight = rd.GetDouble("TotalExpFreight"); } catch { }
                        try { data.TotalExpFreightTHB = rd.GetDouble("TotalExpFreightTHB"); } catch { }
                        try { data.CurExpInsRate = rd.GetDouble("CurExpInsRate"); } catch { }
                        try { data.TotalExpInsurance = rd.GetDouble("TotalExpInsurance"); } catch { }
                        try { data.TotalExpInsuranceTHB = rd.GetDouble("TotalExpInsuranceTHB"); } catch { }
                        try { data.TotalIncreasedPrice = rd.GetDouble("TotalIncreasedPrice"); } catch { }
                        try { data.TotalIncreasedPriceTHB = rd.GetDouble("TotalIncreasedPriceTHB"); } catch { }
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
                    string sql = string.Format("select * from " + tbname + " where RefNO='{0}'", this.RefNO);
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
                        dr["BranchCode"] = this.BranchCode;
                        dr["RefNO"] = this.RefNO;
                        dr["InvNO"] = this.InvNO;
                        dr["TrackingNO"] = this.TrackingNO;
                        dr["CmpCode"] = this.CmpCode;
                        dr["CmpTaxNumber"] = this.CmpTaxNumber;
                        dr["CmpBranch"] = this.CmpBranch;
                        dr["SellerStatus"] = this.SellerStatus;
                        dr["ConsigneeStatus"] = this.ConsigneeStatus;
                        dr["CommercialLevel"] = this.CommercialLevel;
                        dr["BuyerCode"] = this.BuyerCode;
                        dr["BuyerName"] = this.BuyerName;
                        dr["Street"] = this.Street;
                        dr["District"] = this.District;
                        dr["Subprovince"] = this.Subprovince;
                        dr["Province"] = this.Province;
                        dr["Postcode"] = this.Postcode;
                        dr["EmailAddr"] = this.EmailAddr;
                        dr["ConsigneeAddr"] = this.ConsigneeAddr;
                        dr["PurchaseCountry"] = this.PurchaseCountry;
                        dr["NotifyPartyCode"] = this.NotifyPartyCode;
                        dr["NotifyPartyName"] = this.NotifyPartyName;
                        dr["NotifyPartyAddr"] = this.NotifyPartyAddr;
                        dr["NotifyPartyEMail"] = this.NotifyPartyEMail;
                        dr["DestinationCountry"] = this.DestinationCountry;
                        dr["IncoTerms"] = this.IncoTerms;
                        dr["InvCurrency"] = this.InvCurrency;
                        dr["NetWUnit"] = this.NetWUnit;
                        dr["CurExpOther"] = this.CurExpOther;
                        dr["CurExplanding"] = this.CurExplanding;
                        dr["CurExpInland"] = this.CurExpInland;
                        dr["CurExpPack"] = this.CurExpPack;
                        dr["CurExpFwd"] = this.CurExpFwd;
                        dr["CurExpShp"] = this.CurExpShp;
                        dr["CurExpFrg"] = this.CurExpFrg;
                        dr["CurExpIns"] = this.CurExpIns;
                        dr["AvgExpOther"] = this.AvgExpOther;
                        dr["AvgExpInland"] = this.AvgExpInland;
                        dr["AvgExplanding"] = this.AvgExplanding;
                        dr["AvgExpFwd"] = this.AvgExpFwd;
                        dr["AvgExpPack"] = this.AvgExpPack;
                        dr["AvgExpShp"] = this.AvgExpShp;
                        dr["AvgExpFrg"] = this.AvgExpFrg;
                        dr["AvgExpIns"] = this.AvgExpIns;
                        dr["RecByUser"] = this.RecByUser;
                        dr["UIDTransmit"] = this.UIDTransmit;
                        dr["SignBy"] = this.SignBy;
                        dr["FileToSend"] = this.FileToSend;
                        dr["PoNo"] = this.PoNo;
                        dr["PaymentTerm"] = this.PaymentTerm;
                        dr["OtherChargeDesc"] = this.OtherChargeDesc;
                        dr["SelfCertRemark"] = this.SelfCertRemark;
                        dr["AEOsReferNo"] = this.AEOsReferNo;
                        dr["NotifyStreet"] = this.NotifyStreet;
                        dr["NotifyDistrict"] = this.NotifyDistrict;
                        dr["NotifySubProvince"] = this.NotifySubProvince;
                        dr["NotifyProvince"] = this.NotifyProvince;
                        dr["NotifyPostCode"] = this.NotifyPostCode;

                        dr["InvCurRate"] = this.InvCurRate;
                        dr["TotalNetW"] = this.TotalNetW;
                        dr["TotalInvoice"] = this.TotalInvoice;
                        dr["TotalInvTHB"] = this.TotalInvTHB;
                        dr["CurExpOtherRate"] = this.CurExpOtherRate;
                        dr["TotalExpOther"] = this.TotalExpOther;
                        dr["TotalExpOtherTHB"] = this.TotalExpOtherTHB;
                        dr["CurExplandingRate"] = this.CurExplandingRate;
                        dr["TotalExplanding"] = this.TotalExplanding;
                        dr["TotalExplandingTHB"] = this.TotalExplandingTHB;
                        dr["CurExpInlandRate"] = this.CurExpInlandRate;
                        dr["TotalExpInland"] = this.TotalExpInland;
                        dr["TotalExpInlandTHB"] = this.TotalExpInlandTHB;
                        dr["CurExpPackRate"] = this.CurExpPackRate;
                        dr["TotalExpPack"] = this.TotalExpPack;
                        dr["TotalExpPackTHB"] = this.TotalExpPackTHB;
                        dr["CurExpFwdRate"] = this.CurExpFwdRate;
                        dr["TotalExpForward"] = this.TotalExpForward;
                        dr["TotalExpForwardTHB"] = this.TotalExpForwardTHB;
                        dr["CurExpShpRate"] = this.CurExpShpRate;
                        dr["TotalExpShipping"] = this.TotalExpShipping;
                        dr["TotalExpShippingTHB"] = this.TotalExpShippingTHB;
                        dr["CurExpFrgRate"] = this.CurExpFrgRate;
                        dr["TotalExpFreight"] = this.TotalExpFreight;
                        dr["TotalExpFreightTHB"] = this.TotalExpFreightTHB;
                        dr["CurExpInsRate"] = this.CurExpInsRate;
                        dr["TotalExpInsurance"] = this.TotalExpInsurance;
                        dr["TotalExpInsuranceTHB"] = this.TotalExpInsuranceTHB;
                        dr["TotalIncreasedPrice"] = this.TotalIncreasedPrice;
                        dr["TotalIncreasedPriceTHB"] = this.TotalIncreasedPriceTHB;

                        dr["DocStatus"] = this.DocStatus;
                        dr["AvgExp2Free"] = this.AvgExp2Free;
                        dr["ResponseStatus"] = this.ResponseStatus;
                        dr["IsCancel"] = this.IsCancel;
                        dr["InvoiceType"] = this.InvoiceType;
                        dr["IsNotAutoCal"] = this.IsNotAutoCal;

                        dr["InvDate"] = this.InvDate;
                        dr["DepartureDate"] = this.DepartureDate;
                        dr["RecDate"] = this.RecDate;
                        dr["RecTime"] = this.RecTime;
                        dr["SignDate"] = this.SignDate;
                        dr["SignTime"] = this.SignTime;

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
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where RefNO='{0}'", oid)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}