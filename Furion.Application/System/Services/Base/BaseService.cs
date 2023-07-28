using Furion.Core;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Furion.Application.System.Services.Base;

public class BaseService<T> : IBaseService<T> where T : BaseEntity, IPrivateEntity, new()
{
    private readonly IRepository<T> repository;
    public BaseService(IRepository<T> _repository)
    {
        repository = _repository;
    }

    public async Task<PagedList<T>> GetList(int Page=1, int PageSize=10)
    {
        return await repository.AsQueryable().ToPagedListAsync<T>(Page, PageSize);
    }
    public async Task<T> Add(T entity)
    {
        var res = await repository.InsertNowAsync(entity);
        return res.Entity;
    }

    public async Task BatchAdd(List<T> list)
    {
        await repository.InsertNowAsync(list);
    }


    public async Task<T> Update(T entity)
    {
        var res = await repository.UpdateNowAsync(entity);
        return res.Entity;
    }

    public async Task<T> UpdateInclude(T entity, string[] IncludeFiled, bool ignoreNullValues = true)
    {
        var res = await repository.UpdateIncludeNowAsync(entity, IncludeFiled, ignoreNullValues);
        return res.Entity;
    }


    public async Task<T> UpdateExclude(T entity, string[] ExcludeFiled, bool ignoreNullValues = true)
    {
        var res = await repository.UpdateExcludeNowAsync(entity, ExcludeFiled, ignoreNullValues);
        return res.Entity;
    }


    public async Task<T> Delete(T entity)
    {
        var res = await repository.DeleteNowAsync(entity);
        return res.Entity;
    }


}

