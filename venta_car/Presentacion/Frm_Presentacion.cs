using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Presentacion : Form
    {
        public Frm_Presentacion()
        {
            InitializeComponent();
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {

            Frm_Proveedores mv = new Frm_Proveedores();
            mv.Show();
         
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            Frm_Compra filtroProducto = new Frm_Compra();
            filtroProducto.ShowDialog();
            this.Hide();
        }
    }
}
