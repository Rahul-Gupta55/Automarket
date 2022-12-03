﻿namespace Automarket.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> Create(T entity);

        Task<T> Get(int id);

        Task<List<T>> GetAll();

        Task<bool> Delete(T entity);
    }
}
