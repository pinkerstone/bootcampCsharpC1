namespace Clase1WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evento load");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Click de botón");
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
