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
    
    public partial class Cargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cargo()
        {
            this.Stores = new HashSet<Store>();
        }
    
        public System.Guid Id { get; set; }
        public int CategoryId { get; set; }
        public int GroupType { get; set; }
        public double UnitWeight { get; set; }
        public double UnitVolume { get; set; }
        public int ContractId { get; set; }
        public System.DateTime RegisterTime { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
