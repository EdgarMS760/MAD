using MAD.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD
{
    public partial class Form_CambiarContrasena : Form
    {
        public Form_CambiarContrasena()
        {
            InitializeComponent();
            MostrarContrasena();
        }

        public void MostrarContrasena()
        {
            // Verifica si hay información de usuario en la sesión
            if (!string.IsNullOrEmpty(SesionUsuario.Contrasena))
            {
                // Si hay información, muestra el correo electrónico en el TextBox correspondiente
                LBL_CambiarContra_MostrarContra.Text = SesionUsuario.Contrasena;
            }
            else
            {
                // Si no hay información de usuario, deja el TextBox en blanco
                LBL_CambiarContra_MostrarContra.Text = string.Empty;
            }
        }
        private void Form_CambiarContrasena_Load(object sender, EventArgs e)
        {

        }
        private void BTN_CambiarPass_Guardar_Click(object sender, EventArgs e)
        {
            string contrasenaActual = LBL_CambiarContra_MostrarContra.Text;
            string contrasenaNueva = TXTB_CambiarPass_Pass.Text;

            if (ValidarContrasena(contrasenaNueva))
            {
                Usuarios CambioContra = new Usuarios();
                CambioContra.CambiarContrasena(SesionUsuario.CorreoElectronico, contrasenaActual,contrasenaNueva);

                // Limpiar la TextBox
                TXTB_CambiarPass_Pass.Text = string.Empty;

                // Ejecutar MostrarContrasena
                MostrarContrasena();
            }
            else
            {
                MessageBox.Show("La contraseña no cumple con los requisitos mínimos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarContrasena(string contrasena)
        {
            if (contrasena.Length < 6 || contrasena.Length > 15)
                return false;

            if (!contrasena.Any(char.IsUpper))
                return false;

            if (!contrasena.Any(char.IsDigit))
                return false;

            if (!contrasena.Any(c => !char.IsLetterOrDigit(c)))
                return false;

            return true;
        }
    }
}
