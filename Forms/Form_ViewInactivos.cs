using MAD.Dtos;
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
            ConfigureDataGridViewAppearance(); // Llamada a la función para configurar la apariencia del DataGridView
        }
        private void Form_ViewInactivos_Load(object sender, EventArgs e)
        {
            MostrarInactivos();
        }
        private void MostrarInactivos()
        {
            try
            {
                // Verificar si la instancia de Usuarios y el DataGridView están inicializados
                if (_UsuarioSrvs != null && dataGrid_Inactivos != null)
                {
                    var usuariosInactivos = _UsuarioSrvs.viewInactivos();

                    // Verificar si la lista de usuarios inactivos es válida
                    if (usuariosInactivos != null)
                    {
                        dataGrid_Inactivos.Rows.Clear();

                        foreach (var registro in usuariosInactivos)
                        {
                            // Verificar si las propiedades del objeto inactivosDto son válidas
                            if (registro != null)
                            {
                                dataGrid_Inactivos.Rows.Add(
                                    registro.EMAIL,
                                    registro.ESTADO
                                );
                            }
                            else
                            {
                                // Mostrar un mensaje de advertencia si el objeto inactivosDto es nulo
                                MessageBox.Show("El objeto inactivosDto es nulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        // Mostrar un mensaje de advertencia si la lista de usuarios inactivos es nula
                        MessageBox.Show("La lista de usuarios inactivos es nula", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Mostrar un mensaje de advertencia si la instancia de Usuarios o el DataGridView son nulos
                    MessageBox.Show("La instancia de Usuarios o el DataGridView es nulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no hay usuarios inactivos", "ATENCION",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                MessageBox.Show($"Error en MostrarInactivos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureDataGridViewAppearance()
        {
            // Agrega las columnas al DataGridView
            dataGrid_Inactivos.Columns.Add("Correo", "Palabras");
            dataGrid_Inactivos.Columns.Add("Estado", "Fecha y Hora");
            // Configura la apariencia y comportamiento de las columnas según tus necesidades
            dataGrid_Inactivos.Columns["Correo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_Inactivos.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGrid_Inactivos.DefaultCellStyle.BackColor = Color.Beige;
            dataGrid_Inactivos.RowHeadersDefaultCellStyle.BackColor = Color.Beige;
            dataGrid_Inactivos.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige;

            // Ocultar la columna de flechas de ordenamiento
            dataGrid_Inactivos.RowHeadersVisible = false;

            // Ocultar la fila de encabezados
            dataGrid_Inactivos.ColumnHeadersVisible = false;
        }
        private void dataGrid_Inactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
