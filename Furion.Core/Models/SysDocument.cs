using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysDocument : BaseEntity
{
    public string Id { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string Name { get; set; }

    public string Path { get; set; }

    public string FullPath { get; set; }

    public string Suffix { get; set; }

    public int? Size { get; set; }

    public string Remark { get; set; }

    public int? Download { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }

    public virtual ICollection<SysDocumentTalk> SysDocumentTalks { get; set; } = new List<SysDocumentTalk>();

    public virtual ICollection<SysDepartment> SysDepartments { get; set; } = new List<SysDepartment>();

    public virtual ICollection<SysPerson> SysPeople { get; set; } = new List<SysPerson>();
}
