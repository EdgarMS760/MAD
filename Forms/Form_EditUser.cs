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
            TXTB_EditUser_Genere.Enabled = true;
            TXTB_EditUser_Email.Enabled = true;
            //RB_EditUser_Activo.Enabled = true;
            //RB_EditUser_Inactivo.Enabled = true;
            CHEKB_EditUser_Tipo.Enabled = true;
        }

        private void BTN_EditUser_Guardar_Click(object sender, EventArgs e)
        {
            TXTB_EditUser_Name.Enabled = false;
            DTP_EditUser_BirthDate.Enabled = false;
            TXTB_EditUser_Genere.Enabled = false;
            TXTB_EditUser_Email.Enabled = false;
            //RB_EditUser_Activo.Enabled = false;
            //RB_EditUser_Inactivo.Enabled = false;
            CHEKB_EditUser_Tipo.Enabled = false;

            TXTB_EditUser_Name.Text = string.Empty;
            DTP_EditUser_BirthDate.Value = DateTime.Now; // Establecer la fecha actual o cualquier valor predeterminado
            TXTB_EditUser_Genere.Text = string.Empty;
            TXTB_EditUser_Email.Text = string.Empty;
            // Puedes comentar o descomentar las siguientes líneas según el tipo de control que estés usando para representar la opción activo/inactivo
            //RB_EditUser_Activo.Checked = false;
            //RB_EditUser_Inactivo.Checked = false;
            CHEKB_EditUser_Tipo.Checked = false;

        }
    }
}
