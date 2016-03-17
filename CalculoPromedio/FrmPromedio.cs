using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoPromedio
{
    public partial class FrmPromedio : Form
    {
        public FrmPromedio()
        {
            InitializeComponent();
        }

        private void FrmPromedio_Load(object sender, EventArgs e)
        {
            llenarCursos();
        }

        private void llenarCursos()
        {
            cboCurso.Items.Add("Programacion orientada a objetos");
            cboCurso.Items.Add("Lenguaje de Programacion I");
            cboCurso.Items.Add("Analisis de sistemas I");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a la clase Promedio
                Promedio promedio = new Promedio();

                //Enviamos informacion de los atributos(set)
                promedio.alumno = txtAlumno.Text;
                promedio.curso = cboCurso.Text;
                promedio.LC1 = int.Parse(txtLC1.Text);
                promedio.LC2 = int.Parse(txtLC2.Text);
                promedio.LC3 = int.Parse(txtLC3.Text);
                promedio.LC4 = int.Parse(txtLC4.Text);
                promedio.LP = int.Parse(txtLP.Text);
                promedio.NA = int.Parse(txtNA.Text);
                promedio.EF = int.Parse(txtEF.Text);

                lstR.Items.Clear();
                lstR.Items.Add("**RESUMEN DE PROMEDIOS**");
                lstR.Items.Add("ALUMNO: " + promedio.alumno);
                lstR.Items.Add("CURSO: " + promedio.curso);
                lstR.Items.Add("------------------------------------------------");
                lstR.Items.Add("PROMEDIO: " + promedio.calculaPromedio().ToString("0.00"));
                lstR.Items.Add("CONDICION: " + promedio.determinarCondicion());
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la aplicación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (r ==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumno.Text = "";
            cboCurso.SelectedIndex = -1;
            txtLC1.Text = "";
            txtLC2.Text = "";
            txtLC3.Text = "";
            txtLC4.Text = "";
            txtLP.Text = "";
            txtNA.Text = "";
            txtEF.Text = "";
            lstR.Items.Clear();
            txtAlumno.Focus();
        }
    }
}
