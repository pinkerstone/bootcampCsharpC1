namespace CodigoClase17Reto1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPersonas = new DataGridView();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            btnMostarDatos = new Button();
            btnAgregar = new Button();
            lblNombres = new Label();
            lblApellidos = new Label();
            lblFechaNacimiento = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            dpFechaNacimiento = new DateTimePicker();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { Nombres, Apellidos, FechaNacimiento });
            dgvPersonas.Location = new Point(26, 290);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(613, 255);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.CellContentClick += dgvPersonas_CellContentClick;
            // 
            // Nombres
            // 
            Nombres.DataPropertyName = "Nombres";
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            Nombres.Width = 125;
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "Apellidos";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 125;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.DataPropertyName = "FechaNacimiento";
            FechaNacimiento.HeaderText = "Fecha Nacimiento";
            FechaNacimiento.MinimumWidth = 6;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Width = 125;
            // 
            // btnMostarDatos
            // 
            btnMostarDatos.Location = new Point(454, 211);
            btnMostarDatos.Name = "btnMostarDatos";
            btnMostarDatos.Size = new Size(185, 55);
            btnMostarDatos.TabIndex = 1;
            btnMostarDatos.Text = "Mostrar";
            btnMostarDatos.UseVisualStyleBackColor = true;
            btnMostarDatos.Click += btnMostarDatos_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(252, 211);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(185, 55);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(98, 55);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 3;
            lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(98, 104);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(72, 20);
            lblApellidos.TabIndex = 4;
            lblApellidos.Text = "Apellidos";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(98, 159);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(149, 20);
            lblFechaNacimiento.TabIndex = 5;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(197, 48);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(217, 27);
            txtNombres.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(197, 97);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(217, 27);
            txtApellidos.TabIndex = 7;
            // 
            // dpFechaNacimiento
            // 
            dpFechaNacimiento.Location = new Point(269, 152);
            dpFechaNacimiento.Name = "dpFechaNacimiento";
            dpFechaNacimiento.Size = new Size(275, 27);
            dpFechaNacimiento.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(47, 211);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(185, 55);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 672);
            Controls.Add(btnEliminar);
            Controls.Add(dpFechaNacimiento);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombres);
            Controls.Add(btnAgregar);
            Controls.Add(btnMostarDatos);
            Controls.Add(dgvPersonas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonas;
        private Button btnMostarDatos;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private Button btnAgregar;
        private Label lblNombres;
        private Label lblApellidos;
        private Label lblFechaNacimiento;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private DateTimePicker dpFechaNacimiento;
        private Button btnEliminar;
    }
}
