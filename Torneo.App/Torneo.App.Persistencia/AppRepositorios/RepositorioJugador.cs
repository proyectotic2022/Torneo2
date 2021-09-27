using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly AppContext _appContext;

        public RepositorioJugador(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Agregar jugador
        public Jugador AddJugador(Jugador jugador)
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }

        //Eliminar jugador
        public void DeleteJugador(int id)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(id);
            if (jugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos los jugadores
        public IEnumerable<Jugador> GetAllJugadores()
        {
            return _appContext.Jugadores;
        }

        //Mostrar un jugador
        public Jugador GetJugador(int id)
        {
            return _appContext.Jugadores.Find(id);
        }

        //Actualizar jugador
        public Jugador UpdateJugador(Jugador jugador, Equipo equipo, Posicion posicion)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(jugador.id);
            var idEquipo = _appContext.Equipos.Find(equipo.id);
            var idPosicion = _appContext.Posiciones.Find(posicion.id);
            if (jugadorEncontrado != null)
            {
                jugadorEncontrado.nombre = jugador.nombre;
                jugadorEncontrado.numero = jugador.numero;
                idEquipo.id = equipo.id;
                idPosicion.id = posicion.id;
                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }
    }
}