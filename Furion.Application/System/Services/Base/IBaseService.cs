using Furion.Core;

namespace Furion.Application.System.Services.Base
{
    public interface IBaseService<T> where T : BaseEntity, IPrivateEntity, new()
    {
        Task<T> Add(T entity);
        Task BatchAdd(List<T> list);
        Task<T> Delete(T entity);
        Task<PagedList<T>> GetList(int Page, int PageSize);
        Task<T> Update(T entity);
        Task<T> UpdateExclude(T entity, string[] ExcludeFiled, bool ignoreNullValues = true);
        Task<T> UpdateInclude(T entity, string[] IncludeFiled, bool ignoreNullValues = true);
    }
}