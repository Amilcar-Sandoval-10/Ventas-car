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
    public partial class Frm_Compra : Form
    {
        public Frm_Compra()
        {
            InitializeComponent();
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            Frm_Buscardor_Proveedor filtroProveedor = new Frm_Buscardor_Proveedor(this);
            filtroProveedor.ShowDialog();
        }

    
        DateTime Fecha = DateTime.Now;
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_añadir, Btn_quitar, btnBuscarProd, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            btn_añadir.Enabled = true;
            btnBuscarProveedor.Enabled = true;
            nudCantidad.Enabled = true;
            btnBuscarProd.Enabled = true;
            Btn_quitar.Enabled = false;
            Global.Habilitar(paneldetalle);
            Global.Habilitar(panelcompra);
            

            txtfecha.Text = Fecha.ToShortDateString();
        }

        private void Btb_Quitar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvCompra.SelectedRows.Count > 0)
                {
                    txtnombre.Tag = dgvCompra.CurrentRow.Cells["Id_compra"].Value.ToString();
                    if (MessageBox.Show("Desea eliminar la Compra seleccionada", "Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        N_Compra Factura = new N_Compra();
                        E_Compra E_Factura = new E_Compra();

                        E_Factura.Id_compra = Convert.ToInt32(txtnombre.Tag.ToString());

                        if (Factura.Eliminar(E_Factura))
                        {
                            MessageBox.Show("Se Elimino Correctamente", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            btnBuscarProd.Enabled = false;
            Global.Limpiar(paneldetalle);
            Global.Limpiar(panelcompra);
            Global.Limpiar(panel1);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_añadir, Btn_quitar, btnBuscarProd, btn_Cancelar, btn_Limpiar, btn_Cancelar.Text );
            btnBuscarProd.Enabled = false;
            btnBuscarProveedor.Enabled = false;
            nudCantidad.Enabled = false;
            Btn_quitar.Enabled = true;
            Global.Desabilitar(paneldetalle);
            Global.Desabilitar(panelcompra);
            Global.Limpiar(paneldetalle);
            Global.Limpiar(panelcompra);
            Global.Limpiar(panel1);
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            Frm_Buscador_Inventario filtroProducto = new Frm_Buscador_Inventario(this);
            filtroProducto.ShowDialog();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarGrid()
        {
            try
            {
                N_Compra N_Compra = new N_Compra();
                dgvCompra.DataSource = N_Compra.ListaFacturaCompra();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void Frm_Compra_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

       
        private void btn_añadir_Click(object sender, EventArgs e)
        {


            try
            {
                E_Compra Compra = new E_Compra();
                Compra.Id_proveedor = Convert.ToInt32(txtnombre.Tag.ToString());
                Compra.Id_producto = Convert.ToInt32(txtMarca.Tag.ToString());
                Compra.Fecha_compra = txtfecha.Text.ToString();
                Compra.Precio_compra = Convert.ToDouble(txtPrecio.Text.ToString());
                Compra.Cantidad = Convert.ToInt32(nudCantidad.Value.ToString());
                Compra.Subtotal = Convert.ToDouble(txtSubtotal.Text);
                Compra.Iva = Convert.ToDouble(TxtIVA.Text);
                Compra.Descuento = Convert.ToDouble(txtDescuento.Text);
                Compra.Stock = Convert.ToDouble(Txttotal2.Text);
                N_Compra n_FacturaCliente = new N_Compra();
                if (n_FacturaCliente.Guardar(Compra))
                {
                    MessageBox.Show("Se guardo exitosamente", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Global.BotonesAccion(btn_Nuevo, btn_añadir, Btn_quitar, btnBuscarProd, btn_Cancelar, btn_Limpiar, btn_Cancelar.Text);
            btnBuscarProd.Enabled = false;
            btnBuscarProveedor.Enabled = false;
            nudCantidad.Enabled = false;
            Btn_quitar.Enabled = true;
            Global.Desabilitar(paneldetalle);
            Global.Desabilitar(panelcompra);
            Global.Limpiar(paneldetalle);
            Global.Limpiar(panelcompra);
            Global.Limpiar(panel1);


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

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
