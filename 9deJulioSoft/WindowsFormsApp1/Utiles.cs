using CapaNegocio;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class Utiles
    {
        
        public static void LimpiarControles(Form FRM)
        {
            foreach (Control c in FRM.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = null;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = null;
                }

            }

        }
        #region Habilitar/Desabiltar
        public static void BloquearControles(Form FRM)
        {
            foreach (Control c in FRM.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = false;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = false;
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Enabled = false;
                }
                if (c is GroupBox | c is Panel)
                {
                    BC2(c);
                }

            }
        }

        private static void BC2(Control x)
        {
            foreach (Control h in x.Controls)
            {
                if (h is TextBox)
                {
                    ((TextBox)h).Enabled = false;
                }
                if (h is ComboBox)
                {
                    ((ComboBox)h).Enabled = false;
                }
                if (h is RadioButton)
                {
                    ((RadioButton)h).Enabled = false;
                }
            }
        }


        public static void DesbloquearControles(Form FRM)
        {
            foreach (Control c in FRM.Controls)
            {
                Type tipo = c.GetType();

                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = true;
                }
                if (c is GroupBox | c is Panel)
                {
                    DC2(c);
                }
                if(c is RadioButton)
                {
                    ((RadioButton)c).Enabled = true;
                }

            }
        }

        private static void DC2(Control x)
        {
            foreach (Control h in x.Controls)
            {
                if (h is TextBox)
                {
                    ((TextBox)h).Enabled = true;
                }
                if (h is ComboBox)
                {
                    ((ComboBox)h).Enabled = true;
                }
            }
        }
        #endregion

        public static Image ImagenUsuario()
        {
            return CapaPresentacion.Properties.Resources.usuario;
        }
    }
    //Validar email
    class Validar_email
    {
        private string correo;

        public string Correo
        {
            set
            {
                correo = value;
            }
        }
        public bool Valid()
        {
            String validacion;
            validacion = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            //validacion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, validacion))
            {
                if (Regex.Replace(correo, validacion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        
    }

}
