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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsBible));
            PIC_UserControl_icon = new PictureBox();
            LBL_UserControl_Title = new Label();
            LBL_UserControl_Content = new Label();
            panel_select = new Panel();
            LBL_UserControl_Title_Book = new Label();
            panel_ResultBible_title = new Panel();
            PIC_ResultBible_Star = new PictureBox();
            PIC_ResultBible_StarFav = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PIC_UserControl_icon).BeginInit();
            panel_ResultBible_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_ResultBible_Star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PIC_ResultBible_StarFav).BeginInit();
            SuspendLayout();
            // 
            // PIC_UserControl_icon
            // 
            PIC_UserControl_icon.Image = Properties.Resources.bookIcon;
            PIC_UserControl_icon.Location = new Point(0, 50);
            PIC_UserControl_icon.Name = "PIC_UserControl_icon";
            PIC_UserControl_icon.Size = new Size(114, 98);
            PIC_UserControl_icon.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_UserControl_icon.TabIndex = 0;
            PIC_UserControl_icon.TabStop = false;
            PIC_UserControl_icon.Click += PIC_UserControl_icon_Click;
            PIC_UserControl_icon.MouseEnter += ResultsBible_MouseEnter;
            PIC_UserControl_icon.MouseLeave += ResultsBible_MouseLeave;
            // 
            // LBL_UserControl_Title
            // 
            LBL_UserControl_Title.AutoSize = true;
            LBL_UserControl_Title.Dock = DockStyle.Left;
            LBL_UserControl_Title.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_UserControl_Title.Location = new Point(64, 0);
            LBL_UserControl_Title.Name = "LBL_UserControl_Title";
            LBL_UserControl_Title.Size = new Size(166, 30);
            LBL_UserControl_Title.TabIndex = 1;
            LBL_UserControl_Title.Text = "chapter:versicle";
            LBL_UserControl_Title.MouseEnter += ResultsBible_MouseEnter;
            LBL_UserControl_Title.MouseLeave += ResultsBible_MouseLeave;
            // 
            // LBL_UserControl_Content
            // 
            LBL_UserControl_Content.Cursor = Cursors.Help;
            LBL_UserControl_Content.Location = new Point(133, 37);
            LBL_UserControl_Content.Name = "LBL_UserControl_Content";
            LBL_UserControl_Content.Size = new Size(418, 127);
            LBL_UserControl_Content.TabIndex = 2;
            LBL_UserControl_Content.Text = "content";
            LBL_UserControl_Content.Click += LBL_UserControl_Content_Click;
            LBL_UserControl_Content.MouseEnter += ResultsBible_MouseEnter;
            LBL_UserControl_Content.MouseLeave += ResultsBible_MouseLeave;
            // 
            // panel_select
            // 
            panel_select.BackColor = Color.Silver;
            panel_select.Location = new Point(0, 238);
            panel_select.Name = "panel_select";
            panel_select.Size = new Size(706, 1);
            panel_select.TabIndex = 3;
            // 
            // LBL_UserControl_Title_Book
            // 
            LBL_UserControl_Title_Book.AutoSize = true;
            LBL_UserControl_Title_Book.Dock = DockStyle.Left;
            LBL_UserControl_Title_Book.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_UserControl_Title_Book.Location = new Point(0, 0);
            LBL_UserControl_Title_Book.Name = "LBL_UserControl_Title_Book";
            LBL_UserControl_Title_Book.Size = new Size(64, 30);
            LBL_UserControl_Title_Book.TabIndex = 4;
            LBL_UserControl_Title_Book.Text = "book";
            // 
            // panel_ResultBible_title
            // 
            panel_ResultBible_title.Controls.Add(LBL_UserControl_Title);
            panel_ResultBible_title.Controls.Add(LBL_UserControl_Title_Book);
            panel_ResultBible_title.Dock = DockStyle.Top;
            panel_ResultBible_title.Location = new Point(0, 0);
            panel_ResultBible_title.Name = "panel_ResultBible_title";
            panel_ResultBible_title.Size = new Size(622, 34);
            panel_ResultBible_title.TabIndex = 5;
            panel_ResultBible_title.Click += panel_ResultBible_title_Click;
            panel_ResultBible_title.Paint += panel_ResultBible_title_Paint;
            // 
            // PIC_ResultBible_Star
            // 
            PIC_ResultBible_Star.BackColor = Color.Transparent;
            PIC_ResultBible_Star.Cursor = Cursors.Hand;
            PIC_ResultBible_Star.Image = (Image)resources.GetObject("PIC_ResultBible_Star.Image");
            PIC_ResultBible_Star.Location = new Point(554, 69);
            PIC_ResultBible_Star.Name = "PIC_ResultBible_Star";
            PIC_ResultBible_Star.Size = new Size(65, 63);
            PIC_ResultBible_Star.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_ResultBible_Star.TabIndex = 6;
            PIC_ResultBible_Star.TabStop = false;
            PIC_ResultBible_Star.Click += PIC_ResultBible_Star_Click;
            PIC_ResultBible_Star.MouseEnter += PIC_ResultBible_Star_MouseEnter;
            PIC_ResultBible_Star.MouseLeave += PIC_ResultBible_Star_MouseLeave;
            // 
            // PIC_ResultBible_StarFav
            // 
            PIC_ResultBible_StarFav.BackColor = Color.Transparent;
            PIC_ResultBible_StarFav.Cursor = Cursors.Hand;
            PIC_ResultBible_StarFav.Image = (Image)resources.GetObject("PIC_ResultBible_StarFav.Image");
            PIC_ResultBible_StarFav.Location = new Point(554, 69);
            PIC_ResultBible_StarFav.Name = "PIC_ResultBible_StarFav";
            PIC_ResultBible_StarFav.Size = new Size(65, 63);
            PIC_ResultBible_StarFav.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_ResultBible_StarFav.TabIndex = 7;
            PIC_ResultBible_StarFav.TabStop = false;
            PIC_ResultBible_StarFav.Click += PIC_ResultBible_StarFav_Click;
            // 
            // ResultsBible
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PIC_ResultBible_StarFav);
            Controls.Add(PIC_ResultBible_Star);
            Controls.Add(panel_select);
            Controls.Add(LBL_UserControl_Content);
            Controls.Add(PIC_UserControl_icon);
            Controls.Add(panel_ResultBible_title);
            Cursor = Cursors.Help;
            Name = "ResultsBible";
            Size = new Size(622, 178);
            Load += ResultsBible_Load;
            Click += ResultsBible_Click;
            MouseEnter += ResultsBible_MouseEnter;
            MouseLeave += ResultsBible_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)PIC_UserControl_icon).EndInit();
            panel_ResultBible_title.ResumeLayout(false);
            panel_ResultBible_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_ResultBible_Star).EndInit();
            ((System.ComponentModel.ISupportInitialize)PIC_ResultBible_StarFav).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PIC_UserControl_icon;
        private Label LBL_UserControl_Title;
        private Label LBL_UserControl_Content;
        private Panel panel_select;
        private Label LBL_UserControl_Title_Book;
        private Panel panel_ResultBible_title;
        private PictureBox PIC_ResultBible_Star;
        private PictureBox PIC_ResultBible_StarFav;
    }
}
