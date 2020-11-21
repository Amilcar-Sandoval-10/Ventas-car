using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Frm_Login : Form
    {
        int contador = 3;
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CrearBordeRedondeado

        public Frm_Login()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            //Region = Region.FromHrgn(CrearBordeRedondeado(0, 0, Width, Height, 100, 100));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
            "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void cbcontraseña_CheckedChanged(object sender, EventArgs e)
        {

            if (cbcontraseña.Checked == true)
            {
                txtcontraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtcontraseña.UseSystemPasswordChar = true;
            }

        }

        private void ListarTipo()
        {
            N_Usuario NegocioTipo = new N_Usuario();
            cmbTipo.DataSource = NegocioTipo.ListaUsuario();
            cmbTipo.DisplayMember = "Tipo_Usuario";
            cmbTipo.ValueMember = "Id_Usuario";
        }

        private void BtnAcceso_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtusuario.Text == "")
                {
                    errorUsuario.SetError(txtusuario, "Ingrese el Usuario");
                    return;
                }
                else if (txtcontraseña.Text == "")
                {
                    errorUsuario.SetError(txtusuario, "");
                    errorContraseña.SetError(txtcontraseña, "Ingrese la Contraseña");
                    return;
                }
                else
                {
                    errorUsuario.SetError(txtusuario, "");
                    errorContraseña.SetError(txtcontraseña, "");

                    E_Usuario Acceso = new E_Usuario
                    {
                        Usuario = txtusuario.Text,
                        Contraseña = txtcontraseña.Text
                    };

                    N_Usuario n_Usuario = new N_Usuario();
                    if (contador > 1)
                    {
                        if (n_Usuario.Acceso(Acceso))
                        {
                            if (cmbTipo.Text == "Administrador")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();
                                Presentacion.Panel_menu.Enabled = true;

                                Presentacion.Show();
                                this.Hide();
                            }
                           
                            else if (cmbTipo.Text == "Gerente")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();
                                Presentacion.Panel_menu.Enabled = true;
                                Presentacion.Show();

                                this.Hide();
                            }
                   
                            else if (cmbTipo.Text == "Vendedor")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();
                                Presentacion.btn_ventas.Enabled = true;
                                Presentacion.btn_Clientes.Enabled = true;

                                Presentacion.Btn_usuarios.Enabled = false;
                                Presentacion.btn_compra.Enabled = false;
                                Presentacion.btn_provedores.Enabled = false;
                                Presentacion.btn_Inventario.Enabled = false;
                                Presentacion.Show();
                               
                                this.Hide();
                            }
                            else if (cmbTipo.Text == "Comprador")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();

                                Presentacion.btn_Inventario.Enabled = false;
                                Presentacion.btn_ventas.Enabled = false;
                                Presentacion.btn_Clientes.Enabled = false;
                                Presentacion.Btn_usuarios.Enabled = false;

                                Presentacion.btn_compra.Enabled = true;
                                Presentacion.btn_provedores.Enabled = true;
                               

                                Presentacion.Show();

                                this.Hide();
                            }

                            else if (cmbTipo.Text == "Bodega")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();

                                Presentacion.btn_Inventario.Enabled = false;
                                Presentacion.btn_ventas.Enabled = true;
                                Presentacion.btn_Clientes.Enabled = false;
                                Presentacion.Btn_usuarios.Enabled = false;

                                Presentacion.btn_compra.Enabled = true;
                                Presentacion.btn_provedores.Enabled = true;


                                Presentacion.Show();

                                this.Hide();
                            }


                        }
                        else
                        {
                            lberror.Visible = true;
                            txtcontraseña.Text = "";
                            contador = (contador - 1);
                            lbIntentos.Visible = true;
                            lbIntentos.Text = "Intentos restantes: " + contador;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A excedido el número de intentos disponibles para ingresar al sistema", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
