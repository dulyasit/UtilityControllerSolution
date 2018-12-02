using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilityControllers.Models
{
    public class DonatorData
    {
        public int DonatorRunno { get; set; }
        public string DonatorId { get; set; }
        public string DonatorPreName { get; set; }
        public string DonatorName { get; set; }
        public string DonatorSurName { get; set; }        
        public string DonatorCitizenId { get; set; }
        public string DonatorRegisterNo { get; set; }
        public string DonatorTaxId { get; set; }
        public string HouseNumber { get; set; }
        public string Soi { get; set; }
        public string Road { get; set; }
        public string Moo { get; set; }
        public string Building { get; set; }
        public string Tambon { get; set; }
        public string Amphur { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
        public string Telephone { get; set; }
        public string DonatorFullName { get; set; }
        public string Career { get; set; }
        public string Nationality { get; set; }
        public double? ThaiPercent { get; set; }
        public double? ForeignPercent { get; set; }
    }
}