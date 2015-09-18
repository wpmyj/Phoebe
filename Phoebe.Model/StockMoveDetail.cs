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
    
    public partial class StockMoveDetail
    {
        public System.Guid ID { get; set; }
        public System.Guid StockMoveID { get; set; }
        public int SourceWarehouseID { get; set; }
        public int DestinationWarehouseID { get; set; }
        public System.Guid CargoID { get; set; }
        public int Count { get; set; }
        public System.Guid SourceStockID { get; set; }
        public Nullable<System.Guid> DestinationStockID { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    
        public virtual Cargo Cargo { get; set; }
        public virtual Stock SourceStock { get; set; }
        public virtual Stock DestinationStock { get; set; }
        public virtual StockMove StockMove { get; set; }
        public virtual Warehouse SourceWarehouse { get; set; }
        public virtual Warehouse DestinationWarehouse { get; set; }
    }
}
