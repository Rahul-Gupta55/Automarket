using Automarket.Domain.Models;

namespace Automarket.DAL.Interfaces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Car GetByName(string name);
    }
}
