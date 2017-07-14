using System.Collections.Generic;
using System;
using JobMvc.DataLayer;
namespace JobMvc
{
    public class DecInvoice_Detail
    {
        public const string tbname = "DecInvoice_Detail";
        public string BranchCode { get; set; }
        public int ItemNO { get; set; }
        public int IsFreeOfChage { get; set; }
        public int ProductYear { get; set; }
        public int IncreasedPrice { get; set; }
        public int IncreasedPriceTHB { get; set; }
        public int DeclareLineNo { get; set; }
        public Double NetWeight { get; set; }
        public Double GrossWeight { get; set; }
        public Double TariffQty { get; set; }
        public Double ConstantValue { get; set; }
        public Double SalesPackQty { get; set; }
        public Double SalesPrice { get; set; }
        public Double SalesTotalPrice { get; set; }
        public Double SalesNetPriceTHB { get; set; }
        public Double SalesFOBPriceTHB { get; set; }
        public Double PackAmount { get; set; }
        public Double ExpShipping { get; set; }
        public string RefNO { get; set; }
        public string InvNO { get; set; }
        public string GroupCode { get; set; }
        public string PdtCode { get; set; }
        public string PdtSubCode { get; set; }
        public string BrandName { get; set; }
        public string ShippingMark { get; set; }
        public string PdtDescription { get; set; }
        public string PdtDescriptionEN { get; set; }
        public string DRemark { get; set; }
        public string DPurchaseCountry { get; set; }
        public string DOriginCountry { get; set; }
        public string ProductAttribute1 { get; set; }
        public string ProductAttribute2 { get; set; }
        public string SeperateItem { get; set; }
        public string TariffCode { get; set; }
        public string TariffSeq { get; set; }
        public string StatCode { get; set; }
        public string RTCProductCode { get; set; }
        public string WeightUnit { get; set; }
        public string TariffUnit { get; set; }
        public string SalesPackUnit { get; set; }
        public string PackUnit { get; set; }
        public string FormulaNo { get; set; }
        public string BIS19TransferNo { get; set; }
        public string BOILicenseNo { get; set; }
        public string BondFormulaNo { get; set; }
        public string PermitNo { get; set; }
        public string DutyCalcBy { get; set; }
        public string ItmOther1 { get; set; }
        public string ItmOther2 { get; set; }
        public string ItmOther3 { get; set; }
        public string ItmOther4 { get; set; }
        public string ItmOther5 { get; set; }
        public string ItmOther6 { get; set; }
        public string ItmOther7 { get; set; }
        public string ItmOther8 { get; set; }
        public string ItmOther9 { get; set; }
        public string ItmOther10 { get; set; }
        public string SalesPackAddUnit { get; set; }
        public string PackAddUnit { get; set; }
        public string ModelVer { get; set; }
        public string ModelCmpTaxNo { get; set; }
        public string Royalty { get; set; }
        public string RoyaltyDetail { get; set; }
        public Double ExpFreight { get; set; }
        public Double ExpInsurance { get; set; }
        public Double ExpForward { get; set; }
        public Double ExpInLand { get; set; }
        public Double ExpLanding { get; set; }
        public Double ExpPacking { get; set; }
        public Double ExpOther { get; set; }
        public Double ExpShippingTHB { get; set; }
        public Double ExpFreightTHB { get; set; }
        public Double ExpInsuranceTHB { get; set; }
        public Double ExpForwardTHB { get; set; }
        public Double ExpInLandTHB { get; set; }
        public Double ExpLandingTHB { get; set; }
        public Double ExpPackingTHB { get; set; }
        public Double ExpOtherTHB { get; set; }
        public Double DutyPRatePay { get; set; }
        public Double DutySRatePay { get; set; }
        public Double DutyDeduct { get; set; }
        public Double WeightPerUnit { get; set; }
        public Double WeightPerPack { get; set; }
        public Double SalesPackAddQty { get; set; }
        public Double PackAddAmount { get; set; }

        public List<DecInvoice_Detail> get(string wherec = "")
        {
            var rows = new List<DecInvoice_Detail>();
            using (Connection cn = new Connection("cdp1"))
            {
                using (var rd = cn.getDataReader("select * from " + tbname + wherec))
                {
                    while (rd.Read())
                    {
                        var data = new DecInvoice_Detail();

                        try { data.BranchCode = rd.GetString("BranchCode"); } catch { }
                        try { data.RefNO = rd.GetString("RefNO"); } catch { }
                        try { data.InvNO = rd.GetString("InvNO"); } catch { }
                        try { data.ItemNO = rd.GetInt32("ItemNO"); } catch { }
                        try { data.IsFreeOfChage = rd.GetInt32("IsFreeOfChage"); } catch { }
                        try { data.ProductYear = rd.GetInt32("ProductYear"); } catch { }
                        try { data.IncreasedPrice = rd.GetInt32("IncreasedPrice"); } catch { }
                        try { data.IncreasedPriceTHB = rd.GetInt32("IncreasedPriceTHB"); } catch { }
                        try { data.DeclareLineNo = rd.GetInt32("DeclareLineNo"); } catch { }
                        try { data.NetWeight = rd.GetDouble("NetWeight"); } catch { }
                        try { data.GrossWeight = rd.GetDouble("GrossWeight"); } catch { }
                        try { data.TariffQty = rd.GetDouble("TariffQty"); } catch { }
                        try { data.ConstantValue = rd.GetDouble("ConstantValue"); } catch { }
                        try { data.SalesPackQty = rd.GetDouble("SalesPackQty"); } catch { }
                        try { data.SalesPrice = rd.GetDouble("SalesPrice"); } catch { }
                        try { data.SalesTotalPrice = rd.GetDouble("SalesTotalPrice"); } catch { }
                        try { data.SalesNetPriceTHB = rd.GetDouble("SalesNetPriceTHB"); } catch { }
                        try { data.SalesFOBPriceTHB = rd.GetDouble("SalesFOBPriceTHB"); } catch { }
                        try { data.PackAmount = rd.GetDouble("PackAmount"); } catch { }
                        try { data.ExpShipping = rd.GetDouble("ExpShipping"); } catch { }
                        try { data.GroupCode = rd.GetString("GroupCode"); } catch { }
                        try { data.PdtCode = rd.GetString("PdtCode"); } catch { }
                        try { data.PdtSubCode = rd.GetString("PdtSubCode"); } catch { }
                        try { data.BrandName = rd.GetString("BrandName"); } catch { }
                        try { data.ShippingMark = rd.GetString("ShippingMark"); } catch { }
                        try { data.PdtDescription = rd.GetString("PdtDescription"); } catch { }
                        try { data.PdtDescriptionEN = rd.GetString("PdtDescriptionEN"); } catch { }
                        try { data.DRemark = rd.GetString("DRemark"); } catch { }
                        try { data.DPurchaseCountry = rd.GetString("DPurchaseCountry"); } catch { }
                        try { data.DOriginCountry = rd.GetString("DOriginCountry"); } catch { }
                        try { data.ProductAttribute1 = rd.GetString("ProductAttribute1"); } catch { }
                        try { data.ProductAttribute2 = rd.GetString("ProductAttribute2"); } catch { }
                        try { data.SeperateItem = rd.GetString("SeperateItem"); } catch { }
                        try { data.TariffCode = rd.GetString("TariffCode"); } catch { }
                        try { data.TariffSeq = rd.GetString("TariffSeq"); } catch { }
                        try { data.StatCode = rd.GetString("StatCode"); } catch { }
                        try { data.RTCProductCode = rd.GetString("RTCProductCode"); } catch { }
                        try { data.WeightUnit = rd.GetString("WeightUnit"); } catch { }
                        try { data.TariffUnit = rd.GetString("TariffUnit"); } catch { }
                        try { data.SalesPackUnit = rd.GetString("SalesPackUnit"); } catch { }
                        try { data.PackUnit = rd.GetString("PackUnit"); } catch { }
                        try { data.ItmOther1 = rd.GetString("ItmOther1"); } catch { }
                        try { data.ItmOther2 = rd.GetString("ItmOther2"); } catch { }
                        try { data.ItmOther3 = rd.GetString("ItmOther3"); } catch { }
                        try { data.ItmOther4 = rd.GetString("ItmOther4"); } catch { }
                        try { data.ItmOther5 = rd.GetString("ItmOther5"); } catch { }
                        try { data.ItmOther6 = rd.GetString("ItmOther6"); } catch { }
                        try { data.ItmOther7 = rd.GetString("ItmOther7"); } catch { }
                        try { data.ItmOther8 = rd.GetString("ItmOther8"); } catch { }
                        try { data.ItmOther9 = rd.GetString("ItmOther9"); } catch { }
                        try { data.ItmOther10 = rd.GetString("ItmOther10"); } catch { }
                        try { data.FormulaNo = rd.GetString("FormulaNo"); } catch { }
                        try { data.BIS19TransferNo = rd.GetString("BIS19TransferNo"); } catch { }
                        try { data.BOILicenseNo = rd.GetString("BOILicenseNo"); } catch { }
                        try { data.BondFormulaNo = rd.GetString("BondFormulaNo"); } catch { }
                        try { data.PermitNo = rd.GetString("PermitNo"); } catch { }
                        try { data.DutyCalcBy = rd.GetString("DutyCalcBy"); } catch { }
                        try { data.SalesPackAddUnit = rd.GetString("SalesPackAddUnit"); } catch { }
                        try { data.PackAddUnit = rd.GetString("PackAddUnit"); } catch { }
                        try { data.ModelVer = rd.GetString("ModelVer"); } catch { }
                        try { data.ModelCmpTaxNo = rd.GetString("ModelCmpTaxNo"); } catch { }
                        try { data.Royalty = rd.GetString("Royalty"); } catch { }
                        try { data.RoyaltyDetail = rd.GetString("RoyaltyDetail"); } catch { }
                        try { data.ExpFreight = rd.GetDouble("ExpFreight"); } catch { }
                        try { data.ExpInsurance = rd.GetDouble("ExpInsurance"); } catch { }
                        try { data.ExpForward = rd.GetDouble("ExpForward"); } catch { }
                        try { data.ExpInLand = rd.GetDouble("ExpInLand"); } catch { }
                        try { data.ExpLanding = rd.GetDouble("ExpLanding"); } catch { }
                        try { data.ExpPacking = rd.GetDouble("ExpPacking"); } catch { }
                        try { data.ExpOther = rd.GetDouble("ExpOther"); } catch { }
                        try { data.ExpShippingTHB = rd.GetDouble("ExpShippingTHB"); } catch { }
                        try { data.ExpFreightTHB = rd.GetDouble("ExpFreightTHB"); } catch { }
                        try { data.ExpInsuranceTHB = rd.GetDouble("ExpInsuranceTHB"); } catch { }
                        try { data.ExpForwardTHB = rd.GetDouble("ExpForwardTHB"); } catch { }
                        try { data.ExpInLandTHB = rd.GetDouble("ExpInLandTHB"); } catch { }
                        try { data.ExpLandingTHB = rd.GetDouble("ExpLandingTHB"); } catch { }
                        try { data.ExpPackingTHB = rd.GetDouble("ExpPackingTHB"); } catch { }
                        try { data.ExpOtherTHB = rd.GetDouble("ExpOtherTHB"); } catch { }
                        try { data.DutyPRatePay = rd.GetDouble("DutyPRatePay"); } catch { }
                        try { data.DutySRatePay = rd.GetDouble("DutySRatePay"); } catch { }
                        try { data.DutyDeduct = rd.GetDouble("DutyDeduct"); } catch { }
                        try { data.WeightPerUnit = rd.GetDouble("WeightPerUnit"); } catch { }
                        try { data.WeightPerPack = rd.GetDouble("WeightPerPack"); } catch { }
                        try { data.SalesPackAddQty = rd.GetDouble("SalesPackAddQty"); } catch { }
                        try { data.PackAddAmount = rd.GetDouble("PackAddAmount"); } catch { }

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
                    string sql = string.Format("select * from " + tbname + " where RefNO='{0}' and InvNO='{1}' and ItemNO={2}", this.RefNO, this.InvNO, this.ItemNO);
                    using (MysqlDataTable dt = new MysqlDataTable(sql, cn.getConnection()))
                    {
                        var tb = dt.data;
                        var dr = tb.NewRow();
                        if (tb.Rows.Count > 0)
                        {
                            dr = tb.Rows[0];
                        }
                        dr["BranchCode"] = this.BranchCode;
                        dr["ItemNO"] = this.ItemNO;
                        dr["IsFreeOfChage"] = this.IsFreeOfChage;
                        dr["ProductYear"] = this.ProductYear;
                        dr["NetWeight"] = this.NetWeight;
                        dr["GrossWeight"] = this.GrossWeight;
                        dr["TariffQty"] = this.TariffQty;
                        dr["ConstantValue"] = this.ConstantValue;
                        dr["SalesPackQty"] = this.SalesPackQty;
                        dr["SalesPrice"] = this.SalesPrice;
                        dr["SalesTotalPrice"] = this.SalesTotalPrice;
                        dr["SalesNetPriceTHB"] = this.SalesNetPriceTHB;
                        dr["SalesFOBPriceTHB"] = this.SalesFOBPriceTHB;
                        dr["PackAmount"] = this.PackAmount;
                        dr["ExpShipping"] = this.ExpShipping;
                        dr["RefNO"] = this.RefNO;
                        dr["InvNO"] = this.InvNO;
                        dr["GroupCode"] = this.GroupCode;
                        dr["PdtCode"] = this.PdtCode;
                        dr["PdtSubCode"] = this.PdtSubCode;
                        dr["BrandName"] = this.BrandName;
                        dr["ShippingMark"] = this.ShippingMark;
                        dr["PdtDescription"] = this.PdtDescription;
                        dr["PdtDescriptionEN"] = this.PdtDescriptionEN;
                        dr["DRemark"] = this.DRemark;
                        dr["DPurchaseCountry"] = this.DPurchaseCountry;
                        dr["DOriginCountry"] = this.DOriginCountry;
                        dr["ProductAttribute1"] = this.ProductAttribute1;
                        dr["ProductAttribute2"] = this.ProductAttribute2;
                        dr["SeperateItem"] = this.SeperateItem;
                        dr["TariffCode"] = this.TariffCode;
                        dr["TariffSeq"] = this.TariffSeq;
                        dr["StatCode"] = this.StatCode;
                        dr["RTCProductCode"] = this.RTCProductCode;
                        dr["WeightUnit"] = this.WeightUnit;
                        dr["TariffUnit"] = this.TariffUnit;
                        dr["SalesPackUnit"] = this.SalesPackUnit;
                        dr["PackUnit"] = this.PackUnit;
                        dr["ExpFreight"] = this.ExpFreight;
                        dr["ExpInsurance"] = this.ExpInsurance;
                        dr["ExpForward"] = this.ExpForward;
                        dr["ExpInLand"] = this.ExpInLand;
                        dr["ExpLanding"] = this.ExpLanding;
                        dr["ExpPacking"] = this.ExpPacking;
                        dr["ExpOther"] = this.ExpOther;
                        dr["ExpShippingTHB"] = this.ExpShippingTHB;
                        dr["ExpFreightTHB"] = this.ExpFreightTHB;
                        dr["ExpInsuranceTHB"] = this.ExpInsuranceTHB;
                        dr["ExpForwardTHB"] = this.ExpForwardTHB;
                        dr["ExpInLandTHB"] = this.ExpInLandTHB;
                        dr["ExpLandingTHB"] = this.ExpLandingTHB;
                        dr["ExpPackingTHB"] = this.ExpPackingTHB;
                        dr["ExpOtherTHB"] = this.ExpOtherTHB;
                        dr["IncreasedPrice"] = this.IncreasedPrice;
                        dr["IncreasedPriceTHB"] = this.IncreasedPriceTHB;
                        dr["DeclareLineNo"] = this.DeclareLineNo;
                        dr["FormulaNo"] = this.FormulaNo;
                        dr["BIS19TransferNo"] = this.BIS19TransferNo;
                        dr["BOILicenseNo"] = this.BOILicenseNo;
                        dr["BondFormulaNo"] = this.BondFormulaNo;
                        dr["PermitNo"] = this.PermitNo;
                        dr["DutyCalcBy"] = this.DutyCalcBy;
                        dr["DutyPRatePay"] = this.DutyPRatePay;
                        dr["DutySRatePay"] = this.DutySRatePay;
                        dr["DutyDeduct"] = this.DutyDeduct;
                        dr["WeightPerUnit"] = this.WeightPerUnit;
                        dr["WeightPerPack"] = this.WeightPerPack;
                        dr["ItmOther1"] = this.ItmOther1;
                        dr["ItmOther2"] = this.ItmOther2;
                        dr["ItmOther3"] = this.ItmOther3;
                        dr["ItmOther4"] = this.ItmOther4;
                        dr["ItmOther5"] = this.ItmOther5;
                        dr["ItmOther6"] = this.ItmOther6;
                        dr["ItmOther7"] = this.ItmOther7;
                        dr["ItmOther8"] = this.ItmOther8;
                        dr["ItmOther9"] = this.ItmOther9;
                        dr["ItmOther10"] = this.ItmOther10;
                        dr["SalesPackAddUnit"] = this.SalesPackAddUnit;
                        dr["SalesPackAddQty"] = this.SalesPackAddQty;
                        dr["PackAddAmount"] = this.PackAddAmount;
                        dr["PackAddUnit"] = this.PackAddUnit;
                        dr["ModelVer"] = this.ModelVer;
                        dr["ModelCmpTaxNo"] = this.ModelCmpTaxNo;
                        dr["Royalty"] = this.Royalty;
                        dr["RoyaltyDetail"] = this.RoyaltyDetail;

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
            using (Connection cn = new Connection("cdp1"))
            {
                if (cn.ExecuteSQL(string.Format("delete from " + tbname + " RefNO='{0}' and InvNO='{1}' and ItemNO={2}", this.RefNO, this.InvNO, this.ItemNO)) == false)
                {
                    msg = cn.Message;
                }
            }
            return msg;
        }
    }
}
