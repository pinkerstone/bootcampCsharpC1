namespace Clase1WindowsForms
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
            btnCalcularReslt = new Button();
            lvlValor1 = new Label();
            lvlValor2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            lvlResultado = new Label();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            gbxOperaciones = new GroupBox();
            btnCerrarPersona = new Button();
            lvlMenu = new Button();
            gbxOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcularReslt
            // 
            btnCalcularReslt.Location = new Point(28, 39);
            btnCalcularReslt.Name = "btnCalcularReslt";
            btnCalcularReslt.Size = new Size(94, 29);
            btnCalcularReslt.TabIndex = 0;
            btnCalcularReslt.Text = "Sumar";
            btnCalcularReslt.UseVisualStyleBackColor = true;
            btnCalcularReslt.Click += btnCalcularReslt_Click;
            // 
            // lvlValor1
            // 
            lvlValor1.AutoSize = true;
            lvlValor1.Location = new Point(51, 54);
            lvlValor1.Name = "lvlValor1";
            lvlValor1.Size = new Size(55, 20);
            lvlValor1.TabIndex = 1;
            lvlValor1.Text = "Valor 1";
            lvlValor1.Click += label1_Click;
            // 
            // lvlValor2
            // 
            lvlValor2.AutoSize = true;
            lvlValor2.Location = new Point(201, 54);
            lvlValor2.Name = "lvlValor2";
            lvlValor2.Size = new Size(55, 20);
            lvlValor2.TabIndex = 2;
            lvlValor2.Text = "Valor 2";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(51, 92);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(125, 27);
            txtValor1.TabIndex = 3;
            txtValor1.TextChanged += txtValor2_TextChanged;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(201, 92);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(125, 27);
            txtValor2.TabIndex = 4;
            // 
            // lvlResultado
            // 
            lvlResultado.BackColor = SystemColors.ControlLightLight;
            lvlResultado.Location = new Point(51, 145);
            lvlResultado.Name = "lvlResultado";
            lvlResultado.Size = new Size(275, 20);
            lvlResultado.TabIndex = 5;
            lvlResultado.Text = "Resultado";
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(138, 39);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(94, 29);
            btnRestar.TabIndex = 6;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(28, 86);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(94, 29);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // gbxOperaciones
            // 
            gbxOperaciones.Controls.Add(btnCalcularReslt);
            gbxOperaciones.Controls.Add(btnMultiplicar);
            gbxOperaciones.Controls.Add(btnRestar);
            gbxOperaciones.Location = new Point(363, 54);
            gbxOperaciones.Name = "gbxOperaciones";
            gbxOperaciones.Size = new Size(276, 135);
            gbxOperaciones.TabIndex = 8;
            gbxOperaciones.TabStop = false;
            gbxOperaciones.Text = "Operaciones";
            gbxOperaciones.Enter += groupBox1_Enter;
            // 
            // btnCerrarPersona
            // 
            btnCerrarPersona.Location = new Point(545, 210);
            btnCerrarPersona.Name = "btnCerrarPersona";
            btnCerrarPersona.Size = new Size(94, 29);
            btnCerrarPersona.TabIndex = 8;
            btnCerrarPersona.Text = "Cerrar";
            btnCerrarPersona.UseVisualStyleBackColor = true;
            btnCerrarPersona.Click += btnCerrarPersona_Click;
            // 
            // lvlMenu
            // 
            lvlMenu.Location = new Point(445, 210);
            lvlMenu.Name = "lvlMenu";
            lvlMenu.Size = new Size(94, 29);
            lvlMenu.TabIndex = 9;
            lvlMenu.Text = "Ir a menu";
            lvlMenu.UseVisualStyleBackColor = true;
            lvlMenu.Click += lvlMenu_Click;
            // 
            // frmOperaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvlMenu);
            Controls.Add(btnCerrarPersona);
            Controls.Add(gbxOperaciones);
            Controls.Add(lvlResultado);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(lvlValor2);
            Controls.Add(lvlValor1);
            Name = "frmOperaciones";
            Text = "FormularioOperaciones";
            gbxOperaciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularReslt;
        private Label lvlValor1;
        private Label lvlValor2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lvlResultado;
        private Button btnRestar;
        private Button btnMultiplicar;
        private GroupBox gbxOperaciones;
        private Button btnCerrarPersona;
        private Button lvlMenu;
    }
}