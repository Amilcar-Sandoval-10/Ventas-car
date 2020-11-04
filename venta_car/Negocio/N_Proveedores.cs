using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data;

namespace Negocio
{
   public class N_Proveedores
    {

   

        public bool Guardar (E_Proveedores Nuevo_Proveedor)
        {
            try
            {
                D_Proveedores NuevoProveedor = new D_Proveedores();
                return NuevoProveedor.Guardar(Nuevo_Proveedor);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Modificar(E_Proveedores Modificar_Proveedor)
        {
            try
            {
                D_Proveedores ModificarProveedor = new D_Proveedores();
                return ModificarProveedor.Modificar(Modificar_Proveedor);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(E_Proveedores Eliminar_Proveedor)
        {
            try
            {
                D_Proveedores EliminarProveedor = new D_Proveedores();
                return EliminarProveedor.Eliminar(Eliminar_Proveedor);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable listaProveedores()
        {
            try
            {
                D_Proveedores DatosProveedores = new D_Proveedores();
                return DatosProveedores.ListaProveedor();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<E_Proveedores> ListaProveedorBuscar()
        {
            try
            {
                D_Proveedores DatosProveedor = new D_Proveedores();
                return DatosProveedor.ListaProveedorBuscar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
