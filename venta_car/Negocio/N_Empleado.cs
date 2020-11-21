using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data;


namespace Negocio
{
   public class N_Empleado
    {
        public bool Guardar(E_Empleado NuevoEmpleados)
        {
            try
            {
                D_Empleados DatosEmpleados = new D_Empleados();
                return DatosEmpleados.Guardar(NuevoEmpleados);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Modificar(E_Empleado ModificarEmpleados)
        {
            try
            {
                D_Empleados DatosEmpleados = new D_Empleados();
                return DatosEmpleados.Modificar(ModificarEmpleados);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<E_Empleado> ListaEmpleados()
        {
            try
            {
                D_Empleados DatosEmpleados = new D_Empleados();
                return DatosEmpleados.ListaEmpleado();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public bool Eliminar(E_Empleado Eliminar_Empleado)
        {
            try
            {
                D_Empleados EliminarEmpleado = new D_Empleados();
                return EliminarEmpleado.Eliminar(Eliminar_Empleado);

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
                D_Empleados d_Empleados = new D_Empleados();
                return d_Empleados.ListaEmpleadoBuscar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
