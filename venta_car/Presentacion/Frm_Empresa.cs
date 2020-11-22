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
    public partial class Frm_Empresa : Form
    {
        private bool Modificar;
        public Frm_Empresa()
        {
            InitializeComponent();
        }

        private void Cargargrid()
        {
            try
            {
                N_Empresa NegocioEmpresa = new N_Empresa();
                dgv_Empresa.DataSource = NegocioEmpresa.ListaEmpresa();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            if ((Global.ValidaTextBoxVacios(panelEmpresa) == false))
            {
                MessageBox.Show("Necesita llenar todos los campos", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargargrid();
            }
            else
            {
                try
                {
                    N_Empresa N_Empresa = new N_Empresa();
                    if (Modificar)
                    {

                        E_Empresa ModficaeEmpresa = new E_Empresa();
                        ModficaeEmpresa.Id_empresa = txt_Nombre.Tag.ToString();
                        ModficaeEmpresa.Nombre = txt_Nombre.Text;
                        ModficaeEmpresa.Direccion = txt_Direccion.Text;
                        ModficaeEmpresa.Telefono = Convert.ToInt32(txt_Telefono.Text);

                        if (N_Empresa.Modificar(ModficaeEmpresa))
                        {
                            MessageBox.Show("Se Modifico exitosamente", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargargrid();
                            Global.Limpiar(panelEmpresa);
                            Modificar = false;


                        }
                    }
                    else
                    {
                        E_Empresa GuardarEmpresa = new E_Empresa();
                        GuardarEmpresa.Nombre = txt_Nombre.Text;
                        GuardarEmpresa.Direccion = txt_Direccion.Text;
                        GuardarEmpresa.Telefono = Convert.ToInt32(txt_Telefono.Text);

                        if (N_Empresa.Guardar(GuardarEmpresa))
                        {
                            MessageBox.Show("Se guardo exitosamente", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargargrid();
                            Global.Limpiar(panelEmpresa);
                            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
                        }
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Empresa.SelectedRows.Count > 0)
                {
                    txt_Nombre.Tag = dgv_Empresa.CurrentRow.Cells["Id_Empresa"].Value.ToString();
                    txt_Nombre.Text = dgv_Empresa.CurrentRow.Cells["Nombre"].Value.ToString();
                    txt_Direccion.Text = dgv_Empresa.CurrentRow.Cells["Direccion"].Value.ToString();
                    txt_Telefono.Text = dgv_Empresa.CurrentRow.Cells["Telefono"].Value.ToString();


                    Modificar = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Empresa.SelectedRows.Count > 0)
                {
                    txt_Nombre.Tag = dgv_Empresa.CurrentRow.Cells["Id_Empresa"].Value.ToString();
                    if (MessageBox.Show("Desea eliminar Empleado", "Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        N_Empresa nElimiar = new N_Empresa();
                        E_Empresa eEliminar = new E_Empresa();
                        eEliminar.Id_empresa = txt_Nombre.Tag.ToString();

                        if (nElimiar.Eliminar(eEliminar))
                        {
                            MessageBox.Show("Se elimino correctamente", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargargrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Limpiar, btn_Cancelar, btn_Eliminar, btn_Nuevo.Text);
            Global.Desabilitar(panelEmpresa);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Guardar, btn_Modificar, btn_Nuevo, btn_Cancelar, btn_Eliminar, btn_Limpiar, btn_Nuevo.Text);
            Global.Habilitar(panelEmpresa);
            txt_Nombre.Focus();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(panelEmpresa);
        }

        private void Frm_Empresa_Load(object sender, EventArgs e)
        {
            Cargargrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Presentacion frm = new Frm_Presentacion();
            frm.Panel_menu.Enabled = true;

            this.Hide();
            this.Close();

        }
    }
}
