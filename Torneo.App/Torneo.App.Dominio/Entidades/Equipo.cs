using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Torneo.App.Dominio
{
    public class Equipo
    {
        public int id{get;set;}
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string nombre {get;set;}        
        public DirectorTecnico directorTecnico { get; set; }
        //public List<Jugador> jugador { get; set; }
        public Municipio municipio {get;set;}
        public Desempeno desempeno {get;set;}        
    }
}