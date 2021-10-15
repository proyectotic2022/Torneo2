using System;
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
        [Required(ErrorMessage = "El numero es obligatorio")]
        public int numero{get;set;}
        public Equipo equipo {get; set;}
        public Posicion posicion {get; set;}
        
    }
}