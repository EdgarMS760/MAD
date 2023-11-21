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
    public partial class Form_Favoritos : Form
    {
        private Favoritos favoritosService; // Asegúrate de tener esta variable de instancia
        public Form_Favoritos()
        {
            InitializeComponent();
            favoritosService = new Favoritos();
            MostrarFavoritosEnUserControls();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Pic_Favs_ClickExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MostrarFavoritosEnUserControls()
        {
            string correoElectronico = SesionUsuario.CorreoElectronico;
            List<ObtenerFavoritos> favoritos = favoritosService.ObtenerFavs(correoElectronico);

            foreach (var favorito in favoritos)
            {
                Favs_User_Versicle userControl = new Favs_User_Versicle();
                userControl.MostrarFavorito(favorito);
                FlowPanel_Favs_Favoritos.Controls.Add(userControl);

                userControl.FavoritoEliminado += UserControl_FavoritoEliminado;
            }
        }
        private void UserControl_FavoritoEliminado(object sender, EventArgs e)
        {
            if (sender is Favs_User_Versicle userControl)
            {
           
                string libro = userControl.LibroFav;
                int? capitulo = userControl.CapituloFav;
                int? versiculo = userControl.VersiculoFav;

                favoritosService.EliminarFavorito(SesionUsuario.CorreoElectronico, libro, capitulo, versiculo);
                FlowPanel_Favs_Favoritos.Controls.Remove(userControl);
            }
        }
    }
}
