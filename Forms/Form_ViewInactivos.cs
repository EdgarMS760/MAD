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
    public partial class Form_ViewInactivos : Form
    {
        Usuarios _UsuarioSrvs = Usuarios.GetInstance();
        public Form_ViewInactivos()
        {
            InitializeComponent();
        }

        private void Form_ViewInactivos_Load(object sender, EventArgs e)
        {
            List<inactivosDto> inactivos = _UsuarioSrvs.viewInactivos();
            if (inactivos.Count>0)
            {
             dataGrid_Inactivos.DataSource = inactivos;
            }
            else
            {
                MessageBox.Show("no hay usuarios inactivos", "ATENCION",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
          
        }

        private void dataGrid_Inactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
