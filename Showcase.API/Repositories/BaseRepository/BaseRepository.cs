using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Showcase.API.Database;

namespace Showcase.API.Repositories.BaseRepository
{
	public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		protected readonly ShowcaseDbContext _context;
		protected readonly DbSet<T> _dbSet;

		protected BaseRepository(ShowcaseDbContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}

		public virtual async Task<T?> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public virtual async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public virtual async Task<T> AddAsync(T entity)
		{
			EntityEntry<T> result = await _dbSet.AddAsync(entity);
			await _context.SaveChangesAsync();
			return result.Entity;
		}

		public virtual async Task UpdateAsync(T entity)
		{
			_dbSet.Update(entity);
			await _context.SaveChangesAsync();
		}

		public virtual async Task DeleteAsync(T entity)
		{
			_dbSet.Remove(entity);
			await _context.SaveChangesAsync();
		}
	}
}
