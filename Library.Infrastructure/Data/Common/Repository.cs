using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Library.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        protected DbContext Context { get; set; }

        protected DbSet<T> DbSet<T>() where T : class
        {
            return Context.Set<T>();
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return DbSet<T>();
        }

        public async Task<T> GetByIdAsync<T>(Expression<Func<T, bool>> search) where T : class
        {
            return await DbSet<T>()
                .FindAsync(search);
        }

        public async Task<T> GetByParameterAsync<T>(Expression<Func<T, bool>> search) where T : class
        {
            return await DbSet<T>()
                .Where(search)
                .FirstOrDefaultAsync();
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

    }
}
