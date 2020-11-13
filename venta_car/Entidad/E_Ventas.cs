using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
  public class E_Ventas
    {


        public int Id_venta { get; set; }
        public int Id_producto { get; set; }
        public int Id_cliente { get; set; }
        public string Fecha_venta { get; set; }
        public  double Precio_venta { get; set; }
        public double Iva { get; set; }
        public double Descuento { get; set; }
        public int stock { get; set; }
        public double Total { get; set; }

    }
}
