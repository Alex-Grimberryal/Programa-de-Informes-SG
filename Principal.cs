using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            // Suscribir los eventos Click de los botones
            btnVerInformes.Click += BtnVerInformes_Click;
            btnNuevoInforme.Click += BtnNuevoInforme_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVerInformes_Click(object? sender, EventArgs e)
        {
            // Lógica para actualizar el panel al ver informes
            actividad.Text = "Mostrando informes...";
            // Otras actualizaciones necesarias
        }

        private void BtnNuevoInforme_Click(object? sender, EventArgs e)
        {
            // Lógica para actualizar el panel al crear nuevos informes
            actividad.Text = "Creando nuevo informe...";
            // Otras actualizaciones necesarias
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoInforme_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
