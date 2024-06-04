using System.ComponentModel.DataAnnotations;

namespace Medico.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del medicamento es requerido")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El precio del medicamento es requerido")]
        public float Precio { get; set; } = 0.0f;
        public int Stock { get; set; } = 0;
        public string? Observaciones { get; set; }
    }
}
