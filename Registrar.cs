using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLogin
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter usuario = new StreamWriter(txtUsuario.Text + ".txt");
                usuario.WriteLine(txtContraseña.Text);
                usuario.Close();
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
                {
                    MessageBox.Show("Casillas de texto vacias....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se ha registrado el usuario correctamente", "Usuario Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception x)
            {

                MessageBox.Show("Se ha producido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
