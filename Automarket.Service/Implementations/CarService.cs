using Automarket.DAL.Interfaces;
using Automarket.Domain.Models;
using Automarket.Domain.Response;
using Automarket.Service.Interfaces;

namespace Automarket.Service.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IBaseResponse<IEnumerable<Car>>> GetCars()
        {
            var baseResponse = new BaseResponse<IEnumerable<Car>>();
            try
            {
                var cars = await _carRepository.GetAll();
                if(cars.Count == 0)
                {
                    baseResponse.Description = "Found 0 elements";
                    baseResponse.StatusCode = Domain.Enum.StatusCode.Ok;
                    return baseResponse;
                }

                baseResponse.Data = cars;
                baseResponse.StatusCode = Domain.Enum.StatusCode.Ok;

                return baseResponse;
            } 
            catch(Exception ex) 
            {
                return new BaseResponse<IEnumerable<Car>>()
                {
                    Description = $"[GetCars] : {ex.Message}"
                };
            }
        }
    }
}
