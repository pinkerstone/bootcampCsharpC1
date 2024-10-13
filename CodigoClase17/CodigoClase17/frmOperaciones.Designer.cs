namespace CodigoClase17
{
    partial class frmOperaciones
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
            btnSumar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            lblResultado = new Label();
            lblResta = new Label();
            txtValor4 = new TextBox();
            txtValor3 = new TextBox();
            btnRestar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnCerrar = new Button();
            btnMenu = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(428, 35);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(129, 54);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "SUMAR";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 47);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "VALOR 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 47);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "VALOR2";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(42, 45);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(125, 27);
            txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            txtValor2.AcceptsReturn = true;
            txtValor2.Location = new Point(250, 49);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(125, 27);
            txtValor2.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(609, 52);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(120, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado SUMA";
            lblResultado.TextAlign = ContentAlignment.TopRight;
            // 
            // lblResta
            // 
            lblResta.AutoSize = true;
            lblResta.Location = new Point(606, 67);
            lblResta.Name = "lblResta";
            lblResta.Size = new Size(121, 20);
            lblResta.TabIndex = 9;
            lblResta.Text = "Resultado RESTA";
            lblResta.TextAlign = ContentAlignment.TopRight;
            // 
            // txtValor4
            // 
            txtValor4.AcceptsReturn = true;
            txtValor4.Location = new Point(239, 69);
            txtValor4.Name = "txtValor4";
            txtValor4.Size = new Size(125, 27);
            txtValor4.TabIndex = 8;
            // 
            // txtValor3
            // 
            txtValor3.Location = new Point(42, 60);
            txtValor3.Name = "txtValor3";
            txtValor3.Size = new Size(125, 27);
            txtValor3.TabIndex = 7;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(426, 50);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(129, 54);
            btnRestar.TabIndex = 10;
            btnRestar.Text = "RESTAR";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(btnSumar);
            groupBox1.Controls.Add(txtValor1);
            groupBox1.Controls.Add(txtValor2);
            groupBox1.Location = new Point(34, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 125);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sección SUMAR";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lblResta);
            groupBox2.Controls.Add(txtValor3);
            groupBox2.Controls.Add(btnRestar);
            groupBox2.Controls.Add(txtValor4);
            groupBox2.Location = new Point(36, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 125);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sección Restar";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ActiveCaption;
            btnCerrar.Location = new Point(374, 465);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(129, 54);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(218, 465);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(129, 54);
            btnMenu.TabIndex = 13;
            btnMenu.Text = "IR MENÚ";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // frmOperaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 616);
            Controls.Add(btnMenu);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOperaciones";
            Text = "frmOperaciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Label label1;
        private Label label2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lblResultado;
        private Label lblResta;
        private TextBox txtValor4;
        private TextBox txtValor3;
        private Button btnRestar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCerrar;
        private Button btnMenu;
    }
}