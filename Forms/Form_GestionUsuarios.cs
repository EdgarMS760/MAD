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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MAD.Forms
{
    public partial class Form_GestionUsuarios : Form
    {
        Usuarios _UsuarioSrvs = Usuarios.GetInstance();
        private static readonly Random random = new Random();
        public Form_GestionUsuarios()
        {
            InitializeComponent();
        }

        private void BTN_GestionUsuarios_Buscar_Click(object sender, EventArgs e)
        {
            string email = TXTB_GestionUsuarios_Buscar.Text;
            if (email == SesionUsuario.CorreoElectronico)
            {
                MessageBox.Show("favor de ver su informacion desde la pestaña de configuracion de usuario");
            }
            else
            {
                if (_UsuarioSrvs.BuscarUsuario(email))
                {
                    LBL_GestionUsuarios_MostrarCorreo.Text = gestionUsuariosDto.email;
                    if (gestionUsuariosDto.estado == "ACTIVO")
                    {
                        RB_GestionUsuarios_Activo.Checked = true;
                        RB_GestionUsuarios_Inactivo.Checked = false;
                    }
                    else

                    {

                        DialogResult result = MessageBox.Show("Este usuario esta inactivo ¿desea generar contraseña una temporal?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string contraseñatemporal = genPassTemporal();
                            _UsuarioSrvs.addTemporalPass(contraseñatemporal, LBL_GestionUsuarios_MostrarCorreo.Text);
                            MessageBox.Show($"ATENCION!! UNA VEZ FUERA NO SE PODRA VOLVER A VER ESTA CONTRASEÑA TEMPORAL: {contraseñatemporal}", "contraseña temporal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        RB_GestionUsuarios_Activo.Checked = false;
                        RB_GestionUsuarios_Inactivo.Checked = true;
                    }




                    if (gestionUsuariosDto.adminOrNot)
                    {
                        CHEKB_GestionUsuarios_Tipo.Checked = true;
                    }
                    else
                    {
                        CHEKB_GestionUsuarios_Tipo.Checked = false;
                    }

                }
            }
        }
        public static string genPassTemporal()
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

            int length = random.Next(8, 15);
            StringBuilder randomString = new StringBuilder(length);

            randomString.Append(charRandom("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
            randomString.Append(charRandom("abcdefghijklmnopqrstuvwxyz"));
            randomString.Append(charRandom("!@#$%^&*()_+"));
            for (int i = 3; i < length; i++)
            {
                randomString.Append(charRandom(characters));
            }

            return randomString.ToString();
        }

        private static char charRandom(string characterSet)
        {
            int index = random.Next(characterSet.Length);
            return characterSet[index];
        }


        private void BTN_GestionUsuarios_Baja_Click(object sender, EventArgs e)
        {
            string email = LBL_GestionUsuarios_MostrarCorreo.Text;
            if (gestionUsuariosDto.estado == "INACTIVO")
            {
                MessageBox.Show("este usuario ya esta inactivo");
            }
            else
            if (email.Length > 1 && email.ToLower() != "correo")
            {

                DialogResult result = MessageBox.Show("¿Estás seguro de dar de baja al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _UsuarioSrvs.BajaUsuario(LBL_GestionUsuarios_MostrarCorreo.Text);
                }
                else
                {
                    MessageBox.Show("operacion cancelada");
                }
            }
            else
            {
                MessageBox.Show("favor de buscar un usuario valido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CHEKB_GestionUsuarios_Tipo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CHEKB_GestionUsuarios_Tipo_Click(object sender, EventArgs e)
        {
            string email = LBL_GestionUsuarios_MostrarCorreo.Text;

            if (email.Length < 1 || email == "Correo")
            {
                MessageBox.Show("usuario no valido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            if (!gestionUsuariosDto.adminOrNot)
            {
                DialogResult result = MessageBox.Show("¿Estas seguro de hacer Administrador a este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _UsuarioSrvs.updAdmin(email, 1);
                    gestionUsuariosDto.adminOrNot = true;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Estas seguro de quitar permisos de Administrador a este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _UsuarioSrvs.updAdmin(email, 0);
                    gestionUsuariosDto.adminOrNot = false;
                }
            }
        }

        private void BTN_GestionUsuarios_Inactivos_Click(object sender, EventArgs e)
        {
            Form_ViewInactivos viewInactivos = new Form_ViewInactivos();
            viewInactivos.ShowDialog();

        }

        private void Form_GestionUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
