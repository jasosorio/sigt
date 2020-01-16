using System.ComponentModel.DataAnnotations;

namespace sigt.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo Usuario es requerido")]
        //[EmailAddress]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es requerido")]
        [MinLength(6, ErrorMessage = "La contraseña debe contener minimo 6 caracteres")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}

