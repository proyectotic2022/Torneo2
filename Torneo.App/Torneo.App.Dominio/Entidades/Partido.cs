using System.Collections.Generic;

namespace Torneo.App.Dominio
{
    public class Partido{
        public int id{get;set;}
        public string nombre {get;set;}
        public string fecha{get;set;}
        public int marcadorInicalEL {get;set;}
        public string marcadorInicialEV{get;set;}
        public Arbitro arbitros { get; set; }
        public Equipo equipoa{get;set;}
        public Equipo equipob{get;set;}
        public Estadio estadio{get;set;}

    }
}