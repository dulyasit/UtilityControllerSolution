using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilityControllers.Models
{
    public class PK13DetailModel
    {
        public string DateStr { get; set; }
        public string PreName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string CitizenID { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Telephone { get; set; }
        public string Career { get; set; }
        public string Nationality { get; set; }
        public string DonatorRegisterNo { get; set; }
        public string DonatorTaxId { get; set; }
        public Double? ThaiPercent { get; set; }
        public Double? ForeignPercent { get; set; }
        public Double? Cash { get; set; }
        public Double? Asset { get; set; }
    }
}