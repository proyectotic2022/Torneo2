using System;
using System.Collections.Generic;


namespace Torneo.App.Dominio
{
    public class Jugador{
        
        public  int  id { get ; set ;}
        public  string  nombreJugador { get ; set ;}  //nombre
        public  string  numeroJugador { get ; set ;}  //apellido
        public  Posicion  posicion { get ; set ;}
        public  Equipo  Equipo { get ; set ;}
    }
}

/*public int id{get;set;}
        public string nombre {get;set;}
        public int numero{get;set;}
        public List<Equipo> Equipos {get;set;}
        public List<Posicion> Posiciones {get;set;}*/