namespace MAD.Usercontrols
{
    partial class ViewFavs
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
            LBL_viewFavs_ChapVersiculoFav = new Label();
            LBL_viewFavs_LibroFav = new Label();
            pictureBox_viewFavs = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_viewFavs).BeginInit();
            SuspendLayout();
            // 
            // LBL_viewFavs_ChapVersiculoFav
            // 
            LBL_viewFavs_ChapVersiculoFav.AutoSize = true;
            LBL_viewFavs_ChapVersiculoFav.Font = new Font("Mongolian Baiti", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_viewFavs_ChapVersiculoFav.ForeColor = Color.Black;
            LBL_viewFavs_ChapVersiculoFav.Location = new Point(465, 35);
            LBL_viewFavs_ChapVersiculoFav.Name = "LBL_viewFavs_ChapVersiculoFav";
            LBL_viewFavs_ChapVersiculoFav.Size = new Size(134, 40);
            LBL_viewFavs_ChapVersiculoFav.TabIndex = 7;
            LBL_viewFavs_ChapVersiculoFav.Text = "CH:VE";
            LBL_viewFavs_ChapVersiculoFav.Click += LBL_viewFavs_ChapVersiculoFav_Click;
            LBL_viewFavs_ChapVersiculoFav.MouseEnter += LBL_viewFavs_ChapVersiculoFav_MouseEnter;
            // 
            // LBL_viewFavs_LibroFav
            // 
            LBL_viewFavs_LibroFav.AutoSize = true;
            LBL_viewFavs_LibroFav.Font = new Font("Mongolian Baiti", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_viewFavs_LibroFav.ForeColor = Color.Black;
            LBL_viewFavs_LibroFav.Location = new Point(110, 35);
            LBL_viewFavs_LibroFav.Name = "LBL_viewFavs_LibroFav";
            LBL_viewFavs_LibroFav.Size = new Size(127, 40);
            LBL_viewFavs_LibroFav.TabIndex = 5;
            LBL_viewFavs_LibroFav.Text = "BOOK";
            LBL_viewFavs_LibroFav.Click += LBL_viewFavs_LibroFav_Click;
            LBL_viewFavs_LibroFav.MouseEnter += LBL_viewFavs_LibroFav_MouseEnter;
            // 
            // pictureBox_viewFavs
            // 
            pictureBox_viewFavs.Image = Properties.Resources.Fav_removebg;
            pictureBox_viewFavs.Location = new Point(3, -2);
            pictureBox_viewFavs.Name = "pictureBox_viewFavs";
            pictureBox_viewFavs.Size = new Size(101, 104);
            pictureBox_viewFavs.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_viewFavs.TabIndex = 8;
            pictureBox_viewFavs.TabStop = false;
            // 
            // ViewFavs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox_viewFavs);
            Controls.Add(LBL_viewFavs_ChapVersiculoFav);
            Controls.Add(LBL_viewFavs_LibroFav);
            Name = "ViewFavs";
            Size = new Size(614, 105);
            Load += viewFavs_Load;
            Click += viewFavs_Click;
            MouseEnter += viewFavs_MouseEnter;
            MouseLeave += viewFavs_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox_viewFavs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_viewFavs_ChapVersiculoFav;
        private Label LBL_viewFavs_LibroFav;
        private PictureBox pictureBox_viewFavs;
    }
}
