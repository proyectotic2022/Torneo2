using System.Collections.Generic;
using Torneo.App.Dominio;
using System.Linq;

namespace Torneo.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext= new AppContext();

        //Agregar DT
        public DirectorTecnico AddDT(DirectorTecnico directortecnico)
        {
            var DTAdicionado = _appContext.DirectoresTecnicos.Add(directortecnico);
            _appContext.SaveChanges();
            return DTAdicionado.Entity;
        }

        //Eliminar DT
        public void DeleteDT(int id)
        {
            var DTEncontrado = _appContext.DirectoresTecnicos.Find(id);
            if (DTEncontrado == null)
                return;
            _appContext.DirectoresTecnicos.Remove(DTEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos los DT
        public IEnumerable<DirectorTecnico> GetAllDT()
        {
            return _appContext.DirectoresTecnicos;
        }

        //Mostrar un DT
        public DirectorTecnico GetDT(int id)
        {
            return _appContext.DirectoresTecnicos.Find(id);
        }

        //Actualizar DT
        public DirectorTecnico UpdateDT(DirectorTecnico directortecnico)
        {
            var DTEncontrado = _appContext.DirectoresTecnicos.Find(directortecnico.id);
            if (DTEncontrado != null)
            {
                DTEncontrado.nombre = directortecnico.nombre;
                DTEncontrado.documento = directortecnico.documento;
                DTEncontrado.telefono = directortecnico.telefono;
                _appContext.SaveChanges();
            }
            return DTEncontrado;
        }
    }
}