using DataGridAvto.Framework.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridAvto.Framework.Contracts
{
    public interface ICarStorage
    {
        Task<IReadOnlyCollection<Avto>> GetAllAsync();

        Task<Avto> AddAsync(Avto Avto);

        Task EditAsync(Avto Avto);

        Task<bool> DeleteAsync(Guid id);
    }
}
