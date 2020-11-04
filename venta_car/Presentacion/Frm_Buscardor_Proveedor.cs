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
    public partial class Frm_Buscardor_Proveedor : Form
    {
        public Frm_Buscardor_Proveedor()
        {
            InitializeComponent();
        }
     

        private void CargarGrid()
        {
            try
            {

                N_Proveedores NegocioProveedor = new N_Proveedores();
                dgvFiltroInventario.DataSource = NegocioProveedor.listaProveedores();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFiltroProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                N_Proveedores ListaProveedor = new N_Proveedores();
                List<E_Proveedores> lista = ListaProveedor.ListaProveedorBuscar();

                if (cbid.Checked)
                {
                    lista = lista.Where(l => l.Id_proveedor.StartsWith(txtid.Text)).ToList();

                }

                if (cbNombre.Checked)
                {
                    lista = lista.Where(l => l.Nombre.StartsWith(txtCedula.Text)).ToList();
                }
                if (cbCedula.Checked)
                {
                    lista = lista.Where(l => l.No_cedula.StartsWith(txtCedula.Text)).ToList();
                }
                dgvFiltroInventario.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

     
        

        private void Frm_Buscardor_Proveedor_Load(object sender, EventArgs e)
        {
          
            CargarGrid();
        }


        private Frm_Compra Padre;
        public Frm_Buscardor_Proveedor(Frm_Compra parametro)
        {
            InitializeComponent();
            Padre = parametro;
        }

       


        private void cbid_CheckedChanged(object sender, EventArgs e)
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

        private void cbNombre_CheckedChanged_1(object sender, EventArgs e)
        {

            if (cbNombre.Checked == true)
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
            }
        }

        private void cbCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCedula.Checked == true)
            {
                txtCedula.Enabled = true;
            }
            else
            {
                txtCedula.Enabled = false;
            }

        }


        private void dgvFiltroInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Padre.txtnombre.Tag = dgvFiltroInventario.CurrentRow.Cells["Id_proveedor"].Value.ToString();
            Padre.txtnombre.Text = dgvFiltroInventario.CurrentRow.Cells["Nombre"].Value.ToString();
            Padre.txttelefono.Text = dgvFiltroInventario.CurrentRow.Cells["Telefono_personal"].Value.ToString();
            Padre.txtEmail.Text = dgvFiltroInventario.CurrentRow.Cells["Email"].Value.ToString();
            Close();
        }
    }
}
