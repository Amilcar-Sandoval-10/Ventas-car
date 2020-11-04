using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Inventario
    {
       public string Id_producto {get; set;}
       public string Marca { get; set; }
       public string Modelo { get; set; }
       public int Precio { get; set; }
       public int Stock_max { get; set; }
       public int Stock_min { get; set; }
       public int Stock { get; set; }

    }
}
