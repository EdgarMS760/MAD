namespace MAD
{
    partial class Form_EditUser
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
            Pic_EditUser_ClickExit = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            RB_EditUser_Activo = new RadioButton();
            RB_EditUser_Inactivo = new RadioButton();
            BTN_EditUser_Editar = new Button();
            TXTB_EditUser_Name = new TextBox();
            BTN_EditUser_Guardar = new Button();
            DTP_EditUser_BirthDate = new DateTimePicker();
            CHEKB_EditUser_Tipo = new CheckBox();
            label8 = new Label();
            RB_EditUser_Female = new RadioButton();
            RB_EditUser_Male = new RadioButton();
            BTN_EditUser_CambiarContra = new Button();
            BTN_EditUser_CambiarCorreo = new Button();
            LBL_EditUser_MostrarCorreo = new Label();
            LBL_EditUser_MostrarContraseña = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_EditUser_ClickExit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(Pic_EditUser_ClickExit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 100);
            panel1.TabIndex = 0;
            // 
            // Pic_EditUser_ClickExit
            // 
            Pic_EditUser_ClickExit.Location = new Point(735, 3);
            Pic_EditUser_ClickExit.Name = "Pic_EditUser_ClickExit";
            Pic_EditUser_ClickExit.Size = new Size(27, 26);
            Pic_EditUser_ClickExit.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_EditUser_ClickExit.TabIndex = 1;
            Pic_EditUser_ClickExit.TabStop = false;
            Pic_EditUser_ClickExit.Click += Pic_EditUser_ClickExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(41, 22);
            label1.Name = "label1";
            label1.Size = new Size(263, 48);
            label1.TabIndex = 0;
            label1.Text = "Editar Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(88, 350);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 1;
            label2.Text = "CORREO ELECTRONICO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(207, 224);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(83, 265);
            label4.Name = "label4";
            label4.Size = new Size(228, 25);
            label4.TabIndex = 3;
            label4.Text = "FECHA DE NACIMIENTO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(212, 308);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 4;
            label5.Text = "GENERO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(211, 432);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 5;
            label6.Text = "ESTATUS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(244, 469);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 6;
            label7.Text = "TIPO:";
            // 
            // RB_EditUser_Activo
            // 
            RB_EditUser_Activo.AutoSize = true;
            RB_EditUser_Activo.Enabled = false;
            RB_EditUser_Activo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_EditUser_Activo.ForeColor = Color.DimGray;
            RB_EditUser_Activo.Location = new Point(308, 432);
            RB_EditUser_Activo.Name = "RB_EditUser_Activo";
            RB_EditUser_Activo.Size = new Size(71, 25);
            RB_EditUser_Activo.TabIndex = 7;
            RB_EditUser_Activo.TabStop = true;
            RB_EditUser_Activo.Text = "Activo";
            RB_EditUser_Activo.UseVisualStyleBackColor = true;
            // 
            // RB_EditUser_Inactivo
            // 
            RB_EditUser_Inactivo.AutoSize = true;
            RB_EditUser_Inactivo.Enabled = false;
            RB_EditUser_Inactivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_EditUser_Inactivo.ForeColor = Color.DimGray;
            RB_EditUser_Inactivo.Location = new Point(385, 433);
            RB_EditUser_Inactivo.Name = "RB_EditUser_Inactivo";
            RB_EditUser_Inactivo.Size = new Size(82, 25);
            RB_EditUser_Inactivo.TabIndex = 8;
            RB_EditUser_Inactivo.TabStop = true;
            RB_EditUser_Inactivo.Text = "Inactivo";
            RB_EditUser_Inactivo.UseVisualStyleBackColor = true;
            // 
            // BTN_EditUser_Editar
            // 
            BTN_EditUser_Editar.BackColor = Color.NavajoWhite;
            BTN_EditUser_Editar.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_EditUser_Editar.FlatStyle = FlatStyle.Flat;
            BTN_EditUser_Editar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_EditUser_Editar.ForeColor = Color.DimGray;
            BTN_EditUser_Editar.Location = new Point(319, 145);
            BTN_EditUser_Editar.Name = "BTN_EditUser_Editar";
            BTN_EditUser_Editar.Size = new Size(108, 33);
            BTN_EditUser_Editar.TabIndex = 9;
            BTN_EditUser_Editar.Text = "Editar";
            BTN_EditUser_Editar.UseVisualStyleBackColor = false;
            BTN_EditUser_Editar.Click += BTN_EditUser_Editar_Click;
            // 
            // TXTB_EditUser_Name
            // 
            TXTB_EditUser_Name.BackColor = Color.LemonChiffon;
            TXTB_EditUser_Name.Enabled = false;
            TXTB_EditUser_Name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TXTB_EditUser_Name.ForeColor = Color.DimGray;
            TXTB_EditUser_Name.Location = new Point(308, 216);
            TXTB_EditUser_Name.Name = "TXTB_EditUser_Name";
            TXTB_EditUser_Name.Size = new Size(242, 33);
            TXTB_EditUser_Name.TabIndex = 10;
            // 
            // BTN_EditUser_Guardar
            // 
            BTN_EditUser_Guardar.BackColor = Color.NavajoWhite;
            BTN_EditUser_Guardar.Enabled = false;
            BTN_EditUser_Guardar.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_EditUser_Guardar.FlatStyle = FlatStyle.Flat;
            BTN_EditUser_Guardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_EditUser_Guardar.ForeColor = Color.DimGray;
            BTN_EditUser_Guardar.Location = new Point(319, 574);
            BTN_EditUser_Guardar.Name = "BTN_EditUser_Guardar";
            BTN_EditUser_Guardar.Size = new Size(108, 33);
            BTN_EditUser_Guardar.TabIndex = 14;
            BTN_EditUser_Guardar.Text = "Guardar";
            BTN_EditUser_Guardar.UseVisualStyleBackColor = false;
            BTN_EditUser_Guardar.Click += BTN_EditUser_Guardar_Click;
            // 
            // DTP_EditUser_BirthDate
            // 
            DTP_EditUser_BirthDate.CalendarForeColor = Color.PaleGoldenrod;
            DTP_EditUser_BirthDate.CalendarMonthBackground = Color.NavajoWhite;
            DTP_EditUser_BirthDate.CalendarTitleBackColor = Color.PeachPuff;
            DTP_EditUser_BirthDate.CalendarTrailingForeColor = Color.DimGray;
            DTP_EditUser_BirthDate.Enabled = false;
            DTP_EditUser_BirthDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DTP_EditUser_BirthDate.Location = new Point(308, 255);
            DTP_EditUser_BirthDate.Name = "DTP_EditUser_BirthDate";
            DTP_EditUser_BirthDate.Size = new Size(242, 33);
            DTP_EditUser_BirthDate.TabIndex = 15;
            // 
            // CHEKB_EditUser_Tipo
            // 
            CHEKB_EditUser_Tipo.AutoSize = true;
            CHEKB_EditUser_Tipo.Enabled = false;
            CHEKB_EditUser_Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CHEKB_EditUser_Tipo.ForeColor = Color.DimGray;
            CHEKB_EditUser_Tipo.Location = new Point(308, 471);
            CHEKB_EditUser_Tipo.Name = "CHEKB_EditUser_Tipo";
            CHEKB_EditUser_Tipo.Size = new Size(129, 25);
            CHEKB_EditUser_Tipo.TabIndex = 16;
            CHEKB_EditUser_Tipo.Text = "Administrador";
            CHEKB_EditUser_Tipo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(163, 389);
            label8.Name = "label8";
            label8.Size = new Size(141, 25);
            label8.TabIndex = 17;
            label8.Text = "CONTRASEÑA:";
            // 
            // RB_EditUser_Female
            // 
            RB_EditUser_Female.AutoSize = true;
            RB_EditUser_Female.Enabled = false;
            RB_EditUser_Female.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_EditUser_Female.ForeColor = Color.DimGray;
            RB_EditUser_Female.Location = new Point(413, 307);
            RB_EditUser_Female.Name = "RB_EditUser_Female";
            RB_EditUser_Female.Size = new Size(97, 25);
            RB_EditUser_Female.TabIndex = 20;
            RB_EditUser_Female.TabStop = true;
            RB_EditUser_Female.Text = "Femenino";
            RB_EditUser_Female.UseVisualStyleBackColor = true;
            // 
            // RB_EditUser_Male
            // 
            RB_EditUser_Male.AutoSize = true;
            RB_EditUser_Male.Enabled = false;
            RB_EditUser_Male.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_EditUser_Male.ForeColor = Color.DimGray;
            RB_EditUser_Male.Location = new Point(308, 307);
            RB_EditUser_Male.Name = "RB_EditUser_Male";
            RB_EditUser_Male.Size = new Size(99, 25);
            RB_EditUser_Male.TabIndex = 19;
            RB_EditUser_Male.TabStop = true;
            RB_EditUser_Male.Text = "Masculino";
            RB_EditUser_Male.UseVisualStyleBackColor = true;
            // 
            // BTN_EditUser_CambiarContra
            // 
            BTN_EditUser_CambiarContra.BackColor = Color.NavajoWhite;
            BTN_EditUser_CambiarContra.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_EditUser_CambiarContra.FlatStyle = FlatStyle.Flat;
            BTN_EditUser_CambiarContra.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_EditUser_CambiarContra.ForeColor = Color.DimGray;
            BTN_EditUser_CambiarContra.Location = new Point(556, 381);
            BTN_EditUser_CambiarContra.Name = "BTN_EditUser_CambiarContra";
            BTN_EditUser_CambiarContra.Size = new Size(99, 33);
            BTN_EditUser_CambiarContra.TabIndex = 21;
            BTN_EditUser_CambiarContra.Text = "Cambiar";
            BTN_EditUser_CambiarContra.UseVisualStyleBackColor = false;
            BTN_EditUser_CambiarContra.Click += BTN_EditUser_CambiarContra_Click;
            // 
            // BTN_EditUser_CambiarCorreo
            // 
            BTN_EditUser_CambiarCorreo.BackColor = Color.NavajoWhite;
            BTN_EditUser_CambiarCorreo.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_EditUser_CambiarCorreo.FlatStyle = FlatStyle.Flat;
            BTN_EditUser_CambiarCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_EditUser_CambiarCorreo.ForeColor = Color.DimGray;
            BTN_EditUser_CambiarCorreo.Location = new Point(556, 341);
            BTN_EditUser_CambiarCorreo.Name = "BTN_EditUser_CambiarCorreo";
            BTN_EditUser_CambiarCorreo.Size = new Size(99, 33);
            BTN_EditUser_CambiarCorreo.TabIndex = 22;
            BTN_EditUser_CambiarCorreo.Text = "Cambiar";
            BTN_EditUser_CambiarCorreo.UseVisualStyleBackColor = false;
            BTN_EditUser_CambiarCorreo.Click += BTN_EditUser_CambiarCorreo_Click;
            // 
            // LBL_EditUser_MostrarCorreo
            // 
            LBL_EditUser_MostrarCorreo.AutoSize = true;
            LBL_EditUser_MostrarCorreo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_EditUser_MostrarCorreo.ForeColor = Color.Gray;
            LBL_EditUser_MostrarCorreo.Location = new Point(308, 350);
            LBL_EditUser_MostrarCorreo.Name = "LBL_EditUser_MostrarCorreo";
            LBL_EditUser_MostrarCorreo.Size = new Size(70, 25);
            LBL_EditUser_MostrarCorreo.TabIndex = 23;
            LBL_EditUser_MostrarCorreo.Text = "Correo";
            // 
            // LBL_EditUser_MostrarContraseña
            // 
            LBL_EditUser_MostrarContraseña.AutoSize = true;
            LBL_EditUser_MostrarContraseña.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_EditUser_MostrarContraseña.ForeColor = Color.Gray;
            LBL_EditUser_MostrarContraseña.Location = new Point(308, 389);
            LBL_EditUser_MostrarContraseña.Name = "LBL_EditUser_MostrarContraseña";
            LBL_EditUser_MostrarContraseña.Size = new Size(109, 25);
            LBL_EditUser_MostrarContraseña.TabIndex = 24;
            LBL_EditUser_MostrarContraseña.Text = "Contraseña";
            // 
            // Form_EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(765, 687);
            Controls.Add(LBL_EditUser_MostrarContraseña);
            Controls.Add(LBL_EditUser_MostrarCorreo);
            Controls.Add(BTN_EditUser_CambiarCorreo);
            Controls.Add(BTN_EditUser_CambiarContra);
            Controls.Add(RB_EditUser_Female);
            Controls.Add(RB_EditUser_Male);
            Controls.Add(label8);
            Controls.Add(CHEKB_EditUser_Tipo);
            Controls.Add(DTP_EditUser_BirthDate);
            Controls.Add(BTN_EditUser_Guardar);
            Controls.Add(TXTB_EditUser_Name);
            Controls.Add(BTN_EditUser_Editar);
            Controls.Add(RB_EditUser_Inactivo);
            Controls.Add(RB_EditUser_Activo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form_EditUser";
            Text = "Editar Datos del Usuario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_EditUser_ClickExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox Pic_EditUser_ClickExit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton RB_EditUser_Activo;
        private RadioButton RB_EditUser_Inactivo;
        private Button BTN_EditUser_Editar;
        private TextBox TXTB_EditUser_Name;
        private Button BTN_EditUser_Guardar;
        private DateTimePicker DTP_EditUser_BirthDate;
        private CheckBox CHEKB_EditUser_Tipo;
        private Label label8;
        private RadioButton RB_EditUser_Female;
        private RadioButton RB_EditUser_Male;
        private Button BTN_EditUser_CambiarContra;
        private Button BTN_EditUser_CambiarCorreo;
        private Label LBL_EditUser_MostrarCorreo;
        private Label LBL_EditUser_MostrarContraseña;
    }
}