using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class UserControl1 : UserControl
    {
        Procedimientos proc = new Procedimientos();

        public UserControl1()
        {
            InitializeComponent();
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Obtener el siguiente número de informe desde la base de datos
            int siguienteNumeroInforme = proc.ObtenerSiguienteNumeroInforme();

            // Asignar el número de informe al TextBox
            nroRegistro.Text = siguienteNumeroInforme.ToString();

            // Deshabilitar la edición del TextBox
            nroRegistro.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void AbrirModalArticulos_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la ventana emergente
            Seleccionador_deArticulos ventanaEmergente = new Seleccionador_deArticulos();

            // Configurar propiedades de la ventana emergente (tamaño, título, etc.)
            ventanaEmergente.Size = new Size(900, 1200);
            ventanaEmergente.Text = "Seleccionador de Artículos";

            // Obtener el siguiente número de informe
            int siguienteNumeroInforme = proc.ObtenerSiguienteNumeroInforme();

            // Crear una tabla vacía para los artículos vendidos
            DataTable articulosVendidosTable = new DataTable();

            // Pasar la tabla de artículos vendidos al formulario Seleccionador_deArticulos
            ventanaEmergente.ArticulosVendidosTable = articulosVendidosTable;

            // Mostrar la ventana emergente
            ventanaEmergente.ShowDialog();
        }
    }
}
