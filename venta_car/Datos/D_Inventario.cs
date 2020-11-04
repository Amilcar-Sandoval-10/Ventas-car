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
}
