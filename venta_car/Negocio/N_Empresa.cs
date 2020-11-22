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

    }
}
