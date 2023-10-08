namespace MAD
{
    partial class ResultsBible
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PIC_UserControl_icon = new PictureBox();
            LBL_UserControl_Title = new Label();
            LBL_UserControl_Content = new Label();
            ((System.ComponentModel.ISupportInitialize)PIC_UserControl_icon).BeginInit();
            SuspendLayout();
            // 
            // PIC_UserControl_icon
            // 
            PIC_UserControl_icon.Location = new Point(19, 24);
            PIC_UserControl_icon.Name = "PIC_UserControl_icon";
            PIC_UserControl_icon.Size = new Size(114, 98);
            PIC_UserControl_icon.TabIndex = 0;
            PIC_UserControl_icon.TabStop = false;
            // 
            // LBL_UserControl_Title
            // 
            LBL_UserControl_Title.Location = new Point(152, 24);
            LBL_UserControl_Title.Name = "LBL_UserControl_Title";
            LBL_UserControl_Title.Size = new Size(297, 30);
            LBL_UserControl_Title.TabIndex = 1;
            LBL_UserControl_Title.Text = "book chapter:versicle";
            // 
            // LBL_UserControl_Content
            // 
            LBL_UserControl_Content.Location = new Point(152, 72);
            LBL_UserControl_Content.Name = "LBL_UserControl_Content";
            LBL_UserControl_Content.Size = new Size(518, 85);
            LBL_UserControl_Content.TabIndex = 2;
            LBL_UserControl_Content.Text = "Content";
            LBL_UserControl_Content.Click += label2_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LBL_UserControl_Content);
            Controls.Add(LBL_UserControl_Title);
            Controls.Add(PIC_UserControl_icon);
            Name = "UserControl1";
            Size = new Size(702, 179);
            ((System.ComponentModel.ISupportInitialize)PIC_UserControl_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PIC_UserControl_icon;
        private Label LBL_UserControl_Title;
        private Label LBL_UserControl_Content;
    }
}
