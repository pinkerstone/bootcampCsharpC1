namespace Clase1WindowsForms
{
    partial class frmMenu
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
            gpxAplicaciones = new GroupBox();
            btnPersonas = new Button();
            btnOperaciones = new Button();
            gpxAplicaciones.SuspendLayout();
            SuspendLayout();
            // 
            // gpxAplicaciones
            // 
            gpxAplicaciones.Controls.Add(btnPersonas);
            gpxAplicaciones.Controls.Add(btnOperaciones);
            gpxAplicaciones.Location = new Point(72, 56);
            gpxAplicaciones.Name = "gpxAplicaciones";
            gpxAplicaciones.Size = new Size(498, 177);
            gpxAplicaciones.TabIndex = 0;
            gpxAplicaciones.TabStop = false;
            gpxAplicaciones.Text = "Aplicaciones";
            // 
            // btnPersonas
            // 
            btnPersonas.BackColor = Color.FromArgb(255, 255, 192);
            btnPersonas.Location = new Point(289, 59);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(175, 76);
            btnPersonas.TabIndex = 1;
            btnPersonas.Text = "Ir a personas";
            btnPersonas.UseVisualStyleBackColor = false;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // btnOperaciones
            // 
            btnOperaciones.BackColor = Color.FromArgb(255, 192, 128);
            btnOperaciones.Location = new Point(38, 59);
            btnOperaciones.Name = "btnOperaciones";
            btnOperaciones.Size = new Size(175, 76);
            btnOperaciones.TabIndex = 0;
            btnOperaciones.Text = "Ir a operaciones";
            btnOperaciones.UseVisualStyleBackColor = false;
            btnOperaciones.Click += btnOperaciones_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpxAplicaciones);
            Name = "frmMenu";
            Text = "Menú principal";
            gpxAplicaciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxAplicaciones;
        private Button btnPersonas;
        private Button btnOperaciones;
    }
}