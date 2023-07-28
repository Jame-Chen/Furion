using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysField : BaseEntity
{
    public string Id { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string MyTexts { get; set; }

    public string ParentId { get; set; }

    public string MyTables { get; set; }

    public string MyColums { get; set; }

    public int? Sort { get; set; }

    public string Remark { get; set; }

    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string UpdatePerson { get; set; }

    public virtual ICollection<SysField> InverseParent { get; set; } = new List<SysField>();

    public virtual SysField Parent { get; set; }
}
