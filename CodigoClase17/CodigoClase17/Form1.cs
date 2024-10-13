namespace CodigoClase17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evento Load Form1");
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del botón");
        }
    }
}
