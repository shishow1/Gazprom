using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gazprom.Models
{
    public class Fuel
    {
        [Display(Name = "Код")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Тип")]
        public string Name { get; set; } //type

        [Required]
        [Display(Name = "Характеристика")]
        public string Description { get; set; } //characteristic

        public virtual List<Price> Prices { get; set; }
        public virtual List<FuelTank> FuelTanks { get; set; }
    }
}
