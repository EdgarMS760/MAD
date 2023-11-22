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
    public partial class Form_EditUser : Form
    {
        Usuarios _UsuarioSrvs = Usuarios.GetInstance();
        public Form_EditUser()
        {
            InitializeComponent();
            MostrarInformacion();
        }

        public void MostrarInformacion()
        {
            // Verifica si hay información de usuario en la sesión
            if (!string.IsNullOrEmpty(SesionUsuario.CorreoElectronico))
            {
                // Si hay información, muestra el correo electrónico en el TextBox correspondiente
                LBL_EditUser_MostrarCorreo.Text = SesionUsuario.CorreoElectronico;
                LBL_EditUser_MostrarContraseña.Text = SesionUsuario.Contrasena;
                TXTB_EditUser_Name.Text = SesionUsuario.NombreCom;
                DTP_EditUser_BirthDate.Value = SesionUsuario.FechaNac;
                if (SesionUsuario.Genero == 'M')
                {
                    RB_EditUser_Male.Checked = true;
                }
                else if (SesionUsuario.Genero == 'F')
                {
                    RB_EditUser_Female.Checked = true;
                }
                CHEKB_EditUser_Tipo.Checked = SesionUsuario.Tipo;

                if (SesionUsuario.Estatus == "ACTIVO")
                {
                    RB_EditUser_Activo.Checked = true;
                }
                else if (SesionUsuario.Estatus == "INACTIVO")
                {
                    RB_EditUser_Inactivo.Checked = true;
                }
            }
            else
            {
                LBL_EditUser_MostrarCorreo.Text = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pic_EditUser_ClickExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_EditUser_Editar_Click(object sender, EventArgs e)
        {
            TXTB_EditUser_Name.Enabled = true;
            DTP_EditUser_BirthDate.Enabled = true;
            RB_EditUser_Male.Enabled = true;
            RB_EditUser_Female.Enabled = true;
            BTN_EditUser_Guardar.Enabled = true;
        }

        private void BTN_EditUser_Guardar_Click(object sender, EventArgs e)
        {
            char genero = ' ';
            string NombreCom = TXTB_EditUser_Name.Text;
            DateTime FechaNaci = DTP_EditUser_BirthDate.Value;
            if (RB_EditUser_Male.Checked)
            {
                genero = 'M';
            }
            else if (RB_EditUser_Female.Checked)
            {
                genero = 'F';
            }
            bool tipoUsuario = CHEKB_EditUser_Tipo.Checked;

            if (!ValidarFechaNacimiento(FechaNaci))
            {
                MessageBox.Show("La fecha de nacimiento no es válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _UsuarioSrvs.ActualizaInfoPersonal(SesionUsuario.CorreoElectronico, genero, NombreCom, FechaNaci);

            TXTB_EditUser_Name.Enabled = false;
            DTP_EditUser_BirthDate.Enabled = false;
            RB_EditUser_Male.Enabled = false;
            RB_EditUser_Female.Enabled = false;
            CHEKB_EditUser_Tipo.Enabled = false;
            BTN_EditUser_Guardar.Enabled = false;

            MostrarInformacion();
            this.Refresh();

        }
        private bool ValidarFechaNacimiento(DateTime fechaNacimiento)
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime fechaLimiteInferior = new DateTime(1900, 1, 1);

            return fechaNacimiento <= fechaHoy && fechaNacimiento >= fechaLimiteInferior;
        }

        private void TXTB_EditUser_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_EditUser_CambiarContra_Click(object sender, EventArgs e)
        {
            Form_CambiarContrasena _formCamContra = new Form_CambiarContrasena();
            _formCamContra.ShowDialog();
        }

        private void BTN_EditUser_CambiarCorreo_Click(object sender, EventArgs e)
        {
            Form_CambiarCorreo _formCamCorreo = new Form_CambiarCorreo();
            _formCamCorreo.ShowDialog();
        }

        private void BTN_EditUser_Baja_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de confirmación antes de dar de baja al usuario
            DialogResult result = MessageBox.Show("¿Estás seguro de dar de baja al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Si el usuario confirma, realiza la baja
                _UsuarioSrvs.BajaUsuario(SesionUsuario.CorreoElectronico);
                // En alguna parte de tu código
                HomeServices.IgnoreMessageBoxLogic = true;
                CloseAllOpenForms(); // Método para cerrar todas las formas
                HomeServices.IgnoreMessageBoxLogic = false; // Restablecer para futuros cierres


                // Abre una nueva instancia del formulario de inicio de sesión
                FORM_Login formLogin = new FORM_Login();
                formLogin.Show();
            }
            // Si el usuario elige "No", no se realiza ninguna acción
        }

        private void CloseAllOpenForms()
        {
            // Cierra todas las ventanas abiertas excepto la principal (Application.OpenForms[0])
            for (int i = Application.OpenForms.Count - 1; i >= 1; i--)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void CHEKB_EditUser_Tipo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
