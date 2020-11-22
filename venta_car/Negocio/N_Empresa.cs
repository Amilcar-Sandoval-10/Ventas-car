using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class N_Empresa
    {
        public bool Guardar(E_Empresa NuevoEmpresa)
        {
            try
            {
                D_Empresa DatosEmpresa = new D_Empresa();
                return DatosEmpresa.Guardar(NuevoEmpresa);
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
                D_Empresa DatosEmpresa = new D_Empresa();
                return DatosEmpresa.Modificar(ModificarEmpresa);
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
                D_Empresa DatosEmpresa = new D_Empresa();
                return DatosEmpresa.ListaEmpresa();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public bool Eliminar(E_Empresa Eliminar_Empresa)
        {
            try
            {
                D_Empresa EliminarEmpresa = new D_Empresa();
                return EliminarEmpresa.Eliminar(Eliminar_Empresa);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
