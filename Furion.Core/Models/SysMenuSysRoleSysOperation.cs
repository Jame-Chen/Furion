using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysMenuSysRoleSysOperation : BaseEntity
{
    public string Id { get; set; }

    public string SysMenuId { get; set; }

    public string SysOperationId { get; set; }

    public string SysRoleId { get; set; }

    public virtual SysMenu SysMenu { get; set; }

    public virtual SysOperation SysOperation { get; set; }

    public virtual SysRole SysRole { get; set; }
}
