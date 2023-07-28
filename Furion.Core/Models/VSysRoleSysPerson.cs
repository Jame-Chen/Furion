using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class VSysRoleSysPerson : BaseEntity
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string SysPersonId { get; set; }

    public string SysRoleId { get; set; }

    public string RoleId { get; set; }

    public string RoleName { get; set; }

    public string Des { get; set; }

    public string MyName { get; set; }

    public string MobilePhoneNumber { get; set; }

    public string STownid { get; set; }

    public string STownname { get; set; }

    public string SCompany { get; set; }

    public DateTime? CreateTime { get; set; }
}
