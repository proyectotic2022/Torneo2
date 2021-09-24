using System.Collections.Generic;
namespace Torneo.App.Dominio
{
    public class Novedad{
        public int id{get;set;}
        public string nombre {get;set;}
        public int minuto{get;set;}
        public Jugador jugador { get; set; }
    }
}