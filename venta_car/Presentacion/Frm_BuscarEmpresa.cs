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
    public partial class Frm_BuscarEmpresa : Form
    {
        public Frm_BuscarEmpresa()
        {
            InitializeComponent();
        }

        private Frm_Empleado Padre;
        public Frm_BuscarEmpresa(Frm_Empleado parametro)
        {
            InitializeComponent();

            Padre = parametro;
        }
        private void CargarGrid()
        {
            try
            {
                N_Empresa   nInventario = new N_Empresa();
                dgvFiltroInventario.DataSource = nInventario.ListaEmpresa();

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
                N_Empresa Invenario = new N_Empresa();
                List<E_Empresa> lista = Invenario.ListaEmpresa();
                if (cbid.Checked)
                {

                    lista = lista.Where(l => l.Id_empresa.StartsWith(txtid.Text)).ToList();

                }

                if (cbnombre.Checked)
                {

                    lista = lista.Where(l => l.Nombre.StartsWith(txtnombre.Text)).ToList();

                }
              

                dgvFiltroInventario.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Frm_BuscarEmpresa_Load(object sender, EventArgs e)
        {
            CargarGrid();
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
                txtid.Clear();
            }

        }

        private void cbnombre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbnombre.Checked == true)
            {
                txtnombre.Enabled = true;
            }
            else
            {
                txtnombre.Enabled = false;
                txtnombre.Clear();
            }
        }

        private void dgvFiltroInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Padre.txt_Empresa.Text = dgvFiltroInventario.CurrentRow.Cells["Id_empresa0"].Value.ToString();
 
            this.Close();
        }
    }
}
