using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioNovedad : IRepositorioNovedad
    {
        private readonly AppContext _appContext;

        public RepositorioNovedad(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Agregar novedad
        public Novedad AddNovedad(Novedad novedad)
        {
            var novedadAdicionada = _appContext.Novedades.Add(novedad);
            _appContext.SaveChanges();
            return novedadAdicionada.Entity;
        }

        //Eliminar novedad
        public void DeleteNovedad(int id)
        {
            var novedadEncontrada = _appContext.Novedades.Find(id);
            if (novedadEncontrada == null)
                return;
            _appContext.Novedades.Remove(novedadEncontrada);
            _appContext.SaveChanges();
        }

        //Mostrar todas las novedades
        public IEnumerable<Novedad> GetAllNovedades()
        {
            return _appContext.Novedades;
        }

        //Mostrar una novedad
        public Novedad GetNovedad(int id)
        {
            return _appContext.Novedades.Find(id);
        }

        //Actualizar novedad
        public Novedad UpdateNovedad(Novedad novedad, Jugador jugador)
        {
            var novedadEncontrada = _appContext.Novedades.Find(novedad.id);
            var idJugador = _appContext.Jugadores.Find(jugador.id);
            if (novedadEncontrada != null)
            {
                novedadEncontrada.nombre = novedad.nombre;
                novedadEncontrada.minuto = novedad.minuto;
                idJugador.id = jugador.id;
                _appContext.SaveChanges();
            }
            return novedadEncontrada;
        }
    }
}