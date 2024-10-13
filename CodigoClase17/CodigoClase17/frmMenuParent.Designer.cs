namespace CodigoClase17
{
    partial class frmMenuParent
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
            procesosToolStripMenuItem = new ToolStripMenuItem();
            irAOperacionesToolStripMenuItem = new ToolStripMenuItem();
            irAPersonaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { procesosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { irAOperacionesToolStripMenuItem, irAPersonaToolStripMenuItem });
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(81, 24);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // irAOperacionesToolStripMenuItem
            // 
            irAOperacionesToolStripMenuItem.Name = "irAOperacionesToolStripMenuItem";
            irAOperacionesToolStripMenuItem.Size = new Size(224, 26);
            irAOperacionesToolStripMenuItem.Text = "Ir a Operaciones";
            irAOperacionesToolStripMenuItem.Click += irAOperacionesToolStripMenuItem_Click;
            // 
            // irAPersonaToolStripMenuItem
            // 
            irAPersonaToolStripMenuItem.Name = "irAPersonaToolStripMenuItem";
            irAPersonaToolStripMenuItem.Size = new Size(224, 26);
            irAPersonaToolStripMenuItem.Text = "Ir a Persona";
            irAPersonaToolStripMenuItem.Click += irAPersonaToolStripMenuItem_Click;
            // 
            // frmMenuParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMenuParent";
            Text = "frmMenuParent";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem irAOperacionesToolStripMenuItem;
        private ToolStripMenuItem irAPersonaToolStripMenuItem;
    }
}