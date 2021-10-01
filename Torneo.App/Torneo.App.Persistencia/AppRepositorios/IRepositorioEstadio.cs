using  System . Collections . Generic ;
using  Torneo . App . Dominio;

namespace  Torneo . App . Persistencia
{
    public interface IRepositorioEstadio {

            IEnumerable < Estadio > GetAllEstadios ();

            Estadio  AddEstadio ( Estadio  estadio );

            Estadio  UpdateEstadio ( Estadio  estadio , Municipio municipio);

            void  DeleteEstadio ( int  id ); 

            Estadio  GetEstadio ( int  id );

            Municipio AsignarMunicipio (int id_estadio , int id_municipio);
    }
    
}

