using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioNovedad : IRepositorioNovedad
    {
        private readonly AppContext _appContext = new AppContext();

        //Crear novedad
        public Novedad AddNovedad(Novedad novedad)
        {
            var novedadAdicionado = _appContext.Novedades.Add(novedad);
            _appContext.SaveChanges();
            return novedadAdicionado.Entity;
        }

        //Eliminar novedad
        public void DeleteNovedad(int id)
        {
            var novedadEncontrado = _appContext.Novedades.Find(id);
            if (novedadEncontrado == null)
                return;
            _appContext.Novedades.Remove(novedadEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos las novedaes
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