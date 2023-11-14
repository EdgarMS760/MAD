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
                MessageBox.Show("La contraseña no cumple con los requisitos. Minimo 6 caracteres, una mayuscula, un numero y un caracter especial", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si las validaciones son exitosas, llamar a la función AltaUsuario para dar de alta al usuario
            Usuarios usuarios = new Usuarios();
            usuarios.AltaUsuario(correoElectronico, contrasena);

            // Limpiar los controles después de dar de alta al usuario
            TXTB_CreateUser_Email.Text = string.Empty;
            TXTB_CreateUser_Pass.Text = string.Empty;
        }

        private bool ValidarCorreoElectronico(string correo)
        {
            // Puedes implementar una validación más compleja si lo necesitas
            return !string.IsNullOrEmpty(correo) && correo.Contains("@") && correo.Contains(".");
        }

        private bool ValidarContrasena(string contrasena)
        {
            // La contraseña debe tener al menos 6 caracteres, una mayúscula, un número y un carácter especial
            return contrasena.Length >= 6 &&
                   contrasena.Any(char.IsUpper) &&
                   contrasena.Any(char.IsDigit) &&
                   contrasena.Any(c => !char.IsLetterOrDigit(c));
        }

        private void TXTB_CreateUser_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_CrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
