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


        public bool Guardar(E_Cliente NuevoCliente)
        {
            try
            {
                D_Cliente DatosClientes = new D_Cliente();
                return DatosClientes.Guardar(NuevoCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Eliminar(E_Cliente EliminarCliente)
        {
            try
            {
                D_Cliente DatosClientes = new D_Cliente();
                return DatosClientes.Eliminar(EliminarCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Editar(E_Cliente ModificarCliente)
        {
            try
            {
                D_Cliente DatosCliente = new D_Cliente();
                return DatosCliente.Editar(ModificarCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

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
