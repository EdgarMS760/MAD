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
    public partial class ResultsBible : UserControl
    {
        private FORM_Home _formHome;
        private HomeServices _home = HomeServices.GetInstance();
        public ResultsBible(FORM_Home formHome)
        {

            InitializeComponent();
            PIC_UserControl_icon.Image = Properties.Resources.bookIcon;
            _formHome = formHome;
        }

        private void PIC_UserControl_icon_Click(object sender, EventArgs e)
        {

        }
        #region properties
        private string _title;
        private string _titleBook;
        private string _message;
        private Image _icon;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                LBL_UserControl_Title.Text = value;
            }
        }
        public string TitleBook
        {
            get { return _titleBook; }
            set
            {
                _titleBook = value;
                LBL_UserControl_Title_Book.Text = value;
            }
        }
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                LBL_UserControl_Content.Text = value;
            }
        }
        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                PIC_UserControl_icon.Image = value;
            }
        }
        #endregion
        private void ResultsBible_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ResultsBible_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ResultsBible_Click(object sender, EventArgs e)
        {
            clickaux();
        }

        private void ResultsBible_Load(object sender, EventArgs e)
        {

        }

        private void clickaux()
        {
            string chapterVersicle = LBL_UserControl_Title.Text;
            string book = LBL_UserControl_Title_Book.Text;
            string[] partsCV = chapterVersicle.Split(':');
            int chapter = int.Parse(partsCV[0]);
            var fullChapter = _home.fullChapter(book, chapter);

            _formHome.buildChapter(fullChapter);
        }

        private void LBL_UserControl_Content_Click(object sender, EventArgs e)
        {
            clickaux();
        }

        private void panel_ResultBible_title_Click(object sender, EventArgs e)
        {
            clickaux();
        }

        private void PIC_ResultBible_Star_Click(object sender, EventArgs e)
        {
            string chapterVersicle = LBL_UserControl_Title.Text;
            string book = LBL_UserControl_Title_Book.Text;
            string[] partsCV = chapterVersicle.Split(':');
            int chapter = int.Parse(partsCV[0]);
            int versiculo = int.Parse(partsCV[1]);
            _home.GuardarFav(book, chapter, versiculo, SesionUsuario.CorreoElectronico);
        }

        private void PIC_ResultBible_Star_MouseEnter(object sender, EventArgs e)
        {
            PIC_ResultBible_Star.BackColor = Color.DimGray;
        }

        private void PIC_ResultBible_Star_MouseLeave(object sender, EventArgs e)
        {
            PIC_ResultBible_Star.BackColor = Color.Transparent;
        }

        private void panel_ResultBible_title_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
