using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class DataRelaTable:BaseEntity
{
    public int Id { get; set; }

    public string WellCode { get; set; }

    public string WellName { get; set; }

    public int? DataCategory { get; set; }

    public int? DataCode { get; set; }

    public string DataName { get; set; }

    public string DataDesc { get; set; }

    public int? DataType { get; set; }

    public double? DataUpRange { get; set; }

    public double? DataDoRange { get; set; }

    public string SysCode { get; set; }

    public string Dbname { get; set; }

    public string Tbname { get; set; }

    public double? DefaultValue { get; set; }

    public int? TimeToleran { get; set; }

    public int? DataState { get; set; }

    public int? LastState { get; set; }

    public int? LastDeltState { get; set; }

    public DateTime? LastTime { get; set; }

    public double? LastValue { get; set; }

    public double? LastDelt { get; set; }

    public string WarnDesc { get; set; }

    public string Town { get; set; }

    public int NDraiPumpType { get; set; }
}
