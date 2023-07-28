using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysNotice : BaseEntity
{
    public string Id { get; set; }

    public string Message { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public DateTime? LostTime { get; set; }

    public string PersonId { get; set; }

    public string Remark { get; set; }

    public string State { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }
}
