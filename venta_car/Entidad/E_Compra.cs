using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class E_Compra
    {

        public int Id_compra { get; set; }
        public int Id_proveedor { get; set; }
        public int Id_producto { get; set; }
        public string Fecha_compra { get; set; }
        public double  Precio_compra { get; set; }
        public int Cantidad { get; set; }
        public double Subtotal { get; set; }

        public double Iva { get; set; }
        public double Descuento { get; set; }
        public double Stock { get; set; }
       

    }
}
