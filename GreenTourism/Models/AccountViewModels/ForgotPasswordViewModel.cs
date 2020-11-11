using System.ComponentModel.DataAnnotations;

namespace GreenTourism.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Електронна пошта")]
        public string Email { get; set; }
    }
}