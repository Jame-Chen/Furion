using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysRole : BaseEntity
{
    public string Id { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string UpdatePerson { get; set; }

    public virtual ICollection<SysMenuSysRoleSysOperation> SysMenuSysRoleSysOperations { get; set; } = new List<SysMenuSysRoleSysOperation>();
}
