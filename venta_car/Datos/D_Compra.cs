using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class D_Compra
    {

        public bool Guardar(E_Compra NuevaCompra)
        {

            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "insertar_compra";
                Comando.Parameters.AddWithValue("@Id_proveedor", NuevaCompra.Id_proveedor);
                Comando.Parameters.AddWithValue("@Id_producto", NuevaCompra.Id_producto);
                Comando.Parameters.AddWithValue("@Fecha_compra", NuevaCompra.Fecha_compra);
                Comando.Parameters.AddWithValue("@Precio_compra", NuevaCompra.Precio_compra);
                Comando.Parameters.AddWithValue("@Cantidad", NuevaCompra.Cantidad);
                Comando.Parameters.AddWithValue("@Subtotal", NuevaCompra.Subtotal);               
                Comando.Parameters.AddWithValue("@Iva", NuevaCompra.Iva);
                Comando.Parameters.AddWithValue("@Descuento", NuevaCompra.Descuento);
                Comando.Parameters.AddWithValue("@Stock", NuevaCompra.Stock);
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public bool Modificar(E_Compra ModificarCompra)
        {

            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "editar_compra";
                Comando.Parameters.AddWithValue("@Id_compra", ModificarCompra.Id_compra);
                Comando.Parameters.AddWithValue("@Id_proveedor", ModificarCompra.Id_proveedor);
                Comando.Parameters.AddWithValue("@Id_producto", ModificarCompra.Id_producto);
                Comando.Parameters.AddWithValue("@Fecha_compra", ModificarCompra.Fecha_compra);
                Comando.Parameters.AddWithValue("@Precio_compra", ModificarCompra.Precio_compra);
                Comando.Parameters.AddWithValue("@Cantidad", ModificarCompra.Cantidad);
                Comando.Parameters.AddWithValue("@Subtotal", ModificarCompra.Subtotal);
                Comando.Parameters.AddWithValue("@Iva", ModificarCompra.Iva);
                Comando.Parameters.AddWithValue("@Descuento", ModificarCompra.Descuento);
                Comando.Parameters.AddWithValue("@Stock", ModificarCompra.Stock);
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public bool Eliminar(E_Compra EliminarCompra)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Eliminar_compra";
                Comando.Parameters.AddWithValue("@Id_compra", EliminarCompra.Id_compra);
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Mostrarcompra()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarCompra";
            Comando.Connection = Conexion;
            Conexion.Open();
            SqlDataReader leer = Comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            Conexion.Close();
            return Tabla;
        }


 

        //public List<E_Compra> ListaCompra()
        //{
        //    try
        //    {
        //        SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
        //        SqlCommand Comando = new SqlCommand();
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        Comando.CommandText = "MostrarCompra";
        //        Comando.Connection = Conexion;
        //        Conexion.Open();
        //        SqlDataReader leer = Comando.ExecuteReader();
        //        List<E_Compra> Lista = new List<E_Compra>();
        //        while (leer.Read())
        //        {
        //            E_Compra FilaCompra = new E_Compra();
        //            FilaCompra.Id_compra = Convert.ToInt32(leer["Id_compra"].ToString());
        //            FilaCompra.Id_proveedor = Convert.ToInt32(leer["Id_proveedor"].ToString());
        //            FilaCompra.Id_producto = Convert.ToInt32(leer["Id_producto"].ToString());
        //            FilaCompra.Fecha_compra = leer["Fecha_compra"].ToString();
        //            FilaCompra.Precio_compra = Convert.ToInt32(leer["Precio_compra"].ToString());
        //            FilaCompra.Iva = Convert.ToInt32(leer["Iva"].ToString());
        //            FilaCompra.Descuento = Convert.ToInt32(leer["Descuento"].ToString());
        //            FilaCompra.Stock = Convert.ToInt32(leer["Stock"].ToString());


        //            Lista.Add(FilaCompra);
        //        }
        //        Conexion.Close();
        //        return Lista;

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}



    }
}
