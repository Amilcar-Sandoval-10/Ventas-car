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
    public class N_Compra
    {


        public bool Guardar(E_Compra Nueva_Compra)
        {
            try
            {
                D_Compra NuevoCompra = new D_Compra();
                return NuevoCompra.Guardar(Nueva_Compra);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool Modificar(E_Compra Modificar_Compra)
        {
            try
            {
                D_Compra ModificarCompra = new D_Compra();
                return ModificarCompra.Modificar(Modificar_Compra);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(E_Compra Eliminar_Compra)
        {
            try
            {
                D_Compra EliminarCompra = new D_Compra();
                return EliminarCompra.Eliminar(Eliminar_Compra);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListaFacturaCompra()
        {
            try
            {
                D_Compra DatosFacturaCompra = new D_Compra();
                return DatosFacturaCompra.Mostrarcompra();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public DataTable ListaCompra()
        //{
        //    try
        //    {
        //        D_Compra Compra = new D_Compra();
        //        return Compra.ListaCompra();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}



        //public List<E_Compra> ListaCompra()
        //{

        //    try
        //    {

        //        D_Compra ListaCompra = new D_Compra();

        //        return ListaCompra.ListaCompra();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}


    }
}
