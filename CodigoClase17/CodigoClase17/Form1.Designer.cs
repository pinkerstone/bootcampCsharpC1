namespace CodigoClase17
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
            btnPrueba = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnPrueba
            // 
            btnPrueba.BackColor = Color.Cyan;
            btnPrueba.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrueba.ForeColor = Color.Black;
            btnPrueba.Location = new Point(65, 40);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(115, 55);
            btnPrueba.TabIndex = 0;
            btnPrueba.Text = "Haz Click aquí";
            btnPrueba.UseVisualStyleBackColor = false;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 61);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(359, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnPrueba);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrueba;
        private Label label1;
        private TextBox textBox1;
    }
}
