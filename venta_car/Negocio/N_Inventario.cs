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
   public class N_Inventario
    {
        public bool Guardar(E_Inventario Nuevo_inventario)
        {
            try
            {
                D_Inventario NuevoInventario = new D_Inventario();
                return NuevoInventario.Guardar(Nuevo_inventario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool Modificar(E_Inventario Modificar_Inventario)
        {
            try
            {
                D_Inventario ModificarInventario = new D_Inventario();
                return ModificarInventario.Modificar(Modificar_Inventario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(E_Inventario Eliminar_Inventario)
        {
            try
            {
                D_Inventario Eliminarnvenario = new D_Inventario();
                return Eliminarnvenario.Eliminar(Eliminar_Inventario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public DataTable Listainventario()
        {
            try
            {
                D_Inventario  Datos = new D_Inventario();
                return Datos.MostrarInventario();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<E_Inventario> ListaInventarioBuscar()
        {
            try
            {
                D_Inventario DatosProveedor = new D_Inventario();
                return DatosProveedor.ListainventarioBuscar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
