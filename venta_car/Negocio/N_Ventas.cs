using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidad;
using Datos;

namespace Negocio
{
   public class N_Ventas
    {


        public bool Guardar(E_Ventas Nueva_Venta)
        {
            try
            {
                D_Ventas NuevaVenta = new D_Ventas();
                return NuevaVenta.Guardar(Nueva_Venta);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Modificar(E_Ventas Modificar_Venta)
        {
            try
            {
                D_Ventas ModificarVenta = new D_Ventas();
                return ModificarVenta.Modificar(Modificar_Venta);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(E_Ventas Eliminar_Venta)
        {
            try
            {
                D_Ventas EliminarVenta = new D_Ventas();
                return EliminarVenta.Eliminar(Eliminar_Venta);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListaVenta()
        {
            try
            {
                D_Ventas ListaVentas = new D_Ventas();
                return ListaVentas.MostrarVentas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
