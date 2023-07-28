using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysEmail : BaseEntity
{
    public string Id { get; set; }

    public string SysMailId { get; set; }

    public string Subject { get; set; }

    public string Content { get; set; }

    public string ReplyEmail { get; set; }

    public string MailType { get; set; }

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

    public virtual SysEmailTemp SysMail { get; set; }
}
