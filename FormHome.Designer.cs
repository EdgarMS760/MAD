namespace MAD
{
    partial class FORM_Home
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
            panel1_Home = new Panel();
            flowPanel_Home_content = new FlowLayoutPanel();
            panel_Home_search = new Panel();
            panel1 = new Panel();
            panel1_Home.SuspendLayout();
            SuspendLayout();
            // 
            // panel1_Home
            // 
            panel1_Home.Controls.Add(flowPanel_Home_content);
            panel1_Home.Controls.Add(panel_Home_search);
            panel1_Home.Dock = DockStyle.Right;
            panel1_Home.Location = new Point(194, 0);
            panel1_Home.Name = "panel1_Home";
            panel1_Home.Size = new Size(1450, 952);
            panel1_Home.TabIndex = 0;
            // 
            // flowPanel_Home_content
            // 
            flowPanel_Home_content.AutoScroll = true;
            flowPanel_Home_content.Location = new Point(3, 108);
            flowPanel_Home_content.Name = "flowPanel_Home_content";
            flowPanel_Home_content.Size = new Size(743, 790);
            flowPanel_Home_content.TabIndex = 1;
            // 
            // panel_Home_search
            // 
            panel_Home_search.Dock = DockStyle.Top;
            panel_Home_search.Location = new Point(0, 0);
            panel_Home_search.Name = "panel_Home_search";
            panel_Home_search.Size = new Size(1450, 102);
            panel_Home_search.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 940);
            panel1.TabIndex = 1;
            // 
            // FORM_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 952);
            Controls.Add(panel1);
            Controls.Add(panel1_Home);
            Name = "FORM_Home";
            Text = "Home";
            Load += FORM_Home_Load;
            panel1_Home.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1_Home;
        private Panel panel1;
        private FlowLayoutPanel flowPanel_Home_content;
        private Panel panel_Home_search;
    }
}