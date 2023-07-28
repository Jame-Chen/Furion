using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class TDrainuserpicture : BaseEntity
{
    public int Id { get; set; }

    public string FileUploaderId { get; set; }

    public string WbId { get; set; }

    public decimal? TypeId { get; set; }

    public string FullPath { get; set; }

    public DateTime? CreateTime { get; set; }

    public decimal? IdIndex { get; set; }

    public DateTime? OperateTime { get; set; }

    public string Stamp { get; set; }

    public decimal? FileUploaderStatus { get; set; }
}
