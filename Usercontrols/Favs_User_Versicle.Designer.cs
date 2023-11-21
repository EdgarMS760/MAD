namespace MAD
{
    partial class Favs_User_Versicle
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
            LBL_UCFAVS_LibroFav = new Label();
            pictureBox1 = new PictureBox();
            BTN_BCV_EliminasFav = new Button();
            LBL_UCFAVS_CapituloFav = new Label();
            LBL_UCFAVS_VersiculoFav = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LBL_UCFAVS_LibroFav
            // 
            LBL_UCFAVS_LibroFav.AutoSize = true;
            LBL_UCFAVS_LibroFav.Font = new Font("Mongolian Baiti", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_UCFAVS_LibroFav.ForeColor = Color.DimGray;
            LBL_UCFAVS_LibroFav.Location = new Point(110, 32);
            LBL_UCFAVS_LibroFav.Name = "LBL_UCFAVS_LibroFav";
            LBL_UCFAVS_LibroFav.Size = new Size(127, 40);
            LBL_UCFAVS_LibroFav.TabIndex = 0;
            LBL_UCFAVS_LibroFav.Text = "BOOK";
            LBL_UCFAVS_LibroFav.MouseEnter += LBL_UCFAVS_LibroFav_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fav_removebg;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BTN_BCV_EliminasFav
            // 
            BTN_BCV_EliminasFav.BackColor = Color.Moccasin;
            BTN_BCV_EliminasFav.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_BCV_EliminasFav.ForeColor = Color.Red;
            BTN_BCV_EliminasFav.Location = new Point(603, 32);
            BTN_BCV_EliminasFav.Name = "BTN_BCV_EliminasFav";
            BTN_BCV_EliminasFav.Size = new Size(40, 39);
            BTN_BCV_EliminasFav.TabIndex = 2;
            BTN_BCV_EliminasFav.Text = "X";
            BTN_BCV_EliminasFav.UseVisualStyleBackColor = false;
            BTN_BCV_EliminasFav.Click += button1_Click;
            // 
            // LBL_UCFAVS_CapituloFav
            // 
            LBL_UCFAVS_CapituloFav.AutoSize = true;
            LBL_UCFAVS_CapituloFav.Font = new Font("Mongolian Baiti", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_UCFAVS_CapituloFav.ForeColor = Color.DimGray;
            LBL_UCFAVS_CapituloFav.Location = new Point(465, 32);
            LBL_UCFAVS_CapituloFav.Name = "LBL_UCFAVS_CapituloFav";
            LBL_UCFAVS_CapituloFav.Size = new Size(71, 40);
            LBL_UCFAVS_CapituloFav.TabIndex = 3;
            LBL_UCFAVS_CapituloFav.Text = "CH";
            // 
            // LBL_UCFAVS_VersiculoFav
            // 
            LBL_UCFAVS_VersiculoFav.AutoSize = true;
            LBL_UCFAVS_VersiculoFav.Font = new Font("Mongolian Baiti", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_UCFAVS_VersiculoFav.ForeColor = Color.DimGray;
            LBL_UCFAVS_VersiculoFav.Location = new Point(528, 32);
            LBL_UCFAVS_VersiculoFav.Name = "LBL_UCFAVS_VersiculoFav";
            LBL_UCFAVS_VersiculoFav.Size = new Size(69, 40);
            LBL_UCFAVS_VersiculoFav.TabIndex = 4;
            LBL_UCFAVS_VersiculoFav.Text = "VE";
            // 
            // Favs_User_Versicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            Controls.Add(LBL_UCFAVS_VersiculoFav);
            Controls.Add(LBL_UCFAVS_CapituloFav);
            Controls.Add(BTN_BCV_EliminasFav);
            Controls.Add(pictureBox1);
            Controls.Add(LBL_UCFAVS_LibroFav);
            Name = "Favs_User_Versicle";
            Size = new Size(659, 110);
            Load += Favs_User_Versicle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_UCFAVS_LibroFav;
        private PictureBox pictureBox1;
        private Button BTN_BCV_EliminasFav;
        private Label LBL_UCFAVS_CapituloFav;
        private Label LBL_UCFAVS_VersiculoFav;
    }
}
