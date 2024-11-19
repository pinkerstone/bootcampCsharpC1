namespace CodigoClase_18112024
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
            dgvData = new DataGridView();
            btnListar = new Button();
            btnListarAuth = new Button();
            btnUsing = new Button();
            dgvPedidos = new DataGridView();
            btnListarPedidos = new Button();
            btnListarPedidosObj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(59, 164);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(590, 212);
            dgvData.TabIndex = 0;
            dgvData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(59, 88);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(121, 42);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnListarAuth
            // 
            btnListarAuth.Location = new Point(199, 88);
            btnListarAuth.Name = "btnListarAuth";
            btnListarAuth.Size = new Size(121, 42);
            btnListarAuth.TabIndex = 2;
            btnListarAuth.Text = "Listar (Auth)";
            btnListarAuth.UseVisualStyleBackColor = true;
            btnListarAuth.Click += btnListarAuth_Click;
            // 
            // btnUsing
            // 
            btnUsing.Location = new Point(340, 88);
            btnUsing.Name = "btnUsing";
            btnUsing.Size = new Size(121, 42);
            btnUsing.TabIndex = 3;
            btnUsing.Text = "Listar (using)";
            btnUsing.UseVisualStyleBackColor = true;
            btnUsing.Click += btnUsing_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(59, 446);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(590, 212);
            dgvPedidos.TabIndex = 4;
            // 
            // btnListarPedidos
            // 
            btnListarPedidos.Location = new Point(59, 398);
            btnListarPedidos.Name = "btnListarPedidos";
            btnListarPedidos.Size = new Size(121, 42);
            btnListarPedidos.TabIndex = 5;
            btnListarPedidos.Text = "Listar Pedidos";
            btnListarPedidos.UseVisualStyleBackColor = true;
            btnListarPedidos.Click += button1_Click;
            // 
            // btnListarPedidosObj
            // 
            btnListarPedidosObj.Location = new Point(199, 398);
            btnListarPedidosObj.Name = "btnListarPedidosObj";
            btnListarPedidosObj.Size = new Size(152, 42);
            btnListarPedidosObj.TabIndex = 6;
            btnListarPedidosObj.Text = "Listar Pedidos (Obj)";
            btnListarPedidosObj.UseVisualStyleBackColor = true;
            btnListarPedidosObj.Click += btnListarPedidosObj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 679);
            Controls.Add(btnListarPedidosObj);
            Controls.Add(btnListarPedidos);
            Controls.Add(dgvPedidos);
            Controls.Add(btnUsing);
            Controls.Add(btnListarAuth);
            Controls.Add(btnListar);
            Controls.Add(dgvData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private Button btnListar;
        private Button btnListarAuth;
        private Button btnUsing;
        private DataGridView dgvPedidos;
        private Button btnListarPedidos;
        private Button btnListarPedidosObj;
    }
}
