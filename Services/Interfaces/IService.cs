﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpleadosApp.Services.Interfaces
{
    public interface IService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
