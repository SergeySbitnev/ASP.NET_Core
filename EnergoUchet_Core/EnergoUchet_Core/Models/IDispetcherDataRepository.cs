using System.Linq;
namespace EnergoUchet_Core.Models
{
    public interface IDispetcherDataRepository
    {
        IQueryable<DispetcherData> DispetcherDatas { get; }
    }
}
