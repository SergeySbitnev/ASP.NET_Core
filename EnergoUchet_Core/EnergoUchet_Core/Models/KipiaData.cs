using System;
namespace EnergoUchet_Core.Models
{
    public class KipiaData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } //Дата
        public int NaturalGas { get; set; } //Природный газ
        public double ThermalEnergy { get; set; } //Тепловая энергия
        public double HeatCarrier { get; set; } //Теплоноситель ТЭ (пар)
    }
}
