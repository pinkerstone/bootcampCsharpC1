namespace DemoMDI
{
    partial class frmPadre
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
            menuStrip1 = new MenuStrip();
            pruebaToolStripMenuItem = new ToolStripMenuItem();
            primeroToolStripMenuItem = new ToolStripMenuItem();
            segundoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pruebaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pruebaToolStripMenuItem
            // 
            pruebaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { primeroToolStripMenuItem, segundoToolStripMenuItem });
            pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            pruebaToolStripMenuItem.Size = new Size(69, 24);
            pruebaToolStripMenuItem.Text = "Prueba";
            // 
            // primeroToolStripMenuItem
            // 
            primeroToolStripMenuItem.Name = "primeroToolStripMenuItem";
            primeroToolStripMenuItem.Size = new Size(224, 26);
            primeroToolStripMenuItem.Text = "Primero";
            primeroToolStripMenuItem.Click += primeroToolStripMenuItem_Click;
            // 
            // segundoToolStripMenuItem
            // 
            segundoToolStripMenuItem.Name = "segundoToolStripMenuItem";
            segundoToolStripMenuItem.Size = new Size(224, 26);
            segundoToolStripMenuItem.Text = "Segundo";
            // 
            // frmPadre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPadre";
            Text = "frmPadre";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pruebaToolStripMenuItem;
        private ToolStripMenuItem primeroToolStripMenuItem;
        private ToolStripMenuItem segundoToolStripMenuItem;
    }
}