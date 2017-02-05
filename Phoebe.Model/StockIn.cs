//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Phoebe.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockIn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockIn()
        {
            this.StockInDetails = new HashSet<StockInDetail>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime InTime { get; set; }
        public string MonthTime { get; set; }
        public string FlowNumber { get; set; }
        public int ContractId { get; set; }
        public int UserId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    
        public virtual Billing Billing { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockInDetail> StockInDetails { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
