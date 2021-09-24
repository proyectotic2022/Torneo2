using System.Collections.Generic;
namespace Torneo.App.Dominio
{  public class Municipio 
    {
        public int id{get;set;}
        public string nombre {get;set;}
          public List<Equipo> Equipos { get; set; }
    }
}