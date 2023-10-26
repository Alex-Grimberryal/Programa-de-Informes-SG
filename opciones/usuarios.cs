using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD.opciones
{
    public partial class usuarios : UserControl
    {

        Procedimientos proc = new Procedimientos();
        public usuarios()
        {
            InitializeComponent();
        }

        private void EdUsuario_Click(object sender, EventArgs e)
        {
            int roles_idrol = 0;
            if (checkBoxAdmin.Checked)
            {
                roles_idrol += 1;
            }
            if (checkBoxOper.Checked)
            {
                roles_idrol += 2;
            }

            string nombre = txtnombre.Text;
            string contrasena = txtContrasena.Text;
            int rol = roles_idrol;
            // Llamar al método de inserción de usuario de la clase usuarios
            proc.ModificarUsuario(nombre, contrasena, roles_idrol);
        }

        private void VistaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void usuarios_Load(object sender, EventArgs e)
        {
            // Llamar al método ObtenerUsuarios de la clase Procedimientos
            DataTable usuariosTable = proc.ObtenerUsuarios();

            // Crear un BindingSource y asignar el DataTable como origen de datos
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = usuariosTable;

            // Asignar los datos al DataGridView
            VistaUser.DataSource = usuariosTable;

            // Configurar las columnas del DataGridView
            VistaUser.Columns["nombre"].HeaderText = "Nombre";
            VistaUser.Columns["contrasena"].HeaderText = "Contraseña";
            VistaUser.Columns["rol"].HeaderText = "Rol";
        }



        private void ElUsuario_Click(object sender, EventArgs e)
        {

        }

        private void InUsusario_Click(object sender, EventArgs e)
        {
            List<int> rolesSeleccionados = new List<int>();

            if (checkBoxAdmin.Checked)
            {
                rolesSeleccionados.Add(1);
            }
            if (checkBoxOper.Checked)
            {
                rolesSeleccionados.Add(2);
            }

            int roles_idrol = rolesSeleccionados.Count > 0 ? rolesSeleccionados.Aggregate((x, y) => x | y) : 0;

            string nombre = txtnombre.Text;
            string contrasena = txtContrasena.Text;
            int rol = roles_idrol;
            // Llamar al método de inserción de usuario de la clase usuarios
            proc.InsertarUsuario(nombre, contrasena, rol);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxOper_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
