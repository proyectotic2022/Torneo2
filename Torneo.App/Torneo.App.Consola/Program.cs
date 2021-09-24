using System;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioArbitro _RepositorioArbitro= new RepositorioArbitro();
        static void Main(string[] args)
        {

            int opcion;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Insertar");
            Console.WriteLine("4. Editar");
            Console.WriteLine("Digite opcion");
            opcion=int.Parse(Console.ReadLine());
            switch (opcion)
            {
            case 1: 
                      mostrarArbitro();
            break;
            case 2: 
               int codigo;
               Console.WriteLine("Digite codigo Albitro");
               codigo= int.Parse(Console.ReadLine());
               BuscarArbitro(codigo);
             break;
             case 3: 
              int telefono, documento;
              String nombre , colegio;
              Console.WriteLine("Digite Nombre");
              nombre=(Console.ReadLine());
              Console.WriteLine("Digite Documento");
              documento=int.Parse(Console.ReadLine());
              Console.WriteLine("Digite Telefono");
              telefono=int.Parse(Console.ReadLine());
              Console.WriteLine("Digite Colegio");
              colegio=Console.ReadLine();
              AdicionarArbitro(nombre,documento,telefono,colegio);
            
            break;
            case 4: 

            case 5:
            default:
            break;
            }
            
        }

        private static void mostrarArbitro()
        {

            var arbitros= _RepositorioArbitro.GetAllArbitros();
            foreach (var arbitro in arbitros)
            {
                Console.WriteLine(arbitro.nombre+ " " + arbitro.documento +" "+ arbitro.telefono +" "+ arbitro.colegio);
            }
             
        }
        
        private static void BuscarArbitro(int id)
        {
            var arbitros = _RepositorioArbitro.GetArbitro(id);
            
                Console.WriteLine(arbitros.nombre+" " + arbitros.documento +" " + arbitros.telefono +" "+ arbitros.colegio);
            

        }
        private static void AdicionarArbitro(String nombre, int documento, int tel, String colegio)
        {
            var arbitro= new Arbitro
            {
            nombre=nombre,
            documento=documento,
            telefono=tel,
            colegio=colegio

            };
            _RepositorioArbitro.AddArbitro(arbitro);
            
        }
    }
}
