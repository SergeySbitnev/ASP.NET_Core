using System;
using System.Collections.Generic;
using System.Linq;

namespace EnergoUchet_Core.Models
{
    public class FakeKipiaDataRepository: IKipiaDataRepository
    {
        public IQueryable<KipiaData> KipiaDatas => new List<KipiaData>
        {
            new KipiaData {Date = new DateTime(2021, 5, 13, 0, 0, 0), NaturalGas = 4348, ThermalEnergy = 40.3979988098144, HeatCarrier = 61.5410003662109},
            new KipiaData {Date = new DateTime(2021, 5, 14, 0, 0, 0), NaturalGas = 3727, ThermalEnergy = 39.7000000000000, HeatCarrier = 60.4480000000000},
            new KipiaData {Date = new DateTime(2021, 5, 15, 0, 0, 0), NaturalGas = 3186, ThermalEnergy = 34.4129981994628, HeatCarrier = 52.5120010375976},
            new KipiaData {Date = new DateTime(2021, 5, 16, 0, 0, 0), NaturalGas = 2432, ThermalEnergy = 26.4500007629394, HeatCarrier = 40.3009986877441}
        }.AsQueryable<KipiaData>();
    }
}
