using System;
using System.Data.SqlTypes;

namespace UtilityControllers.Models
{
    public class DonateDetailDataModel
    {
        public int DocumentRunno { get; set; }
        public int DetailRunno { get; set; }
        public string Description { get; set; }
        public Double Amount { get; set; }
        public string Remark { get; set; }
        public int DonateTypeRunno { get; set; }
        public string Bill { get; set; }
        public string BankChqueNo { get; set; }
        public string Asset { get; set; }
        public string Benefit { get; set; }
        public string BankCode { get; set; }
        public string DocRefBook { get; set; }
        public string DocRefNo { get; set; }
        public string DocType { get; set; }
        public int DetailNo { get; set; }
    }
}
