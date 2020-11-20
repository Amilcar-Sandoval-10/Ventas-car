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
    public partial class Frm_Proveedores : Form
    {

        private bool Modificar;


        public Frm_Proveedores()
        {
            InitializeComponent();
        }

        private void CargarGrid()
        {
            try
            {

                N_Proveedores Objeto = new N_Proveedores();
                dgvproveedor.DataSource = Objeto.listaProveedores();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }


        private void btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Habilitar(PanelInventario);
            txt_Cedula.Focus();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Desabilitar(PanelInventario);
            Global.Limpiar(PanelInventario);
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Limpiar.Enabled = false;
            btn_Cancelar.Enabled = false;
        }


        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {

            if ((Global.ValidaTextBoxVacios(PanelInventario) == false))
            {
                MessageBox.Show("Necesita llenar todos los campos", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
            }
            else
            {
                try
                {
                    N_Proveedores nInventario = new N_Proveedores();
                    if (Modificar)
                    {
                        E_Proveedores Modificar_Proveedores = new E_Proveedores();
                        Modificar_Proveedores.Id_proveedor = txt_Nombres.Tag.ToString();
                        Modificar_Proveedores.No_cedula = txt_Cedula.Text;
                        Modificar_Proveedores.Nombre = txt_Nombres.Text;
                        Modificar_Proveedores.Apellido = txt_Apellidos.Text;
                        Modificar_Proveedores.Telefono_personal = Convert.ToInt32(txt_Telefono_personal.Text);
                        Modificar_Proveedores.Telefono_empresa = Convert.ToInt32(txt_Telefono_empresa.Text);
                        Modificar_Proveedores.Email = txt_Apellidos.Text;
                        if (nInventario.Modificar(Modificar_Proveedores))
                        {
                            MessageBox.Show("Se Modifico exitosamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                            Global.Limpiar(PanelInventario);
                            Modificar = false;
                        }
                    }
                    else
                    {
                        E_Proveedores GuardarProveedor = new E_Proveedores();
                        GuardarProveedor.No_cedula = txt_Cedula.Text;
                        GuardarProveedor.Nombre = txt_Nombres.Text;
                        GuardarProveedor.Apellido = txt_Apellidos.Text;
                        GuardarProveedor.Telefono_personal = Convert.ToInt32(txt_Telefono_personal.Text);
                        GuardarProveedor.Telefono_empresa = Convert.ToInt32(txt_Telefono_empresa.Text);
                        GuardarProveedor.Email = txt_Email.Text;
                        if (nInventario.Guardar(GuardarProveedor))
                        {
                            MessageBox.Show("Se guardo exitosamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                            Global.Limpiar(PanelInventario);
                        }
                    }

                    Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
                    Global.Desabilitar(PanelInventario);
                    Global.Limpiar(PanelInventario);
                    btn_Guardar.Enabled = false;
                    btn_Nuevo.Enabled = true;
                    btn_Limpiar.Enabled = false;
                    btn_Cancelar.Enabled = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

          

        }
            

        private void btn_Modificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvproveedor.SelectedRows.Count > 0)
                {
                    txt_Nombres.Tag = dgvproveedor.CurrentRow.Cells["Id_proveedor"].Value.ToString();
                    txt_Cedula.Text = dgvproveedor.CurrentRow.Cells["No_cedula"].Value.ToString();
                    txt_Nombres.Text = dgvproveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                    txt_Apellidos.Text = dgvproveedor.CurrentRow.Cells["Apellido"].Value.ToString();
                    txt_Telefono_personal.Text = dgvproveedor.CurrentRow.Cells["Telefono_personal"].Value.ToString();
                    txt_Telefono_empresa.Text = dgvproveedor.CurrentRow.Cells["Telefono_empresa"].Value.ToString();
                    txt_Email.Text = dgvproveedor.CurrentRow.Cells["Email"].Value.ToString();
                    Modificar = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Habilitar(PanelInventario);
            txt_Cedula.Focus();
            btn_Eliminar.Enabled = false;
        }


   



        private void txt_Telefono_personal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Telefono_empresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

   
        private void btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            Global.Limpiar(PanelInventario);
        }

        private void btnFiltroProveedor_Click(object sender, EventArgs e)
        {
         
            try
            {
                N_Proveedores ListaProveedor = new N_Proveedores();
                List<E_Proveedores> lista = ListaProveedor.ListaProveedorBuscar();

                
                    lista = lista.Where(l => l.Nombre.StartsWith(txtfiltro.Text)).ToList();

        
                dgvproveedor.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvproveedor.SelectedRows.Count > 0)
                {
                    txt_Nombres.Tag = dgvproveedor.CurrentRow.Cells["Id_proveedor"].Value.ToString();
                    if (MessageBox.Show("Desea eliminar el proveedor seleccionada", "Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        N_Proveedores Eliminar = new N_Proveedores();
                        E_Proveedores E_Eliminar = new E_Proveedores();

                        E_Eliminar.Id_proveedor = txt_Nombres.Tag.ToString();

                        if (Eliminar.Eliminar(E_Eliminar))
                        {
                            MessageBox.Show("Se Elimino Correctamente", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtfiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

           
        }
    }
}
