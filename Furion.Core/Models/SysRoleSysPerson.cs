using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysRoleSysPerson : BaseEntity
{
    public string SysPersonId { get; set; }

    public string SysRoleId { get; set; }

    public virtual SysPerson SysPerson { get; set; }

    public virtual SysRole SysRole { get; set; }
}
