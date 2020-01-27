using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gazprom.Models
{
    public class IncomeAndExpense
    {
        [Display(Name = "Код")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Значение")]
        public double Value { get; set; } // >= 0 - income, < 0 - expense

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Емкость")]
        public int FuelTankId { get; set; }

        [Display(Name = "Емкость")]
        public FuelTank FuelTank { get; set; }

        [Display(Name = "Оператор")]
        public User User { get; set; }

        [Required]
        [Display(Name = "Оператор")]
        public int UserId { get; set; }
    }
}
