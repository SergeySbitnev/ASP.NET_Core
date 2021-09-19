using System.Linq;
namespace EnergoUchet_Core.Models
{
    public interface IKipiaDataRepository
    {
        IQueryable<KipiaData> KipiaDatas { get; }
    }
}
