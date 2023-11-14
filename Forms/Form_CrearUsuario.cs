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

            // Llamar a la función AltaUsuario para dar de alta al usuario
            Usuarios usuarios = new Usuarios();
            usuarios.AltaUsuario(correoElectronico, contrasena);

            // Limpiar los controles después de dar de alta al usuario
            TXTB_CreateUser_Email.Text = string.Empty;
            TXTB_CreateUser_Pass.Text = string.Empty;
        }

        private void TXTB_CreateUser_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
