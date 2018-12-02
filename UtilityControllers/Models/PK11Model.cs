using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilityControllers.Models
{
    public class PK11Model
    {
        public int DocumentRunno { get; set; }
        public string PartyName { get; set; }
        public string PartyTel { get; set; }
        public string PartyTaxID { get; set; }
        public string PartyAddr1 { get; set; }
        public string PartyAddr2 { get; set; }
        public string DocBookNo { get; set; }
        public string DocNum { get; set; }
        public DateTime DocDate { get; set; }
        public string DocDateStr { get; set; }
        public string DonatorName { get; set; }
        public string CitizenID { get; set; }
        public string RegisterID { get; set; }
        public string TaxID { get; set; }
        public string HouseNum { get; set; }
        public string Moo { get; set; }
        public string Building { get; set; }
        public string Soi { get; set; }
        public string Road { get; set; }
        public string Tambon { get; set; }
        public string Amphur { get; set; }
        public string Province { get; set; }
        public string Zipcode { get; set; }
        public string Telephone { get; set; }
        public string CashFlag { get; set; }
        public string BillFlag { get; set; }
        public string ChqueFlag { get; set; }
        public double Amount { get; set; }
        public string AmountStr { get; set; }
    }
}