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
    
    public partial class SettlementDetail
    {
        public System.Guid ID { get; set; }
        public System.Guid SettlementID { get; set; }
        public Nullable<System.Guid> CargoID { get; set; }
        public Nullable<int> ContractID { get; set; }
        public int ExpenseType { get; set; }
        public decimal SumPrice { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual Settlement Settlement { get; set; }
        public virtual Cargo Cargo { get; set; }
    }
}
