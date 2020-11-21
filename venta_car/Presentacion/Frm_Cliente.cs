using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Frm_Cliente : Form
    {

        private bool Modificar;
        public Frm_Cliente()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                N_Cliente Lista = new N_Cliente();
                List<E_Cliente> lista = Lista.ListaBuscarCliente();


                lista = lista.Where(l => l.Nombre.StartsWith(txt_id.Text)).ToList();


                dgv_clientes.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Cargargrid()
        {                         
            try
            {
                N_Cliente NegocioClientes = new N_Cliente();
                dgv_clientes.DataSource = NegocioClientes.ListaCliente();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Frm_Cliente_Load(object sender, EventArgs e)
        {

            Cargargrid();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        { 

            if((Global.ValidaTextBoxVacios(PanelInventario) == false))
            {
                MessageBox.Show("Necesita llenar todos los campos", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargargrid();
            }

            else
            {
                try
                {
                    if (Modificar == true)
                    {
                        E_Cliente modificarClientes = new E_Cliente();
                        modificarClientes.Id_cliente = txt_cedula.Tag.ToString();
                        modificarClientes.No_cedula = txt_cedula.Text;
                        modificarClientes.Nombre = txt_cedula.Text;
                        modificarClientes.Apellido = txt_cedula.Text;
                        modificarClientes.Telefono = Convert.ToInt32(txt_telefono.Text);
                        modificarClientes.Direccion = txt_direccion.Text;
                        modificarClientes.Ciudad = txt_ciudad.Text;
                        modificarClientes.Email = txt_email.Text;

                        N_Cliente nclientes = new N_Cliente();
                        if (nclientes.Editar(modificarClientes))
                        {
                            MessageBox.Show("se modifico exitosamente", "clientes");
                            Cargargrid();
                            Global.Limpiar(PanelInventario);

                            Modificar = false;
                        }
                    }
                    else
                    {
                        E_Cliente GuardarClientes = new E_Cliente();
                        GuardarClientes.No_cedula = txt_cedula.Text;
                        GuardarClientes.Nombre = txt_cedula.Text;
                        GuardarClientes.Apellido = txt_cedula.Text;
                        GuardarClientes.Telefono = Convert.ToInt32(txt_telefono.Text);
                        GuardarClientes.Direccion = txt_direccion.Text;
                        GuardarClientes.Ciudad = txt_ciudad.Text;
                        GuardarClientes.Email = txt_email.Text;

                        N_Cliente nclientes = new N_Cliente();
                        if (nclientes.Guardar(GuardarClientes))
                        {
                            MessageBox.Show("se guardo exitosamente", "clientes");
                            Cargargrid();
                            Global.Limpiar(PanelInventario);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }


                PanelInventario.Enabled = false;
                Global.Limpiar(PanelInventario);
                btn_guardar.Enabled = false;
                btn_nuevo.Enabled = true;
                btn_cancelar.Enabled = false;
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
 
            try
            {
                if (dgv_clientes.SelectedRows.Count > 0)
                {
                    txt_cedula.Tag = Convert.ToInt32(dgv_clientes.CurrentRow.Cells["Id_cliente"].Value.ToString());
                    txt_cedula.Text = dgv_clientes.CurrentRow.Cells["No_cedula"].Value.ToString();
                    txt_nombre.Text = dgv_clientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    txt_apellido.Text = dgv_clientes.CurrentRow.Cells["Apellido"].Value.ToString();
                    txt_telefono.Text = dgv_clientes.CurrentRow.Cells["Telefono"].Value.ToString();
                    txt_direccion.Text = dgv_clientes.CurrentRow.Cells["Direccion"].Value.ToString();
                    txt_ciudad.Text = dgv_clientes.CurrentRow.Cells["Ciudad"].Value.ToString();
                    txt_email.Text = dgv_clientes.CurrentRow.Cells["Email"].Value.ToString();
                    Modificar = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

            PanelInventario.Enabled = true;
            btn_nuevo.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;
            txt_cedula.Focus();
            btn_eliminar.Enabled = false;
            btn_editar.Enabled = false;

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {


            try
            {
                if (dgv_clientes.SelectedRows.Count > 0)
                {
                    txt_cedula.Tag = dgv_clientes.CurrentRow.Cells["Id_cliente"].Value.ToString();

                    if (MessageBox.Show("Quieres eliminar este cliente?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        E_Cliente Elim = new E_Cliente();

                        N_Cliente nClientes = new N_Cliente();

                        Elim.Id_cliente = txt_cedula.Tag.ToString();

                        if (nClientes.Eliminar(Elim))
                        {
                            MessageBox.Show("Se elimino correctamente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargargrid();
                        }


                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            PanelInventario.Enabled = false;
            Global.Limpiar(PanelInventario);
            btn_guardar.Enabled = false;
            btn_nuevo.Enabled = true;        
            btn_cancelar.Enabled = false;
            btn_eliminar.Enabled = true;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            PanelInventario.Enabled = true;
            btn_nuevo.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;
            txt_cedula.Focus();
            btn_eliminar.Enabled = false;
            btn_editar.Enabled = false;
        }
    }
}
