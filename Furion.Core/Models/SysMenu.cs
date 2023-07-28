using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

/// <summary>
/// 导航栏
/// </summary>
public partial class SysMenu : BaseEntity
{
    public string Id { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string Name { get; set; }

    public string ParentId { get; set; }

    public string Url { get; set; }

    public string Iconic { get; set; }

    public int? Sort { get; set; }

    public string Remark { get; set; }

    /// <summary>
    /// RadioButtonResearch
    /// </summary>
    public string State { get; set; }

    public string CreatePerson { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string UpdatePerson { get; set; }

    public string IsLeaf { get; set; }

    public string BigIconic { get; set; }

    public virtual ICollection<SysMenu> InverseParent { get; set; } = new List<SysMenu>();

    public virtual SysMenu Parent { get; set; }

    public virtual ICollection<SysMenuSysRoleSysOperation> SysMenuSysRoleSysOperations { get; set; } = new List<SysMenuSysRoleSysOperation>();

    public virtual ICollection<SysOperation> SysOperations { get; set; } = new List<SysOperation>();
}
