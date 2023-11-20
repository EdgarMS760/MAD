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
using System.Linq;

namespace MAD
{
    public partial class Form_Historial : Form
    {
        private Historial historialService;  // Agrega una instancia de la clase Historial
        public Form_Historial()
        {
            InitializeComponent();
            ConfigurarDataGridView();

            historialService = new Historial();  // Inicializa la instancia de la clase Historial
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form_Historial_Load(object sender, EventArgs e)
        {
            // Llama al método ObtenerDatosEspecificos para obtener el historial
            List<ObtenerHistorialCompleto> historialcompleto = historialService.ObtenerHistorialCompleto(SesionUsuario.CorreoElectronico);

            // Llama al método para mostrar el historial
            MostrarHistorial(historialcompleto);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Maneja los eventos del DataGridView si es necesario
        }
        private void MostrarHistorial(List<ObtenerHistorialCompleto> historialCompleto)
        {
            DGV_Historial_MostrarHistorial.Rows.Clear();
            // Ordena la lista por FechaYHora de forma descendente
            historialCompleto = historialCompleto.OrderByDescending(h => h.FechaYHora).ToList();


            foreach (var registro in historialCompleto)
            {
                DGV_Historial_MostrarHistorial.Rows.Add(
                    registro.Palabras,
                    registro.FechaYHora,
                    registro.Libro,
                    registro.Capitulo,
                    registro.Versiculo
                );
            }
        }
        private void DGV_Historial_MostrarHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DGV_Historial_MostrarHistorial.Rows[e.RowIndex].Selected = true;
            }
        }
        private void DGV_Historial_MostrarHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Cambia el color de fondo de las celdas a PaleGoldenrod
            DGV_Historial_MostrarHistorial.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGoldenrod;
        }
        private void ConfigurarDataGridView()
        {
            // Agrega las columnas al DataGridView
            DGV_Historial_MostrarHistorial.Columns.Add("Palabras", "Palabras");
            DGV_Historial_MostrarHistorial.Columns.Add("FechaYHora", "Fecha y Hora");
            DGV_Historial_MostrarHistorial.Columns.Add("Libro", "Libro");
            DGV_Historial_MostrarHistorial.Columns.Add("Capitulo", "Capítulo");
            DGV_Historial_MostrarHistorial.Columns.Add("Versiculo", "Versículo");

            // Configura la apariencia y comportamiento de las columnas según tus necesidades
            DGV_Historial_MostrarHistorial.Columns["Palabras"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Historial_MostrarHistorial.Columns["FechaYHora"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Cambiado a Fill
            DGV_Historial_MostrarHistorial.Columns["FechaYHora"].DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm:ss"; // Formato de fecha y hora
            DGV_Historial_MostrarHistorial.Columns["Libro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Historial_MostrarHistorial.Columns["Capitulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Historial_MostrarHistorial.Columns["Versiculo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Configura el DataGridView para que no genere automáticamente las columnas
            DGV_Historial_MostrarHistorial.AutoGenerateColumns = false;

            // Suscribe al evento CellFormatting
            DGV_Historial_MostrarHistorial.CellFormatting += DGV_Historial_MostrarHistorial_CellFormatting;

            // Suscribe al evento CellClick
            DGV_Historial_MostrarHistorial.CellClick += DGV_Historial_MostrarHistorial_CellClick;


            DGV_Historial_MostrarHistorial.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
            DGV_Historial_MostrarHistorial.RowHeadersDefaultCellStyle.BackColor = Color.PaleGoldenrod;
            DGV_Historial_MostrarHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.PaleGoldenrod;

            // Oculta la columna de encabezados de fila
            DGV_Historial_MostrarHistorial.RowHeadersVisible = false;

            // Oculta el encabezado de columna
            DGV_Historial_MostrarHistorial.ColumnHeadersVisible = false;

            // Deshabilita la capacidad de cambiar el tamaño de las columnas y filas// Deshabilita la capacidad de cambiar el tamaño de las columnas y filas
            DGV_Historial_MostrarHistorial.AllowUserToResizeColumns = false;
            DGV_Historial_MostrarHistorial.AllowUserToResizeRows = false;

        }
        private void BTN_Historial_BorrarUno_Click(object sender, EventArgs e)
        {
            // Verificar si hay datos en el DataGridView
            if (DGV_Historial_MostrarHistorial.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en el historial para borrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir del método si no hay datos
            }

            try
            {
                // Obtener la fecha y hora seleccionada en la segunda columna
                if (DGV_Historial_MostrarHistorial.SelectedCells.Count > 0)
                {
                    int rowIndex = DGV_Historial_MostrarHistorial.SelectedCells[0].RowIndex;
                    DateTime fechaRegistro = (DateTime)DGV_Historial_MostrarHistorial.Rows[rowIndex].Cells["FechaYHora"].Value;

                    // Mostrar un mensaje de confirmación
                    DialogResult result = MessageBox.Show("¿Seguro que quieres borrar esta consulta de tu historial?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario hace clic en "Sí", proceder con la eliminación
                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método para eliminar por fecha
                        Historial Historial = new Historial();
                        Historial.EliminarHistorialPorFecha(fechaRegistro);

                        // Volver a cargar los datos en el DataGridView después de eliminar
                        // Llama al método ObtenerDatosEspecificos para obtener el historial
                        List<ObtenerHistorialCompleto> historialcompleto = historialService.ObtenerHistorialCompleto(SesionUsuario.CorreoElectronico);

                        // Llama al método para mostrar el historial
                        MostrarHistorial(historialcompleto);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTN_Historial_BorrarTodo_Click(object sender, EventArgs e)
        {
            // Verificar si hay datos en el DataGridView
            if (DGV_Historial_MostrarHistorial.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en el historial para borrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir del método si no hay datos
            }

            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Seguro que quieres borrar todo el historial?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario hace clic en "Sí", proceder con la eliminación
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Llamar al método para eliminar todo el historial por usuario
                    Historial Historial = new Historial();
                    Historial.EliminarHistorialPorUsuario(SesionUsuario.CorreoElectronico);

                    // Volver a cargar los datos en el DataGridView después de eliminar
                    // Llama al método ObtenerDatosEspecificos para obtener el historial
                    List<ObtenerHistorialCompleto> historialcompleto = historialService.ObtenerHistorialCompleto(SesionUsuario.CorreoElectronico);

                    // Llama al método para mostrar el historial
                    MostrarHistorial(historialcompleto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
