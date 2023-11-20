namespace MAD.Forms
{
    partial class Form_GestionUsuarios
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
            label9 = new Label();
            BTN_GestionUsuarios_Baja = new Button();
            LBL_GestionUsuarios_MostrarCorreo = new Label();
            CHEKB_GestionUsuarios_Tipo = new CheckBox();
            BTN_GestionUsuarios_Guardar = new Button();
            BTN_GestionUsuarios_Editar = new Button();
            RB_GestionUsuarios_Inactivo = new RadioButton();
            RB_GestionUsuarios_Activo = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            TXTB_GestionUsuarios_Buscar = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(350, 558);
            label9.Name = "label9";
            label9.Size = new Size(235, 25);
            label9.TabIndex = 49;
            label9.Text = "DAR DE BAJA LA CUENTA";
            // 
            // BTN_GestionUsuarios_Baja
            // 
            BTN_GestionUsuarios_Baja.BackColor = Color.NavajoWhite;
            BTN_GestionUsuarios_Baja.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_GestionUsuarios_Baja.FlatStyle = FlatStyle.Flat;
            BTN_GestionUsuarios_Baja.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_GestionUsuarios_Baja.ForeColor = Color.DimGray;
            BTN_GestionUsuarios_Baja.Location = new Point(584, 554);
            BTN_GestionUsuarios_Baja.Name = "BTN_GestionUsuarios_Baja";
            BTN_GestionUsuarios_Baja.Size = new Size(108, 33);
            BTN_GestionUsuarios_Baja.TabIndex = 48;
            BTN_GestionUsuarios_Baja.Text = "BAJA";
            BTN_GestionUsuarios_Baja.UseVisualStyleBackColor = false;
            // 
            // LBL_GestionUsuarios_MostrarCorreo
            // 
            LBL_GestionUsuarios_MostrarCorreo.AutoSize = true;
            LBL_GestionUsuarios_MostrarCorreo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_GestionUsuarios_MostrarCorreo.ForeColor = Color.Gray;
            LBL_GestionUsuarios_MostrarCorreo.Location = new Point(289, 273);
            LBL_GestionUsuarios_MostrarCorreo.Name = "LBL_GestionUsuarios_MostrarCorreo";
            LBL_GestionUsuarios_MostrarCorreo.Size = new Size(70, 25);
            LBL_GestionUsuarios_MostrarCorreo.TabIndex = 46;
            LBL_GestionUsuarios_MostrarCorreo.Text = "Correo";
            // 
            // CHEKB_GestionUsuarios_Tipo
            // 
            CHEKB_GestionUsuarios_Tipo.AutoSize = true;
            CHEKB_GestionUsuarios_Tipo.Enabled = false;
            CHEKB_GestionUsuarios_Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CHEKB_GestionUsuarios_Tipo.ForeColor = Color.DimGray;
            CHEKB_GestionUsuarios_Tipo.Location = new Point(289, 357);
            CHEKB_GestionUsuarios_Tipo.Name = "CHEKB_GestionUsuarios_Tipo";
            CHEKB_GestionUsuarios_Tipo.Size = new Size(129, 25);
            CHEKB_GestionUsuarios_Tipo.TabIndex = 40;
            CHEKB_GestionUsuarios_Tipo.Text = "Administrador";
            CHEKB_GestionUsuarios_Tipo.UseVisualStyleBackColor = true;
            // 
            // BTN_GestionUsuarios_Guardar
            // 
            BTN_GestionUsuarios_Guardar.BackColor = Color.NavajoWhite;
            BTN_GestionUsuarios_Guardar.Enabled = false;
            BTN_GestionUsuarios_Guardar.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_GestionUsuarios_Guardar.FlatStyle = FlatStyle.Flat;
            BTN_GestionUsuarios_Guardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_GestionUsuarios_Guardar.ForeColor = Color.DimGray;
            BTN_GestionUsuarios_Guardar.Location = new Point(300, 420);
            BTN_GestionUsuarios_Guardar.Name = "BTN_GestionUsuarios_Guardar";
            BTN_GestionUsuarios_Guardar.Size = new Size(108, 33);
            BTN_GestionUsuarios_Guardar.TabIndex = 38;
            BTN_GestionUsuarios_Guardar.Text = "Guardar";
            BTN_GestionUsuarios_Guardar.UseVisualStyleBackColor = false;
            // 
            // BTN_GestionUsuarios_Editar
            // 
            BTN_GestionUsuarios_Editar.BackColor = Color.NavajoWhite;
            BTN_GestionUsuarios_Editar.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_GestionUsuarios_Editar.FlatStyle = FlatStyle.Flat;
            BTN_GestionUsuarios_Editar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_GestionUsuarios_Editar.ForeColor = Color.DimGray;
            BTN_GestionUsuarios_Editar.Location = new Point(385, 146);
            BTN_GestionUsuarios_Editar.Name = "BTN_GestionUsuarios_Editar";
            BTN_GestionUsuarios_Editar.Size = new Size(108, 33);
            BTN_GestionUsuarios_Editar.TabIndex = 36;
            BTN_GestionUsuarios_Editar.Text = "Buscar";
            BTN_GestionUsuarios_Editar.UseVisualStyleBackColor = false;
            BTN_GestionUsuarios_Editar.Click += BTN_GestionUsuarios_Editar_Click;
            // 
            // RB_GestionUsuarios_Inactivo
            // 
            RB_GestionUsuarios_Inactivo.AutoSize = true;
            RB_GestionUsuarios_Inactivo.Enabled = false;
            RB_GestionUsuarios_Inactivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_GestionUsuarios_Inactivo.ForeColor = Color.DimGray;
            RB_GestionUsuarios_Inactivo.Location = new Point(366, 319);
            RB_GestionUsuarios_Inactivo.Name = "RB_GestionUsuarios_Inactivo";
            RB_GestionUsuarios_Inactivo.Size = new Size(82, 25);
            RB_GestionUsuarios_Inactivo.TabIndex = 35;
            RB_GestionUsuarios_Inactivo.TabStop = true;
            RB_GestionUsuarios_Inactivo.Text = "Inactivo";
            RB_GestionUsuarios_Inactivo.UseVisualStyleBackColor = true;
            // 
            // RB_GestionUsuarios_Activo
            // 
            RB_GestionUsuarios_Activo.AutoSize = true;
            RB_GestionUsuarios_Activo.Enabled = false;
            RB_GestionUsuarios_Activo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_GestionUsuarios_Activo.ForeColor = Color.DimGray;
            RB_GestionUsuarios_Activo.Location = new Point(289, 318);
            RB_GestionUsuarios_Activo.Name = "RB_GestionUsuarios_Activo";
            RB_GestionUsuarios_Activo.Size = new Size(71, 25);
            RB_GestionUsuarios_Activo.TabIndex = 34;
            RB_GestionUsuarios_Activo.TabStop = true;
            RB_GestionUsuarios_Activo.Text = "Activo";
            RB_GestionUsuarios_Activo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(225, 355);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 33;
            label7.Text = "TIPO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(192, 318);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 32;
            label6.Text = "ESTATUS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(63, 273);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 28;
            label2.Text = "CORREO ELECTRONICO:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 100);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(41, 22);
            label1.Name = "label1";
            label1.Size = new Size(422, 48);
            label1.TabIndex = 0;
            label1.Text = "Gestion De Usuarios";
            // 
            // TXTB_GestionUsuarios_Buscar
            // 
            TXTB_GestionUsuarios_Buscar.Location = new Point(229, 155);
            TXTB_GestionUsuarios_Buscar.Name = "TXTB_GestionUsuarios_Buscar";
            TXTB_GestionUsuarios_Buscar.Size = new Size(150, 23);
            TXTB_GestionUsuarios_Buscar.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 137);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 51;
            label3.Text = "Ingrese correo electronico";
            // 
            // Form_GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 621);
            Controls.Add(label3);
            Controls.Add(TXTB_GestionUsuarios_Buscar);
            Controls.Add(label9);
            Controls.Add(BTN_GestionUsuarios_Baja);
            Controls.Add(LBL_GestionUsuarios_MostrarCorreo);
            Controls.Add(CHEKB_GestionUsuarios_Tipo);
            Controls.Add(BTN_GestionUsuarios_Guardar);
            Controls.Add(BTN_GestionUsuarios_Editar);
            Controls.Add(RB_GestionUsuarios_Inactivo);
            Controls.Add(RB_GestionUsuarios_Activo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form_GestionUsuarios";
            Text = " Gestion Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Button BTN_GestionUsuarios_Baja;
        private Label LBL_GestionUsuarios_MostrarCorreo;
        private CheckBox CHEKB_GestionUsuarios_Tipo;
        private Button BTN_GestionUsuarios_Guardar;
        private Button BTN_GestionUsuarios_Editar;
        private RadioButton RB_GestionUsuarios_Inactivo;
        private RadioButton RB_GestionUsuarios_Activo;
        private Label label7;
        private Label label6;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private TextBox TXTB_GestionUsuarios_Buscar;
        private Label label3;
    }
}