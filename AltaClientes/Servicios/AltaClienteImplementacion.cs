using AltaClientes.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaClientes.Servicios
{
    internal class AltaClienteImplementacion : AltaClienteInterfaz
    {

        /// <summary>
        /// Metodo encargado de la creacion de un nuevo Cliente y solicitar al cliente todos los datos 
        /// 17/11/2023 - DMN
        /// </summary>
        /// <param name="args"></param>


        public void darAltaCliente(List<ClientesDtos>listaAntigua)
        {

            ClientesDtos cliente01 = new ClientesDtos();

            Console.WriteLine("########### Introduzca sus Datos ###########");

            Console.WriteLine("Nombre: ");
            string nombreCliente = Console.ReadLine();
            cliente01.NombreCliente = nombreCliente;

            Console.WriteLine("Apellido: ");
            string apellidosCliente = Console.ReadLine();
            cliente01.ApellidosCliente = apellidosCliente;

            Console.WriteLine("DNI: ");
            string dniCliente = Console.ReadLine();
            cliente01.DniCliente = dniCliente;

            Console.WriteLine("Fecha Nacimiento: ");
            string fchNacimientoClienteCliente = Console.ReadLine();
            cliente01.FchNacimientoCliente = fchNacimientoClienteCliente;

            Console.WriteLine("Email: ");
            string emailCliente = Console.ReadLine();
            cliente01.EmailCliente = emailCliente;

            Console.WriteLine("Nº Telefono: ");
            int tlfCliente = Convert.ToInt32(Console.ReadLine());
            cliente01.TlfCliente = tlfCliente;

            Console.WriteLine("Fecha Alta: ");
            string fchAltaCliente = Console.ReadLine();
            cliente01.FchAltaCliente = fchAltaCliente;
            listaAntigua.Add(cliente01); //Añadira al nuevo cliente a la lista ce clientes "listaAntigua"
          

        }



    }
}
