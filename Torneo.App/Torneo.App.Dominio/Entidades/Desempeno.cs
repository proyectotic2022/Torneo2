using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Torneo.App.Dominio
{
    public class Desempeno{
        public int id{get;set;}

        [Required(ErrorMessage = "El campo es obligatorio")]
        public int partidosJ {get;set;}
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int partidosG {get;set;}
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string partidosE{get;set;}
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string partidosP{get;set;}
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string golesaFavor{get;set;}
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string golesEnContra{get;set;}
    }
}