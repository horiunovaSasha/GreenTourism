using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenTourism.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Логін")]
        public string Email { get; set; }
 
        [Required]
        [StringLength(100, ErrorMessage = "Пароль має бути мінімум {2} символів і максимум {1} символів.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
 
        [DataType(DataType.Password)]
        [Display(Name = "Підтвердити пароль")]
        [Compare("Password", ErrorMessage = "Підтверджений пароль не збігається з введеним паролем.")]
        public string ConfirmPassword { get; set; }
    }
}