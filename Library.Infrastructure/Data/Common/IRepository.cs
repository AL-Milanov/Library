using System.Linq.Expressions;

namespace Library.Infrastructure.Data.Common
{
    public interface IRepository
    {
        Task<IQueryable<T>> GetAllAsync<T>() where T : class;

        Task<T> GetByIdAsync<T>(string id) where T : class;

        Task<T> GetByParameterAsync<T>(Expression<Func<string, T>> search) where T : class;

        Task SaveChangesAsync();
    }
}
