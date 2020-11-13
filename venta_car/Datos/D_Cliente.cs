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
     public class D_Cliente
    {

        public List<E_Cliente> ListaBuscarCliente()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Buscar_cliente";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Cliente> Lista = new List<E_Cliente>();
                while (leer.Read())
                {
                    E_Cliente FilaCliente= new E_Cliente();
                    FilaCliente.Id_cliente = leer["Id_cliente"].ToString();
                    FilaCliente.No_cedula = leer["No_cedula"].ToString();
                    FilaCliente.Nombre = leer["Nombre"].ToString();
                    FilaCliente.Apellido = leer["Apellido"].ToString();
                    FilaCliente.Telefono = Convert.ToInt32(leer["Telefono"].ToString());
                    FilaCliente.Direccion = leer["Direccion"].ToString();
                    FilaCliente.Ciudad = leer["Ciudad"].ToString();
                    FilaCliente.Email = leer["Email"].ToString();


                    Lista.Add(FilaCliente);
                }
                Conexion.Close();
                return Lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Listacliente()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarClientes";
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
