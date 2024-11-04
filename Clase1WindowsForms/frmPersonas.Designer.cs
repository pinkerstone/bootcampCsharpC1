namespace Clase1WindowsForms
{
    partial class frmPersonas
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
            gpxDatosPersonales = new GroupBox();
            txtSueldo = new TextBox();
            lvlSueldo = new Label();
            btnCalcular = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            txtNombresApellidos = new TextBox();
            cmbTipoDocumento = new ComboBox();
            lvlNombresApellidos = new Label();
            lvlFechaNacimiento = new Label();
            lvlTipoDocumento = new Label();
            gpbResultados = new GroupBox();
            lvlImpuestoRslt = new Label();
            lvlMayorEdadRslt = new Label();
            lvlImpuestoRenta = new Label();
            lvlMayorEdad = new Label();
            btnCerrarPersonas = new Button();
            gpxDatosPersonales.SuspendLayout();
            gpbResultados.SuspendLayout();
            SuspendLayout();
            // 
            // gpxDatosPersonales
            // 
            gpxDatosPersonales.BackColor = Color.FromArgb(255, 224, 192);
            gpxDatosPersonales.Controls.Add(txtSueldo);
            gpxDatosPersonales.Controls.Add(lvlSueldo);
            gpxDatosPersonales.Controls.Add(btnCalcular);
            gpxDatosPersonales.Controls.Add(dtpFechaNacimiento);
            gpxDatosPersonales.Controls.Add(txtNombresApellidos);
            gpxDatosPersonales.Controls.Add(cmbTipoDocumento);
            gpxDatosPersonales.Controls.Add(lvlNombresApellidos);
            gpxDatosPersonales.Controls.Add(lvlFechaNacimiento);
            gpxDatosPersonales.Controls.Add(lvlTipoDocumento);
            gpxDatosPersonales.Location = new Point(35, 25);
            gpxDatosPersonales.Name = "gpxDatosPersonales";
            gpxDatosPersonales.Size = new Size(516, 267);
            gpxDatosPersonales.TabIndex = 0;
            gpxDatosPersonales.TabStop = false;
            gpxDatosPersonales.Text = "Datos Personales";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(210, 185);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(143, 27);
            txtSueldo.TabIndex = 8;
            // 
            // lvlSueldo
            // 
            lvlSueldo.AutoSize = true;
            lvlSueldo.Location = new Point(39, 188);
            lvlSueldo.Name = "lvlSueldo";
            lvlSueldo.Size = new Size(55, 20);
            lvlSueldo.TabIndex = 7;
            lvlSueldo.Text = "Sueldo";
            lvlSueldo.Click += label1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(384, 223);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(210, 134);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(143, 27);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // txtNombresApellidos
            // 
            txtNombresApellidos.Location = new Point(210, 90);
            txtNombresApellidos.Name = "txtNombresApellidos";
            txtNombresApellidos.Size = new Size(268, 27);
            txtNombresApellidos.TabIndex = 1;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Items.AddRange(new object[] { "DNI", "RUC" });
            cmbTipoDocumento.Location = new Point(210, 45);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(81, 28);
            cmbTipoDocumento.TabIndex = 4;
            // 
            // lvlNombresApellidos
            // 
            lvlNombresApellidos.AutoSize = true;
            lvlNombresApellidos.Location = new Point(37, 93);
            lvlNombresApellidos.Name = "lvlNombresApellidos";
            lvlNombresApellidos.Size = new Size(148, 20);
            lvlNombresApellidos.TabIndex = 2;
            lvlNombresApellidos.Text = "Nombres y Apellidos";
            // 
            // lvlFechaNacimiento
            // 
            lvlFechaNacimiento.AutoSize = true;
            lvlFechaNacimiento.Location = new Point(39, 139);
            lvlFechaNacimiento.Name = "lvlFechaNacimiento";
            lvlFechaNacimiento.Size = new Size(146, 20);
            lvlFechaNacimiento.TabIndex = 3;
            lvlFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lvlTipoDocumento
            // 
            lvlTipoDocumento.AutoSize = true;
            lvlTipoDocumento.Location = new Point(37, 50);
            lvlTipoDocumento.Name = "lvlTipoDocumento";
            lvlTipoDocumento.Size = new Size(140, 20);
            lvlTipoDocumento.TabIndex = 1;
            lvlTipoDocumento.Text = "Tipo de documento";
            // 
            // gpbResultados
            // 
            gpbResultados.BackColor = Color.FromArgb(192, 255, 255);
            gpbResultados.Controls.Add(lvlImpuestoRslt);
            gpbResultados.Controls.Add(lvlMayorEdadRslt);
            gpbResultados.Controls.Add(lvlImpuestoRenta);
            gpbResultados.Controls.Add(lvlMayorEdad);
            gpbResultados.Location = new Point(35, 298);
            gpbResultados.Name = "gpbResultados";
            gpbResultados.Size = new Size(516, 125);
            gpbResultados.TabIndex = 1;
            gpbResultados.TabStop = false;
            gpbResultados.Text = "Resultados";
            gpbResultados.Enter += gpbResultados_Enter;
            // 
            // lvlImpuestoRslt
            // 
            lvlImpuestoRslt.BackColor = SystemColors.ButtonHighlight;
            lvlImpuestoRslt.Location = new Point(257, 76);
            lvlImpuestoRslt.Name = "lvlImpuestoRslt";
            lvlImpuestoRslt.Size = new Size(137, 20);
            lvlImpuestoRslt.TabIndex = 13;
            // 
            // lvlMayorEdadRslt
            // 
            lvlMayorEdadRslt.BackColor = SystemColors.ButtonHighlight;
            lvlMayorEdadRslt.Location = new Point(39, 76);
            lvlMayorEdadRslt.Name = "lvlMayorEdadRslt";
            lvlMayorEdadRslt.Size = new Size(55, 20);
            lvlMayorEdadRslt.TabIndex = 12;
            // 
            // lvlImpuestoRenta
            // 
            lvlImpuestoRenta.AutoSize = true;
            lvlImpuestoRenta.Location = new Point(257, 39);
            lvlImpuestoRenta.Name = "lvlImpuestoRenta";
            lvlImpuestoRenta.Size = new Size(137, 20);
            lvlImpuestoRenta.TabIndex = 10;
            lvlImpuestoRenta.Text = "Impuesto a la renta";
            // 
            // lvlMayorEdad
            // 
            lvlMayorEdad.AutoSize = true;
            lvlMayorEdad.Location = new Point(37, 39);
            lvlMayorEdad.Name = "lvlMayorEdad";
            lvlMayorEdad.Size = new Size(128, 20);
            lvlMayorEdad.TabIndex = 9;
            lvlMayorEdad.Text = "Es mayor de edad";
            // 
            // btnCerrarPersonas
            // 
            btnCerrarPersonas.Location = new Point(571, 25);
            btnCerrarPersonas.Name = "btnCerrarPersonas";
            btnCerrarPersonas.Size = new Size(94, 29);
            btnCerrarPersonas.TabIndex = 10;
            btnCerrarPersonas.Text = "Cerrar";
            btnCerrarPersonas.UseVisualStyleBackColor = true;
            btnCerrarPersonas.Click += btnCerrarPersonas_Click;
            // 
            // frmPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarPersonas);
            Controls.Add(gpbResultados);
            Controls.Add(gpxDatosPersonales);
            Name = "frmPersonas";
            Text = "frmPersonas";
            Load += frmPersonas_Load;
            gpxDatosPersonales.ResumeLayout(false);
            gpxDatosPersonales.PerformLayout();
            gpbResultados.ResumeLayout(false);
            gpbResultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxDatosPersonales;
        private Label lvlNombresApellidos;
        private Label lvlFechaNacimiento;
        private Label lvlTipoDocumento;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtNombresApellidos;
        private ComboBox cmbTipoDocumento;
        private Button btnCalcular;
        private GroupBox gpbResultados;
        private Label lvlSueldo;
        private TextBox txtSueldo;
        private Label lvlImpuestoRenta;
        private Label lvlMayorEdad;
        private Label lvlImpuestoRslt;
        private Label lvlMayorEdadRslt;
        private Button btnCerrarPersonas;
    }
}