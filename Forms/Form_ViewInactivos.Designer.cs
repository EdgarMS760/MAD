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
            ((System.ComponentModel.ISupportInitialize)dataGrid_Inactivos).BeginInit();
            SuspendLayout();
            // 
            // dataGrid_Inactivos
            // 
            dataGrid_Inactivos.AllowUserToAddRows = false;
            dataGrid_Inactivos.AllowUserToDeleteRows = false;
            dataGrid_Inactivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Inactivos.Location = new Point(2, 3);
            dataGrid_Inactivos.Name = "dataGrid_Inactivos";
            dataGrid_Inactivos.ReadOnly = true;
            dataGrid_Inactivos.RowTemplate.Height = 25;
            dataGrid_Inactivos.Size = new Size(342, 447);
            dataGrid_Inactivos.TabIndex = 0;
            dataGrid_Inactivos.CellContentClick += dataGrid_Inactivos_CellContentClick;
            // 
            // Form_ViewInactivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 456);
            Controls.Add(dataGrid_Inactivos);
            Name = "Form_ViewInactivos";
            Text = "Form_ViewInactivos";
            Load += Form_ViewInactivos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Inactivos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrid_Inactivos;
    }
}