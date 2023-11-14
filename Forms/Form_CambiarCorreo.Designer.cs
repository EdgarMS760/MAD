namespace MAD
{
    partial class Form_CambiarCorreo
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
            BTN_CambiarCorreo_Guardar = new Button();
            LBL_CambiarCorreo_MostrarCorreo = new Label();
            label1 = new Label();
            label5 = new Label();
            TXTB_CambiarCorreo_CorreoNew = new TextBox();
            SuspendLayout();
            // 
            // BTN_CambiarCorreo_Guardar
            // 
            BTN_CambiarCorreo_Guardar.BackColor = Color.NavajoWhite;
            BTN_CambiarCorreo_Guardar.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_CambiarCorreo_Guardar.FlatStyle = FlatStyle.Flat;
            BTN_CambiarCorreo_Guardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_CambiarCorreo_Guardar.ForeColor = Color.DimGray;
            BTN_CambiarCorreo_Guardar.Location = new Point(171, 160);
            BTN_CambiarCorreo_Guardar.Name = "BTN_CambiarCorreo_Guardar";
            BTN_CambiarCorreo_Guardar.Size = new Size(108, 33);
            BTN_CambiarCorreo_Guardar.TabIndex = 26;
            BTN_CambiarCorreo_Guardar.Text = "Guardar";
            BTN_CambiarCorreo_Guardar.UseVisualStyleBackColor = false;
            BTN_CambiarCorreo_Guardar.Click += BTN_CambiarCorreo_Guardar_Click;
            // 
            // LBL_CambiarCorreo_MostrarCorreo
            // 
            LBL_CambiarCorreo_MostrarCorreo.AutoSize = true;
            LBL_CambiarCorreo_MostrarCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_CambiarCorreo_MostrarCorreo.ForeColor = Color.Gray;
            LBL_CambiarCorreo_MostrarCorreo.Location = new Point(191, 63);
            LBL_CambiarCorreo_MostrarCorreo.Name = "LBL_CambiarCorreo_MostrarCorreo";
            LBL_CambiarCorreo_MostrarCorreo.Size = new Size(108, 21);
            LBL_CambiarCorreo_MostrarCorreo.TabIndex = 25;
            LBL_CambiarCorreo_MostrarCorreo.Text = "Correo actual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(45, 63);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 24;
            label1.Text = "CORREO ACTUAL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(45, 102);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 23;
            label5.Text = "CORREO NUEVO:";
            // 
            // TXTB_CambiarCorreo_CorreoNew
            // 
            TXTB_CambiarCorreo_CorreoNew.BackColor = Color.LemonChiffon;
            TXTB_CambiarCorreo_CorreoNew.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TXTB_CambiarCorreo_CorreoNew.ForeColor = Color.DimGray;
            TXTB_CambiarCorreo_CorreoNew.Location = new Point(191, 96);
            TXTB_CambiarCorreo_CorreoNew.Name = "TXTB_CambiarCorreo_CorreoNew";
            TXTB_CambiarCorreo_CorreoNew.Size = new Size(242, 33);
            TXTB_CambiarCorreo_CorreoNew.TabIndex = 22;
            // 
            // Form_CambiarCorreo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(464, 238);
            Controls.Add(BTN_CambiarCorreo_Guardar);
            Controls.Add(LBL_CambiarCorreo_MostrarCorreo);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(TXTB_CambiarCorreo_CorreoNew);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_CambiarCorreo";
            Text = "Cambiar Correo";
            Load += Form_CambiarCorreo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_CambiarCorreo_Guardar;
        private Label LBL_CambiarCorreo_MostrarCorreo;
        private Label label1;
        private Label label5;
        private TextBox TXTB_CambiarCorreo_CorreoNew;
    }
}