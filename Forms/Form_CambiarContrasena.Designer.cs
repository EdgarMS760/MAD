namespace MAD
{
    partial class Form_CambiarContrasena
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
            TXTB_CambiarPass_Pass = new TextBox();
            label5 = new Label();
            label1 = new Label();
            LBL_CambiarContra_MostrarContra = new Label();
            BTN_CambiarPass_Guardar = new Button();
            SuspendLayout();
            // 
            // TXTB_CambiarPass_Pass
            // 
            TXTB_CambiarPass_Pass.BackColor = Color.LemonChiffon;
            TXTB_CambiarPass_Pass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TXTB_CambiarPass_Pass.ForeColor = Color.DimGray;
            TXTB_CambiarPass_Pass.Location = new Point(212, 83);
            TXTB_CambiarPass_Pass.Name = "TXTB_CambiarPass_Pass";
            TXTB_CambiarPass_Pass.Size = new Size(242, 33);
            TXTB_CambiarPass_Pass.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(33, 89);
            label5.Name = "label5";
            label5.Size = new Size(173, 21);
            label5.TabIndex = 18;
            label5.Text = "CONTRASEÑA NUEVA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 19;
            label1.Text = "CONTRASEÑA ACTUAL:";
            // 
            // LBL_CambiarContra_MostrarContra
            // 
            LBL_CambiarContra_MostrarContra.AutoSize = true;
            LBL_CambiarContra_MostrarContra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_CambiarContra_MostrarContra.ForeColor = Color.Gray;
            LBL_CambiarContra_MostrarContra.Location = new Point(212, 50);
            LBL_CambiarContra_MostrarContra.Name = "LBL_CambiarContra_MostrarContra";
            LBL_CambiarContra_MostrarContra.Size = new Size(139, 21);
            LBL_CambiarContra_MostrarContra.TabIndex = 20;
            LBL_CambiarContra_MostrarContra.Text = "Contraseña actual";
            // 
            // BTN_CambiarPass_Guardar
            // 
            BTN_CambiarPass_Guardar.BackColor = Color.NavajoWhite;
            BTN_CambiarPass_Guardar.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_CambiarPass_Guardar.FlatStyle = FlatStyle.Flat;
            BTN_CambiarPass_Guardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_CambiarPass_Guardar.ForeColor = Color.DimGray;
            BTN_CambiarPass_Guardar.Location = new Point(173, 146);
            BTN_CambiarPass_Guardar.Name = "BTN_CambiarPass_Guardar";
            BTN_CambiarPass_Guardar.Size = new Size(108, 33);
            BTN_CambiarPass_Guardar.TabIndex = 21;
            BTN_CambiarPass_Guardar.Text = "Guardar";
            BTN_CambiarPass_Guardar.UseVisualStyleBackColor = false;
            BTN_CambiarPass_Guardar.Click += BTN_CambiarPass_Guardar_Click;
            // 
            // Form_CambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(482, 260);
            Controls.Add(BTN_CambiarPass_Guardar);
            Controls.Add(LBL_CambiarContra_MostrarContra);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(TXTB_CambiarPass_Pass);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_CambiarContrasena";
            Text = "Cambiar Contraseña";
            Load += Form_CambiarContrasena_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXTB_CambiarPass_Pass;
        private Label label5;
        private Label label1;
        private Label LBL_CambiarContra_MostrarContra;
        private Button BTN_CambiarPass_Guardar;
    }
}