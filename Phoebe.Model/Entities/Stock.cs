﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoebe.Model
{
    public class StockMetadata
    {
        /// <summary>
        /// ID
        /// </summary>
        [Display(Name = "ID")]
        public System.Guid ID { get; set; }

        /// <summary>
        /// 仓库ID
        /// </summary>
        [Display(Name = "仓库")]
        public int WarehouseID { get; set; }

        /// <summary>
        /// 托盘ID
        /// </summary>
        [Display(Name = "托盘")]
        public int TrayID { get; set; }

        /// <summary>
        /// 货品ID
        /// </summary>
        [Display(Name = "货品")]
        public System.Guid CargoID { get; set; }

        /// <summary>
        /// 入库时间
        /// </summary>
        [Display(Name = "入库时间")]
        public System.DateTime InTime { get; set; }

        /// <summary>
        /// 出库时间
        /// </summary>
        [Display(Name = "出库时间")]
        public Nullable<System.DateTime> OutTime { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [Display(Name = "来源")]
        public int Source { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        [Display(Name = "目的地")]
        public Nullable<int> Destination { get; set; }

        /// <summary>
        /// 入库记录
        /// </summary>
        [Display(Name = "入库记录")]
        public Nullable<System.Guid> StockInID { get; set; }

        /// <summary>
        /// 出库记录
        /// </summary>
        [Display(Name = "出库记录")]
        public Nullable<System.Guid> StockOutID { get; set; }

        /// <summary>
        /// 移库记录
        /// </summary>
        [Display(Name = "移库记录")]
        public Nullable<System.Guid> StockMoveID { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [DataType(DataType.MultilineText)]
        [Display(Name = "备注")]
        public string Remark { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        public int Status { get; set; }
    }

    [MetadataType(typeof(StockMetadata))]
    public partial class Stock
    {
    }
}