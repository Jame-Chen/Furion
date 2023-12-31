﻿using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysMenuOld : BaseEntity
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string ParentId { get; set; }

    public string Url { get; set; }

    public string Iconic { get; set; }

    public int? Sort { get; set; }

    public string Remark { get; set; }

    public string State { get; set; }

    public string CreatePerson { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string UpdatePerson { get; set; }

    public string IsLeaf { get; set; }

    public string BigIconic { get; set; }
}
