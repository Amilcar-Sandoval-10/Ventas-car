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
    public class D_Empleados
    {

        public bool Guardar(E_Empleado NuevoEmpleado)
        {
            try
            {

                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "insertar_empleado";
                Comando.Parameters.AddWithValue("@Id_Empresa", NuevoEmpleado.Id_Empresa);
                Comando.Parameters.AddWithValue("@Nombre", NuevoEmpleado.Nombre);
                Comando.Parameters.AddWithValue("@Apellido", NuevoEmpleado.Apellido);
                Comando.Parameters.AddWithValue("@Inss", NuevoEmpleado.INSS);
                Comando.Parameters.AddWithValue("@Fecha_nac", NuevoEmpleado.fecha_Nac);
                Comando.Parameters.AddWithValue("@Genero", NuevoEmpleado.Genero);
                Comando.Parameters.AddWithValue("@Direccion", NuevoEmpleado.Direccion);
                Comando.Parameters.AddWithValue("@No_cedula", NuevoEmpleado.No_Cedula);
                Comando.Parameters.AddWithValue("@Telefono", NuevoEmpleado.Telefono);
                Comando.Parameters.AddWithValue("@Estado_civil", NuevoEmpleado.Estado_Civil);
                Comando.Parameters.AddWithValue("@Email", NuevoEmpleado.Email);
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


        public bool Modificar(E_Empleado ModificarEmpleado)
        {
            try
            {

                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "editar_empleado";
                Comando.Parameters.AddWithValue("@Id_Empleado", ModificarEmpleado.Id_Empleado);
                Comando.Parameters.AddWithValue("@Id_Empresa", ModificarEmpleado.Id_Empresa);
                Comando.Parameters.AddWithValue("@Nombre", ModificarEmpleado.Nombre);
                Comando.Parameters.AddWithValue("@Apellido", ModificarEmpleado.Apellido);
                Comando.Parameters.AddWithValue("@INSS", ModificarEmpleado.INSS);
                Comando.Parameters.AddWithValue("@Fecha_nac", ModificarEmpleado.fecha_Nac);
                Comando.Parameters.AddWithValue("@Genero", ModificarEmpleado.Genero);
                Comando.Parameters.AddWithValue("@Direccion", ModificarEmpleado.Direccion);
                Comando.Parameters.AddWithValue("@No_cedula", ModificarEmpleado.No_Cedula);
                Comando.Parameters.AddWithValue("@Telefono", ModificarEmpleado.Telefono);
                Comando.Parameters.AddWithValue("@Estado_civil", ModificarEmpleado.Estado_Civil);
                Comando.Parameters.AddWithValue("@Email", ModificarEmpleado.Email);
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
        public List<E_Empleado> ListaEmpleado()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarEmpleado";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Empleado> Lista = new List<E_Empleado>();
                while (leer.Read())
                {
                    E_Empleado FilaEmpleado = new E_Empleado();
                    FilaEmpleado.Id_Empleado = Convert.ToInt32(leer["Id_Empleado"].ToString());
                    FilaEmpleado.Id_Empresa = Convert.ToInt32(leer["Id_Empresa"].ToString());
                    FilaEmpleado.Nombre = leer["Nombre"].ToString();
                    FilaEmpleado.Apellido = leer["Apellido"].ToString();
                    FilaEmpleado.INSS = leer["Inss"].ToString();
                    FilaEmpleado.fecha_Nac = leer["fecha_nac"].ToString();
                    FilaEmpleado.Direccion = leer["Direccion"].ToString();
                    FilaEmpleado.No_Cedula = leer["No_cedula"].ToString();
                    FilaEmpleado.Genero = leer["Genero"].ToString();
                    FilaEmpleado.Telefono = Convert.ToInt32(leer["Telefono"].ToString());
                    FilaEmpleado.Estado_Civil = leer["Estado_Civil"].ToString();
                    FilaEmpleado.Email = leer["Email"].ToString();

                    Lista.Add(FilaEmpleado);
                }
                Conexion.Close();
                return Lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public bool Eliminar(E_Empleado EliminarEmpleado)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Eliminar_Empleado";
                Comando.Parameters.AddWithValue("@Id_empleado", EliminarEmpleado.Id_Empleado);
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
        public List<E_Empleado> ListaEmpleadoBuscar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "Buscar_Empleado";
                command.Connection = conexion;
                conexion.Open();
                SqlDataReader leer = command.ExecuteReader();
                List<E_Empleado> Lista = new List<E_Empleado>();
                while (leer.Read())
                {
                    E_Empleado filaEmpleado = new E_Empleado();
                    filaEmpleado.Id_Empleado = Convert.ToInt32(leer["ID_Empleado"].ToString());
                    filaEmpleado.Nombre = leer["Nombre"].ToString();
                    filaEmpleado.Apellido = leer["Apellidos"].ToString();
                    filaEmpleado.INSS = leer["INSS"].ToString();
                    filaEmpleado.fecha_Nac = leer["FechaNac"].ToString();
                    filaEmpleado.Genero = leer["Genero"].ToString();
                    filaEmpleado.Direccion = leer["Direccion"].ToString();
                    filaEmpleado.Telefono = Convert.ToInt32(leer["Telefono"].ToString());
                    filaEmpleado.No_Cedula = leer["Cedula"].ToString();
                    filaEmpleado.Estado_Civil = leer["EstadoCivil"].ToString();
                    filaEmpleado.Email = leer["Email"].ToString();
                    Lista.Add(filaEmpleado);
                }
                conexion.Close();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ListaEmpleados()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Cadena_conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarEmpleado";
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
