using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Presentacion : Form
    {
        public Frm_Presentacion()
        {
            InitializeComponent();
        }

        //Metodo para abrir formulario dentro del panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Panel_formularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                Panel_formularios.Controls.Add(formulario);
                Panel_formularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            
            }
        
            else
            {
                formulario.BringToFront();
            }
        }


        private void btn_compra_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Compra>();
            Panel_menu.Visible = true;
            Panel_menu.Height = btn_compra.Height;
            Panel_menu.Top = btn_compra.Top;

        

        }



        private void btn_provedores_Click(object sender, EventArgs e)
        {


            AbrirFormulario<Frm_Proveedores>();
            Panel_menu.Visible = true;
            Panel_menu.Height = btn_provedores.Height;
            Panel_menu.Top = btn_provedores.Top;
           
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario<Frm_Ventas  >();
            Panel_menu.Visible = true;
            Panel_menu.Height = btn_ventas.Height;
            Panel_menu.Top = btn_ventas.Top;
          


        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Inventario>();
            Panel_menu.Visible = true;
            Panel_menu.Height = btn_ventas.Height;
            Panel_menu.Top = btn_ventas.Top;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Empresa>();
            Panel_menu.Visible = true;
            Panel_menu.Height = btn_ventas.Height;
            Panel_menu.Top = btn_ventas.Top;

        }
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Cliente>();
            Panel_menu.Visible = true;
            Panel_menu.Height = btn_ventas.Height;
            Panel_menu.Top = btn_ventas.Top;

        }
        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Empleado>();
            Panel_menu.Visible = true;
            Panel_menu.Height = btn_ventas.Height;
            Panel_menu.Top = btn_ventas.Top;
        }
        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Frm_Login frm2 = new Frm_Login();

            this.Hide();

            frm2.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
            "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                Application.ExitThread();
            }

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     
    }
}
