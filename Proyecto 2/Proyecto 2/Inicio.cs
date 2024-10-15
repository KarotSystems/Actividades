namespace Proyecto_2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Biblioteca_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form bibliotecario = new Form();
            bibliotecario.Show();
        }

        private void Lector_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form lector = new Form();
            lector.Show();
        }
    }
}
