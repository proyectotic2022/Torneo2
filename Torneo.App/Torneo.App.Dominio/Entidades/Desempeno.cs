using  System;
using  System.Collections.Generic;

namespace  Torneo . App . Dominio
{
     public class Desempeno {
        public  int  id { get ; set ;}
        public  Equipo  Equipo { get ; set ;}
        public List < Partido > Partidos { get ; set ;}
        public int partidosJ {get; set;}
        public  int  partidosG { get ; set ;}
        public  int  partidosP { get ; set ;}
        public  int  partidosE { get ; set ;}        
        public  int  golesAFavor { get ; set ;}
        public  int  golesEnContra { get ; set ;}
        public  int  puntos { get ; set ;}
    }
}