using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gazprom.Models
{
    public class Price
    {
        [Display(Name = "Код")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Тип ГСМ")]
        public int FuelId { get; set; }

        public Fuel Fuel { get; set; }

        [Required]
        [Display(Name = "Цена за 1 литр")]
        public double PricePerLiter { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
    }
}
