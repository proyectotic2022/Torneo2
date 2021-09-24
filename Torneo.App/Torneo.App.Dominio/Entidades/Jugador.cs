using System.Collections.Generic;


namespace Torneo.App.Dominio
{
    public class Jugador{
        public int id{get;set;}
        public string nombre {get;set;}
        public int numero{get;set;}
        public Equipo equipo { get; set; }
        public Posicion posicion { get; set; }
    }
}