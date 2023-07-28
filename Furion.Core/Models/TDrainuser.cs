using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class TDrainuser : BaseEntity
{
    public decimal? NJd { get; set; }

    public decimal? NWd { get; set; }

    public string QppshTableId { get; set; }

    public string SNo { get; set; }

    public string SName { get; set; }

    public string SAddress { get; set; }

    public string SType { get; set; }

    public string SXkh { get; set; }

    public string SArea { get; set; }

    public string STown { get; set; }

    public decimal? Status { get; set; }

    public string Stamp { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? OperateTime { get; set; }

    public string SStatus { get; set; }

    public string SInMan { get; set; }
}
