using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Torneo.App.Dominio
{  
    public class Municipio 
    {
        public int id{get;set;}
        [Display(Name = "Nombre municipio")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string nombre {get;set;}
        public List<Equipo> Equipos { get; set; }
    }
}