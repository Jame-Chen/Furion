using Furion.DatabaseAccessor;
using System;
using System.Collections.Generic;

namespace Furion.Core.Models;

public partial class SysPerson: BaseEntity
{
    public string  Id { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Research
    /// </summary>
    public string MyName { get; set; }

    public string Password { get; set; }

    public string SurePassword { get; set; }

    /// <summary>
    /// DropDown
    /// </summary>
    public string Sex { get; set; }

    public string SysDepartmentId { get; set; }

    public string Position { get; set; }

    public string MobilePhoneNumber { get; set; }

    public string PhoneNumber { get; set; }

    /// <summary>
    /// DropDown
    /// </summary>
    public string Province { get; set; }

    /// <summary>
    /// ProvinceCascade
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// CityCascade
    /// </summary>
    public string Village { get; set; }

    public string Address { get; set; }

    public string EmailAddress { get; set; }

    public string Remark { get; set; }

    /// <summary>
    /// RadioButtonResearch
    /// </summary>
    public string State { get; set; }

    public DateTime? CreateTime { get; set; }

    public string CreatePerson { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? LogonNum { get; set; }

    public DateTime? LogonTime { get; set; }

    public string LogonIp { get; set; }

    public DateTime? LastLogonTime { get; set; }

    public string LastLogonIp { get; set; }

    /// <summary>
    /// Display
    /// </summary>
    public string PageStyle { get; set; }

    public string UpdatePerson { get; set; }

    public byte[] Version { get; set; }

    public string Hdpic { get; set; }

    public string ToKen { get; set; }

    public int ChangePwd { get; set; }

    public DateTime? ChangePwdTime { get; set; }

    public virtual SysDepartment SysDepartment { get; set; }

    public virtual ICollection<SysDocument> SysSysDocumentIds { get; set; } = new List<SysDocument>();
}
