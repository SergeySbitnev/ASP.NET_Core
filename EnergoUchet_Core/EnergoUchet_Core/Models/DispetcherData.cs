using System;
namespace EnergoUchet_Core.Models
{
    public class DispetcherData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } //Дата
        public int processWater { get; set; } //Техническая вода
        public int returnedCondensateCounter { get; set; } //Возвращенный конденсат, счетчик
        public double returnedCondensateT { get; set; } //Возвращенный конденсат, температура
        public int electricity { get; set; } //Электроэнергия
    }
}
