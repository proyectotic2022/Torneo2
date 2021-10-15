using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class Posicion
    {
        public int id{get;set;}
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "Maximo 10 caracteres")]
        [Display(Name ="Posicion")]
        public string nombre {get;set;}
        
    }    
}