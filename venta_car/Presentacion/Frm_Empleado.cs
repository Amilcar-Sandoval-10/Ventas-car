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
    public partial class Frm_Empleado : Form
    {
        public Frm_Empleado()
        {
            InitializeComponent();
        }

        private bool Modificar;
        private void Cargargrid()
        {
            try
            {
                N_Empleado NegocioEmpleado = new N_Empleado();
                dgvEmpleados.DataSource = NegocioEmpleado.ListaEmpleados();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Empleado_Load(object sender, EventArgs e)
        {
            Cargargrid();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if ((Global.ValidaTextBoxVacios(panelInventario) == false))
            {
                MessageBox.Show("Necesita llenar todos los campos", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargargrid();
            }
            else
            {

                try
                {
                    N_Empleado N_Empleado = new N_Empleado();
                    if (Modificar)
                    {
                        E_Empleado ModificarEmpleado = new E_Empleado();
                        ModificarEmpleado.Id_Empleado = Convert.ToInt32(txt_Empresa.Tag);
                        ModificarEmpleado.Id_Empresa = Convert.ToInt32(txt_Empresa.Text);
                        ModificarEmpleado.Nombre = txt_Nombre.Text;
                        ModificarEmpleado.Apellido = txt_Apellido.Text;
                        ModificarEmpleado.INSS = txt_INSS.Text;
                        ModificarEmpleado.Email = txt_Email.Text;
                        ModificarEmpleado.Direccion = txt_Direccion.Text;
                        ModificarEmpleado.No_Cedula = txt_Cedula.Text;
                        ModificarEmpleado.Telefono = Convert.ToInt32(txt_Telefono.Text);
                        ModificarEmpleado.Estado_Civil = txt_Estado.Text;
                        ModificarEmpleado.fecha_Nac = txt_Fecha.Text;
                        if (rb_Masculino.Checked == true)
                        {
                            ModificarEmpleado.Genero = "M";
                        }
                        else
                        {
                            ModificarEmpleado.Genero = "F";
                        }

                        if (N_Empleado.Modificar(ModificarEmpleado))
                        {
                            MessageBox.Show("Se Modifico exitosamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargargrid();
                            Global.Limpiar(panelInventario);
                            Modificar = false;
                        }
                    }
                    else
                    {
                        E_Empleado GuardarEmpleado = new E_Empleado();
                        GuardarEmpleado.Id_Empresa = Convert.ToInt32(txt_Empresa.Text);
                        GuardarEmpleado.Nombre = txt_Nombre.Text;
                        GuardarEmpleado.Apellido = txt_Apellido.Text;
                        GuardarEmpleado.INSS =  txt_INSS.Text;
                        GuardarEmpleado.Email = txt_Email.Text;
                        GuardarEmpleado.Direccion = txt_Direccion.Text;
                        GuardarEmpleado.No_Cedula = txt_Cedula.Text;
                        GuardarEmpleado.Telefono = Convert.ToInt32(txt_Telefono.Text);
                        GuardarEmpleado.Estado_Civil = txt_Estado.Text;
                        GuardarEmpleado.fecha_Nac = txt_Fecha.Text;
                        if (rb_Masculino.Checked == true)
                        {
                            GuardarEmpleado.Genero = "M";
                        }
                        else
                        {
                            GuardarEmpleado.Genero = "F";
                        }

                        if (N_Empleado.Guardar(GuardarEmpleado))
                        {
                            MessageBox.Show("Se guardo exitosamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargargrid();
                            Global.Limpiar(panelInventario);
                            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
                            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
                            Global.Desabilitar(panelInventario);
                            Global.Limpiar(panelInventario);
                            btn_Guardar.Enabled = false;
                            btn_Nuevo.Enabled = true;
                            btn_Limpiar.Enabled = false;
                            btn_Cancelar.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Habilitar(panelInventario);
            txt_Empresa.Focus();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    txt_Empresa.Tag = dgvEmpleados.CurrentRow.Cells["Id_Empleado"].Value.ToString();
                    txt_Empresa.Text = dgvEmpleados.CurrentRow.Cells["Id_Empresa"].Value.ToString();
                    txt_Nombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                    txt_Apellido.Text = dgvEmpleados.CurrentRow.Cells["Apellido"].Value.ToString();
                    txt_INSS.Text = dgvEmpleados.CurrentRow.Cells["INSS"].Value.ToString();
                    txt_Email.Text = dgvEmpleados.CurrentRow.Cells["Email"].Value.ToString();
                    txt_Direccion.Text = dgvEmpleados.CurrentRow.Cells["Direccion"].Value.ToString();
                    txt_Cedula.Text = dgvEmpleados.CurrentRow.Cells["No_Cedula"].Value.ToString();
                    txt_Telefono.Text = dgvEmpleados.CurrentRow.Cells["INSS"].Value.ToString();
                    txt_Estado.Text = dgvEmpleados.CurrentRow.Cells["Estado_Civil"].Value.ToString();
                    txt_Fecha.Text = dgvEmpleados.CurrentRow.Cells["fecha_Nac"].Value.ToString();

                    if (rb_Masculino.Checked == true)
                    {
                        dgvEmpleados.CurrentRow.Cells["Genero"].Value = "M";
                    }
                    else
                    {
                        dgvEmpleados.CurrentRow.Cells["Genero"].Value = "F";
                    }
                    Modificar = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Habilitar(panelInventario);
            txt_Empresa.Focus();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    txt_Nombre.Tag = dgvEmpleados.CurrentRow.Cells["Id_Empleado"].Value.ToString();
                    if (MessageBox.Show("Desea eliminar Empleado", "Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        N_Empleado nElimiar = new N_Empleado();
                        E_Empleado eEliminar = new E_Empleado();
                        eEliminar.Id_Empleado = Convert.ToInt32(txt_Nombre.Tag.ToString());

                        if (nElimiar.Eliminar(eEliminar))
                        {
                            MessageBox.Show("Se elimino correctamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Global.BotonesAccion(btn_Nuevo, btn_Guardar, btn_Modificar, btn_Eliminar, btn_Cancelar, btn_Limpiar, btn_Nuevo.Text);
            Global.Desabilitar(panelInventario);
            Global.Limpiar(panelInventario);
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Limpiar.Enabled = false;
            btn_Cancelar.Enabled = false;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(panelInventario);
        }

        private void txt_INSS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Estado_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
