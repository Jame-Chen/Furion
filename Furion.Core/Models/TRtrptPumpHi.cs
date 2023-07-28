using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class TRtrptPumpHi : BaseEntity
{
    public decimal NId { get; set; }

    public string SDraiPumpId { get; set; }

    public string SSname { get; set; }

    public decimal? NDraiPumpType { get; set; }

    public decimal? NDraiPumpTypeFeat { get; set; }

    public DateTime? TStime { get; set; }

    public decimal? NLiuliang { get; set; }

    public decimal? NYuliang { get; set; }

    public decimal? NShuiwei { get; set; }

    public decimal? NTaishu { get; set; }

    public decimal? NKaijitaishu { get; set; }

    public decimal? NYewei { get; set; }

    public decimal? NWaiyewei { get; set; }

    public decimal? NRunning { get; set; }

    public string SPumpstatus { get; set; }

    public decimal? Cod { get; set; }

    public decimal? Ph { get; set; }

    public decimal? Bod { get; set; }

    public decimal? Nh3n { get; set; }

    public decimal? Tp { get; set; }

    public decimal? Tn { get; set; }

    public decimal? Toc { get; set; }

    public decimal? Ss { get; set; }

    public decimal? Ljll { get; set; }

    public int? Cckg { get; set; }

    public decimal? Ssll1 { get; set; }

    public decimal? Ssll2 { get; set; }

    public decimal? Ssll3 { get; set; }

    public decimal? Ssll4 { get; set; }

    public decimal? Ssll5 { get; set; }

    public decimal? Ssll6 { get; set; }

    public decimal? Ssll7 { get; set; }

    public decimal? Ssll8 { get; set; }

    public decimal? Ssll9 { get; set; }

    public decimal? Ssll10 { get; set; }

    public decimal? Ssll11 { get; set; }

    public decimal? Ssll12 { get; set; }

    public int? SLljs { get; set; }

    public decimal? Bzssll { get; set; }

    public string Town { get; set; }
}
