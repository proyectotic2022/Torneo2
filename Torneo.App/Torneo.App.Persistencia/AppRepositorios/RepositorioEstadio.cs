using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();

        //Agregar estadio
        public Estadio AddEstadio(Estadio estadio)
        {
            var estadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        }

        //Eliminar estadio
        public void DeleteEstadio(int id)
        {
            var estadioEncontrado = _appContext.Estadios.Find(id);
            if (estadioEncontrado == null)
                return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos los estadios
        public IEnumerable<Estadio> GetAllEstadios()
        {
            return _appContext.Estadios;
        }

        //Mostrar un estadio
        public Estadio GetEstadio(int id)
        {
            return _appContext.Estadios.Find(id);
        }

        //Actualizar estadio
        public Estadio UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(estadio.id);
            //var idMunicipio = _appContext.Municipios.Find(municipio.id);
            if (estadioEncontrado != null)
            {
                estadioEncontrado.nombre = estadio.nombre;
                estadioEncontrado.direccion = estadio.direccion;
                //idMunicipio.id = municipio.id;
                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }
    }
}