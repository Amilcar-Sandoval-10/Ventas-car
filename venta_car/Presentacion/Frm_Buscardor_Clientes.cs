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
    public partial class Frm_Buscardor_Clientes : Form
    {
        public Frm_Buscardor_Clientes()
        {
            InitializeComponent();
        }

        private void CargarGrid()
        {
            try
            {
                N_Cliente nCliente = new N_Cliente();
                dgvFiltroCliente.DataSource = nCliente.ListaCliente();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                N_Cliente cliente = new N_Cliente();
                List<E_Cliente> lista = cliente.ListaBuscarCliente();
                if (cbid.Checked)
                {

                    lista = lista.Where(l => l.Id_cliente.StartsWith(txtid.Text)).ToList();

                }

                if (cbNombre.Checked)
                {

                    lista = lista.Where(l => l.Nombre.StartsWith(txtNombre.Text)).ToList();

                }
                if (cbCedula.Checked)
                {

                    lista = lista.Where(l => l.No_cedula.StartsWith(txtCedula.Text)).ToList();

                }

                dgvFiltroCliente.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private Frm_Ventas Padre;
        public Frm_Buscardor_Clientes(Frm_Ventas parametro)
        {
            InitializeComponent();
            Padre = parametro;
        }


        private void Frm_Buscardor_Clientes_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }


        private void dgvFiltroCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Padre.txtnombre.Tag = dgvFiltroCliente.CurrentRow.Cells["Id_cliente"].Value.ToString();
            Padre.txtnombre.Text = dgvFiltroCliente.CurrentRow.Cells["Nombre"].Value.ToString();
            Padre.txtcedula.Text = dgvFiltroCliente.CurrentRow.Cells["No_cedula"].Value.ToString();
            Padre.txttelefono.Text = dgvFiltroCliente.CurrentRow.Cells["Telefono"].Value.ToString();
            Padre.txtEmail.Text = dgvFiltroCliente.CurrentRow.Cells["Email"].Value.ToString();

            this.Close();
        }
    }
}
