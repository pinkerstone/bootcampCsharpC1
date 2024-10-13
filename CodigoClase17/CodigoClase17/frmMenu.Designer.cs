namespace CodigoClase17
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
            groupBox1 = new GroupBox();
            btnOperaciones = new Button();
            btnPersonas = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnPersonas);
            groupBox1.Controls.Add(btnOperaciones);
            groupBox1.Location = new Point(198, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menú";
            // 
            // btnOperaciones
            // 
            btnOperaciones.Location = new Point(129, 26);
            btnOperaciones.Name = "btnOperaciones";
            btnOperaciones.Size = new Size(154, 85);
            btnOperaciones.TabIndex = 1;
            btnOperaciones.Text = "Ir a Operaciones";
            btnOperaciones.UseVisualStyleBackColor = true;
            btnOperaciones.Click += btnOperaciones_Click;
            // 
            // btnPersonas
            // 
            btnPersonas.Location = new Point(129, 126);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(154, 85);
            btnPersonas.TabIndex = 2;
            btnPersonas.Text = "ir a Persona";
            btnPersonas.UseVisualStyleBackColor = true;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmMenu";
            Text = "frmMenu";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnPersonas;
        private Button btnOperaciones;
    }
}