using System;
using System.Data.SqlTypes;

namespace UtilityControllers.Models
{
    public class ReceiptDataModel
    {
        public int DocumentRunno { get; set; }
        public string DocumentBookNumber { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string PayerType { get; set; }
        public int PayerRunno { get; set; }
        public string PayerName { get; set; }
        public string PayerId { get; set; }
        public string HouseNumber { get; set; }
        public string Soi { get; set; }
        public string Road { get; set; }
        public string Moo { get; set; }
        public string Building { get; set; }
        public string Tambon { get; set; }
        public string Amphur { get; set; }
        public string Province { get; set; }
        public string Zipcode { get; set; }
        public string Telephone { get; set; }
        public string AsReceiptTo { get; set; }
        public string AsReceiptToRemark { get; set; } // สำหรับกรณีเป็นการเลือก Option อื่น ๆ จะเป็นส่วนของ การระบุ
        public Double ReceiptAmount { get; set; }
        public string ReceiptPayType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string ReceiptBank { get; set; }
        public string ReceiptBillNumber { get; set; }
        public string ReceiptChqBank { get; set; }
        public string ReceiptChqNumber { get; set; }
        public string ReceiptOther { get; set; }        
        public string BankName { get; set; }
        public string CitizenId { get; set; }
        public string AmountStr { get; set; }
    }
}
