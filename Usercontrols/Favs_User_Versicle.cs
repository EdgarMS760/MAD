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

namespace MAD
{
    public partial class Favs_User_Versicle : UserControl
    {
        private Favoritos favoritosService; // Asegúrate de tener esta variable de instancia
        public string LibroFav
        {
            get { return LBL_UCFAVS_LibroFav.Text; }
        }

        public int? CapituloFav
        {
            get { return string.IsNullOrEmpty(LBL_UCFAVS_CapituloFav.Text) ? (int?)null : int.Parse(LBL_UCFAVS_CapituloFav.Text); }
        }

        public int? VersiculoFav
        {
            get { return string.IsNullOrEmpty(LBL_UCFAVS_VersiculoFav.Text) ? (int?)null : int.Parse(LBL_UCFAVS_VersiculoFav.Text); }
        }

        public Favs_User_Versicle()
        {
            InitializeComponent();
        }
        public event EventHandler FavoritoEliminado;
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar este favorito?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Obtén la información del favorito
                string libro = LBL_UCFAVS_LibroFav.Text;
                int? capitulo = LBL_UCFAVS_CapituloFav.Text == "" ? (int?)null : int.Parse(LBL_UCFAVS_CapituloFav.Text);
                int? versiculo = LBL_UCFAVS_VersiculoFav.Text == "" ? (int?)null : int.Parse(LBL_UCFAVS_VersiculoFav.Text);


                // Lanza el evento para notificar al formulario
                OnFavoritoEliminado(EventArgs.Empty);

                // Resto del código para eliminar el favorito...
            }
        }
        // Método para lanzar el evento FavoritoEliminado
        protected virtual void OnFavoritoEliminado(EventArgs e)
        {
            FavoritoEliminado?.Invoke(this, e);
        }

        public void MostrarFavorito(ObtenerFavoritos favorito)
        {
            // Limpiar el contenido existente (si lo hay)
            LimpiarContenido();

            // Mostrar la información del favorito en los Label
            LBL_UCFAVS_LibroFav.Text = favorito.Libro;
            LBL_UCFAVS_CapituloFav.Text = favorito.Capitulo?.ToString() ?? "";
            LBL_UCFAVS_VersiculoFav.Text = favorito.Versiculo?.ToString() ?? "";
        }
        private void LimpiarContenido()
        {
            // Limpiar el contenido de los Label
            LBL_UCFAVS_LibroFav.Text = string.Empty;
            LBL_UCFAVS_CapituloFav.Text = string.Empty;
            LBL_UCFAVS_VersiculoFav.Text = string.Empty;
        }

    }
}
