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
    public partial class Nomina : Form
    {
        double salBas;
        int Ant;
        int HExtr;
        double Cuo;
        double salarioBru;
        double AntS;
        int fecha;
        int n;
        int a = 0;
        public Nomina()
        {
            InitializeComponent();
            Desactivar();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Activar();

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Comprobacion();
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Debe Ingresar Almenos el Salario", "Salario no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                salBas = Convert.ToDouble(txtSalario.Text);
                CalculandoSalarioBruto obj = new CalculandoSalarioBruto(salBas, Ant, HExtr, salarioBru);
                double horas = obj.CalculandoHoras();
                double antiduedad = obj.CalculandoAntiguedad();
                double salBru = obj.CalculandoSalarioBrut();
                CalculandoTotalDeducciones obj2 = new CalculandoTotalDeducciones(salBas, Cuo, AntS, salBru);
                CalculandoOtros obj3 = new CalculandoOtros(salBru);

                //Creando Vector
                double inss1 = obj2.calculandoInss();
                double cuota = obj2.calculandoCuota();
                double ir = obj2.calculandoIr(cmbFecha.Text);
                double deducciones = obj2.calculandoTotal(inss1, AntS, cuota, ir);
                double salNeto = salBru - deducciones;


                double[] vector = { salBas, horas, antiduedad, Math.Round(salBru, 4), inss1, obj2.calculandoIr(cmbFecha.Text), cuota, AntS, deducciones, salNeto, obj3.CalculandoInatec(), obj3.CalculandoInssPatronal(), obj3.CalculandoVacacciones(cmbFecha.Text), obj3.CalculandoVacacciones(cmbFecha.Text), obj3.CalculandoVacacciones(cmbFecha.Text) };

                //Ingresado en listview
                ListViewItem listViewItem = new ListViewItem(txtNombre1.Text);
                foreach (double item in vector)
                {
                    listViewItem.SubItems.Add(item.ToString());
                }
                lvNomina.Items.Add(listViewItem);

                //Ingresando en el .txt

                System.IO.StreamWriter ArchivoNomina = new StreamWriter("Nomina.txt", true);
                if (n != 1)
                {
                    DateTime f;
                    f = DateTime.Now;
                    ArchivoNomina.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    ArchivoNomina.WriteLine((f).ToString());
                    ArchivoNomina.WriteLine("Nombre del Empleado    |Salario Básico    |Horas Extras    |Antigüedad    |Salario Bruto    |INNS Laboral    |IR        |Cuota Sindical    |Anticipo de Salario    |Total Deducciones    |Salario Neto    |INATEC        |INSS Patronal        |Vacaciones    |Aguinaldo    |Indemnización    |");
                }
                ArchivoNomina.Write(txtNombre1.Text + "           |");
                foreach (double item in vector)
                {
                    ArchivoNomina.Write(item.ToString() + "          |");
                }
                ArchivoNomina.WriteLine();
                ArchivoNomina.Close();
                n = 1;


            }



            Desactivar();
        }










        //___--_-_-ACTIVANDO Y DESACTIVANDO BOTONES-_-_--___\\
        private void btnActCuo_Click(object sender, EventArgs e)
        {
            if (rdSiCuo.Checked == true)
            {
                txtCuota.Enabled = true;

            }
            else
            {
                txtCuota.Enabled = false;
            }
        }
        private void Desactivar()
        {
            txtAntiguedad.Enabled = false;
            txtCuota.Enabled = false;
            txtHorasEx.Enabled = false;
            txtSalario.Enabled = false;
            cmbFecha.Enabled = false;
            rdSiHE.Enabled = false;
            rdNoHE.Enabled = false;
            btnIngresar.Enabled = false;
            btnActCuo.Enabled = false;
            btnActHoras.Enabled = false;
            button1.Enabled = false;
            rdSiCuo.Enabled = false;
            rdSiAntg.Enabled = false;
            rdNoAntg.Enabled = false;
            rdSiHE.Enabled = false;
            rdNoHE.Enabled = false;
            rdNoCuo.Enabled = false;
            btnAgregar.Enabled = true;
            txtAntSal.Enabled = false;
            txtNombre1.Enabled = false;
            rdAntSalNo.Enabled = false;
            rdAntSalSi.Enabled = false;
            btnActAntSal.Enabled = false;
            btnActualizarFecha.Enabled = false;
        }
        private void btnActHoras_Click(object sender, EventArgs e)
        {
            if (rdSiHE.Checked == true)
            {
                txtHorasEx.Enabled = true;

            }
            else
            {
                txtHorasEx.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdSiAntg.Checked == true)
            {
                txtAntiguedad.Enabled = true;

            }
            else
            {
                txtAntiguedad.Enabled = false;
            }
        }
        private void Activar()
        {
            txtSalario.Enabled = true;
            btnActCuo.Enabled = true;
            btnActHoras.Enabled = true;
            button1.Enabled = true;
            rdSiHE.Enabled = true;
            rdNoHE.Enabled = true;
            rdNoCuo.Enabled = true;
            rdSiCuo.Enabled = true;
            rdSiAntg.Enabled = true;
            rdNoAntg.Enabled = true;
            txtNombre1.Enabled = true;
            btnActAntSal.Enabled = true;
            rdAntSalSi.Enabled = true;
            rdAntSalNo.Enabled = true;
            btnAgregar.Enabled = false;
            btnIngresar.Enabled = true;
        }

        private void btnActAntSal_Click(object sender, EventArgs e)
        {
            if (rdAntSalSi.Checked == true)
            {
                txtAntSal.Enabled = true;

            }
            else
            {
                txtAntSal.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal nomina = new Principal();
            this.Hide();
            nomina.ShowDialog();
            this.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process VerArchivo = new System.Diagnostics.Process();
            VerArchivo.StartInfo.FileName = "notepad.exe";
            VerArchivo.StartInfo.Arguments = "Nomina.txt";
            VerArchivo.Start();


        }

        private void btnActualizarFecha_Click(object sender, EventArgs e)
        {
            btnActualizarFecha.Enabled = false;
            cmbFecha.Enabled = false;
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            cmbFecha.Enabled = true;
            btnActualizarFecha.Enabled = true;
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Al colocar el salario solo sera valido NUMEROS o '.' al escribir", "Solo numeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtHorasEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Al colocar las Horas solo sera valido NUMEROS ENTEROS", "Solo numeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtAntiguedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Al colocar la Antigueda solo sera valido NUMEROS ENTEROS", "Solo numeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Al colocar la Cuota Sindical solo sera valido NUMEROS ENTEROS", "Solo numeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtAntSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Al colocar el Anticipo de Salario solo sera valido NUMEROS o '.' al escribir", "Solo numeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
        private void Comprobacion()
        {
            if (string.IsNullOrEmpty(txtHorasEx.Text))
            {
                HExtr = 0;
            }
            else
            {
                HExtr = (int)Convert.ToDouble(txtHorasEx.Text);
            }
            if (string.IsNullOrEmpty(txtAntSal.Text))
            {
                Ant = 0;
            }
            else
            {
                Ant = (int)Convert.ToDouble(txtAntiguedad.Text);
            }
            if (string.IsNullOrEmpty(txtCuota.Text))
            {
                Cuo = 0;
            }
            else
            {
                Cuo = (int)Convert.ToDouble(txtCuota.Text);
            }
            if (string.IsNullOrEmpty(txtAntSal.Text))
            {
                AntS = 0;
            }
            else
            {
                AntS = (int)Convert.ToDouble(txtAntSal.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desactivar();
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
