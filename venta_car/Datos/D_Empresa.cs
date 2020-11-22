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

    }
}
