using System;
using System.Collections.Generic;
using System.Linq;

namespace EnergoUchet_Core.Models
{
    public class FakeDispetcherDataRepository: IDispetcherDataRepository
    {
        public IQueryable<DispetcherData> DispetcherDatas => new List<DispetcherData>
        {
            new DispetcherData {Date = new DateTime(2021, 5, 13, 0, 0, 0), ProcessWater = 19, ReturnedCondensateCounter = 19215, ReturnedCondensateT = 0, Electricity = 21276},
            new DispetcherData {Date = new DateTime(2021, 5, 14, 0, 0, 0), ProcessWater = 25, ReturnedCondensateCounter = 19221, ReturnedCondensateT = 0, Electricity = 21279},
            new DispetcherData {Date = new DateTime(2021, 5, 15, 0, 0, 0), ProcessWater = 35, ReturnedCondensateCounter = 19261, ReturnedCondensateT = 0, Electricity = 21284},
            new DispetcherData {Date = new DateTime(2021, 5, 16, 0, 0, 0), ProcessWater = 37, ReturnedCondensateCounter = 19298, ReturnedCondensateT = 0, Electricity = 21288}
        }.AsQueryable<DispetcherData>();
  
    }
}
