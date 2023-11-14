namespace MAD.Forms
{
    partial class Form_CrearUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            TXTB_CreateUser_Email = new TextBox();
            TXTB_CreateUser_Pass = new TextBox();
            label5 = new Label();
            label2 = new Label();
            BTN_CreateUser_Guardar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(149, 28);
            label1.Name = "label1";
            label1.Size = new Size(273, 48);
            label1.TabIndex = 1;
            label1.Text = "Crear Cuenta";
            // 
            // TXTB_CreateUser_Email
            // 
            TXTB_CreateUser_Email.BackColor = Color.LemonChiffon;
            TXTB_CreateUser_Email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TXTB_CreateUser_Email.ForeColor = Color.DimGray;
            TXTB_CreateUser_Email.Location = new Point(272, 152);
            TXTB_CreateUser_Email.Name = "TXTB_CreateUser_Email";
            TXTB_CreateUser_Email.Size = new Size(242, 33);
            TXTB_CreateUser_Email.TabIndex = 17;
            TXTB_CreateUser_Email.TextChanged += TXTB_CreateUser_Email_TextChanged;
            // 
            // TXTB_CreateUser_Pass
            // 
            TXTB_CreateUser_Pass.BackColor = Color.LemonChiffon;
            TXTB_CreateUser_Pass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TXTB_CreateUser_Pass.ForeColor = Color.DimGray;
            TXTB_CreateUser_Pass.Location = new Point(272, 191);
            TXTB_CreateUser_Pass.Name = "TXTB_CreateUser_Pass";
            TXTB_CreateUser_Pass.Size = new Size(242, 33);
            TXTB_CreateUser_Pass.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(125, 199);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 15;
            label5.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(46, 160);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 14;
            label2.Text = "CORREO ELECTRONICO:";
            // 
            // BTN_CreateUser_Guardar
            // 
            BTN_CreateUser_Guardar.BackColor = Color.NavajoWhite;
            BTN_CreateUser_Guardar.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_CreateUser_Guardar.FlatStyle = FlatStyle.Flat;
            BTN_CreateUser_Guardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_CreateUser_Guardar.ForeColor = Color.DimGray;
            BTN_CreateUser_Guardar.Location = new Point(249, 259);
            BTN_CreateUser_Guardar.Name = "BTN_CreateUser_Guardar";
            BTN_CreateUser_Guardar.Size = new Size(108, 33);
            BTN_CreateUser_Guardar.TabIndex = 18;
            BTN_CreateUser_Guardar.Text = "Guardar";
            BTN_CreateUser_Guardar.UseVisualStyleBackColor = false;
            BTN_CreateUser_Guardar.Click += BTN_CreateUser_Guardar_Click;
            // 
            // Form_CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(624, 411);
            Controls.Add(BTN_CreateUser_Guardar);
            Controls.Add(TXTB_CreateUser_Email);
            Controls.Add(TXTB_CreateUser_Pass);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_CrearUsuario";
            Text = "Crear Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox TXTB_CreateUser_Email;
        private TextBox TXTB_CreateUser_Pass;
        private Label label5;
        private Label label2;
        private Button BTN_CreateUser_Guardar;
    }
}