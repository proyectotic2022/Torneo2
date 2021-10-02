using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioDesempeno : IRepositorioDesempeno
    {
        private readonly AppContext _appContext = new AppContext();

        //Agregar desempeno
        public Desempeno AddDesempeno(Desempeno desempeno)
        {
            var desempenoAdicionado = _appContext.Desempenos.Add(desempeno);
            _appContext.SaveChanges();
            return desempenoAdicionado.Entity;
        }

        //Eliminar desempeno
        public void DeleteDesempeno(int id)
        {
            var desempenoEncontrado = _appContext.Desempenos.Find(id);
            if (desempenoEncontrado == null)
                return;
            _appContext.Desempenos.Remove(desempenoEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos los desempeno
        public IEnumerable<Desempeno> GetAllDesempenos()
        {
            return _appContext.Desempenos;
        }

        //Mostrar un desempeno
        public Desempeno GetDesempeno(int id)
        {
            return _appContext.Desempenos.Find(id);
        }

        //Actualizar desempeno
        public Desempeno UpdateDesempeno(Desempeno desempeno, Partido partido)
        {
            var desempenoEncontrado = _appContext.Desempenos.Find(desempeno.id);
            var PartidosJ = _appContext.Partidos.Find(partido.id);
            if (desempenoEncontrado != null)
            {
                PartidosJ.id = partido.id;
                //desempenoEncontrado.partidosJ = desempeno.partidosJ;
                desempenoEncontrado.partidosG = desempeno.partidosG;
                desempenoEncontrado.partidosE = desempeno.partidosE;
                desempenoEncontrado.partidosP = desempeno.partidosP;
                desempenoEncontrado.golesaFavor = desempeno.golesaFavor;
                desempenoEncontrado.golesEnContra = desempeno.golesEnContra;
                //desempenoEncontrado.puntos = desempeno.puntos;
                _appContext.SaveChanges();
            }
            return desempenoEncontrado;
        }
    }
}