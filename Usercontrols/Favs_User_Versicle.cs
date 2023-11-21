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
        private Favoritos favoritosService;
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

                string libro = LBL_UCFAVS_LibroFav.Text;
                int? capitulo = LBL_UCFAVS_CapituloFav.Text == "" ? (int?)null : int.Parse(LBL_UCFAVS_CapituloFav.Text);
                int? versiculo = LBL_UCFAVS_VersiculoFav.Text == "" ? (int?)null : int.Parse(LBL_UCFAVS_VersiculoFav.Text);


                OnFavoritoEliminado(EventArgs.Empty);
            }
        }

        protected virtual void OnFavoritoEliminado(EventArgs e)
        {
            FavoritoEliminado?.Invoke(this, e);
        }

        public void MostrarFavorito(ObtenerFavoritos favorito)
        {

            LimpiarContenido();

            LBL_UCFAVS_LibroFav.Text = favorito.Libro;
            LBL_UCFAVS_CapituloFav.Text = favorito.Capitulo?.ToString() ?? "";
            LBL_UCFAVS_VersiculoFav.Text = favorito.Versiculo?.ToString() ?? "";
        }
        private void LimpiarContenido()
        {
            LBL_UCFAVS_LibroFav.Text = string.Empty;
            LBL_UCFAVS_CapituloFav.Text = string.Empty;
            LBL_UCFAVS_VersiculoFav.Text = string.Empty;
        }

        private void Favs_User_Versicle_Load(object sender, EventArgs e)
        {

        }

        private void LBL_UCFAVS_LibroFav_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }
    }
}
