using System;
using System.Collections.Generic;
using System.Linq;

namespace EnergoUchet_Core.Models
{
    public class FakeKipiaDataRepository: IKipiaDataRepository
    {
        public IQueryable<KipiaData> kipiaDatas => new List<KipiaData>
        {
            new KipiaData {Date = new DateTime(2021, 5, 13, 0, 0, 0), naturalGas = 4348, thermalEnergy = 40.3979988098144, heatCarrier = 61.5410003662109},
            new KipiaData {Date = new DateTime(2021, 5, 14, 0, 0, 0), naturalGas = 3727, thermalEnergy = 39.7000000000000, heatCarrier = 60.4480000000000},
            new KipiaData {Date = new DateTime(2021, 5, 15, 0, 0, 0), naturalGas = 3186, thermalEnergy = 34.4129981994628, heatCarrier = 52.5120010375976},
            new KipiaData {Date = new DateTime(2021, 5, 16, 0, 0, 0), naturalGas = 2432, thermalEnergy = 26.4500007629394, heatCarrier = 40.3009986877441}
        }.AsQueryable<KipiaData>();
    }
}
