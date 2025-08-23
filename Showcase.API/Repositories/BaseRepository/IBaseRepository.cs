﻿namespace Showcase.API.Repositories.BaseRepository
{
	public interface IBaseRepository<T> where T : class
	{
		Task<T?> GetByIdAsync(int id);
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
	}
}
