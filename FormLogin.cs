using System.Runtime.InteropServices;
namespace MAD
{
    public partial class FORM_Login : Form
    {

        public FORM_Login()
        {
            InitializeComponent();
        }


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
                TXTB_Login_Email.ForeColor = Color.LightGray;
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
                TXTB_Login_Pass.ForeColor = Color.DimGray;
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
    }
}