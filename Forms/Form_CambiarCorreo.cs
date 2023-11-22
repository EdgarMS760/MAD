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
    public partial class Form_CambiarCorreo : Form
    {
        private Usuarios _UsuarioSrvs = Usuarios.GetInstance();

        public Form_CambiarCorreo()
        {
            InitializeComponent();
            MostrarCorreo();
        }
        public void MostrarCorreo()
        {
            // Verifica si hay información de usuario en la sesión
            if (!string.IsNullOrEmpty(SesionUsuario.CorreoElectronico))
            {
                // Si hay información, muestra el correo electrónico en el TextBox correspondiente
                LBL_CambiarCorreo_MostrarCorreo.Text = SesionUsuario.CorreoElectronico;
            }
            else
            {
                // Si no hay información de usuario, deja el TextBox en blanco
                LBL_CambiarCorreo_MostrarCorreo.Text = string.Empty;
            }
        }
        private void Form_CambiarCorreo_Load(object sender, EventArgs e)
        {

        }
        private void BTN_CambiarCorreo_Guardar_Click(object sender, EventArgs e)
        {
            string CorreoActual = SesionUsuario.CorreoElectronico;
            string CorreoNuevo = TXTB_CambiarCorreo_CorreoNew.Text;

            // Validar el nuevo correo electrónico
            if (!ValidarCorreoElectronico(CorreoNuevo))
            {
                MessageBox.Show("El nuevo correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el nuevo correo no sea el mismo que el actual
            if (CorreoNuevo.Equals(CorreoActual, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El nuevo correo electrónico no puede ser el mismo que el actual.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _UsuarioSrvs.CambiarCorreoElectronico(CorreoActual, CorreoNuevo);
            // Limpiar el TextBox
            TXTB_CambiarCorreo_CorreoNew.Text = string.Empty;

            // Ejecutar MostrarCorreo
            MostrarCorreo();
        }
        private bool ValidarCorreoElectronico(string correo)
        {
            // Puedes implementar una validación más compleja si lo necesitas
            return !string.IsNullOrEmpty(correo) && correo.Contains("@") && correo.Contains(".");
        }

    }
}
