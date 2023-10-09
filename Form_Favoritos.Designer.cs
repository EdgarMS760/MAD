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
            panel1.Name = "panel1";
            // 
            // Form_Favoritos
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            Controls.Add(FlowPanel_Favs_Favoritos);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Favoritos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel FlowPanel_Favs_Favoritos;
        private Panel panel1;
    }
}