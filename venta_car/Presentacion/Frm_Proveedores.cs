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


        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Habilitar(PanelInventario);
            txt_Cedula.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Desabilitar(PanelInventario);
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(PanelInventario);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                N_Proveedores nProveedor = new N_Proveedores();
                if (Modificar)
                {
                    E_Proveedores Modificar_Proveedores = new E_Proveedores();

                    Modificar_Proveedores.Id_proveedor = txt_Nombres.Tag.ToString();
                    Modificar_Proveedores.No_cedula = txt_Cedula.Text;
                    Modificar_Proveedores.Nombre = txt_Nombres.Text;
                    Modificar_Proveedores.Apellido = txt_Apellidos.Text;
                    Modificar_Proveedores.Telefono_personal = Convert.ToInt32(txt_Telefono_personal.Text);
                    Modificar_Proveedores.Telefono_empresa = Convert.ToInt32(txt_Telefono_empresa.Text);
                    Modificar_Proveedores.Email = txt_Email.Text;
                    
                    if (nProveedor.Modificar(Modificar_Proveedores))
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
                        GuardarProveedor.Id_proveedor = txt_Nombres.Tag.ToString();
                        GuardarProveedor.No_cedula = txt_Cedula.Text;
                        GuardarProveedor.Nombre = txt_Nombres.Text;
                        GuardarProveedor.Apellido = txt_Apellidos.Text;
                        GuardarProveedor.Telefono_personal = Convert.ToInt32(txt_Telefono_personal.Text);
                        GuardarProveedor.Telefono_empresa = Convert.ToInt32(txt_Telefono_empresa.Text);
                        GuardarProveedor.Email = txt_Email.Text;
                  
                        if (nProveedor.Guardar(GuardarProveedor))
                        {
                            MessageBox.Show("Se guardo exitosamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                            Global.Limpiar(PanelInventario);
                            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
                        }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
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
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvproveedor.SelectedRows.Count > 0)
                {
                    txt_Nombres.Tag = dgvproveedor.CurrentRow.Cells["Id_proveedor"].Value.ToString();
                    if (MessageBox.Show("Desea eliminar la Compra seleccionada", "Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        N_Compra Factura = new N_Compra();
                        E_Compra E_Factura = new E_Compra();

                        E_Factura.Id_compra = Convert.ToInt32(txt_Nombres.Tag.ToString());

                        if (Factura.Eliminar(E_Factura))
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

        private void dgvproveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
