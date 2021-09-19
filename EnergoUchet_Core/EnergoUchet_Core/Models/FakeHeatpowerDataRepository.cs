using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergoUchet_Core.Models
{
    public class FakeHeatpowerDataRepository: IHeatpowerDataRepository
    {
        public IQueryable<HeatpowerData> HeatpowerDatas => new List<HeatpowerData>
        {
            new HeatpowerData { Date = new DateTime(2021, 5, 13, 0, 0, 0), Reagents = 50 },
            new HeatpowerData { Date = new DateTime(2021, 5, 14, 0, 0, 0), Reagents = 200 },
            new HeatpowerData { Date = new DateTime(2021, 5, 15, 0, 0, 0), Reagents = 25 },
            new HeatpowerData { Date = new DateTime(2021, 5, 16, 0, 0, 0), Reagents = 50 }
        }.AsQueryable<HeatpowerData>();
    }
}
