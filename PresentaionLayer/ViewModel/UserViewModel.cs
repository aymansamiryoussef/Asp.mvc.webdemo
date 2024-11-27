using System.ComponentModel.DataAnnotations;

namespace WEBDEMO.ViewModel
{
    public class UserViewModel
    {
        [Required]
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Cant match")]
        public string ConfirmPassword { get; set; }
    }
}
