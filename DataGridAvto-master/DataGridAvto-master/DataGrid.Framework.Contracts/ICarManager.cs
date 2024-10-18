using DataGridAvto.Framework.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridAvto.Framework.Contracts
{
    public interface ICarManager
    {
        Task<IReadOnlyCollection<Avto>> GetAllAsync();

        Task<Avto> AddAsync(Avto avto);

        Task EditAsync(Avto avto);

        Task<bool> DeleteAsync(Guid id);

        Task<ICarStats> GetStatsAsync();
    }
}
