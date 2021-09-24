using System.Collections.Generic;
namespace Torneo.App.Dominio
{
    public class Equipo{
        public int id{get;set;}
        public string nombre {get;set;}
        public DirectorTecnico diretoresTecnico { get; set; }
        public List<Jugador> jugador { get; set; }
        public Municipio municipio{get;set;}
        public Desempeno desempeno{get;set;}
    }
}