using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class TOnlineNewSsdatasHi : BaseEntity
{
    public long Sid { get; set; }

    public string StdId { get; set; }

    public string ComId { get; set; }

    public string FactId { get; set; }

    public string Jckid { get; set; }

    public int? Jcktype { get; set; }

    public string JckName { get; set; }

    public DateTime? Datetime { get; set; }

    public string DspName { get; set; }

    public string Codtoctime { get; set; }

    public DateTime? Codtocdt { get; set; }

    public int? ClrCodtocdt { get; set; }

    public string D009 { get; set; }

    public string D010 { get; set; }

    public string D011 { get; set; }

    public string D012 { get; set; }

    public int? ClrD009 { get; set; }

    public int? ClrD010 { get; set; }

    public int? ClrD011 { get; set; }

    public int? ClrD012 { get; set; }

    public string Codtocstate { get; set; }

    public int? Codtocstval { get; set; }

    public string Codtocwarning { get; set; }

    public int? Codtocwnval { get; set; }

    public string Codtocfault { get; set; }

    public int? Codtocftval { get; set; }

    public double? Flag { get; set; }

    public string DataDt { get; set; }

    public int? ClrDatetime { get; set; }

    public double? Cod { get; set; }

    public double? Ph { get; set; }

    public double? Ssll { get; set; }

    public double? Ljll { get; set; }

    public double? Wt { get; set; }

    public double? Yw { get; set; }

    public double? Toc { get; set; }

    public double? Tp { get; set; }

    public double? Nh3n { get; set; }

    public double? Tn { get; set; }

    public string District { get; set; }

    public string Info { get; set; }

    public decimal? Outamount { get; set; }

    public int? Factxs { get; set; }
}
