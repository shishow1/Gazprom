using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gazprom.Models
{
    public class FuelTank
    {
        [Display(Name = "Код")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Объем емкости")]
        public double Size { get; set; }

        [Required]
        [Display(Name = "Занято")]
        public double Value { get; set; }

        [Required]
        [Display(Name = "Тип ГСМ")]
        public int FuelId { get; set; }

        [Display(Name = "ГСМ")]
        public Fuel Fuel { get; set; }
        public IEnumerable<IncomeAndExpense> IncomesAndExpenses { get; set; }
    }
}
