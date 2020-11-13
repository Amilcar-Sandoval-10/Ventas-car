using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Data;

namespace Negocio
{
   public class N_Cliente
    {

        public List<E_Cliente> ListaBuscarCliente()
        {
            try
            {
                D_Cliente DatosCliente = new D_Cliente();
                return DatosCliente.ListaBuscarCliente();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ListaCliente()
        {
            try
            {
                D_Cliente DatosClientes = new D_Cliente();
                return DatosClientes.Listacliente();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
