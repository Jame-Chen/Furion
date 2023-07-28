using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysAnnouncement : BaseEntity
{
    public  new string Id { get; set; }

    public string Title { get; set; }

    public string Message { get; set; }

    public string State { get; set; }

    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }
}
