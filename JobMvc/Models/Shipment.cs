using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JobMvc.Models
{
    [Table("shipment_h")]
    public class Shipment
    {
        [Key]
        public int oid { get; set; }
        public string code_company { get; set; }
        public string shipment_no { get; set; }
        public string code_customer { get; set; }
        public string type_shipment { get; set; }
        public DateTime date_create { get; set; }
        public DateTime date_confirm { get; set; }
        public DateTime date_expected { get; set; }
        public DateTime date_clearance { get; set; }
        public DateTime date_invoice { get; set; }
        public DateTime date_billing { get; set; }
        public DateTime date_closed { get; set; }
        public int status_shipment { get; set; }
        public virtual ICollection<CommercialInvoice> invoices { get; set; }
    }
    [Table("shipment_invoice")]
    public class CommercialInvoice
    {
        [Key]
        public int oid { get; set; }
        public string invoice_no { get; set; }
        public string code_company { get; set; }
        public string code_shipper { get; set; }
        public string code_consignee { get; set; }
        public string code_notifyparty { get; set; }
        public DateTime date_invoice { get; set; }
        public string customer_po { get; set; }
        public string reference_job { get; set; }
        public string lc_no { get; set; }
        public string lc_issueby { get; set; }
        public DateTime date_lc { get; set; }
        public string bl_awb_no { get; set; }
        public string bl_awb_agent { get; set; }
        public string type_shipment { get; set; }
        public DateTime date_shipment { get; set; }
        public string commodity { get; set; }
        public DateTime date_delivery { get; set; } 
        public double weight_gross { get; set; }
        public double weight_net { get; set; }
        public string weight_unit { get; set; }
        public double package_total { get; set; }
        public string package_unit { get; set; }
        public string reason { get; set; }
        public string from_port { get; set; }
        public string form_country { get; set; }
        public string to_port { get; set; }
        public string to_country { get; set; }
        public string code_carrier { get; set; }
        public string vessel_no { get; set; }
        public string voyage_no { get; set; }
        public string dest_country { get; set; }
        public DateTime date_departure { get; set; }
        public DateTime date_arrival { get; set; }
        public string incoterm { get; set; }
        public string type_frieght { get; set; }
        public double invoice_total { get; set; }
        public string currency { get; set; }
        public double exchange_rate { get; set; }
        public string shipping_condition { get; set; }
        public string payment_condition { get; set; }
        public string invoice_remark { get; set; }
        public virtual ICollection<CommercialInvoiceItem> items { get; set; }
        public virtual ICollection<CommercialInvoicePackingList> packing_list { get; set; }
        public string declaration_no { get; set; }
    }
    [Table("shipment_invoiceitem")]
    public class CommercialInvoiceItem
    {
        [Key]
        public int oid { get; set; }
        public string code_company { get; set; }
        public string invoice_no { get; set; }
        public int seq { get; set; }
        public string package_no { get; set; }
        public string shipping_mark { get; set; }
        public string type_package { get; set; }
        public string package_details { get; set; }
        public double total_qty { get; set; }
        public string unit_measure { get; set; }
        public double unit_price { get; set; }
        public double total_amount { get; set; }
        public double total_weight { get; set; }
        public string hs_code { get; set; }
        public string origin_country { get; set; }
        public int declaration_itemno { get; set; }
    }
    [Table("shipment_packinglist")]
    public class CommercialInvoicePackingList
    {
        [Key]
        public int oid { get; set; }
        public string code_company { get; set; }
        public string invoice_no { get; set; }
        public int package_no { get; set; }
        public string reference_code { get; set; }
        public string product_code { get; set; }
        public string product_description { get; set; }
        public double product_qty { get; set; }
        public string unit_product { get; set; }
        public double package_qty { get; set; }
        public string unit_package { get; set; }
        public double net_weight { get; set; }
        public double gross_weight { get; set; }
        public string packing_note { get; set; }
        public double measurement { get; set; }
        public string dimension { get; set; }
    }
    [Table("declarations_h")]
    public class Declaration
    {
        [Key]
        public int oid { get; set; }
        public string reference_no { get; set; }
        public DateTime date_create { get; set; }
        public string code_company { get; set; }
        public string code_shipper { get; set; }
        public string declaration_no { get; set; }
        public string status_declare { get; set; }
        public DateTime date_accept { get; set; }
        public DateTime date_response { get; set; }
        public DateTime date_cancel { get; set; }
        public DateTime date_complete { get; set; }
        public string status_document { get; set; }
        public virtual ICollection<CommercialInvoice> invoices { get; set; }
    }
}