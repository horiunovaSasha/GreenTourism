using System.ComponentModel.DataAnnotations;

namespace GreenTourism.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}