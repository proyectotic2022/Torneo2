using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioPosicion : IRepositorioPosicion
    {
        private readonly AppContext _appContext = new AppContext();

        //Crear posicion
        public Posicion AddPosicion(Posicion posicion)
        {
            var posicionAdicionado = _appContext.Posiciones.Add(posicion);
            _appContext.SaveChanges();
            return posicionAdicionado.Entity;
        }

        //Eliminar posicion
        public void DeletePosicion(int id)
        {
            var posicionEncontrado = _appContext.Posiciones.Find(id);
            if (posicionEncontrado == null)
                return;
            _appContext.Posiciones.Remove(posicionEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todas las posiciones
        public IEnumerable<Posicion> GetAllPosiciones()
        {
            return _appContext.Posiciones;
        }

        //Mostrar una posicion
        public Posicion GetPosicion(int id)
        {
            return _appContext.Posiciones.Find(id);
        }

        //Actualizar posicion
        public Posicion UpdatePosicion(Posicion posicion)
        {
            var posicionEncontrado = _appContext.Posiciones.Find(posicion.id);
            if (posicionEncontrado != null)
            {
                posicionEncontrado.nombre = posicion.nombre;
                _appContext.SaveChanges();              
            }
            return posicionEncontrado;
        }
    }
}