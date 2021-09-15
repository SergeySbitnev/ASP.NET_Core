using System;
using System.Collections.Generic;
using System.Linq;

namespace EnergoUchet_Core.Models
{
    public class FakeDispetcherDataRepository: IDispetcherDataRepository
    {
        public IQueryable<DispetcherData> dispetcherDatas => new List<DispetcherData>
        {
            new DispetcherData {Date = new DateTime(2021, 5, 13, 0, 0, 0), processWater = 19, returnedCondensateCounter = 19215, returnedCondensateT = 0, electricity = 21276},
            new DispetcherData {Date = new DateTime(2021, 5, 14, 0, 0, 0), processWater = 25, returnedCondensateCounter = 19221, returnedCondensateT = 0, electricity = 21279},
            new DispetcherData {Date = new DateTime(2021, 5, 15, 0, 0, 0), processWater = 35, returnedCondensateCounter = 19261, returnedCondensateT = 0, electricity = 21284},
            new DispetcherData {Date = new DateTime(2021, 5, 16, 0, 0, 0), processWater = 37, returnedCondensateCounter = 19298, returnedCondensateT = 0, electricity = 21288}
        }.AsQueryable<DispetcherData>();
  
    }
}
