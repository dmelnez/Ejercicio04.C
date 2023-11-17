using AltaClientes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaClientes.Servicios
{
    internal interface AltaClienteInterfaz 
    {
        /// <summary>
        /// Interfaz que contiene los encabezados de los metodos de la implementacion
        /// 17/11/2023 - DMN
        /// </summary>
        /// <param name="args"></param>
    
        public void darAltaCliente(List<ClientesDtos> listaAntigua);
    }
}
