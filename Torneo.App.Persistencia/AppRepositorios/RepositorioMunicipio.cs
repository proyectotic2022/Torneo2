using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();

        //Crear municipio
        public Municipio AddMunicipio(Municipio municipio)
        {
            var municipioAdicionado = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return municipioAdicionado.Entity;
        }

        //Eliminar municipio
        public void DeleteMunicipio(int id)
        {
            var municipioEncontrado = _appContext.Municipios.Find(id);
            if (municipioEncontrado == null)
                return;
            _appContext.Municipios.Remove(municipioEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos los municipios
        public IEnumerable<Municipio> GetAllMunicipios()
        {
            return _appContext.Municipios;
        }

        //Mostrar un municipio
        public Municipio GetMunicipio(int id)
        {
            return _appContext.Municipios.Find(id);
        }

        //Actualizar municipio
        public Municipio UpdateMunicipio(Municipio municipio)
        {
            var municipioEncontrado = _appContext.Municipios.Find(municipio.id);
            if (municipioEncontrado != null)
            {
                municipioEncontrado.nombre = municipio.nombre;
                _appContext.SaveChanges();              
            }
            return municipioEncontrado;
        }
    }
}