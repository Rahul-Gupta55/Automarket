namespace Automarket.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(T entity);

        T Get(int id);

        IQueryable<T> GetAll();

        bool Delete(T entity);
    }
}
