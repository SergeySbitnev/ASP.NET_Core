using System.Collections.Generic;
using System.Linq;

namespace EnergoUchet_Core.Models
{
    public class EFDispetcherDataRepository : IDispetcherDataRepository
    {
        private ApplicationDbContext context;
        public EFDispetcherDataRepository (ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<DispetcherData> DispetcherDatas => context.DispetcherDatas;
    }
}
