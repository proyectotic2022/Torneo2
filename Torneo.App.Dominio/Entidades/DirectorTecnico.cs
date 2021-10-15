using System;
using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class DirectorTecnico
    {
        public int id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string nombre { get; set; }

        [Display(Name = "Documento")]
        [Required(ErrorMessage = "El número de documento es obligatorio")]
        public int documento { get; set; }

        [Required(ErrorMessage = "El número de telefono es obligatorio")]
        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public int telefono { get; set; }

    }
}