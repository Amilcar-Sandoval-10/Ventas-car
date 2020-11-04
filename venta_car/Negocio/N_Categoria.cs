using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class N_Categoria
    {

        public DataTable ListaCategoria()
        {
            try
            {
                D_Categoria DCategoria = new D_Categoria();
                return DCategoria.ListarCategoria();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
