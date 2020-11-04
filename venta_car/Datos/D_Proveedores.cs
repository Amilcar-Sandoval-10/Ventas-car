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
   public class D_Proveedores
    {
       

        public bool Guardar (E_Proveedores NuevoProveedor)
        {

            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Insertar_proveedor";
                Comando.Parameters.AddWithValue("@No_cedula", NuevoProveedor.No_cedula);
                Comando.Parameters.AddWithValue("@Nombre", NuevoProveedor.Nombre);
                Comando.Parameters.AddWithValue("@Apellido", NuevoProveedor.Apellido);
                Comando.Parameters.AddWithValue("@Telefono_personal", NuevoProveedor.Telefono_personal);
                Comando.Parameters.AddWithValue("@Telefono_empresa", NuevoProveedor.Telefono_empresa);
                Comando.Parameters.AddWithValue("@Email", NuevoProveedor.Email);
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



        public bool  Modificar (E_Proveedores ModificarProveedor)
        {

            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Editar_proveedor";
                Comando.Parameters.AddWithValue("@Id_proveedor", ModificarProveedor.Id_proveedor);
                Comando.Parameters.AddWithValue("@No_cedula", ModificarProveedor.No_cedula);
                Comando.Parameters.AddWithValue("@Nombre", ModificarProveedor.Nombre);
                Comando.Parameters.AddWithValue("@Apellido", ModificarProveedor.Apellido);
                Comando.Parameters.AddWithValue("@Telefono_personal", ModificarProveedor.Telefono_personal);
                Comando.Parameters.AddWithValue("@Telefono_empresa", ModificarProveedor.Telefono_empresa);
                Comando.Parameters.AddWithValue("@Email", ModificarProveedor.Email);
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

        public bool Eliminar (E_Proveedores EliminarProveedor)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Eliminar_proveedor";
                Comando.Parameters.AddWithValue("@Id_proveedor", EliminarProveedor.Id_proveedor);
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;

            }

            catch(Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListaProveedor()
        {
            


                DataTable Tabla = new DataTable();
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarProveedores";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                Tabla.Load(leer);
                leer.Close();
                Conexion.Close();
                return Tabla;

        }

        public List<E_Proveedores> ListaProveedorBuscar()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarProveedores";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Proveedores> Lista = new List<E_Proveedores>();
                while (leer.Read())
                {
                    E_Proveedores FilaProveedor = new E_Proveedores();

                    FilaProveedor.Id_proveedor = leer["Id_Proveedor"].ToString();
                    FilaProveedor.No_cedula = leer["No_cedula"].ToString();
                    FilaProveedor.Nombre = leer["Nombre"].ToString();
                    FilaProveedor.Apellido = leer["Apellido"].ToString();
                    FilaProveedor.Telefono_personal = Convert.ToInt32(leer["Telefono_Personal"].ToString());
                    FilaProveedor.Telefono_empresa = Convert.ToInt32(leer["Telefono_empresa"].ToString());
                    FilaProveedor.Email = leer["Email"].ToString();

                    Lista.Add(FilaProveedor);
                }
                Conexion.Close();
                return Lista;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
