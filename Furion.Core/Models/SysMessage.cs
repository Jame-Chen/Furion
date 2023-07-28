using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysMessage : BaseEntity
{
    public string Id { get; set; }

    public string Content { get; set; }

    public string SysMessageTempId { get; set; }

    public string MessageType { get; set; }

    public string Remark { get; set; }

    public string State { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public DateTime? ReadTime { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }

    public virtual SysMessageTemp SysMessageTemp { get; set; }
}
