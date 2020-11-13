using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;

namespace Presentacion
{
    public partial class Frm_Buscador_Producto : Form
    {
        public Frm_Buscador_Producto()
        {
            InitializeComponent();
        }

        


        private Frm_Ventas Padre;


        public Frm_Buscador_Producto(Frm_Ventas parametro)
        {
            InitializeComponent();

            Padre = parametro;
        }

        private void CargarGrid()
        {
            try
            {
                N_Inventario nInventario = new N_Inventario();
                dgvFiltroInventario.DataSource = nInventario.ListaInventario();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Buscador_Producto_Load(object sender, EventArgs e)
        {
            CargarGrid();
           
        }



        private void btnFiltroCliente_Click(object sender, EventArgs e)
        {

            try
            {
                N_Inventario Invenario = new N_Inventario();
                List<E_Inventario> lista = Invenario.ListaInventarioBuscar();
                if (cbid.Checked)
                {

                    lista = lista.Where(l => l.Id_producto.StartsWith(txtid.Text)).ToList();

                }

                if (cbmarca.Checked)
                {

                    lista = lista.Where(l => l.Marca.StartsWith(txtmarca.Text)).ToList();

                }
                if (cbmodelo.Checked)
                {

                    lista = lista.Where(l => l.Modelo.StartsWith(txtmodelo.Text)).ToList();

                }

                dgvFiltroInventario.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cbcodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbid.Checked == true)
            {
                txtid.Enabled = true;
            }
            else
            {
                txtid.Enabled = false;
            }
        }

        private void cbmodelo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmodelo.Checked == true)
            {
                txtmodelo.Enabled = true;
            }
            else
            {
                txtmodelo.Enabled = false;
            }
        }

        private void cbmarca_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmarca.Checked == true)
            {
                txtmarca.Enabled = true;
            }
            else
            {
                txtmarca.Enabled = false;
            }
        }



        private void dgvFiltroInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Padre.txtMarca.Tag = dgvFiltroInventario.CurrentRow.Cells["Id_producto"].Value.ToString();
            Padre.txtMarca.Text = dgvFiltroInventario.CurrentRow.Cells["Marca"].Value.ToString();
            Padre.txtModelo.Text = dgvFiltroInventario.CurrentRow.Cells["Modelo"].Value.ToString();
            Padre.txtPrecio.Text = dgvFiltroInventario.CurrentRow.Cells["Precio"].Value.ToString();

            this.Close();
        }
    }
}
