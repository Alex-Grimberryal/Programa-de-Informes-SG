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
        public string role;
        public int idUser;

#pragma warning disable CS0169 // El campo 'Principal.userControl2' nunca se usa
        private UserControl2 userControl2;
#pragma warning restore CS0169 // El campo 'Principal.userControl2' nunca se usa
        private readonly EventHandler UserControl2_Load;

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public Principal(string role, int userId)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            this.role = role;
            idUser = userId;

            InitializeComponent();
            // Suscribir los eventos Click de los botones
            btnVerInformes.Click += BtnVerInformes_Click;
            btnNuevoInforme.Click += BtnNuevoInforme_Click;
#pragma warning disable CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
            opciones.Click += opciones_Click;
#pragma warning restore CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).

        }

        public Principal()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVerInformes_Click(object? sender, EventArgs e)
        {
            // Lógica para actualizar el panel al crear nuevos informes
            actividad.Controls.Clear(); // Limpia cualquier control existente en el panel

            UserControl2 userControl2 = new UserControl2();
            userControl2.Dock = DockStyle.Fill; // Ajusta el relleno del UserControl al tamaño del panel

            actividad.Controls.Add(userControl2); // Agrega el UserControl al panel
            actividad.Refresh(); // Actualiza el panel si es necesario

            userControl2.Load += UserControl2_Load; // Suscribe al evento Load del UserControl2

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
            // Lógica para actualizar el panel al crear nuevos informes
            actividad.Controls.Clear(); // Limpia cualquier control existente en el panel

            UserControl1 nuevoInforme = new UserControl1(idUser);
            nuevoInforme.Dock = DockStyle.Fill; // Ajusta el relleno del UserControl al tamaño del panel

            actividad.Controls.Add(nuevoInforme); // Agrega el UserControl al panel
            actividad.Refresh(); // Actualiza el panel si es necesario

            // Otras actualizaciones necesarias
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

        private void actividad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void opciones_Click(object sender, EventArgs e)
        {
            try
            {
                actividad.Controls.Clear(); // Limpia cualquier control existente en el panel

                if (role == "Administrador")
                {
                    Opciones opciones = new Opciones();
                    opciones.Dock = DockStyle.Fill; // Ajusta el relleno del User

                    actividad.Controls.Add(opciones); // Agrega el UserControl al panel
                    actividad.Refresh(); // Actualiza el panel si es necesario
                }
                else
                {
                    MessageBox.Show("No tienes permisos de Administrador para realizar esta acción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
