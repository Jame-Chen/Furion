using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class GwtableHi : BaseEntity
{
    public   int Id { get; set; }

    public string WellCode { get; set; }

    public int DataCode { get; set; }

    public string DataName { get; set; }

    public DateTime GetInfoTime { get; set; }

    public double DataValue { get; set; }

    public double? DeltValue { get; set; }

    public DateTime InsertTime { get; set; }

    public int? TimeSpan { get; set; }

    public int? DataState { get; set; }

    public int Flag { get; set; }

    public double? RawValue { get; set; }
}
