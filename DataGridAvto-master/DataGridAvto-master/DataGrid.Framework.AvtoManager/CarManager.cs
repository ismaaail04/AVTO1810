using DataGridAvto.Framework.Contracts;
using DataGridAvto.Framework.Contracts.Models;
using DataGridAvto.Framework.AvtoManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGridAvto.Framework.CarManager
{
    public class CarManager : ICarManager
    {
        private ICarStorage carStorage;

        public CarManager(ICarStorage carStorage)
        {
            this.carStorage = carStorage;
        }

        public async Task<Avto> AddAsync(Avto Avto)
        {
            var result = await carStorage.AddAsync(Avto);
            return result;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await carStorage.DeleteAsync(id);
            return result;
        }

        public Task EditAsync(Avto avto)
            => carStorage.EditAsync(avto);

        public Task<IReadOnlyCollection<Avto>> GetAllAsync()
            => carStorage.GetAllAsync();

        public async Task<ICarStats> GetStatsAsync()
        {
            var result = await carStorage.GetAllAsync();
            return new CarStatsModel
            {
                Count = result.Count,
                LowCount = result.Count,

            };
        }
    }
}
