//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_DBFirstTest_Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class WFPriceConfirmationLetterDetails
    {
        public int WFPriceConfirmationLetterDetailsId { get; set; }
        public Nullable<int> WFPriceConfirmationLetterId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<int> CommodityId { get; set; }
        public Nullable<int> SpecificationId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<decimal> Premium { get; set; }
        public Nullable<decimal> BasePrice { get; set; }
        public Nullable<decimal> PricingPrice { get; set; }
        public Nullable<decimal> PricingPremium { get; set; }
        public Nullable<decimal> PricingBasePrice { get; set; }
    
        public virtual WFPriceConfirmationLetter WFPriceConfirmationLetter { get; set; }
    }
}