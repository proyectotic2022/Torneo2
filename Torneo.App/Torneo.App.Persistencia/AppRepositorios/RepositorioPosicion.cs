using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioPosicion : IRepositorioPosicion
    {
        private readonly AppContext  _appContext= new AppContext();

        //Agregar posicion
        public Posicion AddPosicion(Posicion posicion)
        {
            var posicionAdicionada = _appContext.Posiciones.Add(posicion);
            _appContext.SaveChanges();
            return posicionAdicionada.Entity;
        }

        //Eliminar posicion
        public void DeletePosicion(int id)
        {
            var posicionEncontrada = _appContext.Posiciones.Find(id);
            if (posicionEncontrada == null)
                return;
            _appContext.Posiciones.Remove(posicionEncontrada);
            _appContext.SaveChanges();
        }

        //Mostrar todos las posiciones
        public IEnumerable<Posicion> GetAllPosiciones()
        {
            return _appContext.Posiciones;
        }

        //Mostrar una posicion
        public Posicion GetPosicion(int id)
        {
            return _appContext.Posiciones.Find(id);
        }

        //Actualizar municipio
        public Posicion UpdatePosicion(Posicion posicion)
        {
            var posicionEncontrada = _appContext.Posiciones.Find(posicion.id);
            if (posicionEncontrada != null)
            {
                posicionEncontrada.nombre = posicion.nombre;
                _appContext.SaveChanges();
            }
            return posicionEncontrada;
        }
    }
}