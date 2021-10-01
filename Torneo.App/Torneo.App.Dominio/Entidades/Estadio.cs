using System;
using System.Collections.Generic;
namespace Torneo.App.Dominio
//Esta tabla quedo lista 

{
    public class Estadio
    {
        
        public  int  id { get ; set ;}
        public  string  nombreEstadio { get ; set ;}
        public  string direccionEstadio { get ; set ;}
        public  Municipio  municipio { get ; set ;} //Aqui inserto mi objeto tipo A
        

    
    }
}

