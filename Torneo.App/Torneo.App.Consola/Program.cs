using System;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioArbitro _RepositorioArbitro = new RepositorioArbitro();
        private static IRepositorioMunicipio _RepositorioMunicipio = new RepositorioMunicipio();
        static void Main(string[] args)
        {

            int opcion;
            do{
            Console.WriteLine("Bienvenido ingrese su menu deseado");
            Console.WriteLine("1. Municipio");
            Console.WriteLine("2. Arbitro ");
            Console.WriteLine("3.  ");
            Console.WriteLine("4.  ");
            Console.WriteLine("5.  ");
            Console.WriteLine("6.  ");
            Console.WriteLine("7.  ");
            Console.WriteLine("8.  ");
            Console.WriteLine("9.  ");
            Console.WriteLine("10. ");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Ingrese su menu deseado");
            opcion = int.Parse(Console.ReadLine());


                switch(opcion){

                    case 1: 
                            int operacion1;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de municipio");
                                Console.WriteLine("1.  Insertar municipio");
                                Console.WriteLine("2.  Buscar municipio");
                                Console.WriteLine("3.  Mostrar munipio");
                                Console.WriteLine("4.  Actualizar municipio");
                                Console.WriteLine("5.  Eliminar municipio");
                                Console.WriteLine("0.  Salir del municipio");
                                Console.WriteLine("Ingrese la operación que desea ejecutar");
                                operacion1 = int.Parse(Console.ReadLine());

                                switch(operacion1){

                                    case 1: 
                                        String nombreMun;
                                        Console.WriteLine("Digite nombre Municipio");
                                        nombreMun = (Console.ReadLine());
                                        AdicionarMunicipio(nombreMun);
                                    break;

                                    case 2:
                                        int codigoMun;
                                        Console.WriteLine("Digite codigo Municipio");
                                        codigoMun = int.Parse(Console.ReadLine());
                                        BuscarMunicipio(codigoMun);
                                    break;

                                    case 3: 
                                        mostrarMunicipio();
                                    break;

                                    case 4: 
                                        int idMuni;
                                        String nombreMuni;
                                        Municipio objmunicipio = new Municipio();
                                        Console.WriteLine("Digite ID a editar");
                                        idMuni = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo nombre");
                                        nombreMuni = (Console.ReadLine());
                                        objmunicipio.id = idMuni;
                                        objmunicipio.nombre = nombreMuni;
                                        ModificarMunicipio(objmunicipio);
                                    break;

                                    case 5: 
                                        int id2;
                                        Console.WriteLine("Digite ID a eliminar");
                                        id2 = int.Parse(Console.ReadLine());
                                        EliminarMunicipio(id2);
                                    break;
                      
                                }//cierre swich municipio
                            }while ( operacion1 != 0); 
                    break;
                    case 2: 
                            int operacion2;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de Arbitro");
                                Console.WriteLine("1.  Insertar Arbitro");
                                Console.WriteLine("2.  Buscar Arbitro");
                                Console.WriteLine("3.  Mostrar Arbitro");
                                Console.WriteLine("4.  Actualizar Arbitro");
                                Console.WriteLine("5.  Eliminar Arbitro");
                                Console.WriteLine("0.  Salir opción Arbitro");
                                Console.WriteLine("Ingrese la operación que desea ejecutar");
                                operacion2 = int.Parse(Console.ReadLine());

                                switch(operacion2){

                                    case 1: 
                                        int telefono1, documento1;
                                        String nombre1, colegio1;
                                        Console.WriteLine("Digite Nombre");
                                        nombre1 = (Console.ReadLine());
                                        Console.WriteLine("Digite Documento");
                                        documento1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite Telefono");
                                        telefono1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite Colegio");
                                        colegio1 = Console.ReadLine();
                                        AdicionarArbitro(nombre1, documento1, telefono1, colegio1);
                                    break;

                                    case 2:
                                        int codigoArbi;
                                        Console.WriteLine("Digite codigo Albitro");
                                        codigoArbi = int.Parse(Console.ReadLine());
                                        BuscarArbitro(codigoArbi);
                                    break;

                                    case 3: 
                                        mostrarArbitro();
                                    break;

                                    case 4: 
                                        int id, telefono, documento;
                                        String nombre, colegio;
                                        Arbitro objarbitro = new Arbitro();
                                        Console.WriteLine("Digite ID a editar");
                                        id = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo nombre");
                                        nombre = (Console.ReadLine());
                                        Console.WriteLine("Digite nuevo documento");
                                        documento = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo telefono");
                                        telefono = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo colegio");
                                        colegio = Console.ReadLine();
                                        objarbitro.id = id;
                                        objarbitro.nombre = nombre;
                                        objarbitro.documento = documento;
                                        objarbitro.telefono = telefono;
                                        objarbitro.colegio = colegio;
                                        ModificarArbitro(objarbitro);
                                    break;

                                    case 5: 
                                        int id1;
                                        Console.WriteLine("Digite ID a eliminar");
                                        id1 = int.Parse(Console.ReadLine());
                                        EliminarArbitro(id1);
                                    break;
                      
                                }//cierre swich arbitro
                            }while ( operacion2 != 0); 
                    break;                    
                }//cierre switch principal 
            } while (opcion != 0);

        }

        //////////// MOSTRAR ///////////////////////
        private static void mostrarArbitro()
        {
            var arbitros = _RepositorioArbitro.GetAllArbitros();
            foreach (var arbitro in arbitros)
            {
                Console.WriteLine(arbitro.nombre + " " + arbitro.documento + " " + arbitro.telefono + " " + arbitro.colegio);
            }
        }
        private static void mostrarMunicipio()
        {
            var municipios = _RepositorioMunicipio.GetAllMunicipios();
            foreach (var municipio in municipios)
            {
                Console.WriteLine(municipio.nombre + " ");
            }
        }
        //////////// BUSCAR ///////////////////////
        private static void BuscarArbitro(int id)
        {
            var arbitros = _RepositorioArbitro.GetArbitro(id);

            Console.WriteLine(arbitros.nombre + " " + arbitros.documento + " " + arbitros.telefono + " " + arbitros.colegio);
        }
        private static void BuscarMunicipio(int id)
        {
            var municipios = _RepositorioMunicipio.GetMunicipio(id);

            Console.WriteLine(municipios.nombre + " ");
        }
        //////////// INSERTAR ///////////////////////        
        private static void AdicionarArbitro(String nombre, int documento, int telefono, String colegio)
        {
            var arbitro = new Arbitro
            {
                nombre = nombre,
                documento = documento,
                telefono = telefono,
                colegio = colegio
            };
            _RepositorioArbitro.AddArbitro(arbitro);
        }
        private static void AdicionarMunicipio(String nombre)
        {
            var municipio = new Municipio
            {
                nombre = nombre
            };
            _RepositorioMunicipio.AddMunicipio(municipio);
        }
        //////////// ELIMINAR /////////////////////// 
        private static void EliminarArbitro(int id)
        {
            _RepositorioArbitro.DeleteArbitro(id);
        }
        private static void EliminarMunicipio(int id)
        {
            _RepositorioMunicipio.DeleteMunicipio(id);
        }   
        //////////// MODIFICAR ///////////////////////  
        private static void ModificarArbitro(Arbitro arbitro)
        {
            _RepositorioArbitro.UpdateArbitro(arbitro);
            Console.WriteLine(arbitro.nombre);
            Console.WriteLine(arbitro.documento);
            Console.WriteLine(arbitro.telefono);
            Console.WriteLine(arbitro.colegio);
        }
        private static void ModificarMunicipio(Municipio municipio)
        {
            _RepositorioMunicipio.UpdateMunicipio(municipio);
            Console.WriteLine(municipio.nombre);
        }  
    }
}
