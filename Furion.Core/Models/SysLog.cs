using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysLog : BaseEntity
{
    public  new string Id { get; set; }

    public string PersonId { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string Message { get; set; }

    public string Result { get; set; }

    public string MenuId { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string Ip { get; set; }

    public string Remark { get; set; }

    /// <summary>
    /// ResearchDropDown
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }
}
