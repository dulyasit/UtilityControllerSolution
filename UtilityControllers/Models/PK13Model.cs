using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilityControllers.Models
{
    public class PK13Model
    {
        public string PartyName { get; set; }
        public string SDay { get; set; }
        public string SMonth { get; set; }
        public string SYear { get; set; }
        public string EDay { get; set; }
        public string EMonth { get; set; }
        public string EYear { get; set; }
        public Double? TotalAmount { get; set; }
        public string TotalAmountStr { get; set; }
        public Double? TotalCash { get; set; }
        public Double? TotalAsset { get; set; }
        public string AnnouDay { get; set; }
        public string AnnouMonth { get; set; }
        public string AnnouYear { get; set; }
        public string ErrorMessage { get; set; }
        public List<PK13DetailModel> DetailData { get; set; }
    }
}