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
            }
            else
            {
                // Si no hay información de usuario, deja el TextBox en blanco
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
            CHEKB_EditUser_Tipo.Enabled = true;
            BTN_EditUser_Guardar.Enabled = true;
        }

        private void BTN_EditUser_Guardar_Click(object sender, EventArgs e)
        {
            char genero = ' ';
            //Obtener los datos 
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

            //Llamar funcion
            Usuarios InfoPersonal = new Usuarios();
            InfoPersonal.ActualizaInfoPersonal(SesionUsuario.CorreoElectronico, genero, NombreCom, FechaNaci);

            //Limpiar controles
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
            // La fecha de nacimiento no puede ser mayor al día de hoy ni menor a 1990
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
            _formCamContra.Show();
        }

        private void BTN_EditUser_CambiarCorreo_Click(object sender, EventArgs e)
        {
            Form_CambiarCorreo _formCamCorreo = new Form_CambiarCorreo();
            _formCamCorreo.Show();
        }
    }
}
