using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioJugador
    {
        IEnumerable<Jugador> GetAllJugadores();
        Jugador AddJugador(Jugador jugador);
        Jugador UpdateJugador(Jugador jugador, Equipo equipo, Posicion posicion);
        void DeleteJugador(int id);    
        Jugador GetJugador(int id);
    }
}