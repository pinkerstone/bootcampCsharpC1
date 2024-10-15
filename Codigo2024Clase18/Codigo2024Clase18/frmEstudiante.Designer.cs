﻿namespace Codigo2024Clase18
{
    partial class frmEstudiante
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnContar = new Button();
            btnEliminarBinding = new Button();
            btnAgregarBinding = new Button();
            btnBinding = new Button();
            btnListar = new Button();
            btnAgregar = new Button();
            chkBecado = new CheckBox();
            dtpFechaMatricula = new DateTimePicker();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvEstudiantes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            FechaMatricula = new DataGridViewTextBoxColumn();
            EsBecado = new DataGridViewCheckBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            btnIniciar = new Button();
            btnDetener = new Button();
            LBLHORA = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnContar);
            groupBox1.Controls.Add(btnEliminarBinding);
            groupBox1.Controls.Add(btnAgregarBinding);
            groupBox1.Controls.Add(btnBinding);
            groupBox1.Controls.Add(btnListar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(chkBecado);
            groupBox1.Controls.Add(dtpFechaMatricula);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(51, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Estudiante";
            // 
            // btnContar
            // 
            btnContar.BackColor = Color.CadetBlue;
            btnContar.Location = new Point(675, 205);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(94, 37);
            btnContar.TabIndex = 12;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = false;
            btnContar.Click += btnContar_Click;
            // 
            // btnEliminarBinding
            // 
            btnEliminarBinding.BackColor = Color.CadetBlue;
            btnEliminarBinding.Location = new Point(675, 248);
            btnEliminarBinding.Name = "btnEliminarBinding";
            btnEliminarBinding.Size = new Size(94, 37);
            btnEliminarBinding.TabIndex = 11;
            btnEliminarBinding.Text = "Eliminar";
            btnEliminarBinding.UseVisualStyleBackColor = false;
            btnEliminarBinding.Click += btnEliminarBinding_Click;
            // 
            // btnAgregarBinding
            // 
            btnAgregarBinding.BackColor = Color.CadetBlue;
            btnAgregarBinding.Location = new Point(575, 248);
            btnAgregarBinding.Name = "btnAgregarBinding";
            btnAgregarBinding.Size = new Size(94, 37);
            btnAgregarBinding.TabIndex = 10;
            btnAgregarBinding.Text = "Agregar";
            btnAgregarBinding.UseVisualStyleBackColor = false;
            btnAgregarBinding.Click += btnAgregarBinding_Click;
            // 
            // btnBinding
            // 
            btnBinding.BackColor = Color.CadetBlue;
            btnBinding.Location = new Point(475, 248);
            btnBinding.Name = "btnBinding";
            btnBinding.Size = new Size(94, 37);
            btnBinding.TabIndex = 9;
            btnBinding.Text = "Binding";
            btnBinding.UseVisualStyleBackColor = false;
            btnBinding.Click += btnBinding_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.DodgerBlue;
            btnListar.Location = new Point(164, 248);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(94, 37);
            btnListar.TabIndex = 8;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DodgerBlue;
            btnAgregar.Location = new Point(53, 248);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 37);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // chkBecado
            // 
            chkBecado.AutoSize = true;
            chkBecado.Location = new Point(250, 207);
            chkBecado.Name = "chkBecado";
            chkBecado.Size = new Size(97, 24);
            chkBecado.TabIndex = 6;
            chkBecado.Text = "EsBecado";
            chkBecado.UseVisualStyleBackColor = true;
            // 
            // dtpFechaMatricula
            // 
            dtpFechaMatricula.Location = new Point(250, 155);
            dtpFechaMatricula.Name = "dtpFechaMatricula";
            dtpFechaMatricula.Size = new Size(396, 27);
            dtpFechaMatricula.TabIndex = 5;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(254, 108);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(392, 27);
            txtApellidos.TabIndex = 4;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(254, 64);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(392, 27);
            txtNombres.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 154);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha Matrícula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 108);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 61);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Nombres";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(dgvEstudiantes);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(59, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(778, 266);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de Estudiantes";
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { Id, Nombres, Apellidos, FechaMatricula, EsBecado });
            dgvEstudiantes.Location = new Point(6, 52);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.Size = new Size(751, 188);
            dgvEstudiantes.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "EstudianteID";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Nombres
            // 
            Nombres.DataPropertyName = "Nombres";
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            Nombres.Width = 200;
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "Apellidos";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 200;
            // 
            // FechaMatricula
            // 
            FechaMatricula.DataPropertyName = "FechaMatricula";
            FechaMatricula.HeaderText = "FechaMatricula";
            FechaMatricula.MinimumWidth = 6;
            FechaMatricula.Name = "FechaMatricula";
            FechaMatricula.Width = 140;
            // 
            // EsBecado
            // 
            EsBecado.DataPropertyName = "EsBecado";
            EsBecado.HeaderText = "EsBecado";
            EsBecado.MinimumWidth = 6;
            EsBecado.Name = "EsBecado";
            EsBecado.Width = 125;
            // 
            // timer1
            // 
            timer1.Interval = 7000;
            timer1.Tick += timer1_Tick;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Salmon;
            btnIniciar.Location = new Point(301, 676);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 37);
            btnIniciar.TabIndex = 13;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.Salmon;
            btnDetener.Location = new Point(416, 676);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 37);
            btnDetener.TabIndex = 14;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // LBLHORA
            // 
            LBLHORA.AutoSize = true;
            LBLHORA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LBLHORA.Location = new Point(51, 9);
            LBLHORA.Name = "LBLHORA";
            LBLHORA.Size = new Size(51, 20);
            LBLHORA.TabIndex = 15;
            LBLHORA.Text = "label4";
            // 
            // timerHora
            // 
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // frmEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 713);
            Controls.Add(LBLHORA);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmEstudiante";
            Text = "frmEstudiante";
            Load += frmEstudiante_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnListar;
        private Button btnAgregar;
        private CheckBox chkBecado;
        private DateTimePicker dtpFechaMatricula;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private GroupBox groupBox2;
        private DataGridView dgvEstudiantes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn FechaMatricula;
        private DataGridViewCheckBoxColumn EsBecado;
        private Button btnBinding;
        private Button btnEliminarBinding;
        private Button btnAgregarBinding;
        private Button btnContar;
        private System.Windows.Forms.Timer timer1;
        private Button btnIniciar;
        private Button btnDetener;
        private Label LBLHORA;
        private System.Windows.Forms.Timer timerHora;
    }
}