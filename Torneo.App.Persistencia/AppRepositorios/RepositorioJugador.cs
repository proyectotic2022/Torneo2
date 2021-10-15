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
        // Se define el metodo buscar Jugador

        IEnumerable<Jugador> IRepositorioJugador.SearchJugador(string nombre)
        {
            return _appContext.Jugadores
                .Where(j => j.nombre.Contains(nombre));
        }        

        //Mostrar un jugador
        Jugador IRepositorioJugador.GetJugador(int id)
        {
            var jugador = _appContext.Jugadores
                .Where(j => j.id == id)
                .Include(j => j.equipo)
                .Include(j => j.posicion)
                .FirstOrDefault();
            return jugador;
        }

        //Actualizar jugadores
        Jugador IRepositorioJugador.UpdateJugador(Jugador jugador)
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
        Equipo IRepositorioJugador.AsignarJugador_Equipo(int id_jugador, int id_equipo)
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
        // Asignar Posicion a Jugador ------ Se edita
        Posicion IRepositorioJugador.AsignarPosicion_Jugador(int id_jugador, int id_posicion)
        {
            var j_encontrado=_appContext.Jugadores.FirstOrDefault(j=>j.id==id_jugador);
            if(j_encontrado!= null)
            {
             var p_encontrado=_appContext.Posiciones.FirstOrDefault(p=>p.id==id_posicion);
             if(p_encontrado!=null)
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