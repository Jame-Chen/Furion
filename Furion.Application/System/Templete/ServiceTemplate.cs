
using Furion.Core.Models;
using Furion.Application.System.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furion.Application.System.Services;

public partial class DataRelaTableService : BaseService<DataRelaTable>, IDynamicApiController
{
    public DataRelaTableService(IRepository<DataRelaTable> _repository) : base(_repository)
    {
    }
}

public partial class FileUploaderService : BaseService<FileUploader>, IDynamicApiController
{
    public FileUploaderService(IRepository<FileUploader> _repository) : base(_repository)
    {
    }
}

public partial class GwtableHiService : BaseService<GwtableHi>, IDynamicApiController
{
    public GwtableHiService(IRepository<GwtableHi> _repository) : base(_repository)
    {
    }
}

public partial class SysAnnouncementService : BaseService<SysAnnouncement>, IDynamicApiController
{
    public SysAnnouncementService(IRepository<SysAnnouncement> _repository) : base(_repository)
    {
    }
}

public partial class SysDepartmentService : BaseService<SysDepartment>, IDynamicApiController
{
    public SysDepartmentService(IRepository<SysDepartment> _repository) : base(_repository)
    {
    }
}

public partial class SysDocumentService : BaseService<SysDocument>, IDynamicApiController
{
    public SysDocumentService(IRepository<SysDocument> _repository) : base(_repository)
    {
    }
}

public partial class SysDocumentTalkService : BaseService<SysDocumentTalk>, IDynamicApiController
{
    public SysDocumentTalkService(IRepository<SysDocumentTalk> _repository) : base(_repository)
    {
    }
}

public partial class SysEmailService : BaseService<SysEmail>, IDynamicApiController
{
    public SysEmailService(IRepository<SysEmail> _repository) : base(_repository)
    {
    }
}

public partial class SysEmailTempService : BaseService<SysEmailTemp>, IDynamicApiController
{
    public SysEmailTempService(IRepository<SysEmailTemp> _repository) : base(_repository)
    {
    }
}

public partial class SysExceptionService : BaseService<SysException>, IDynamicApiController
{
    public SysExceptionService(IRepository<SysException> _repository) : base(_repository)
    {
    }
}

public partial class SysFieldService : BaseService<SysField>, IDynamicApiController
{
    public SysFieldService(IRepository<SysField> _repository) : base(_repository)
    {
    }
}

public partial class SysLogService : BaseService<SysLog>, IDynamicApiController
{
    public SysLogService(IRepository<SysLog> _repository) : base(_repository)
    {
    }
}

public partial class SysMenuService : BaseService<SysMenu>, IDynamicApiController
{
    public SysMenuService(IRepository<SysMenu> _repository) : base(_repository)
    {
    }
}

public partial class SysMenuOldService : BaseService<SysMenuOld>, IDynamicApiController
{
    public SysMenuOldService(IRepository<SysMenuOld> _repository) : base(_repository)
    {
    }
}

public partial class SysMenuSysRoleSysOperationService : BaseService<SysMenuSysRoleSysOperation>, IDynamicApiController
{
    public SysMenuSysRoleSysOperationService(IRepository<SysMenuSysRoleSysOperation> _repository) : base(_repository)
    {
    }
}

public partial class SysMessageService : BaseService<SysMessage>, IDynamicApiController
{
    public SysMessageService(IRepository<SysMessage> _repository) : base(_repository)
    {
    }
}

public partial class SysMessageTempService : BaseService<SysMessageTemp>, IDynamicApiController
{
    public SysMessageTempService(IRepository<SysMessageTemp> _repository) : base(_repository)
    {
    }
}

public partial class SysNoticeService : BaseService<SysNotice>, IDynamicApiController
{
    public SysNoticeService(IRepository<SysNotice> _repository) : base(_repository)
    {
    }
}

public partial class SysOperationService : BaseService<SysOperation>, IDynamicApiController
{
    public SysOperationService(IRepository<SysOperation> _repository) : base(_repository)
    {
    }
}

public partial class SysPersonService : BaseService<SysPerson>, IDynamicApiController
{
    public SysPersonService(IRepository<SysPerson> _repository) : base(_repository)
    {
    }
}

public partial class SysPerson20230717Service : BaseService<SysPerson20230717>, IDynamicApiController
{
    public SysPerson20230717Service(IRepository<SysPerson20230717> _repository) : base(_repository)
    {
    }
}

public partial class SysRoleService : BaseService<SysRole>, IDynamicApiController
{
    public SysRoleService(IRepository<SysRole> _repository) : base(_repository)
    {
    }
}

public partial class SysRoleSysPersonService : BaseService<SysRoleSysPerson>, IDynamicApiController
{
    public SysRoleSysPersonService(IRepository<SysRoleSysPerson> _repository) : base(_repository)
    {
    }
}

public partial class TDrainuserService : BaseService<TDrainuser>, IDynamicApiController
{
    public TDrainuserService(IRepository<TDrainuser> _repository) : base(_repository)
    {
    }
}

public partial class TDrainuserpictureService : BaseService<TDrainuserpicture>, IDynamicApiController
{
    public TDrainuserpictureService(IRepository<TDrainuserpicture> _repository) : base(_repository)
    {
    }
}

public partial class TOnlineNewSsdataService : BaseService<TOnlineNewSsdata>, IDynamicApiController
{
    public TOnlineNewSsdataService(IRepository<TOnlineNewSsdata> _repository) : base(_repository)
    {
    }
}

public partial class TOnlineNewSsdatasHiService : BaseService<TOnlineNewSsdatasHi>, IDynamicApiController
{
    public TOnlineNewSsdatasHiService(IRepository<TOnlineNewSsdatasHi> _repository) : base(_repository)
    {
    }
}

public partial class TRtrptPumpHiService : BaseService<TRtrptPumpHi>, IDynamicApiController
{
    public TRtrptPumpHiService(IRepository<TRtrptPumpHi> _repository) : base(_repository)
    {
    }
}

public partial class TRtrptPumpHisHiService : BaseService<TRtrptPumpHisHi>, IDynamicApiController
{
    public TRtrptPumpHisHiService(IRepository<TRtrptPumpHisHi> _repository) : base(_repository)
    {
    }
}

public partial class VSysRoleSysPersonService : BaseService<VSysRoleSysPerson>, IDynamicApiController
{
    public VSysRoleSysPersonService(IRepository<VSysRoleSysPerson> _repository) : base(_repository)
    {
    }
}

