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

namespace MAD.Usercontrols
{
    public partial class ViewFavs : UserControl
    {
        private FORM_Home _formHome;
        private HomeServices _home = HomeServices.GetInstance();
        public ViewFavs(FORM_Home formHome)
        {
            InitializeComponent();
            _formHome = formHome;
        }
        #region properties
        private string _title;
        private string _titleBook;
        private Image _icon;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                LBL_viewFavs_ChapVersiculoFav.Text = value;
            }
        }
        public string TitleBook
        {
            get { return _titleBook; }
            set
            {
                _titleBook = value;
                LBL_viewFavs_LibroFav.Text = value;
            }
        }

        #endregion
        private void clickaux()
        {
            string chapterVersicle = LBL_viewFavs_ChapVersiculoFav.Text;
            string book = LBL_viewFavs_LibroFav.Text;
            string[] partsCV = chapterVersicle.Split(':');
            int chapter = int.Parse(partsCV[0]);
            var fullChapter = _home.fullChapter(book, chapter);

            _formHome.buildChapter(fullChapter);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewFavs_Load(object sender, EventArgs e)
        {

        }

        private void viewFavs_Click(object sender, EventArgs e)
        {
            clickaux();
        }

        private void LBL_viewFavs_ChapVersiculoFav_Click(object sender, EventArgs e)
        {
            clickaux();
        }

        private void LBL_viewFavs_LibroFav_Click(object sender, EventArgs e)
        {
            clickaux();
        }

        private void viewFavs_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void viewFavs_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void LBL_viewFavs_LibroFav_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void LBL_viewFavs_ChapVersiculoFav_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }
    }
}
