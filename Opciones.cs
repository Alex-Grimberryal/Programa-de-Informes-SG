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
    public partial class Opciones : UserControl
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            opciones.articulos articulos = new opciones.articulos();
            articulos.Dock = DockStyle.Fill;

            panel1.Controls.Add(articulos);
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyC_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            opciones.MyC myC = new opciones.MyC();
            myC.Dock = DockStyle.Fill;

            panel1.Controls.Add(myC);
            panel1.Refresh();
        }

        private void tec_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            opciones.tecnicos tecnicos = new opciones.tecnicos();
            tecnicos.Dock = DockStyle.Fill;

            panel1.Controls.Add(tecnicos);
            panel1.Refresh();
        }

        private void usuarios_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            opciones.usuarios usuarios = new opciones.usuarios();
            usuarios.Dock = DockStyle.Fill;

            panel1.Controls.Add(usuarios);
            panel1.Refresh();
        }
    }
}
