using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
	public class Declare_Header
	{
		public const string tbname = "Declare_Header";
		public string BranchCode { get; set; }
		public string RefNO { get; set; }
        public string DecNO { get; set; }
        
        public string RefJobNO { get; set; }
        public DateTime DepDate { get; set; }
        public string BrokerTaxNo { get; set; }
        public string BrokerBranch { get; set; }
        public string BrokerName { get; set; }
        public string BrokerAddr { get; set; }
        public string CCCard { get; set; }
        public string CCName { get; set; }
        public string ManagerNo { get; set; }
        public string ManagerName { get; set; }
        public string VesselName { get; set; }
        public string VoyNo { get; set; }
        public string TranportMode { get; set; }
        public string ReleasePort { get; set; }
        public string LoadedPort { get; set; }
        public string DestCountry { get; set; }
        public Double TotalPackageAmt { get; set; }
        public string TotalPackageUnit { get; set; }
        public Double TotalGrossW { get; set; }
        public string WeightUnit { get; set; }
        public string GWeightUnit { get; set; }
        public string BankCode { get; set; }
        public string BankBranch { get; set; }
        public string BankAccNo { get; set; }
        public Double TotalPaymentAmt { get; set; }
        public string CurCode { get; set; }
        public Double CurRate { get; set; }
        public Double FOBValueF { get; set; }
        public Double FOBValueB { get; set; }
        public string PaymentMethod { get; set; }
        public string DepositReason { get; set; }
        public Double TotalTax { get; set; }
        public Double TotalDeposit { get; set; }
        public DateTime SendDate { get; set; }
        public string SendTime { get; set; }
        public string SendStatus { get; set; }
        public DateTime AcceptDate { get; set; }
        public string AcceptTime { get; set; }
        public string ResponseMsg { get; set; }
        public string CancelReson { get; set; }
        public DateTime CancelDate { get; set; }
        public string CancelTime { get; set; }
        public string CancelProve { get; set; }
        public DateTime CancelProveDate { get; set; }
        public string CancelProveTime { get; set; }
        public string PayProve { get; set; }
        public DateTime PayProveDate { get; set; }
        public string PayProveTime { get; set; }
        public int IsIncompleted { get; set; }
        public DateTime UDateRelease { get; set; }
        public DateTime UDateComp { get; set; }
        public DateTime UDateReImport { get; set; }
        public DateTime UDateBorn { get; set; }
        public DateTime UDate19BIS { get; set; }
        public DateTime UDateReExport { get; set; }
        public string InvNOList { get; set; }
        public Double AssessValue { get; set; }
        public string UNDGNumber { get; set; }
        public string EstablishNo { get; set; }
        public string FactoryNo { get; set; }
        public string UserTransmit { get; set; }
        public DateTime TransmitDate { get; set; }
        public string TransmitTime { get; set; }
        public int DeclareType { get; set; }
        public string DocType { get; set; }
        public string PackingType { get; set; }
        public string MasterAWB { get; set; }
        public string HouseAWB { get; set; }
        public string RGSCode { get; set; }
        public string CustomBankCode { get; set; }
        public int isAssessment { get; set; }
        public int IsInspect { get; set; }
        public string ApprovalPort { get; set; }
        public string ApprovalNo { get; set; }
        public string ShippingMark { get; set; }
        public string DeclareFormType { get; set; }
        public int Revised { get; set; }
        public string Status02 { get; set; }
        public string Status03 { get; set; }
        public string Status04 { get; set; }
        public string RemarkText { get; set; }
        public string Remark1 { get; set; }
        public Double TotalPackageAddAmt { get; set; }
        public string TotalPackageAddUnit { get; set; }
        public string TotalPackageDesc { get; set; }
        public int IsNotAutoCal { get; set; }
        public string OutsideReleasePort { get; set; }
        public string GuaranteeMethod { get; set; }
        public string GuaranteeType { get; set; }
        public string GuaranteeBankCode { get; set; }
        public string GuaranteeBankBranch { get; set; }
        public string GuaranteeBankAccNo { get; set; }
        public string ExportTaxIncentivesID { get; set; }
        public string TradingPartnerTaxNo { get; set; }
        public string TradingPartnerTaxBranch { get; set; }
        public string SubBrokerTaxNo { get; set; }
        public Double DeferredDutyTaxFee { get; set; }
        public string TaxCardBankCode { get; set; }
        public string TaxCardBankBranchCode { get; set; }
        public string TaxCardAccNo { get; set; }
        public Double TotalTaxCardAmt { get; set; }
        public int IsNotAutoCalGW { get; set; }
        public Double TotalLocal { get; set; }
        public string Remark2 { get; set; }
        public string XMLCustRevision { get; set; }
        public string UpTrack04Status { get; set; }
        public DateTime ActualReleaseDate { get; set; }
        public string ConfirmReleaseBy { get; set; }
        public DateTime ConfirmReleaseDate { get; set; }         

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

		public List<Declare_Header> get()
		{
			var rows = new List<Declare_Header>();
			using (Connection cn = new Connection("cdp1"))
			{
				using (var rd = cn.getDataReader("select * from " + tbname))
				{
					while (rd.Read())
					{
                        var data = new Declare_Header();
                        
                        try { data.BranchCode = rd.GetString("BranchCode"); } catch { data.BranchCode = ""; }
                        try { data.RefNO = rd.GetString("RefNO"); } catch { data.RefNO = ""; }
                        try { data.InvNOList = rd.GetString("InvNO"); } catch { data.InvNOList = ""; }
                        try { data.DecNO = rd.GetString("DecNO"); } catch { data.DecNO = ""; }
                        try { data.TrackingNO = rd.GetString("TrackingNO"); } catch { data.TrackingNO = ""; }
                        try { data.CmpCode = rd.GetString("CmpCode"); } catch { data.CmpCode = ""; }
                        try { data.CmpTaxNumber = rd.GetString("CmpTaxNumber"); } catch { data.CmpTaxNumber = ""; }
                        try { data.CmpBranch = rd.GetString("CmpBranch"); } catch { data.CmpBranch = ""; }
                        try { data.SellerStatus = rd.GetString("SellerStatus"); } catch { data.SellerStatus = ""; }
                        try { data.ConsigneeStatus = rd.GetString("ConsigneeStatus"); } catch { data.ConsigneeStatus = ""; }
                        try { data.CommercialLevel = rd.GetString("CommercialLevel"); } catch { data.CommercialLevel = ""; }
                        try { data.BuyerCode = rd.GetString("BuyerCode"); } catch { data.BuyerCode = ""; }
                        try { data.BuyerName = rd.GetString("BuyerName"); } catch { data.BuyerName = ""; }
                        try { data.Street = rd.GetString("Street"); } catch { data.Street = ""; }
                        try { data.District = rd.GetString("District"); } catch { data.District = ""; }
                        try { data.Subprovince = rd.GetString("Subprovince"); } catch { data.Subprovince = ""; }
                        try { data.Province = rd.GetString("Province"); } catch { data.Province = ""; }
                        try { data.Postcode = rd.GetString("Postcode"); } catch { data.Postcode = ""; }
                        try { data.EmailAddr = rd.GetString("EmailAddr"); } catch { data.EmailAddr = ""; }
                        try { data.ConsigneeAddr = rd.GetString("ConsigneeAddr"); } catch { data.ConsigneeAddr = ""; }
                        try { data.PurchaseCountry = rd.GetString("PurchaseCountry"); } catch { data.PurchaseCountry = ""; }
                        try { data.NotifyPartyCode = rd.GetString("NotifyPartyCode"); } catch { data.NotifyPartyCode = ""; }
                        try { data.NotifyPartyName = rd.GetString("NotifyPartyName"); } catch { data.NotifyPartyName = ""; }
                        try { data.NotifyPartyAddr = rd.GetString("NotifyPartyAddr"); } catch { data.NotifyPartyAddr = ""; }
                        try { data.NotifyPartyEMail = rd.GetString("NotifyPartyEMail"); } catch { data.NotifyPartyEMail = ""; }
                        try { data.CurExpInland = rd.GetString("CurExpInland"); } catch { data.CurExpInland = ""; }
                        try { data.CurExpPack = rd.GetString("CurExpPack"); } catch { data.CurExpPack = ""; }
                        try { data.CurExpFwd = rd.GetString("CurExpFwd"); } catch { data.CurExpFwd = ""; }
                        try { data.CurExpShp = rd.GetString("CurExpShp"); } catch { data.CurExpShp = ""; }
                        try { data.CurExpFrg = rd.GetString("CurExpFrg"); } catch { data.CurExpFrg = ""; }
                        try { data.CurExpIns = rd.GetString("CurExpIns"); } catch { data.CurExpIns = ""; }
                        try { data.AvgExpOther = rd.GetString("AvgExpOther"); } catch { data.AvgExpOther = ""; }
                        try { data.AvgExpInland = rd.GetString("AvgExpInland"); } catch { data.AvgExpInland = ""; }
                        try { data.AvgExplanding = rd.GetString("AvgExplanding"); } catch { data.AvgExplanding = ""; }
                        try { data.AvgExpFwd = rd.GetString("AvgExpFwd"); } catch { data.AvgExpFwd = ""; }
                        try { data.DestinationCountry = rd.GetString("DestinationCountry"); } catch { data.DestinationCountry = ""; }
                        try { data.IncoTerms = rd.GetString("IncoTerms"); } catch { data.IncoTerms = ""; }
                        try { data.InvCurrency = rd.GetString("InvCurrency"); } catch { data.InvCurrency = ""; }
                        try { data.NetWUnit = rd.GetString("NetWUnit"); } catch { data.NetWUnit = ""; }
                        try { data.CurExpOther = rd.GetString("CurExpOther"); } catch { data.CurExpOther = ""; }
                        try { data.CurExplanding = rd.GetString("CurExplanding"); } catch { data.CurExplanding = ""; }
                        try { data.AvgExpPack = rd.GetString("AvgExpPack"); } catch { data.AvgExpPack = ""; }
                        try { data.AvgExpShp = rd.GetString("AvgExpShp"); } catch { data.AvgExpShp = ""; }
                        try { data.AvgExpFrg = rd.GetString("AvgExpFrg"); } catch { data.AvgExpFrg = ""; }
                        try { data.AvgExpIns = rd.GetString("AvgExpIns"); } catch { data.AvgExpIns = ""; }
                        try { data.RecByUser = rd.GetString("RecByUser"); } catch { data.RecByUser = ""; }
                        try { data.UIDTransmit = rd.GetString("UIDTransmit"); } catch { data.UIDTransmit = ""; }
                        try { data.SignBy = rd.GetString("SignBy"); } catch { data.SignBy = ""; }
                        try { data.FileToSend = rd.GetString("FileToSend"); } catch { data.FileToSend = ""; }
                        try { data.PoNo = rd.GetString("PoNo"); } catch { data.PoNo = ""; }
                        try { data.PaymentTerm = rd.GetString("PaymentTerm"); } catch { data.PaymentTerm = ""; }
                        try { data.OtherChargeDesc = rd.GetString("OtherChargeDesc"); } catch { data.OtherChargeDesc = ""; }
                        try { data.SelfCertRemark = rd.GetString("SelfCertRemark"); } catch { data.SelfCertRemark = ""; }
                        try { data.AEOsReferNo = rd.GetString("AEOsReferNo"); } catch { data.AEOsReferNo = ""; }
                        try { data.NotifyStreet = rd.GetString("NotifyStreet"); } catch { data.NotifyStreet = ""; }
                        try { data.NotifyDistrict = rd.GetString("NotifyDistrict"); } catch { data.NotifyDistrict = ""; }
                        try { data.NotifySubProvince = rd.GetString("NotifySubProvince"); } catch { data.NotifySubProvince = ""; }
                        try { data.NotifyProvince = rd.GetString("NotifyProvince"); } catch { data.NotifyProvince = ""; }
                        try { data.NotifyPostCode = rd.GetString("NotifyPostCode"); } catch { data.NotifyPostCode = ""; }

                        try { data.InvDate = rd.GetDateTime("InvDate"); } catch {}
                        try { data.DepartureDate = rd.GetDateTime("DepartureDate"); } catch {}
                        try { data.RecDate = rd.GetDateTime("RecDate"); } catch {}
                        try { data.RecTime = rd.GetDateTime("RecTime"); } catch {}
                        try { data.SignDate = rd.GetDateTime("SignDate"); } catch {}
                        try { data.SignTime = rd.GetDateTime("SignTime"); } catch {}

                        try { data.DocStatus = rd.GetInt32("DocStatus"); } catch {}
                        try { data.AvgExp2Free = rd.GetInt32("AvgExp2Free"); } catch {}
                        try { data.ResponseStatus = rd.GetInt32("ResponseStatus"); } catch {}
                        try { data.IsCancel = rd.GetInt32("IsCancel"); } catch {}
                        try { data.InvoiceType = rd.GetInt32("InvoiceType"); } catch {}
                        try { data.IsNotAutoCal = rd.GetInt32("IsNotAutoCal"); } catch {}

                        try { data.InvCurRate = rd.GetDouble("InvCurRate"); } catch {}
                        try { data.TotalNetW = rd.GetDouble("TotalNetW"); } catch {}
                        try { data.TotalInvoice = rd.GetDouble("TotalInvoice"); } catch {}
                        try { data.TotalInvTHB = rd.GetDouble("TotalInvTHB"); } catch {}
                        try { data.CurExpOtherRate = rd.GetDouble("CurExpOtherRate"); } catch {}
                        try { data.TotalExpOther = rd.GetDouble("TotalExpOther"); } catch {}
                        try { data.TotalExpOtherTHB = rd.GetDouble("TotalExpOtherTHB"); } catch {}
                        try { data.CurExplandingRate = rd.GetDouble("CurExplandingRate"); } catch {}
                        try { data.TotalExplanding = rd.GetDouble("TotalExplanding"); } catch {}
                        try { data.TotalExplandingTHB = rd.GetDouble("TotalExplandingTHB"); } catch {}
                        try { data.CurExpInlandRate = rd.GetDouble("CurExpInlandRate"); } catch {}
                        try { data.TotalExpInland = rd.GetDouble("TotalExpInland"); } catch {}
                        try { data.TotalExpInlandTHB = rd.GetDouble("TotalExpInlandTHB"); } catch {}
                        try { data.CurExpPackRate = rd.GetDouble("CurExpPackRate"); } catch {}
                        try { data.TotalExpPack = rd.GetDouble("TotalExpPack"); } catch {}
                        try { data.TotalExpPackTHB = rd.GetDouble("TotalExpPackTHB"); } catch {}
                        try { data.CurExpFwdRate = rd.GetDouble("CurExpFwdRate"); } catch {}
                        try { data.TotalExpForward = rd.GetDouble("TotalExpForward"); } catch {}
                        try { data.TotalExpForwardTHB = rd.GetDouble("TotalExpForwardTHB"); } catch {}
                        try { data.CurExpShpRate = rd.GetDouble("CurExpShpRate"); } catch {}
                        try { data.TotalExpShipping = rd.GetDouble("TotalExpShipping"); } catch {}
                        try { data.TotalExpShippingTHB = rd.GetDouble("TotalExpShippingTHB"); } catch {}
                        try { data.CurExpFrgRate = rd.GetDouble("CurExpFrgRate"); } catch {}
                        try { data.TotalExpFreight = rd.GetDouble("TotalExpFreight"); } catch {}
                        try { data.TotalExpFreightTHB = rd.GetDouble("TotalExpFreightTHB"); } catch {}
                        try { data.CurExpInsRate = rd.GetDouble("CurExpInsRate"); } catch {}
                        try { data.TotalExpInsurance = rd.GetDouble("TotalExpInsurance"); } catch {}
                        try { data.TotalExpInsuranceTHB = rd.GetDouble("TotalExpInsuranceTHB"); } catch {}
                        try { data.TotalIncreasedPrice = rd.GetDouble("TotalIncreasedPrice"); } catch {}
                        try { data.TotalIncreasedPriceTHB = rd.GetDouble("TotalIncreasedPriceTHB"); } catch {}
                        
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
					string sql = string.Format("select * from " + tbname + " where BranchCode='{0}' and RefNO='{1}'", this.BranchCode,this.RefNO);
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
						dr["InvNO"] = this.InvNOList;
                        dr["DecNO"] = this.DecNO;
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
				if (cn.ExecuteSQL(string.Format("delete from " + tbname + " where oid={0}", oid)) == false)
				{
					msg = cn.Message;
				}
			}
			return msg;
		}
	}
}