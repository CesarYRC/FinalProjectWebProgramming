using System.ComponentModel.DataAnnotations;

namespace FinalProjectBikes.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Debe ser un correo valido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El modelo es requerido")]
        [StringLength(20, ErrorMessage = "Maximo 100 caracteres")]
        public string? ModelBike { get; set; }

    }
}
