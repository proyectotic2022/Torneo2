using System.Collections.Generic;
namespace Torneo.App.Dominio
//ya quedo bien su tabla

{
    public class Equipo{
        public  int  id { get ; set ;}
        public  string  nombreEquipo { get ; set ;}
        public  Municipio  Municipio { get ; set ;}
        public  DirectorTecnico  DirectorTecnico { get ; set ; }
    }
}

/*public class Equipo{
        public int id{get;set;}
        public string nombre{get;set;}
        public string partidos {get;set;}
        //como no se que variable corresponde a partidosJ la pondre string
        public string partidosJ {get;set;}
        public int partidosG {get;set;}
        public string partidosE{get;set;}
        public string partidosP{get;set;}
        public string golesaFavor {get;set;}
        public string golesEnContra{get;set;}
        public List <DirectorTecnico> DirectoresTecnicos {get;set;}
        public List<Partido> Partidos{get;set;}*/
