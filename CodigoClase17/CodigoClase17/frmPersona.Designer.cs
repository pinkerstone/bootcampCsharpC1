namespace CodigoClase17
{
    partial class frmPersona
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
            txtSueldo = new TextBox();
            label4 = new Label();
            btnCalcular = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            txtNombresApellidos = new TextBox();
            cboTipoDocumento = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            btnCerrar = new Button();
            LBLContador = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtSueldo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(txtNombresApellidos);
            groupBox1.Controls.Add(cboTipoDocumento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(73, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(236, 144);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(242, 27);
            txtSueldo.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 144);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 12;
            label4.Text = "Sueldo";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(245, 280);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(129, 54);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(236, 207);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // txtNombresApellidos
            // 
            txtNombresApellidos.Location = new Point(236, 89);
            txtNombresApellidos.Name = "txtNombresApellidos";
            txtNombresApellidos.Size = new Size(242, 27);
            txtNombresApellidos.TabIndex = 4;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Items.AddRange(new object[] { "DNI", "RUC" });
            cboTipoDocumento.Location = new Point(236, 42);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(242, 28);
            cboTipoDocumento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 207);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 2;
            label3.Text = "FechaNacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 88);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 1;
            label2.Text = "NombresApellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 42);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "TipoDocumento";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(87, 478);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(610, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 49);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 15;
            label6.Text = "Impuesto a la renta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 49);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 14;
            label5.Text = "Es Mayor de edad?";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ActiveCaption;
            btnCerrar.Location = new Point(318, 621);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(129, 54);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // LBLContador
            // 
            LBLContador.AutoSize = true;
            LBLContador.Location = new Point(498, 627);
            LBLContador.Name = "LBLContador";
            LBLContador.Size = new Size(17, 20);
            LBLContador.TabIndex = 13;
            LBLContador.Text = "0";
            // 
            // frmPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 687);
            Controls.Add(LBLContador);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPersona";
            Text = "frmPersona";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNombresApellidos;
        private ComboBox cboTipoDocumento;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtSueldo;
        private Label label4;
        private Button btnCalcular;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Button btnCerrar;
        private Label LBLContador;
    }
}