using MAD.Forms;
using MAD.Services;
using System.Runtime.InteropServices;
namespace MAD
{
    public partial class FORM_Login : Form
    {
        private LoginServices _loginSrvs = LoginServices.GetInstance();
        public FORM_Login()
        {
            InitializeComponent();

        }
        // Importa funciones necesarias de user32.dll para mover el formulario sin barra de título
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TXTB_Login_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TXTB_Login_Email_Enter(object sender, EventArgs e)
        {
            if (TXTB_Login_Email.Text == "EMAIL")
            {
                TXTB_Login_Email.Text = "";
                TXTB_Login_Email.ForeColor = Color.Black;
            }
        }
        private void TXTB_Login_Email_Leave(object sender, EventArgs e)
        {
            if (TXTB_Login_Email.Text == "")
            {
                TXTB_Login_Email.Text = "EMAIL";
                TXTB_Login_Email.ForeColor = Color.DimGray;
            }
        }

        private void TXTB_Login_Pass_Enter(object sender, EventArgs e)
        {
            if (TXTB_Login_Pass.Text == "PASSWORD")
            {
                TXTB_Login_Pass.Text = "";
                TXTB_Login_Pass.ForeColor = Color.LightGray;
                TXTB_Login_Pass.UseSystemPasswordChar = true;
            }
        }
        private void TXTB_Login_Pass_Leave(object sender, EventArgs e)
        {
            if (TXTB_Login_Pass.Text == "")
            {
                TXTB_Login_Pass.Text = "PASSWORD";
                TXTB_Login_Pass.ForeColor = Color.Black;
                TXTB_Login_Pass.UseSystemPasswordChar = false;
            }
        }
        private void PIC_Login_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PIC_Login_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FORM_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BTN_Login_Entrar_Click(object sender, EventArgs e)
        {
           
            int autentication = _loginSrvs.autenticacion(TXTB_Login_Email.Text, TXTB_Login_Pass.Text);

            if (autentication==1)
            {
<<<<<<< Updated upstream
                FORM_Home _formhome = new FORM_Home();
                _formhome.Show();
=======
                if (pass.Length < 1 || pass == "PASSWORD")
                {
                    MessageBox.Show("EL USUARIO ESTA INACTIVO UTILICE SU CONTRASEÑA TEMPORAL PARA CONTINUAR, SI NO LA TIENE CONTACTE AL ADMINISTRADOR", "Error de autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    int autentication = _loginSrvs.autenticacionPassTemporal(email, pass);

                    if (autentication == 1)
                    {
                        _loginSrvs.loginPassTemporal(email, pass);
                        FORM_Home _formhome = new FORM_Home();
                        _formhome.Show();
                        this.Hide();
                    }
                }
                return;
>>>>>>> Stashed changes
            }

<<<<<<< Updated upstream
            //FORM_Home _formhome = new FORM_Home();
            //_formhome.Show();
=======
                if (autentication == 1)
                {
                    FORM_Home _formhome = new FORM_Home();
                    _formhome.Show();
                    this.Hide();
                }

                //FORM_Home _formhome = new FORM_Home();
                //_formhome.Show();
            }
>>>>>>> Stashed changes
        }

        private void FORM_Login_Load(object sender, EventArgs e)
        {

        }

        private void LINKLBL_Login_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_CrearUsuario _formCreateUser = new Form_CrearUsuario();
            _formCreateUser.ShowDialog();
        }
    }
}