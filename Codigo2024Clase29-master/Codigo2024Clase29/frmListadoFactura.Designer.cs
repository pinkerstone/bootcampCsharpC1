namespace Codigo2024Clase29
{
    partial class frmListadoFactura
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
            dgvFacturas = new DataGridView();
            btnBuscarFacturas = new Button();
            label1 = new Label();
            txtNombreCliente = new TextBox();
            dgvDetalle = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            IdCabecera = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(22, 78);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.ReadOnly = true;
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.Size = new Size(635, 188);
            dgvFacturas.TabIndex = 0;
            dgvFacturas.MouseDoubleClick += dgvFacturas_MouseDoubleClick;
            // 
            // btnBuscarFacturas
            // 
            btnBuscarFacturas.Location = new Point(563, 20);
            btnBuscarFacturas.Name = "btnBuscarFacturas";
            btnBuscarFacturas.Size = new Size(94, 29);
            btnBuscarFacturas.TabIndex = 1;
            btnBuscarFacturas.Text = "Buscar";
            btnBuscarFacturas.UseVisualStyleBackColor = true;
            btnBuscarFacturas.Click += btnBuscarFacturas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(92, 26);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(335, 27);
            txtNombreCliente.TabIndex = 3;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { Id, Producto, Cantidad, Precio, IdCabecera });
            dgvDetalle.Location = new Point(22, 288);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new Size(635, 289);
            dgvDetalle.TabIndex = 4;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdDetalle";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Producto
            // 
            Producto.DataPropertyName = "Cantidad";
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // IdCabecera
            // 
            IdCabecera.DataPropertyName = "IdCabecera";
            IdCabecera.HeaderText = "Id Cabecera";
            IdCabecera.MinimumWidth = 6;
            IdCabecera.Name = "IdCabecera";
            IdCabecera.ReadOnly = true;
            IdCabecera.Visible = false;
            IdCabecera.Width = 125;
            // 
            // frmListadoFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 613);
            Controls.Add(dgvDetalle);
            Controls.Add(txtNombreCliente);
            Controls.Add(label1);
            Controls.Add(btnBuscarFacturas);
            Controls.Add(dgvFacturas);
            Name = "frmListadoFactura";
            Text = "frmListadoFactura";
            Load += frmListadoFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFacturas;
        private Button btnBuscarFacturas;
        private Label label1;
        private TextBox txtNombreCliente;
        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn IdCabecera;
    }
}