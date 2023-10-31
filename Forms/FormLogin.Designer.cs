namespace MAD
{
    partial class FORM_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            Label label2;
            TXTB_Login_Email = new TextBox();
            TXTB_Login_Pass = new TextBox();
            BTN_Login_Entrar = new Button();
            PANEL_Login = new Panel();
            Pic_Login_Logo = new PictureBox();
            label3 = new Label();
            PIC_Login_Minimizar = new PictureBox();
            PIC_Login_Close = new PictureBox();
            LINKLBL_Login_ForgotPass = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            PANEL_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Login_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PIC_Login_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PIC_Login_Close).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.CausesValidation = false;
            label1.FlatStyle = FlatStyle.Popup;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(405, 158);
            label1.Name = "label1";
            label1.Size = new Size(327, 15);
            label1.TabIndex = 0;
            label1.Text = "________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.CausesValidation = false;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(405, 229);
            label2.Name = "label2";
            label2.Size = new Size(327, 15);
            label2.TabIndex = 6;
            label2.Text = "________________________________________________________________";
            // 
            // TXTB_Login_Email
            // 
            TXTB_Login_Email.BackColor = Color.Beige;
            TXTB_Login_Email.BorderStyle = BorderStyle.None;
            TXTB_Login_Email.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TXTB_Login_Email.ForeColor = Color.DimGray;
            TXTB_Login_Email.Location = new Point(405, 125);
            TXTB_Login_Email.Multiline = true;
            TXTB_Login_Email.Name = "TXTB_Login_Email";
            TXTB_Login_Email.Size = new Size(323, 42);
            TXTB_Login_Email.TabIndex = 1;
            TXTB_Login_Email.Text = "EMAIL";
            TXTB_Login_Email.TextChanged += TXTB_Login_Email_TextChanged;
            TXTB_Login_Email.Enter += TXTB_Login_Email_Enter;
            TXTB_Login_Email.Leave += TXTB_Login_Email_Leave;
            // 
            // TXTB_Login_Pass
            // 
            TXTB_Login_Pass.BackColor = Color.Beige;
            TXTB_Login_Pass.BorderStyle = BorderStyle.None;
            TXTB_Login_Pass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TXTB_Login_Pass.ForeColor = Color.DimGray;
            TXTB_Login_Pass.Location = new Point(407, 198);
            TXTB_Login_Pass.MaxLength = 15;
            TXTB_Login_Pass.Name = "TXTB_Login_Pass";
            TXTB_Login_Pass.Size = new Size(325, 28);
            TXTB_Login_Pass.TabIndex = 2;
            TXTB_Login_Pass.Text = "PASSWORD";
            TXTB_Login_Pass.Enter += TXTB_Login_Pass_Enter;
            TXTB_Login_Pass.Leave += TXTB_Login_Pass_Leave;
            // 
            // BTN_Login_Entrar
            // 
            BTN_Login_Entrar.BackColor = Color.DimGray;
            BTN_Login_Entrar.Cursor = Cursors.Hand;
            BTN_Login_Entrar.FlatStyle = FlatStyle.Popup;
            BTN_Login_Entrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Login_Entrar.ForeColor = Color.DarkGray;
            BTN_Login_Entrar.Location = new Point(405, 268);
            BTN_Login_Entrar.Name = "BTN_Login_Entrar";
            BTN_Login_Entrar.Size = new Size(325, 37);
            BTN_Login_Entrar.TabIndex = 4;
            BTN_Login_Entrar.Text = "LOGIN";
            BTN_Login_Entrar.UseVisualStyleBackColor = false;
            BTN_Login_Entrar.Click += BTN_Login_Entrar_Click;
            // 
            // PANEL_Login
            // 
            PANEL_Login.BackColor = Color.Wheat;
            PANEL_Login.Controls.Add(Pic_Login_Logo);
            PANEL_Login.Dock = DockStyle.Left;
            PANEL_Login.Location = new Point(0, 0);
            PANEL_Login.Name = "PANEL_Login";
            PANEL_Login.Size = new Size(314, 391);
            PANEL_Login.TabIndex = 5;
            // 
            // Pic_Login_Logo
            // 
            Pic_Login_Logo.BackColor = Color.Transparent;
            Pic_Login_Logo.Image = Properties.Resources.MAD_Logo;
            Pic_Login_Logo.Location = new Point(-12, 49);
            Pic_Login_Logo.Name = "Pic_Login_Logo";
            Pic_Login_Logo.Size = new Size(336, 293);
            Pic_Login_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic_Login_Logo.TabIndex = 0;
            Pic_Login_Logo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(454, 9);
            label3.Name = "label3";
            label3.Size = new Size(250, 48);
            label3.TabIndex = 7;
            label3.Text = "WELCOME";
            // 
            // PIC_Login_Minimizar
            // 
            PIC_Login_Minimizar.BackColor = Color.Transparent;
            PIC_Login_Minimizar.Cursor = Cursors.Hand;
            PIC_Login_Minimizar.Image = Properties.Resources.minimizeNew;
            PIC_Login_Minimizar.Location = new Point(772, 0);
            PIC_Login_Minimizar.Name = "PIC_Login_Minimizar";
            PIC_Login_Minimizar.Size = new Size(29, 24);
            PIC_Login_Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_Login_Minimizar.TabIndex = 8;
            PIC_Login_Minimizar.TabStop = false;
            PIC_Login_Minimizar.Click += PIC_Login_Minimizar_Click;
            // 
            // PIC_Login_Close
            // 
            PIC_Login_Close.Cursor = Cursors.Hand;
            PIC_Login_Close.Image = Properties.Resources.X_Letter_PNG_Transparent_Picture;
            PIC_Login_Close.Location = new Point(816, 0);
            PIC_Login_Close.Name = "PIC_Login_Close";
            PIC_Login_Close.Size = new Size(25, 24);
            PIC_Login_Close.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_Login_Close.TabIndex = 9;
            PIC_Login_Close.TabStop = false;
            PIC_Login_Close.Click += PIC_Login_Close_Click;
            // 
            // LINKLBL_Login_ForgotPass
            // 
            LINKLBL_Login_ForgotPass.AutoSize = true;
            LINKLBL_Login_ForgotPass.LinkColor = Color.DimGray;
            LINKLBL_Login_ForgotPass.Location = new Point(504, 327);
            LINKLBL_Login_ForgotPass.Name = "LINKLBL_Login_ForgotPass";
            LINKLBL_Login_ForgotPass.Size = new Size(120, 15);
            LINKLBL_Login_ForgotPass.TabIndex = 0;
            LINKLBL_Login_ForgotPass.TabStop = true;
            LINKLBL_Login_ForgotPass.Text = "FORGOT PASSWORD?";
            // 
            // FORM_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(842, 391);
            Controls.Add(LINKLBL_Login_ForgotPass);
            Controls.Add(PIC_Login_Close);
            Controls.Add(PIC_Login_Minimizar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PANEL_Login);
            Controls.Add(BTN_Login_Entrar);
            Controls.Add(TXTB_Login_Pass);
            Controls.Add(TXTB_Login_Email);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FORM_Login";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += FORM_Login_MouseDown;
            PANEL_Login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pic_Login_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PIC_Login_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PIC_Login_Close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TXTB_Login_Email;
        private TextBox TXTB_Login_Pass;
        private Button BTN_Login_Entrar;
        private Panel PANEL_Login;
        private Label label1;
        private PictureBox Pic_Login_Logo;
        private Label label3;
        private PictureBox PIC_Login_Minimizar;
        private PictureBox PIC_Login_Close;
        private LinkLabel LINKLBL_Login_ForgotPass;
    }
}