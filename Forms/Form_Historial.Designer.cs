namespace MAD
{
    partial class Form_Historial
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            DGV_Historial_MostrarHistorial = new DataGridView();
            BTN_Historial_BorrarUno = new Button();
            BTN_Historial_BorrarTodo = new Button();
            historialBindingSource = new BindingSource(components);
            historialBindingSource1 = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Historial_MostrarHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historialBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(792, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(269, 48);
            label1.TabIndex = 0;
            label1.Text = "HISTORIAL";
            // 
            // DGV_Historial_MostrarHistorial
            // 
            DGV_Historial_MostrarHistorial.AllowUserToAddRows = false;
            DGV_Historial_MostrarHistorial.AllowUserToDeleteRows = false;
            DGV_Historial_MostrarHistorial.BackgroundColor = Color.PaleGoldenrod;
            DGV_Historial_MostrarHistorial.BorderStyle = BorderStyle.None;
            DGV_Historial_MostrarHistorial.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_Historial_MostrarHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Historial_MostrarHistorial.Location = new Point(31, 128);
            DGV_Historial_MostrarHistorial.Name = "DGV_Historial_MostrarHistorial";
            DGV_Historial_MostrarHistorial.ReadOnly = true;
            DGV_Historial_MostrarHistorial.RowTemplate.Height = 25;
            DGV_Historial_MostrarHistorial.Size = new Size(653, 523);
            DGV_Historial_MostrarHistorial.TabIndex = 1;
            DGV_Historial_MostrarHistorial.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BTN_Historial_BorrarUno
            // 
            BTN_Historial_BorrarUno.BackColor = Color.NavajoWhite;
            BTN_Historial_BorrarUno.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_Historial_BorrarUno.FlatStyle = FlatStyle.Flat;
            BTN_Historial_BorrarUno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_Historial_BorrarUno.ForeColor = Color.DimGray;
            BTN_Historial_BorrarUno.Location = new Point(705, 137);
            BTN_Historial_BorrarUno.Name = "BTN_Historial_BorrarUno";
            BTN_Historial_BorrarUno.Size = new Size(108, 60);
            BTN_Historial_BorrarUno.TabIndex = 10;
            BTN_Historial_BorrarUno.Text = "Borrar Consulta";
            BTN_Historial_BorrarUno.UseVisualStyleBackColor = false;
            BTN_Historial_BorrarUno.Click += BTN_Historial_BorrarUno_Click;
            // 
            // BTN_Historial_BorrarTodo
            // 
            BTN_Historial_BorrarTodo.BackColor = Color.NavajoWhite;
            BTN_Historial_BorrarTodo.FlatAppearance.BorderColor = Color.NavajoWhite;
            BTN_Historial_BorrarTodo.FlatStyle = FlatStyle.Flat;
            BTN_Historial_BorrarTodo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_Historial_BorrarTodo.ForeColor = Color.DimGray;
            BTN_Historial_BorrarTodo.Location = new Point(705, 615);
            BTN_Historial_BorrarTodo.Name = "BTN_Historial_BorrarTodo";
            BTN_Historial_BorrarTodo.Size = new Size(108, 68);
            BTN_Historial_BorrarTodo.TabIndex = 11;
            BTN_Historial_BorrarTodo.Text = "Borrar Historial";
            BTN_Historial_BorrarTodo.UseVisualStyleBackColor = false;
            BTN_Historial_BorrarTodo.Click += BTN_Historial_BorrarTodo_Click;
            // 
            // historialBindingSource
            // 
            historialBindingSource.DataSource = typeof(Services.Historial);
            // 
            // historialBindingSource1
            // 
            historialBindingSource1.DataSource = typeof(Services.Historial);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(59, 104);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 12;
            label2.Text = "Palabras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(226, 103);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 13;
            label3.Text = "Fecha y Hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(398, 104);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 14;
            label4.Text = "Libro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(486, 104);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 15;
            label5.Text = "Capitulo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(608, 104);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 16;
            label6.Text = "Versiculo";
            // 
            // Form_Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Beige;
            ClientSize = new Size(825, 695);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BTN_Historial_BorrarTodo);
            Controls.Add(BTN_Historial_BorrarUno);
            Controls.Add(DGV_Historial_MostrarHistorial);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_Historial";
            Text = "Historial";
            Load += Form_Historial_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Historial_MostrarHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)historialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)historialBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView DGV_Historial_MostrarHistorial;
        private PictureBox pictureBox1;
        private Button BTN_Historial_BorrarUno;
        private Button BTN_Historial_BorrarTodo;
        private BindingSource historialBindingSource;
        private BindingSource historialBindingSource1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}