using System.ComponentModel.DataAnnotations;

namespace WEBDEMO.ViewModel
{
    public class LoginUserViewModel
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool remmberme { get; set; }
    }
}
