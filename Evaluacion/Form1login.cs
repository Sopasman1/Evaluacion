namespace Evaluacion
{
    public partial class Form1login : Form
    {
        public Form1login()
        {
            InitializeComponent();
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Txtusuario.Clear();
            txtcontrase�a.Clear();
        }

        private void Btningresar_Click(object sender, EventArgs e)
        {
            if(Txtusuario.Text =="usuario" && txtcontrase�a.Text == "contra")
            {
                Forminicio forminicio = new Forminicio();
                this.Hide();
                forminicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingrsados son incorrectos");
                Txtusuario.Clear();
                txtcontrase�a.Clear();
            }
        }
    }
}
