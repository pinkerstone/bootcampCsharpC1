namespace CodigoClase_18112024
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            btnBuscar = new Button();
            btnBuscarSDT = new Button();
            label3 = new Label();
            txtPais = new TextBox();
            btnBuscarDAO = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 188);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 67);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 67);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Cargo";
            label2.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(181, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(367, 60);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(181, 27);
            txtCargo.TabIndex = 2;
            txtCargo.TextChanged += textBox2_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(611, 129);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(123, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnBuscarSDT
            // 
            btnBuscarSDT.Location = new Point(611, 75);
            btnBuscarSDT.Name = "btnBuscarSDT";
            btnBuscarSDT.Size = new Size(123, 30);
            btnBuscarSDT.TabIndex = 4;
            btnBuscarSDT.Text = "BuscarSDT";
            btnBuscarSDT.UseVisualStyleBackColor = true;
            btnBuscarSDT.Click += btnBuscarSDT_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 116);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 5;
            label3.Text = "País";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(95, 109);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(181, 27);
            txtPais.TabIndex = 6;
            // 
            // btnBuscarDAO
            // 
            btnBuscarDAO.Location = new Point(611, 25);
            btnBuscarDAO.Name = "btnBuscarDAO";
            btnBuscarDAO.Size = new Size(123, 30);
            btnBuscarDAO.TabIndex = 7;
            btnBuscarDAO.Text = "BuscarDAO";
            btnBuscarDAO.UseVisualStyleBackColor = true;
            btnBuscarDAO.Click += btnBuscarDAO_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarDAO);
            Controls.Add(txtPais);
            Controls.Add(label3);
            Controls.Add(btnBuscarSDT);
            Controls.Add(btnBuscar);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private Button btnBuscar;
        private Button btnBuscarSDT;
        private Label label3;
        private TextBox txtPais;
        private Button btnBuscarDAO;
    }
}