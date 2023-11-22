namespace MAD.Forms
{
    partial class Form_ViewInactivos
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
            dataGrid_Inactivos = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Inactivos).BeginInit();
            SuspendLayout();
            // 
            // dataGrid_Inactivos
            // 
            dataGrid_Inactivos.AllowUserToAddRows = false;
            dataGrid_Inactivos.AllowUserToDeleteRows = false;
            dataGrid_Inactivos.BackgroundColor = Color.Beige;
            dataGrid_Inactivos.BorderStyle = BorderStyle.None;
            dataGrid_Inactivos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid_Inactivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Inactivos.Enabled = false;
            dataGrid_Inactivos.Location = new Point(12, 42);
            dataGrid_Inactivos.Name = "dataGrid_Inactivos";
            dataGrid_Inactivos.ReadOnly = true;
            dataGrid_Inactivos.RowTemplate.Height = 25;
            dataGrid_Inactivos.Size = new Size(321, 369);
            dataGrid_Inactivos.TabIndex = 0;
            dataGrid_Inactivos.CellContentClick += dataGrid_Inactivos_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 13;
            label2.Text = "Correo del usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(274, 18);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 14;
            label1.Text = "Estado";
            // 
            // Form_ViewInactivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(349, 456);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGrid_Inactivos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_ViewInactivos";
            Text = "Ver Usuarios Inactivos";
            Load += Form_ViewInactivos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Inactivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_Inactivos;
        private Label label2;
        private Label label1;
    }
}