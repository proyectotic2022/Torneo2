using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class Jugador{
        public int id{get;set;}
        [Display(Name ="Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string nombre {get;set;}
        [Display(Name ="Número")]
        public int numero{get;set;}
        [Display(Name ="Equipo")]
        public Equipo equipo {get; set;}
        [Display(Name ="Posicion")]
        public Posicion posicion {get; set;}
        
    }
}