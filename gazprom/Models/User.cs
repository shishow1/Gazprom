using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gazprom.Models
{
    public class User
    {
        [Display(Name = "Код")]
        public int Id { get; set; }

        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Должность")]
        public string Post { get; set; }

        [Display(Name = "Роль")]
        public int? RoleId { get; set; }

        [Display(Name = "Роль")]
        public Role Role { get; set; }
    }
}
