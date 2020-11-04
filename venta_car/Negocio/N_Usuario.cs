using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Data;

namespace Negocio
{
   public class N_Usuario
    {

        public bool Guardar(E_Usuario NuevoUsuario)
        {
            try
            {
                D_Usuario DatosUsuario = new D_Usuario();
                return DatosUsuario.Guardar(NuevoUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Modificar(E_Usuario ModificarUsuario)
        {
            try
            {
                D_Usuario DatosUsuario = new D_Usuario();
                return DatosUsuario.Modificar(ModificarUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ListaUsuario()
        {
            try
            {
                D_Usuario DatosUsuario = new D_Usuario();
                return DatosUsuario.ListaUsuario();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Acceso(E_Usuario AccesoUsuario)
        {
            try
            {
                D_Usuario DatosAcceso = new D_Usuario();
                return DatosAcceso.Acceso(AccesoUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<E_Usuario> ListaUsuarioB()
        {
            try
            {
                D_Usuario DatosUsuario = new D_Usuario();
                return DatosUsuario.ListaUsuarioBuscar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
