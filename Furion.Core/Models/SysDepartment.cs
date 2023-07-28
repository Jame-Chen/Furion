using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysDepartment : BaseEntity
{
    public string Id { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string Name { get; set; }

    public string ParentId { get; set; }

    public string Address { get; set; }

    public int? Sort { get; set; }

    public string Remark { get; set; }

    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string UpdatePerson { get; set; }

    public virtual ICollection<SysDepartment> InverseParent { get; set; } = new List<SysDepartment>();

    public virtual SysDepartment Parent { get; set; }

    public virtual ICollection<SysPerson> SysPeople { get; set; } = new List<SysPerson>();

    public virtual ICollection<SysDocument> Sys { get; set; } = new List<SysDocument>();
}
