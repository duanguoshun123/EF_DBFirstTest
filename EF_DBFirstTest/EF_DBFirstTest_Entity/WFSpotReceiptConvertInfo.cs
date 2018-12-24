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
    
    public partial class WFSpotReceiptConvertInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFSpotReceiptConvertInfo()
        {
            this.WFSpotReceiptConvertDetailInfo = new HashSet<WFSpotReceiptConvertDetailInfo>();
        }
    
        public int WFSpotReceiptConvertInfoId { get; set; }
        public Nullable<decimal> ConvertWeight { get; set; }
        public Nullable<decimal> ConvertCost { get; set; }
        public bool IsConvertToSpot { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<System.DateTime> ConvertDate { get; set; }
        public Nullable<int> ActorId { get; set; }
        public string Note { get; set; }
        public int UnitId { get; set; }
        public int CurrencyId { get; set; }
        public bool IsDeleted { get; set; }
        public string CardCode { get; set; }
        public bool IsReceiptCodeRemain { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> SpecificationId { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public Nullable<int> ExchangeId { get; set; }
        public Nullable<int> CommodityId { get; set; }
        public Nullable<int> CorporationId { get; set; }
        public Nullable<int> Creator { get; set; }
        public Nullable<int> AccountEntityId { get; set; }
        public string VoucherCode { get; set; }
        public Nullable<int> SalerId { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public short TradeType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFSpotReceiptConvertDetailInfo> WFSpotReceiptConvertDetailInfo { get; set; }
    }
}
