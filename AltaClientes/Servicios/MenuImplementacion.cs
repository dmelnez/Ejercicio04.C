using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaClientes.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de imprimir por pantalla la selecciones a poder escoger por el usuaro, y recoge el valor introducido
        /// 17/11/2023 - DMN
        /// </summary>
        /// <param name="args"></param>
        public int menu()
        {
            Console.WriteLine("########## Seleccione una Opcion ##########");
            Console.WriteLine("0 -> Finalizar la Aplicacion");
            Console.WriteLine("1 -> Añadir un Nuevo usuario");
            Console.WriteLine("###########################################");
            int seleccionUsu = Convert.ToInt32(Console.ReadLine());
            return seleccionUsu;
            
        }
    }
}
