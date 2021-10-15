using System;
using System.Collections.Generic;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioJugador
    {
        IEnumerable<Jugador> GetAllJugadores();
        IEnumerable<Jugador> SearchJugador(string nombre);
        Jugador AddJugador(Jugador jugador);
        Jugador UpdateJugador(Jugador jugador);
        void DeleteJugador(int id);    
        Jugador GetJugador(int id);
        Equipo AsignarJugador_Equipo(int id_jugador, int id_equipo);
        Posicion AsignarPosicion_Jugador(int id_jugador, int id_posicion);
    }
}