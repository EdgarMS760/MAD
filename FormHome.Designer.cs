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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1_Home
            // 
            panel1_Home.Dock = DockStyle.Right;
            panel1_Home.Location = new Point(194, 0);
            panel1_Home.Name = "panel1_Home";
            panel1_Home.Size = new Size(1309, 952);
            panel1_Home.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 188);
            panel1.TabIndex = 1;
            // 
            // FORM_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 952);
            Controls.Add(panel1);
            Controls.Add(panel1_Home);
            Name = "FORM_Home";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1_Home;
        private Panel panel1;
    }
}