namespace PracticaLogin
{
    public partial class Form1 : Form
    {
        int op = 0;
        public Form1()
        {
            InitializeComponent();
            txtContra.PasswordChar = '*';

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader usuario = new StreamReader(txtUsuario.Text + ".txt");
                if (usuario.ReadLine() == txtContra.Text)
                {
                    MessageBox.Show($"Bienvenido: {txtUsuario.Text}!", "Inicio Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Principal principal = new Principal();
                    this.Hide();
                    principal.ShowDialog();
                    this.Close();
                }
                if (string.IsNullOrEmpty(txtContra.Text) || usuario.ReadLine() != txtContra.Text)
                {
                    MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    op++;
                }
                if (op == 3)
                {
                    MessageBox.Show("Limite de oportunidades alcansado porfavor ejecute el programa e intente nuevamente", "Limite Alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }

            }
            catch (Exception y)
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                op++;
                if (op == 3)
                {
                    MessageBox.Show("Limite de oportunidades alcansado porfavor ejecute el programa e intente nuevamente", "Limite Alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            this.Hide();
            registrar.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }
    }
}