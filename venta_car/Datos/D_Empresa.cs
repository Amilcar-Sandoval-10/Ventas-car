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
    public class D_Empresa
    {
        public bool Guardar(E_Empresa NuevaEmpresa)
        {
            try
            {

                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Insertar_Empresa";
                Comando.Parameters.AddWithValue("@Nombre", NuevaEmpresa.Nombre);
                Comando.Parameters.AddWithValue("@Direccion", NuevaEmpresa.Direccion);
                Comando.Parameters.AddWithValue("@Telefono", NuevaEmpresa.Telefono);
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


        public bool Modificar(E_Empresa ModificarEmpresa)
        {
            try
            {

                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Editar_empresa";
                Comando.Parameters.AddWithValue("@Id_Empresa", ModificarEmpresa.Id_empresa);
                Comando.Parameters.AddWithValue("@Nombre", ModificarEmpresa.Nombre);
                Comando.Parameters.AddWithValue("@Direccion", ModificarEmpresa.Direccion);
                Comando.Parameters.AddWithValue("@Telefono", ModificarEmpresa.Telefono);
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
        public List<E_Empresa> ListaEmpresa()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarEmpresa";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Empresa> Lista = new List<E_Empresa>();
                while (leer.Read())
                {
                    E_Empresa FilaEmpresa = new E_Empresa();
                    FilaEmpresa.Id_empresa = leer["Id_empresa"].ToString();
                    FilaEmpresa.Nombre = leer["Nombre"].ToString();
                    FilaEmpresa.Direccion = leer["Direccion"].ToString();
                    FilaEmpresa.Telefono = Convert.ToInt32(leer["Telefono"].ToString());
                    Lista.Add(FilaEmpresa);
                }
                Conexion.Close();
                return Lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public bool Eliminar(E_Empresa EliminarEmpresa)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Eliminar_Empresa";
                Comando.Parameters.AddWithValue("@Id_Empresa", EliminarEmpresa.Id_empresa);
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
}
