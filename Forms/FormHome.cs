using MAD.Properties;
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

namespace MAD
{
    public partial class FORM_Home : Form
    {
        public FORM_Home()
        {
            InitializeComponent();
            MenuCustom()
;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FORM_Home_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            ResultsBible[] resultsBible = new ResultsBible[5];
            for (int i = 0; i < resultsBible.Length; i++)
            {
                resultsBible[i] = new ResultsBible();
                resultsBible[i].Icon = Resources.bookIcon;
                resultsBible[i].Title = "Book chapter:versicle";
                resultsBible[i].Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec semper pharetra ante, at tempor nibh venenatis id. Aenean vel aliquam eros. Donec sodales libero sed massa hendrerit ultricies. Pellentesque dapibus justo in turpis sollicitudin fringilla. Etiam ac pulvinar lectus. Donec sit amet odio et ex consequat maximus nec eget ex. Ut vehicula rhoncus lobortis. Pellentesque id augue sit amet nisl dapibus volutpat eu eu ex. Nulla laoreet sed ex a facilisis. Nullam ac efficitur ex. Maecenas faucibus quam bibendum ligula pharetra, sed molestie sem rhoncus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Donec ut feugiat quam, ut varius turpis. Ut facilisis congue mi. Sed libero felis, molestie vel augue et, vehicula iaculis mauris. Quisque vitae aliquet turpis. Aenean eu dui at lorem vestibulum rhoncus vel nec nulla. Curabitur id sollicitudin elit. Proin vitae orci laoreet, sagittis lorem id, placerat tellus. Praesent in ipsum in libero aliquet fermentum a eu tellus.";
                if (flowPanel_Home_content.Controls.Count < 0)
                {
                    flowPanel_Home_content.Controls.Clear();
                }
                else
                {
                    flowPanel_Home_content.Controls.Add(resultsBible[i]);
                }

            }
        }

        private void TXTB_Home_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTB_Home_Search_Enter(object sender, EventArgs e)
        {
            if (TXTB_Home_Search.Text == "SEARCH")
            {
                TXTB_Home_Search.Text = "";
                TXTB_Home_Search.ForeColor = Color.Black;
            }
        }

        private void TXTB_Home_Search_Leave(object sender, EventArgs e)
        {
            if (TXTB_Home_Search.Text == "")
            {
                TXTB_Home_Search.Text = "SEARCH";
                TXTB_Home_Search.ForeColor = Color.DimGray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuCustom()
        {
            panel_favs_home.Visible = false;
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
    }
}
