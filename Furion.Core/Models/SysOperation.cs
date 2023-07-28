using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

/// <summary>
/// 操作
/// </summary>
public partial class SysOperation : BaseEntity
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Function { get; set; }

    /// <summary>
    /// Equal
    /// </summary>
    public string Iconic { get; set; }

    public int? Sort { get; set; }

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

    public virtual ICollection<SysMenuSysRoleSysOperation> SysMenuSysRoleSysOperations { get; set; } = new List<SysMenuSysRoleSysOperation>();

    public virtual ICollection<SysMenu> SysMenus { get; set; } = new List<SysMenu>();
}
