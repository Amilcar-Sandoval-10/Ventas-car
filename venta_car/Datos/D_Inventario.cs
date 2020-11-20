using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class D_Inventario
    {

      public bool Guardar(E_Inventario NuevoInventario)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Insertar_inventario";
                Comando.Parameters.AddWithValue("@Marca", NuevoInventario.Marca);
                Comando.Parameters.AddWithValue("@Modelo", NuevoInventario.Modelo);
                Comando.Parameters.AddWithValue("@Precio", NuevoInventario.Precio);
                Comando.Parameters.AddWithValue("@Stock_max", NuevoInventario.Stock_max);
                Comando.Parameters.AddWithValue("@Stock_min", NuevoInventario.Stock_min);
                Comando.Parameters.AddWithValue("@Stock", NuevoInventario.Stock);

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

        public bool Modificar(E_Inventario Modificar_inventario)
            {
                try
                {
                    SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                    SqlCommand Comando = new SqlCommand();

                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.CommandText = "Editar_inventario";

                    Comando.Parameters.AddWithValue("@Id_producto", Modificar_inventario.Id_producto);
                    Comando.Parameters.AddWithValue("@Marca", Modificar_inventario.Marca);
                    Comando.Parameters.AddWithValue("@Modelo", Modificar_inventario.Modelo);
                    Comando.Parameters.AddWithValue("@Precio", Modificar_inventario.Precio);
                    Comando.Parameters.AddWithValue("@Stock", Modificar_inventario.Stock);
                    Comando.Parameters.AddWithValue("@Stock_max", Modificar_inventario.Stock_max);
                    Comando.Parameters.AddWithValue("@Stock_min", Modificar_inventario.Stock_min);

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

        public List<E_Inventario> Listainventario()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Mostrarinventario";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Inventario> Lista = new List<E_Inventario>();
                while (leer.Read())
                {
                    E_Inventario FilaClientes = new E_Inventario();
                    FilaClientes.Marca = leer["Marca"].ToString();
                    FilaClientes.Modelo = leer["Modelo"].ToString();
                    FilaClientes.Precio = Convert.ToInt32(leer["Precio"].ToString());
                    FilaClientes.Stock_max = Convert.ToInt32(leer["Stock_max"].ToString());
                    FilaClientes.Stock_min = Convert.ToInt32(leer["Stock_min"].ToString());
                    FilaClientes.Stock = Convert.ToInt32(leer["Stock"].ToString());
                    Lista.Add(FilaClientes);
                }
                Conexion.Close();
                return Lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public bool Eliminar(E_Inventario Eliminar_inventario)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Eliminar_inventario";
                Comando.Parameters.AddWithValue("@Id_producto", Eliminar_inventario.Id_producto);
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


    }

    public List<E_Inventario> ListaInventarioBuscar()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarInventario";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Inventario> Lista = new List<E_Inventario>();
                while (leer.Read())
                {
                    E_Inventario FilaInventario = new E_Inventario();
                    FilaInventario.Id_producto = leer["Id_producto"].ToString();
                    FilaInventario.Marca = leer["Marca"].ToString();
                    FilaInventario.Modelo = leer["Modelo"].ToString();
                    FilaInventario.Precio = Convert.ToInt32(leer["Precio"].ToString());
               
                    FilaInventario.Stock_max = Convert.ToInt32(leer["Stock_max"].ToString());
                    FilaInventario.Stock_min = Convert.ToInt32(leer["Stock_min"].ToString());
                    FilaInventario.Stock = Convert.ToInt32(leer["Stock"].ToString());
                    

                    Lista.Add(FilaInventario);
                }
                Conexion.Close();
                return Lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ListaInventario()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarInventario";
            Comando.Connection = Conexion;
            Conexion.Open();
            SqlDataReader leer = Comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            Conexion.Close();
            return Tabla;
        }

}
