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
    public class D_Ventas
    {


        public bool Guardar(E_Ventas NuevaVenta)
        {

            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "insertar_venta";
                Comando.Parameters.AddWithValue("@Id_producto", NuevaVenta.Id_producto);
                Comando.Parameters.AddWithValue("@Id_cliente", NuevaVenta.Id_cliente);
                Comando.Parameters.AddWithValue("@Fecha_venta", NuevaVenta.Fecha_venta);
                Comando.Parameters.AddWithValue("@Precio_venta", NuevaVenta.Precio_venta);
                Comando.Parameters.AddWithValue("@stock", NuevaVenta.stock);
                Comando.Parameters.AddWithValue("@Iva", NuevaVenta.Iva);
                Comando.Parameters.AddWithValue("@Descuento", NuevaVenta.Descuento);
                Comando.Parameters.AddWithValue("@Total", NuevaVenta.Total);
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



        public bool Modificar(E_Ventas ModificarVenta)
        {

            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "editar_venta";
                Comando.Parameters.AddWithValue("@Id_venta ", ModificarVenta.Id_venta);
                Comando.Parameters.AddWithValue("@Id_producto", ModificarVenta.Id_producto);
                Comando.Parameters.AddWithValue("@Id_cliente", ModificarVenta.Id_cliente);
                Comando.Parameters.AddWithValue("@Fecha_venta", ModificarVenta.Fecha_venta);
                Comando.Parameters.AddWithValue("@Precio_venta", ModificarVenta.Precio_venta);
                Comando.Parameters.AddWithValue("@stock", ModificarVenta.stock);
                Comando.Parameters.AddWithValue("@Iva", ModificarVenta.Iva);
                Comando.Parameters.AddWithValue("@Descuento", ModificarVenta.Descuento);
                Comando.Parameters.AddWithValue("@Total", ModificarVenta.Total);
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

        public bool Eliminar(E_Ventas EliminarVenta)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Eliminar_venta";
                Comando.Parameters.AddWithValue("@Id_venta ", EliminarVenta.Id_venta);
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

        public DataTable MostrarVentas()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarVenta";
            Comando.Connection = Conexion;
            Conexion.Open();
            SqlDataReader leer = Comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            Conexion.Close();
            return Tabla;
        }


    }
}
