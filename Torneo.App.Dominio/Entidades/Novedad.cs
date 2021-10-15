using System;
using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class Novedad{
        public int id{get;set;}
        [Display(Name ="Novedad(Tarjeta Amarilla, Roja o Gol)")]
        [Required(ErrorMessage = "El campo novedad es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]        
        public string nombre {get;set;}
        [Display(Name ="Minuto Novedad")]
        //[Range(1, 100, ErrorMessage = "El campo {0} debe ser un número entre {1} y {2}")]
        public int minuto{get;set;}
        public Jugador jugador { get; set; }
    }
}