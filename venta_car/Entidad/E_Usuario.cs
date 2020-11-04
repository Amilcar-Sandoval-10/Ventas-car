using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Usuario
    {
        public int Id_Usuario { get; set; }
        public int Id_empleado { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Tipo_Usuario { get; set; }
    }
}
