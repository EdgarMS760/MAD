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

namespace MAD.Forms
{
    public partial class Form_CrearUsuario : Form
    {
        private Usuarios _UsuarioSrvs = Usuarios.GetInstance();
        public Form_CrearUsuario()
        {
            InitializeComponent();
        }

        private void BTN_CreateUser_Guardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores del correo electrónico y la contraseña desde los controles
            string correoElectronico = TXTB_CreateUser_Email.Text;
            string contrasena = TXTB_CreateUser_Pass.Text;

            // Validar el correo electrónico
            if (!ValidarCorreoElectronico(correoElectronico))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la contraseña
            if (!ValidarContrasena(contrasena))
            {
               return;
            }

            // Si las validaciones son exitosas, llamar a la función AltaUsuario para dar de alta al usuario

            _UsuarioSrvs.AltaUsuario(correoElectronico, contrasena);

            // Limpiar los controles después de dar de alta al usuario
            TXTB_CreateUser_Email.Text = string.Empty;
            TXTB_CreateUser_Pass.Text = string.Empty;
            this.Close();
        }

        private bool ValidarCorreoElectronico(string correo)
        {
            // Puedes implementar una validación más compleja si lo necesitas
            return !string.IsNullOrEmpty(correo) && correo.Contains("@") && correo.Contains(".");
        }
        private bool ValidarContrasena(string contrasena)
        {
            // Validar que la contraseña cumpla con los requisitos
            if (contrasena.Length < 6 || contrasena.Length > 15)
            {
                MessageBox.Show("La contraseña debe tener entre 6 y 15 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!contrasena.Any(char.IsUpper))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!contrasena.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe contener al menos un número.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!contrasena.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("La contraseña debe contener al menos un carácter especial.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void TXTB_CreateUser_Email_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form_CrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
