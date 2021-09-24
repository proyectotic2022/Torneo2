using System.Collections.Generic;
namespace Torneo.App.Dominio
{
    public class Torneos{
        public int id{get;set;}
        public string nombre {get;set;}
        public List<Partido> partidos{get;set;}
    }
}