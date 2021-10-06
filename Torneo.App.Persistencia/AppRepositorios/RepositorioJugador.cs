using System.Collections.Generic;
using Torneo.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Torneo.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {

        private readonly AppContext _appContext = new AppContext();

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
            var jugador = _appContext.Jugadores
            .Where(e => e.id == id)
            .Include(e => e.equipo)
            .FirstOrDefault();
            jugador = _appContext.Jugadores
            .Where(e => e.id == id)
            .Include(e => e.posicion)
            .FirstOrDefault();       
            return _appContext.Jugadores.Find(id);
        }

        //Actualizar jugadores
        public Jugador UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(jugador.id);
            if (jugadorEncontrado != null)
            {
                jugadorEncontrado.nombre = jugador.nombre;
                jugadorEncontrado.numero = jugador.numero;
                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }
        // Asignar Equipo a Jugador
        public Equipo AsignarJugador_Equipo(int id_jugador, int id_equipo)
        {
            var j_encontrado=_appContext.Jugadores.FirstOrDefault(j=>j.id==id_jugador);
            if(j_encontrado!= null)
            {
             var e_encontrado=_appContext.Equipos.FirstOrDefault(e=>e.id==id_equipo);
             if(e_encontrado!=null)
             {
               j_encontrado.equipo=e_encontrado;
               _appContext.SaveChanges();
             }
             return e_encontrado;
            }
            return null;
        }
        // Asignar Posicion a Jugador
        public Posicion AsignarPosicion_Jugador(int id_jugador, int id_posicion)
        {
            var j_encontrado=_appContext.Jugadores.FirstOrDefault(p=>p.id==id_jugador);
            if(j_encontrado!= null)
            {
             var p_encontrado=_appContext.Posiciones.FirstOrDefault(j=>j.id==id_posicion);
             if(j_encontrado!=null)
             {
               j_encontrado.posicion=p_encontrado;
               _appContext.SaveChanges();
             }
             return p_encontrado;
            }
            return null;
        }        

    }
}