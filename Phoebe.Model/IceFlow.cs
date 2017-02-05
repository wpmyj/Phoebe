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
    
    public partial class IceFlow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IceFlow()
        {
            this.IceSales = new HashSet<IceSale>();
            this.IceStocks = new HashSet<IceStock>();
        }
    
        public System.Guid Id { get; set; }
        public int FlowType { get; set; }
        public string MonthTime { get; set; }
        public string FlowNumber { get; set; }
        public System.DateTime FlowTime { get; set; }
        public Nullable<int> ContractId { get; set; }
        public int UserId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IceSale> IceSales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IceStock> IceStocks { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
