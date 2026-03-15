using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Polaris.Modelo
{
    public class UsuarioRegister
    {

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(10, ErrorMessage = "El nombre debe tener al menos 10 caracteres")]
        public string Name { get; set; } = "";

        [DisplayName("Correo Electronico")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del correo no es válido")]
        public string Email { get; set; } = "";

        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "La contraseña es obligatoria")]

        [MinLength(8, ErrorMessage = "Debe de ser mas de 8 caracteres")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=(?:.*\d){2,})(?=.*[#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?!]).{8,}$",
    ErrorMessage = "La contraseña debe tener al menos: 1 mayúscula, 1 minúscula, 2 números y un carácter especial.")]
        public string Password { get; set; } = "";

        [DisplayName("Repite la Contraseña")]
        [NotMapped]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Debes repetir la contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        [MinLength(8, ErrorMessage = "Debe de ser mas de 8 caracteres")]
        public string RPassword { get; set; } = "";

        [DisplayName("Proyecto de Interes")]
        [Required(ErrorMessage = "Por favor, selecciona un proyecto")]
        public int Proyecto { get; set; } = 0;
    }
}
