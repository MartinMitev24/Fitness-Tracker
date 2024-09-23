using Fitness_Tracker.Infrastucture.Data;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Tracker.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(ApplicationDbContext _context)
        {
            context = _context;
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return context.Set<T>();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await context.AddAsync(entity);
        }
    }
}
