using MAD.Dtos;
using MAD.Properties;
using MAD.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAD
{
    public partial class FORM_Home : Form
    {
        private bool consulta = false;
        public FORM_Home()
        {
            InitializeComponent();
            MenuCustom();
            CargarIdiomas();

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FORM_Home_Load(object sender, EventArgs e)
        {
            //populateItems();
        }

        private void populateItems(List<VersiculoDto> versiculoDtos)
        {
            flowPanel_Home_content.Controls.Clear();

            foreach (var versiculo in versiculoDtos)
            {
                ResultsBible resultBible = new ResultsBible(this)
                {
                    Icon = Resources.bookIcon,
                    Title = $"{versiculo.numeroCap}:{versiculo.numeroVers}",
                    TitleBook = $"{versiculo.nombreLibro}",
                    Message = versiculo.texto
                };

                flowPanel_Home_content.Controls.Add(resultBible);
            }

        }
        private void CargarIdiomas()
        {
            CB_Home_Lang.Items.Clear();
            HomeServices home = new HomeServices();
            List<IdiomaDto> idiomas = home.ObtenerIdiomas();

            CB_Home_Lang.DisplayMember = "Nombre";
            CB_Home_Lang.ValueMember = "Id";
            CB_Home_Lang.Items.AddRange(idiomas.ToArray());

            if (CB_Home_Lang.Items.Count > 0)
            {
                CB_Home_Lang.SelectedIndex = 0;
            }

        }

        private void TXTB_Home_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTB_Home_Search_Enter(object sender, EventArgs e)
        {
            //if (TXTB_Home_Search.Text == "SEARCH")
            //{
            //    TXTB_Home_Search.Text = "";
            //    TXTB_Home_Search.ForeColor = Color.Black;
            //}
        }

        private void TXTB_Home_Search_Leave(object sender, EventArgs e)
        {
            //if (TXTB_Home_Search.Text == "")
            //{
            //    TXTB_Home_Search.Text = "SEARCH";
            //    TXTB_Home_Search.ForeColor = Color.DimGray;
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuCustom()
        {
            panel_favs_home.Visible = false;
            panel_Home_Search_Consulta.Visible = false;
        }
        private void HideFavsOptions()
        {
            if (panel_favs_home.Visible)
            {
                panel_favs_home.Visible = false;
            }
        }
        private void ShowFavsOptions(Panel favsOptions)
        {
            if (!panel_favs_home.Visible)
            {
                HideFavsOptions();
                favsOptions.Visible = true;
            }
            else
            {
                favsOptions.Visible = false;
            }
        }

        private void BTN_Home_Favs_Click(object sender, EventArgs e)
        {
            ShowFavsOptions(panel_favs_home);
        }

        private void BTN_Home_Favs_verFavs_Click(object sender, EventArgs e)
        {
            HideFavsOptions();
        }

        private void BTN_Home_Favs_EditFavs_Click(object sender, EventArgs e)
        {
            HideFavsOptions();
            Form_Favoritos _formEFav = new Form_Favoritos();
            _formEFav.Show();
        }

        private void FORM_Home_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PIC_Home_Search_Click(object sender, EventArgs e)
        {
            if (TXTB_Home_Search.TextLength < 3 && !consulta)
            {

                MessageBox.Show("la busqueda debe tener minimo 3 palabras");
            }
            else if(CB_Home_Book.Text =="" && consulta)
            {
                MessageBox.Show("seleccione un libro");
            }
            else
            {
                HomeServices home = new HomeServices();
                var ids = idsCombo();
                string numcap = CB_Home_Search_Capitulo.Text;
                string numvers = CB_Home_Search_Versiculo.Text;
                string? nombreLibro = CB_Home_Book.Text;
                int parsedNumCap, parsedNumVers;

                bool capParse = int.TryParse(numcap, out parsedNumCap);
                bool versParse = int.TryParse(numvers, out parsedNumVers);

                List<VersiculoDto> info = home.BuscarVersiculos(TXTB_Home_Search.Text, ids[0], ids[1] > 0 ? ids[1] : null, ids[2] > 0 ? ids[2] : null, capParse ? parsedNumCap : null, versParse ? parsedNumVers : null);
                if (info.Count>0)
                {
                home.GuardarConsulta(TXTB_Home_Search.Text, nombreLibro, capParse ? parsedNumCap : null, versParse ? parsedNumVers : null, "admin@mail.com");
                populateItems(info);
                }
                else
                {
                    MessageBox.Show("no se encontraron resultados");
                }
             
            }
        }

        private void CB_Home_Lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Home_Book.Items.Clear();
            CB_Home_Testament.Items.Clear();
            CB_Home_Version.Items.Clear();
            CB_Home_Book.Items.Add("");
            CB_Home_Testament.Items.Add("");
            if (CB_Home_Lang.SelectedItem != null)
            {
                HomeServices home = new HomeServices();

                IdiomaDto idiomaSeleccionado = (IdiomaDto)CB_Home_Lang.SelectedItem;
                int idSeleccionado = idiomaSeleccionado.id_Idioma;
                var libros = home.ObtenerLibros(idSeleccionado);
                CB_Home_Book.DisplayMember = "Nombre";

                CB_Home_Book.Items.AddRange(libros.ToArray());

                if (CB_Home_Book.Items.Count > 0)
                {
                    CB_Home_Book.SelectedIndex = 0;
                }

                var versiones = home.ObtenerVersion(idSeleccionado);
                CB_Home_Version.DisplayMember = "Nombre";
                CB_Home_Version.Items.AddRange(versiones.ToArray());

                if (CB_Home_Version.Items.Count > 0)
                {
                    CB_Home_Version.SelectedIndex = 0;
                }

                var testamentos = home.ObtenerTestamento(idSeleccionado);
                CB_Home_Testament.DisplayMember = "Nombre";
                CB_Home_Testament.Items.AddRange(testamentos.ToArray());
                if (CB_Home_Testament.Items.Count > 0)
                {
                    CB_Home_Testament.SelectedIndex = 0;
                }
            }

        }

        private void CB_Home_Testament_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CB_Home_Testament.SelectedItem != "")
            {
                CB_Home_Book.Items.Clear();
                CB_Home_Book.Items.Add("");
                HomeServices home = new HomeServices();

                TestamentoDto testamento = (TestamentoDto)CB_Home_Testament.SelectedItem;
                int idTestmento = testamento.id_Testamento;
                var libros = home.ObtenerLibroPorTestamento(idTestmento);
                CB_Home_Book.DisplayMember = "Nombre";

                CB_Home_Book.Items.AddRange(libros.ToArray());

                if (CB_Home_Book.Items.Count > 0)
                {
                    CB_Home_Book.SelectedIndex = 0;
                }
            }
        }
        private List<int> idsCombo()
        {
            List<int> ids = new List<int>();
            HomeServices home = new HomeServices();
            List<IdiomaDto> idiomas = home.ObtenerIdiomas();
            string nombreIdiomaSeleccionado = CB_Home_Lang.Text;
            int idIdioma = 0;


            foreach (IdiomaDto idioma in idiomas)
            {
                if (idioma.nombre == nombreIdiomaSeleccionado)
                {
                    idIdioma = idioma.id_Idioma;
                    break;
                }
            }
            List<VersionDto> versiones = home.ObtenerVersion(idIdioma);
            string versionselec = CB_Home_Version.Text;
            int idversion = 0;


            foreach (VersionDto version in versiones)
            {
                if (version.nombre == versionselec)
                {
                    idversion = version.id_Version;
                    break;
                }
            }

            List<TestamentoDto> testamentos = home.ObtenerTestamento(idIdioma);
            string testamentoselec = CB_Home_Testament.Text;
            int idtestamento = 0;


            foreach (TestamentoDto testamento in testamentos)
            {
                if (testamento.nombre == testamentoselec)
                {
                    idtestamento = testamento.id_Testamento;
                    break;
                }
            }
            List<LibroDto> libros = home.ObtenerLibros(idIdioma);
            string libroselec = CB_Home_Book.Text;
            int idlibro = 0;


            foreach (LibroDto libro in libros)
            {
                if (libro.nombre == libroselec)
                {
                    idlibro = libro.id_Libro;
                    break;
                }
            }
            ids.Add(idversion);
            ids.Add(idtestamento);
            ids.Add(idlibro);
            return ids;
        }
        private void BTN_Home_History_Click(object sender, EventArgs e)
        {
            Form_Historial _formHisto = new Form_Historial();
            _formHisto.Show();
        }

        private void BTN_Home_Config_Click(object sender, EventArgs e)
        {
            Form_EditUser _formEdUser = new Form_EditUser();
            _formEdUser.Show();
        }

        public void buildChapter(List<FullChapterDto> fullChapterDtos)
        {
            RICHTXTB_Home_Content.Clear();

            if (fullChapterDtos != null && fullChapterDtos.Count > 0)
            {
                Font boldFont = new Font(RICHTXTB_Home_Content.Font, FontStyle.Bold);
                Font chapterFont = new Font(RICHTXTB_Home_Content.Font.FontFamily, 32, FontStyle.Bold);
                RICHTXTB_Home_Content.SelectionFont = boldFont;
                RICHTXTB_Home_Content.SelectionFont = chapterFont;
                RICHTXTB_Home_Content.AppendText(fullChapterDtos[0].numeroCap.ToString() + Environment.NewLine);
                RICHTXTB_Home_Content.SelectionFont = RICHTXTB_Home_Content.Font;
                foreach (var versiculo in fullChapterDtos)
                {
                    RICHTXTB_Home_Content.AppendText($"{Environment.NewLine}");
                    RICHTXTB_Home_Content.SelectionFont = boldFont;
                    RICHTXTB_Home_Content.AppendText($"{versiculo.numeroVers} ");
                    RICHTXTB_Home_Content.SelectionFont = RICHTXTB_Home_Content.Font;

                    string capitulo = $"{versiculo.texto}{Environment.NewLine}";
                    RICHTXTB_Home_Content.AppendText(capitulo);
                }
            }
            else
            {
                RICHTXTB_Home_Content.AppendText("No hay versículos para mostrar.");
            }

        }

        private void LINKLBL_Home_AdvSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel_Home_Search_Consulta.Visible)
            {
                consulta = false;
                //TXTB_Home_Search.Enabled = true;
                panel_Home_Search_Consulta.Visible = false;
            }
            else
            {
                TXTB_Home_Search.Text = "";
                CB_Home_Book.SelectedIndex = 0;
                consulta = true;
                CB_Home_Search_Capitulo.Items.Clear();
                //TXTB_Home_Search.Enabled = false;
                panel_Home_Search_Consulta.Visible = true;
            }

        }

        private void CB_Home_Book_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (consulta)
            {
                if (CB_Home_Book.SelectedItem != "")
                {
                    CB_Home_Search_Capitulo.Items.Clear();
                    HomeServices home = new HomeServices();
                    string libro = CB_Home_Book.Text;

                    List<int> caps = home.ObtenerNumeroCapPorLibro(libro);

                    foreach (int numCap in caps)
                    {
                        CB_Home_Search_Capitulo.Items.Add(numCap);
                    }

                    if (CB_Home_Search_Capitulo.Items.Count > 0)
                    {
                        CB_Home_Search_Capitulo.SelectedIndex = 0;
                    }

                }
            }
        }

        private void CB_Home_Search_Capitulo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (consulta)
            {
                if (CB_Home_Search_Capitulo.SelectedItem != "")
                {
                    CB_Home_Search_Versiculo.Items.Clear();
                    HomeServices home = new HomeServices();
                    CB_Home_Search_Versiculo.Items.Add("");
                    int cap = int.Parse(CB_Home_Search_Capitulo.Text);

                    List<int> vers = home.ObtenerNumeroVersPorCapitulo(cap);

                    foreach (int numvers in vers)
                    {
                        CB_Home_Search_Versiculo.Items.Add(numvers);
                    }

                    if (CB_Home_Search_Versiculo.Items.Count > 0)
                    {
                        CB_Home_Search_Versiculo.SelectedIndex = 0;
                    }

                }
            }
        }
    }
}
