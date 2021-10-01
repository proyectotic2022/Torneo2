using  System . Collections . Generic ;
using  Torneo . App . Dominio ;

namespace  Torneo . App . Persistencia
{
    public class Repositorioposicion : IRepositorioposicion
    {
        //este es el constructor
        private  readonly  AppContext  _appContext  =  new  AppContext ();

    
         
        //Aqui agrego la posicion
       public  Posicion  AddPosicion ( Posicion  posicion )
        {
            var  posicionAdicionado  =  _appContext . Posiciones . Add ( posicion );
            _appContext . SaveChanges (); //Guardo 
            return  posicionAdicionado . Entity ;
        }
        
        //Aqui elimino la posicion
        //Al chocar creo que me va chocar porque en todas las entidades el atributo se llama ID
        public  void  DeletePosicion ( int  id )  //aqui se supone que estoy llamando id posicion 
        {
           var  posicionEncontrado  =  _appContext . Posiciones . Find ( id ); //aqui nuevamente se supone que id posicion
            if ( posicionEncontrado  ==  null )
                return ;
            _appContext . Posiciones . Remove ( posicionEncontrado );
            _appContext . SaveChanges (); //Guardo 
        }

        public  IEnumerable < Posicion > GetAllPosiciones ()
        {
            return _appContext . Posiciones  ;
        }

        public  Posicion  GetPosicion ( int  id ) //aqui id posicion 
        {
            return _appContext . Posiciones . Find ( id );
        }

         public Posicion   UpdatePosicion ( Posicion  posicion )
        {
            var  posicionEncontrado  =  _appContext . Posiciones . Find ( posicion . id ); //Id posicion 
            if ( posicionEncontrado  !=  null )
            {
                /*Aqui traigo todos los campos a excepacion de la llave primaria porque la llave primaria no
                se puede modificar*/
                posicionEncontrado . nombreposicion  =  posicion . nombreposicion ;
                _appContext . SaveChanges (); //Guardo 
            }
            return  posicionEncontrado ;
        }
    }
}