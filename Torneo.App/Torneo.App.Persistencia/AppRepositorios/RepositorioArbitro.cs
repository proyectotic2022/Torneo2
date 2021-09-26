using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext  _appContext= new AppContext();

        /*public RepositorioArbitro(AppContext appContext)
        {
            _appContext = appContext;
        }*/

        //Agregar arbitro
        public Arbitro AddArbitro(Arbitro arbitro)
        {
            var arbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        }

        //Eliminar arbitro
        public void DeleteArbitro(int id)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(id);
            if (arbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos los arbitros
        public IEnumerable<Arbitro> GetAllArbitros()
        {
            return _appContext.Arbitros;
        }

        //Mostrar un arbitro
        public Arbitro GetArbitro(int id)
        {
            return _appContext.Arbitros.Find(id);
        }

        //Actualizar arbitro
        public Arbitro UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(arbitro.id);
            if (arbitroEncontrado != null)
            {
                arbitroEncontrado.nombre = arbitro.nombre;
                arbitroEncontrado.documento = arbitro.documento;
                arbitroEncontrado.telefono = arbitro.telefono;
                arbitroEncontrado.colegio = arbitro.colegio;
                _appContext.SaveChanges();              
            }
            return arbitroEncontrado;
        }
    }
}