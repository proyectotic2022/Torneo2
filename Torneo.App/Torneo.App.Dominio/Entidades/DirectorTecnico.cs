using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Torneo.App.Dominio
{
    public class DirectorTecnico{
        public int id {get;set;}
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string nombre {get;set;}
        [Display(Name = "Documento")]
        [Required(ErrorMessage = "El documento es obligatorio")]
        public int documento{get;set;}
        [Display(Name = "Documento")]
        public int telefono {get;set;}        
    }
}