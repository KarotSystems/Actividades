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
            Usuario Usuario = new Usuario();
            Usuario.Show();
        }

        private void Lector_Click(object sender, EventArgs e)
        {
            Usuario Usuario = new Usuario();
            Usuario.Show();
        }
    }
}
