using System.Collections.Generic;
namespace Torneo.App.Dominio
//aqui ya me quedo bien su tabla de base de datos

{
    public class Novedad{
        public  int  id { get ; set ;}
        public  string  tipoDeNovedad { get ; set ;}
        public  int  minutoNovedad { get ; set ;}
        public  Jugador  jugador { get ; set ;}
    }
}

/*public int id{get;set;}
        public string nombre {get;set;}
        public int minuto{get;set;}
        public List<Jugador> Jugadores {get;set;}*/