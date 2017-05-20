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
        public DateTime? InvDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? RecDate { get; set; }
        public DateTime? RecTime { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? SignTime { get; set; }
        public int? DocStatus { get; set; }
        public int? AvgExp2Free { get; set; }
        public int? ResponseStatus { get; set; }
        public int? IsCancel { get; set; }
        public int? InvoiceType { get; set; }
        public int? IsNotAutoCal { get; set; }
        public Double? InvCurRate { get; set; }
        public Double? TotalNetW { get; set; }
        public Double? TotalInvoice { get; set; }
        public Double? TotalInvTHB { get; set; }
        public Double? CurExpOtherRate { get; set; }
        public Double? TotalExpOther { get; set; }
        public Double? TotalExpOtherTHB { get; set; }
        public Double? CurExplandingRate { get; set; }
        public Double? TotalExplanding { get; set; }
        public Double? TotalExplandingTHB { get; set; }
        public Double? CurExpInlandRate { get; set; }
        public Double? TotalExpInland { get; set; }
        public Double? TotalExpInlandTHB { get; set; }
        public Double? CurExpPackRate { get; set; }
        public Double? TotalExpPack { get; set; }
        public Double? TotalExpPackTHB { get; set; }
        public Double? CurExpFwdRate { get; set; }
        public Double? TotalExpForward { get; set; }
        public Double? TotalExpForwardTHB { get; set; }
        public Double? CurExpShpRate { get; set; }
        public Double? TotalExpShipping { get; set; }
        public Double? TotalExpShippingTHB { get; set; }
        public Double? CurExpFrgRate { get; set; }
        public Double? TotalExpFreight { get; set; }
        public Double? TotalExpFreightTHB { get; set; }
        public Double? CurExpInsRate { get; set; }
        public Double? TotalExpInsurance { get; set; }
        public Double? TotalExpInsuranceTHB { get; set; }
        public Double? TotalIncreasedPrice { get; set; }
        public Double? TotalIncreasedPriceTHB { get; set; }
        public string DeclareNo { get; set; }
        public string GetDecNo()
        {
            string val = "";
            using (Connection cn = new Connection("cdp1")){
                using (var rd = cn.getDataReader(String.Format("select * from Declare_header where BranchCode='{0}' and RefNO='{1}' and docstatus<9", this.BranchCode, this.RefNO)))
                {
                    if (rd.Read())
                    {
                        val = rd["DecNO"].ToString();
                    }
                }
            }
            return val;
        }
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

                        data.BranchCode = "" + rd.GetValue(rd.GetOrdinal("BranchCode"));
                        data.RefNO = "" + rd.GetValue(rd.GetOrdinal("RefNO"));
                        data.InvNO = "" + rd.GetValue(rd.GetOrdinal("InvNO"));
                        data.TrackingNO = "" + rd.GetValue(rd.GetOrdinal("TrackingNO"));
                        data.CmpCode = "" + rd.GetValue(rd.GetOrdinal("CmpCode"));
                        data.CmpTaxNumber = "" + rd.GetValue(rd.GetOrdinal("CmpTaxNumber"));
                        data.CmpBranch = "" + rd.GetValue(rd.GetOrdinal("CmpBranch"));
                        data.SellerStatus = "" + rd.GetValue(rd.GetOrdinal("SellerStatus"));
                        data.ConsigneeStatus = "" + rd.GetValue(rd.GetOrdinal("ConsigneeStatus"));
                        data.CommercialLevel = "" + rd.GetValue(rd.GetOrdinal("CommercialLevel"));
                        data.BuyerCode = "" + rd.GetValue(rd.GetOrdinal("BuyerCode"));
                        data.BuyerName = "" + rd.GetValue(rd.GetOrdinal("BuyerName"));
                        data.Street = "" + rd.GetValue(rd.GetOrdinal("Street"));
                        data.District = "" + rd.GetValue(rd.GetOrdinal("District"));
                        data.Subprovince = "" + rd.GetValue(rd.GetOrdinal("Subprovince"));
                        data.Province = "" + rd.GetValue(rd.GetOrdinal("Province"));
                        data.Postcode = "" + rd.GetValue(rd.GetOrdinal("Postcode"));
                        data.EmailAddr = "" + rd.GetValue(rd.GetOrdinal("EmailAddr"));
                        data.ConsigneeAddr = "" + rd.GetValue(rd.GetOrdinal("ConsigneeAddr"));
                        data.PurchaseCountry = "" + rd.GetValue(rd.GetOrdinal("PurchaseCountry"));
                        data.NotifyPartyCode = "" + rd.GetValue(rd.GetOrdinal("NotifyPartyCode"));
                        data.NotifyPartyName = "" + rd.GetValue(rd.GetOrdinal("NotifyPartyName"));
                        data.NotifyPartyAddr = "" + rd.GetValue(rd.GetOrdinal("NotifyPartyAddr"));
                        data.NotifyPartyEMail = "" + rd.GetValue(rd.GetOrdinal("NotifyPartyEMail"));
                        data.CurExpInland = "" + rd.GetValue(rd.GetOrdinal("CurExpInland"));
                        data.CurExpPack = "" + rd.GetValue(rd.GetOrdinal("CurExpPack"));
                        data.CurExpFwd = "" + rd.GetValue(rd.GetOrdinal("CurExpFwd"));
                        data.CurExpShp = "" + rd.GetValue(rd.GetOrdinal("CurExpShp"));
                        data.CurExpFrg = "" + rd.GetValue(rd.GetOrdinal("CurExpFrg"));
                        data.CurExpIns = "" + rd.GetValue(rd.GetOrdinal("CurExpIns"));
                        data.AvgExpOther = "" + rd.GetValue(rd.GetOrdinal("AvgExpOther"));
                        data.AvgExpInland = "" + rd.GetValue(rd.GetOrdinal("AvgExpInland"));
                        data.AvgExplanding = "" + rd.GetValue(rd.GetOrdinal("AvgExplanding"));
                        data.AvgExpFwd = "" + rd.GetValue(rd.GetOrdinal("AvgExpFwd"));
                        data.DestinationCountry = "" + rd.GetValue(rd.GetOrdinal("DestinationCountry"));
                        data.IncoTerms = "" + rd.GetValue(rd.GetOrdinal("IncoTerms"));
                        data.InvCurrency = "" + rd.GetValue(rd.GetOrdinal("InvCurrency"));
                        data.NetWUnit = "" + rd.GetValue(rd.GetOrdinal("NetWUnit"));
                        data.CurExpOther = "" + rd.GetValue(rd.GetOrdinal("CurExpOther"));
                        data.CurExplanding = "" + rd.GetValue(rd.GetOrdinal("CurExplanding"));
                        data.AvgExpPack = "" + rd.GetValue(rd.GetOrdinal("AvgExpPack"));
                        data.AvgExpShp = "" + rd.GetValue(rd.GetOrdinal("AvgExpShp"));
                        data.AvgExpFrg = "" + rd.GetValue(rd.GetOrdinal("AvgExpFrg"));
                        data.AvgExpIns = "" + rd.GetValue(rd.GetOrdinal("AvgExpIns"));
                        data.RecByUser = "" + rd.GetValue(rd.GetOrdinal("RecByUser"));
                        data.UIDTransmit = "" + rd.GetValue(rd.GetOrdinal("UIDTransmit"));
                        data.SignBy = "" + rd.GetValue(rd.GetOrdinal("SignBy"));
                        data.FileToSend = "" + rd.GetValue(rd.GetOrdinal("FileToSend"));
                        data.PoNo = "" + rd.GetValue(rd.GetOrdinal("PoNo"));
                        data.PaymentTerm = "" + rd.GetValue(rd.GetOrdinal("PaymentTerm"));
                        data.OtherChargeDesc = "" + rd.GetValue(rd.GetOrdinal("OtherChargeDesc"));
                        data.SelfCertRemark = "" + rd.GetValue(rd.GetOrdinal("SelfCertRemark"));
                        data.AEOsReferNo = "" + rd.GetValue(rd.GetOrdinal("AEOsReferNo"));
                        data.NotifyStreet = "" + rd.GetValue(rd.GetOrdinal("NotifyStreet"));
                        data.NotifyDistrict = "" + rd.GetValue(rd.GetOrdinal("NotifyDistrict"));
                        data.NotifySubProvince = "" + rd.GetValue(rd.GetOrdinal("NotifySubProvince"));
                        data.NotifyProvince = "" + rd.GetValue(rd.GetOrdinal("NotifyProvince"));
                        data.NotifyPostCode = "" + rd.GetValue(rd.GetOrdinal("NotifyPostCode"));

                        data.InvDate = rd.GetDateTime("InvDate");
                        try { data.DepartureDate = rd.GetDateTime("DepartureDate"); } catch { continue; }
                        data.RecDate = rd.GetDateTime("RecDate");
                        data.RecTime = rd.GetDateTime("RecTime");
                        try { data.SignDate = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("SignDate"))); } catch { continue; }
                        try { data.SignTime = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("SignTime"))); } catch { continue; }

                        data.DocStatus = rd.GetInt32("DocStatus");
                        data.AvgExp2Free = rd.GetInt32("AvgExp2Free");
                        data.ResponseStatus = rd.GetInt32("ResponseStatus");
                        data.IsCancel = rd.GetInt32("IsCancel");
                        data.InvoiceType = rd.GetInt32("InvoiceType");
                        data.IsNotAutoCal =Convert.ToInt32("0" + rd.GetValue(rd.GetOrdinal("IsNotAutoCal")));

                        data.InvCurRate = rd.GetDouble("InvCurRate");
                        data.TotalNetW = rd.GetDouble("TotalNetW");
                        data.TotalInvoice = rd.GetDouble("TotalInvoice");
                        data.TotalInvTHB = rd.GetDouble("TotalInvTHB");
                        data.CurExpOtherRate = rd.GetDouble("CurExpOtherRate");
                        data.TotalExpOther = rd.GetDouble("TotalExpOther");
                        data.TotalExpOtherTHB = rd.GetDouble("TotalExpOtherTHB");
                        data.CurExplandingRate = rd.GetDouble("CurExplandingRate");
                        data.TotalExplanding = rd.GetDouble("TotalExplanding");
                        data.TotalExplandingTHB = rd.GetDouble("TotalExplandingTHB");
                        data.CurExpInlandRate = rd.GetDouble("CurExpInlandRate");
                        data.TotalExpInland = rd.GetDouble("TotalExpInland");
                        data.TotalExpInlandTHB = rd.GetDouble("TotalExpInlandTHB");
                        data.CurExpPackRate = rd.GetDouble("CurExpPackRate");
                        data.TotalExpPack = rd.GetDouble("TotalExpPack");
                        data.TotalExpPackTHB = rd.GetDouble("TotalExpPackTHB");
                        data.CurExpFwdRate = rd.GetDouble("CurExpFwdRate");
                        data.TotalExpForward = rd.GetDouble("TotalExpForward");
                        data.TotalExpForwardTHB = rd.GetDouble("TotalExpForwardTHB");
                        data.CurExpShpRate = rd.GetDouble("CurExpShpRate");
                        data.TotalExpShipping = rd.GetDouble("TotalExpShipping");
                        data.TotalExpShippingTHB = rd.GetDouble("TotalExpShippingTHB");
                        data.CurExpFrgRate = rd.GetDouble("CurExpFrgRate");
                        data.TotalExpFreight = rd.GetDouble("TotalExpFreight");
                        data.TotalExpFreightTHB = rd.GetDouble("TotalExpFreightTHB");
                        data.CurExpInsRate = rd.GetDouble("CurExpInsRate");
                        data.TotalExpInsurance = rd.GetDouble("TotalExpInsurance");
                        data.TotalExpInsuranceTHB = rd.GetDouble("TotalExpInsuranceTHB");
                        data.TotalIncreasedPrice = rd.GetDouble("TotalIncreasedPrice");
                        data.TotalIncreasedPriceTHB = rd.GetDouble("TotalIncreasedPriceTHB");
                        data.DeclareNo = data.GetDecNo();
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
					string sql = string.Format("select * from " + tbname + " where BranchCode='{0}' and RefNo='{1}'", cn.branchcode,this.RefNO);
					using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
					{
						var tb = dt.data;
						var dr = tb.NewRow();
						if (tb.Rows.Count > 0)
						{
							dr = tb.Rows[0];
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

		public string delete(string ReFNo)
		{
			string msg = "Delete Success";
			using (Connection cn = new Connection("cdp1"))
			{
				if (cn.ExecuteSQL(string.Format("update " + tbname + " set DocStatus='99' where BranchCode='{0}' and RefNo='{1}'", cn.branchcode,this.RefNO)) == false)
				{
					msg = cn.Message;
				}
			}
			return msg;
		}
	}
}