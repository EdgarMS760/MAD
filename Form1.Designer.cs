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
            LBL_Login_Email = new Label();
            LBL_Login_Pass = new Label();
            TXTB_Login_Email = new TextBox();
            TXTB_Login_Pass = new TextBox();
            BTN_Login_Entrar = new Button();
            SuspendLayout();
            // 
            // LBL_Login_Email
            // 
            LBL_Login_Email.AutoSize = true;
            LBL_Login_Email.Location = new Point(181, 144);
            LBL_Login_Email.Name = "LBL_Login_Email";
            LBL_Login_Email.Size = new Size(39, 15);
            LBL_Login_Email.TabIndex = 0;
            LBL_Login_Email.Text = "Email:";
            // 
            // LBL_Login_Pass
            // 
            LBL_Login_Pass.AutoSize = true;
            LBL_Login_Pass.Location = new Point(160, 179);
            LBL_Login_Pass.Name = "LBL_Login_Pass";
            LBL_Login_Pass.Size = new Size(60, 15);
            LBL_Login_Pass.TabIndex = 1;
            LBL_Login_Pass.Text = "Password:";
            // 
            // TXTB_Login_Email
            // 
            TXTB_Login_Email.Location = new Point(228, 143);
            TXTB_Login_Email.Name = "TXTB_Login_Email";
            TXTB_Login_Email.Size = new Size(100, 23);
            TXTB_Login_Email.TabIndex = 2;
            // 
            // TXTB_Login_Pass
            // 
            TXTB_Login_Pass.Location = new Point(228, 179);
            TXTB_Login_Pass.Name = "TXTB_Login_Pass";
            TXTB_Login_Pass.Size = new Size(100, 23);
            TXTB_Login_Pass.TabIndex = 3;
            // 
            // BTN_Login_Entrar
            // 
            BTN_Login_Entrar.Location = new Point(228, 217);
            BTN_Login_Entrar.Name = "BTN_Login_Entrar";
            BTN_Login_Entrar.Size = new Size(75, 23);
            BTN_Login_Entrar.TabIndex = 4;
            BTN_Login_Entrar.Text = "Entrar";
            BTN_Login_Entrar.UseVisualStyleBackColor = true;
            // 
            // FORM_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_Login_Entrar);
            Controls.Add(TXTB_Login_Pass);
            Controls.Add(TXTB_Login_Email);
            Controls.Add(LBL_Login_Pass);
            Controls.Add(LBL_Login_Email);
            Name = "FORM_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_Login_Email;
        private Label LBL_Login_Pass;
        private TextBox TXTB_Login_Email;
        private TextBox TXTB_Login_Pass;
        private Button BTN_Login_Entrar;
    }
}