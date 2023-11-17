using AltaClientes.Dtos;
using AltaClientes.Servicios;
using System.Collections.Generic;

namespace AltaClientes
{
    class Program
    {
        /// <summary>
        /// Clase Principal de la Aplicacion 
        /// 17/11/2023 - DMN
        /// </summary>
        /// <param name="args"></param>


        public static void Main(string[] args)
        {
            /// <summary>
            /// Clase por la cual se inicializa la aplicacion, y pide al usuario sus datos y lo añade a la lista de clientes
            /// 17/11/2023 - DMN
            /// </summary>
            /// <param name="args"></param>

            MenuInterfaz mi = new MenuImplementacion();
            List<ClientesDtos> listaClientes = new List<ClientesDtos>();
        
            AltaClienteInterfaz mi01 = new AltaClienteImplementacion();
      
            
            bool cerraMenu = false;       

            while (!cerraMenu) 
            {
                int seleccionUsu = mi.menu();

                switch (seleccionUsu)
                {
                    case 0:
                        Console.WriteLine("[INFO] -- > La aplicacion se Cerrara");
                        cerraMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] -- > Alta Nuevo Cliente");
                        mi01.darAltaCliente(listaClientes);
                        string datos = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("[INFO] -- > Seleccion no Valida");
                        break;
                }
            
            }

        }

    }

}

