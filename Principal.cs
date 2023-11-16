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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nomina nomina = new Nomina();
            this.Hide();
            nomina.ShowDialog();
            this.Close();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quiere salir del programa?", "Salir del Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborado por:\n-Gustavo Adolfo Estrada Mayorga\n-Bismarck Andres Conde Torres\n-Eliab Antonio Maltez TorreZ", "Integrantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
