using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysException : BaseEntity
{
    public   string Id { get; set; }

    public string LeiXing { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string Message { get; set; }

    public string Result { get; set; }

    public string Remark { get; set; }

    public string State { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }
}
