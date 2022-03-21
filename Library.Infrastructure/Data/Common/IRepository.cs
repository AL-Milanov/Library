using System.Linq.Expressions;

namespace Library.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> GetAll<T>() where T : class;

        Task<T> GetByIdAsync<T>(Expression<Func<T, bool>> search) where T : class;

        Task<T> GetByParameterAsync<T>(Expression<Func<T, bool>> search) where T : class;

        Task SaveChangesAsync();
    }
}
