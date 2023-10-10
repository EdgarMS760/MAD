namespace MAD
{
    partial class Form_Favoritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Favoritos));
            label1 = new Label();
            FlowPanel_Favs_Favoritos = new FlowLayoutPanel();
            panel1 = new Panel();
            Pic_Favs_ClickExit = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Favs_ClickExit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.PaleGoldenrod;
            label1.ForeColor = Color.DimGray;
            label1.Name = "label1";
            // 
            // FlowPanel_Favs_Favoritos
            // 
            resources.ApplyResources(FlowPanel_Favs_Favoritos, "FlowPanel_Favs_Favoritos");
            FlowPanel_Favs_Favoritos.Name = "FlowPanel_Favs_Favoritos";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.Controls.Add(Pic_Favs_ClickExit);
            panel1.Controls.Add(label1);
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // Pic_Favs_ClickExit
            // 
            resources.ApplyResources(Pic_Favs_ClickExit, "Pic_Favs_ClickExit");
            Pic_Favs_ClickExit.Image = Properties.Resources.Salir_gris;
            Pic_Favs_ClickExit.Name = "Pic_Favs_ClickExit";
            Pic_Favs_ClickExit.TabStop = false;
            Pic_Favs_ClickExit.Click += Pic_Favs_ClickExit_Click;
            // 
            // Form_Favoritos
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            Controls.Add(FlowPanel_Favs_Favoritos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Favoritos";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pic_Favs_ClickExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel FlowPanel_Favs_Favoritos;
        private Panel panel1;
        private PictureBox Pic_Favs_ClickExit;
    }
}