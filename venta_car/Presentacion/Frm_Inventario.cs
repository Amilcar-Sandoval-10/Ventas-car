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
    public partial class Frm_Inventario : Form
    {
        private bool Modificar;

        public Frm_Inventario()
        {
            InitializeComponent();
        }



        private void CargarGrid()
        {
            try
            {
                N_Inventario N_Inventario = new N_Inventario();
                dataGridView1.DataSource = N_Inventario.Listainventario();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_añadir, btn_Modificar, Btn_quitar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Habilitar(panel_inventario);
            txt_marca.Focus();
            Btn_quitar.Enabled = false;
            btn_Modificar.Enabled = false;
            panel_inventario.Enabled = true;

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            if (Global.ValidaTextBoxVacios(panel_inventario) == false)

            {
                MessageBox.Show("Necesita llenar todos los campos", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
            }

            else
            {
                try
                {
                    N_Inventario n_Inventario = new N_Inventario();

                    if (Modificar)
                    {
                        E_Inventario Modi = new E_Inventario();

                        Modi.Id_producto = txt_marca.Tag.ToString();
                        Modi.Marca = txt_marca.Text;
                        Modi.Modelo = txt_modelo.Text;
                        Modi.Precio = Convert.ToInt32(txt_precio.Text);
                        Modi.Stock = Convert.ToInt32(txt_Stock.Text);
                        Modi.Stock_max = Convert.ToInt32(txt_Stock_max.Text);
                        Modi.Stock_min = Convert.ToInt32(txt_Stock_min.Text);

                        if (n_Inventario.Modificar(Modi))
                        {
                            MessageBox.Show("Se Modifico exitosamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                            Global.Limpiar(panel_inventario);
                            Modificar = false;

                            txt_marca.Clear();//En teoria deberia guardar ya
                            txt_modelo.Clear();
                            txt_precio.Clear();
                            txt_Stock_max.Clear();
                            txt_Stock_min.Clear();
                            txt_Stock.Clear();
                            btn_añadir.Enabled = false;
                            btn_Modificar.Enabled = false;
                            Btn_quitar.Enabled = false;
                            panel_inventario.Enabled = false;

                        }


                    }

                    else
                    {
                        E_Inventario GR = new E_Inventario();

                        GR.Marca = txt_marca.Text;
                        GR.Modelo = txt_modelo.Text;
                        GR.Precio = Convert.ToInt32(txt_precio.Text);
                        GR.Stock = Convert.ToInt32(txt_Stock.Text);
                        GR.Stock_max = Convert.ToInt32(txt_Stock_max.Text);
                        GR.Stock_min = Convert.ToInt32(txt_Stock_min.Text);

                        if (n_Inventario.Guardar(GR))
                        {
                            MessageBox.Show("Se Modifico exitosamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                            Global.Limpiar(panel_inventario);
                            Modificar = false;

                        }

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//ESto es por si hay un error
                }


                Global.BotonesAccion(btn_Nuevo, btn_añadir, btn_Modificar, Btn_quitar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
                Global.Desabilitar(panel_inventario);
                Global.Limpiar(panel_inventario);
                btn_añadir.Enabled = false;
                btn_Nuevo.Enabled = true;
                btn_Limpiar.Enabled = false;
                btn_Cancelar.Enabled = false;

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_añadir.Enabled = false;
            btn_Modificar.Enabled = true;
            btn_Cancelar.Enabled = false;
            Btn_quitar.Enabled = true;
            btn_Nuevo.Enabled = true;
            panel_inventario.Enabled = false;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(panel_inventario);

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txt_marca.Tag = dataGridView1.CurrentRow.Cells["Id_producto"].Value.ToString();
                    txt_marca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                    txt_modelo.Text = dataGridView1.CurrentRow.Cells["Modelo"].Value.ToString();
                    txt_precio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                    txt_Stock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                    txt_Stock_max.Text = dataGridView1.CurrentRow.Cells["Stock_max"].Value.ToString();
                    txt_Stock_min.Text = dataGridView1.CurrentRow.Cells["Stock_min"].Value.ToString();

                    Modificar = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//ESto es por si hay un error

            }
            

            Global.BotonesAccion(btn_Nuevo, btn_añadir, btn_Modificar, Btn_quitar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Habilitar(panel_inventario);
            txt_marca.Focus();
            btn_añadir.Enabled = false;

        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txt_marca.Tag = dataGridView1.CurrentRow.Cells["Id_producto"].Value.ToString();

                    if (MessageBox.Show("Quieres eliminar este Producto?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        E_Inventario Elim = new E_Inventario();

                        N_Inventario n_Inventario = new N_Inventario();

                        Elim.Id_producto = txt_marca.Tag.ToString();

                        if (n_Inventario.Eliminar(Elim))
                        {
                            MessageBox.Show("Se elimino correctamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                            CargarGrid();
                            txt_marca.Clear();
                            txt_modelo.Clear();
                            txt_precio.Clear();
                            txt_Stock_max.Clear();
                            txt_Stock_min.Clear();
                            txt_Stock.Clear();

                            btn_añadir.Enabled = false;
                            btn_Modificar.Enabled = false;
                            Btn_quitar.Enabled = false;
                            panel_inventario.Enabled = false;
                        }

                    }


                }

                else
                {
                    MessageBox.Show("Se Elimino Correctamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnFiltroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                N_Inventario Invenario = new N_Inventario();
                List<E_Inventario> lista = Invenario.ListaInventarioBuscar();

                lista = lista.Where(l => l.Marca.StartsWith(txtfiltro.Text)).ToList();


                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
