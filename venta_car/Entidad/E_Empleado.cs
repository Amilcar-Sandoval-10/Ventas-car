using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public  class E_Empleado
    {
        public int Id_Empleado { get; set; }
        public int Id_Empresa { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string INSS { get; set; }
        public string Genero { get; set; }
        public string fecha_Nac { get; set; }
        public string Direccion { get; set; }
        public string No_Cedula { get; set; }
        public int Telefono { get; set; }
        public string Estado_Civil { get; set; }
        public string Email { get; set; }
    }
}
