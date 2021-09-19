using System;
namespace EnergoUchet_Core.Models
{
    public class DispetcherData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } //Дата
        public int ProcessWater { get; set; } //Техническая вода
        public int ReturnedCondensateCounter { get; set; } //Возвращенный конденсат, счетчик
        public double ReturnedCondensateT { get; set; } //Возвращенный конденсат, температура
        public int Electricity { get; set; } //Электроэнергия
    }
}
