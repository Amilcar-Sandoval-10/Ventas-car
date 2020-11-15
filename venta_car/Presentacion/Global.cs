 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class Global
    {

        public static void BotonesAccion(Button btn_Nuevo, Button btn_Guardar, Button btn_Modificar, Button btn_Buscar, Button btn_Cancelar, Button btn_Limpiar, string Accion)
        {

            try
            {
                switch (Accion)
                {
                    case "Nuevo":
                        btn_Guardar.Enabled = true;
                        btn_Modificar.Enabled = true;
                        btn_Cancelar.Enabled = true;
                        btn_Buscar.Enabled = true;
                        btn_Limpiar.Enabled = true;
                        btn_Nuevo.Enabled = false;
                        break;
                    case "Guardar":
                        btn_Nuevo.Enabled = true;
                        btn_Guardar.Enabled = false;
                        btn_Modificar.Enabled = false;
                        btn_Cancelar.Enabled = false;
                        btn_Buscar.Enabled = false;
                        btn_Limpiar.Enabled = false;
                        break;
                    case "Cancelar":
                        btn_Nuevo.Enabled = true;
                        btn_Guardar.Enabled = false;
                        btn_Modificar.Enabled = false;
                        btn_Cancelar.Enabled = false;
                        btn_Buscar.Enabled = false;
                        btn_Limpiar.Enabled = false;
                        
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static void Limpiar(Panel contenedor)
        {
            try
            {
                foreach (var item in contenedor.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                    else if (item is MaskedTextBox)
                    {
                        ((MaskedTextBox)item).Clear();
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void Habilitar(Panel contenedor)
        {
            try
            {
                foreach (var item in contenedor.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Enabled = true;
                    }
                    else if (item is MaskedTextBox)
                    {
                        ((MaskedTextBox)item).Enabled = true;
                    }
                    else if (item is DateTimePicker)
                    {
                        ((DateTimePicker)item).Enabled = true;
                    }
                    else if (item is RadioButton)
                    {
                        ((RadioButton)item).Enabled = true;
                    }
                    else if (item is ComboBox)
                    {
                        ((ComboBox)item).Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Desabilitar(Panel contenedor)
        {
            try
            {
                foreach (var item in contenedor.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Enabled = false;
                    }
                    else if (item is MaskedTextBox)
                    {
                        ((MaskedTextBox)item).Enabled = false;
                    }
                    else if (item is DateTimePicker)
                    {
                        ((DateTimePicker)item).Enabled = false;
                    }
                    else if (item is RadioButton)
                    {
                        ((RadioButton)item).Enabled = false;
                    }
                    else if (item is ComboBox)
                    {
                        ((ComboBox)item).Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool ValidaTextBoxVacios(Panel Contenedor)
        {

            foreach (Control control in Contenedor.Controls)
            {

                if (control.GetType().Equals(typeof(TextBox)))
                {

                    if (control.Text.Equals(""))
                    {

                        return false;
                    }
                }
                else if (control.GetType().Equals(typeof(MaskedTextBox)))
                {
                    if (control.Text.Equals(""))
                    {
                        return false;
                    }
                }
            }
            return true;
        }




    }
}
