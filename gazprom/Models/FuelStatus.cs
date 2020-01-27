using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gazprom.Models
{
    public class FuelStatus
    {
        [Display(Name = "Код")]
        public int Id { get; set; }

        [Display(Name = "Тип")]
        public string Name { get; set; } //type

        [Display(Name = "Характеристика")]
        public string Description { get; set; } //characteristic

        [Display(Name = "Цена за литр")]
        public double PricePerLiter { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата выставления цены")]
        public DateTime Date { get; set; }

        [Display(Name = "Общий объем")]
        public double Value { get; set; }

        [Display(Name = "Емкости")]
        public virtual List<FuelTank> FuelTanks { get; set; }
    }
}
