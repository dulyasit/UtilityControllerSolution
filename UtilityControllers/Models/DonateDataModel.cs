using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Web.UI;

namespace UtilityControllers.Models
{
    public class DonateDataModel
    {
        public int DocumentRunno { get; set; }
        public string WriteAt { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentDateStr { get; set; }
        public int DonateTypeRunno { get; set; }
        public string DonateType { get; set; }
        public string DonateObjective { get; set; }
        public int MemberRunno { get; set; }
        public string MemberId { get; set; }        
        public string MemberName { get; set; }        
        public DateTime? MemberBirthdate { get; set; }
        public string MemberAddress { get; set; }        
        public string MemberTelephone { get; set; }
        public int PositionNo { get; set; }
        public string MemberPosition { get; set; }
        public int DonatorRunno { get; set; }
        public string DonatorId { get; set; }
        public Double DonateAmount { get; set; }
        public string DonatorName { get; set; }        
        public string DonatorCitizenId { get; set; }
        public string DonatorRegisterNO { get; set; }
        public string DonatorTaxID { get; set; }
        public string DonatorAddress { get; set; }
        public string DonatorTelephone { get; set; }
        public int DonateDetailCount { get; set; }
        public string PartyName { get; set; }
        public string PartyTel { get; set; }
        public string PartyTaxID { get; set; }       
        public string PartyAddr1 { get; set; }
        public string PartyAddr2 { get; set; }
        public int? MemberAge { get; set; }
        public string MemberHouseNumber { get; set; }
        public string MemberSoi { get; set; }
        public string MemberRoad { get; set; }
        public string MemberMoo { get; set; }
        public string MemberBuilding { get; set; }
        public string MemberTambon { get; set; }
        public string MemberAmphur { get; set; }
        public string MemberProvince { get; set; }
        public string MemberZipCode { get; set; }
        public string DonatorHouseNumber { get; set; }
        public string DonatorSoi { get; set; }
        public string DonatorRoad { get; set; }
        public string DonatorMoo { get; set; }
        public string DonatorBuilding { get; set; }
        public string DonatorTambon { get; set; }
        public string DonatorAmphur { get; set; }
        public string DonatorProvince { get; set; }
        public string DonatorZipCode { get; set; }
        public string CashFlag { get; set; }
        public string AssetFlag { get; set; }
        public string BenefitFlag { get; set; }
        public List<DonateDetailDataModel> DonateDetail { get; set; }
    }
}
