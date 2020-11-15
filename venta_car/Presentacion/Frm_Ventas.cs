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
    public partial class Frm_Ventas : Form
    {
        public Frm_Ventas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            Frm_Buscardor_Clientes filtro = new Frm_Buscardor_Clientes(this);
            filtro.ShowDialog();

        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {

            Frm_Buscador_Producto filtro = new Frm_Buscador_Producto(this);
            filtro.ShowDialog();
        }

        DateTime Fecha = DateTime.Now;
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_añadir, Btn_quitar, btnBuscarProd, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            btn_añadir.Enabled = true;
            btnBuscarCliente.Enabled = true;
            nudCantidad.Enabled = true;
            btnBuscarProd.Enabled = true;
            Btn_quitar.Enabled = false;
            Global.Habilitar(paneldetalle);
            Global.Habilitar(panelcompra);

            txtfecha.Text = Fecha.ToShortDateString();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_añadir, Btn_quitar, btnBuscarProd, btn_Cancelar, btn_Limpiar, btn_Cancelar.Text);
            btnBuscarProd.Enabled = false;
            btnBuscarCliente.Enabled = false;
            nudCantidad.Enabled = false;
            Btn_quitar.Enabled = true;
            Global.Desabilitar(paneldetalle);
            Global.Desabilitar(panelcompra);
            Global.Limpiar(paneldetalle);
            Global.Limpiar(panelcompra);
            Global.Limpiar(panel1);
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
          
            Global.Limpiar(paneldetalle);
            Global.Limpiar(panelcompra);
            Global.Limpiar(panel1);
        }


        private void CargarGrid()
        {
            try
            {
                N_Ventas N_Ventas = new N_Ventas();
                dgvVenta.DataSource = N_Ventas.ListaVenta();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void btn_añadir_Click(object sender, EventArgs e)
        {

            try
            {
                E_Ventas venta = new E_Ventas();

                venta.Id_producto = Convert.ToInt32(txtnombre.Tag.ToString());
                venta.Id_cliente = Convert.ToInt32(txtMarca.Tag.ToString());
                venta.Fecha_venta = txtfecha.Text.ToString();
                venta.Precio_venta = Convert.ToDouble(txtPrecio.Text.ToString());
                venta.stock = Convert.ToInt32(nudCantidad.Value.ToString());
                venta.Iva = Convert.ToDouble(TxtIVA.Text);
                venta.Descuento = Convert.ToDouble(txtDescuento.Text);
                venta.Total = Convert.ToDouble(Txttotal2.Text);

                N_Ventas n_Factura = new N_Ventas();
                if (n_Factura.Guardar(venta))
                {
                    MessageBox.Show("Se guardo exitosamente", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Global.BotonesAccion(btn_Nuevo, btn_añadir, Btn_quitar, btnBuscarProd, btn_Cancelar, btn_Limpiar, btn_Cancelar.Text);
            btnBuscarProd.Enabled = false;
            btnBuscarCliente.Enabled = false;
            nudCantidad.Enabled = false;
            Btn_quitar.Enabled = true;
            Global.Desabilitar(paneldetalle);
            Global.Desabilitar(panelcompra);
            Global.Limpiar(paneldetalle);
            Global.Limpiar(panelcompra);
            Global.Limpiar(panel1);


        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVenta.SelectedRows.Count > 0)
                {
                    txtnombre.Tag = dgvVenta.CurrentRow.Cells["Id_venta"].Value.ToString();
                    if (MessageBox.Show("Desea eliminar la Compra seleccionada", "Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        N_Ventas Factura = new N_Ventas();
                        E_Ventas E_Factura = new E_Ventas();

                        E_Factura.Id_venta= Convert.ToInt32(txtnombre.Tag.ToString());

                        if (Factura.Eliminar(E_Factura))
                        {
                            MessageBox.Show("Se Elimino Correctamente", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            double Cantidad = Convert.ToDouble(nudCantidad.Value);
            double Precio = Convert.ToDouble(txtPrecio.Text);
            double SubtotalAntesdeIVA = Cantidad * Precio;
            txtSubtotal.Text = SubtotalAntesdeIVA.ToString();
            double Iva = (SubtotalAntesdeIVA * 0.15);
            double subtotal = Iva + SubtotalAntesdeIVA;
            TxtIVA.Text = Iva.ToString();
            double Descuento = Convert.ToDouble(txtDescuento.Text);
            double Total = (subtotal - Descuento);
            Txttotal2.Text = Total.ToString();
        }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}
