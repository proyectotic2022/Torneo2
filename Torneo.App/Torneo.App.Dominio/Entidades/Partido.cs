using System;
using System.Collections.Generic;
//ya esta bien su tabla de base de datos 
namespace Torneo.App.Dominio
{
    public  class Partido{
        public  int  id { get ; set ;}
        public  DateTime  fechaPartido { get ; set ;}
        public  string horaPartido { get ; set ;}
        public  int  equipoLocal { get ; set ;}
        public  int  equipoVisitante { get ; set ;}
        public  int  marcadorInicialEL { get ; set ;}
        public  int  marcadorInicialEV { get ; set ;}
        public  Arbitro  Arbitro { get ; set ; }
        public  Estadio   estadio { get ; set ;}
        public  Novedad  Novedad { get ; set ;}


    }
}

/*public int id {get;set;}
        public string nombre {get;set;}
        public string fecha{get;set;}
        public int marcadorInicialEL {get;set;}
        public string  marcadorInicialEV {get;set;}
        public List<Arbitro> Arbitros {get;set;}
        public List<Novedad> Novedades {get;set;}*/