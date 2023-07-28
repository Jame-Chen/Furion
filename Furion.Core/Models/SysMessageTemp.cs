using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysMessageTemp : BaseEntity
{
    public string Id { get; set; }

    public string MessageName { get; set; }

    public string Content { get; set; }

    /// <summary>
    /// RadioButton
    /// </summary>
    public string IsDefault { get; set; }

    public string MessageType { get; set; }

    public string Remark { get; set; }

    public string State { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }

    public virtual ICollection<SysMessage> SysMessages { get; set; } = new List<SysMessage>();
}
