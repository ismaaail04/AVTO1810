using DataGridAvto.Framework.Contracts.Models;

namespace DataGridAvto.Framework.AvtoManager.Models
{
    public class CarStatsModel : ICarStats
    {
        public int Count { get; set; }

        public int LowCount { get; set; }
    }
}
