using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaClientes.Dtos
{
    /// <summary>
    /// Creacion de las variables con sus atributos, los cuales contendran los campos que se solicitaran al cliente
    /// 17/11/2023 - DMN
    /// </summary>
    /// <param name="args"></param>
    internal class ClientesDtos
    {
        long id;

        string nombreCliente = "aaaaa";

        string apellidosCliente = "aaaaa";

        string dniCliente = "aaaaa";

        string fchNacimientoCliente = "9999/12/31";

        string emailCliente = "aaaaa";

        int tlfCliente = 111111111;

        string fchAltaCliente = "9999/12/31";

        string fchBajaCliente = "9999/12/31";

    

        public long Id { get => id; set => id = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }    
        
        
        
        
        public ClientesDtos(long id, string nombreCliente, string apellidosCliente, string dniCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente, string fchBajaCliente)
        {
            /// <summary>
            /// Creacion de un constructos, al cual se le pasaran los parametros que contendran los campos que definiran a cada cliente
            /// /// 17/11/2023 - DMN
            /// </summary>
            /// <param name="args"></param>
            /// 
            this.id = id;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
        }


        public ClientesDtos() {
        }


        /// <summary>
        /// Metodo el cual concatenara los datos introducidos de los clientes
        /// 17/11/2023 - DMN
        /// </summary>
        /// <param name="args"></param>


        override
        public  string ToString()
        {
            string clienteString = 
                "Nombre: " + this.nombreCliente +
                "Apellido:" +  this.apellidosCliente +
                "DNI: " + this.dniCliente +
                "Fecha Nacimiento: " + this.fchNacimientoCliente +
                "Email: " + this.emailCliente +
                "Nº Telefono: " + this.tlfCliente +
                "Fecha Alta: " + this.fchAltaCliente;
            return clienteString; 
        }
    }
}
