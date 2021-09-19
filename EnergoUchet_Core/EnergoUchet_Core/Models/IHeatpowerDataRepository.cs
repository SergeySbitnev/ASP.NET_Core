using System.Linq;
namespace EnergoUchet_Core.Models
{
    public interface IHeatpowerDataRepository
    {
        IQueryable<HeatpowerData> HeatpowerDatas { get; }
    }
}
