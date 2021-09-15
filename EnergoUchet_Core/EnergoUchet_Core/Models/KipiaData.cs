using System;
namespace EnergoUchet_Core.Models
{
    public class KipiaData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } //Дата
        public int naturalGas { get; set; } //Природный газ
        public double thermalEnergy { get; set; } //Тепловая энергия
        public double heatCarrier { get; set; } //Теплоноситель ТЭ (пар)
    }
}
