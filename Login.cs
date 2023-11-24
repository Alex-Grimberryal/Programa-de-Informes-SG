using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class Login : Form
    {
        Procedimientos proc = new Procedimientos(); 
        Principal Principal;

        public Login()
        {
            InitializeComponent();
            Principal = new Principal();
            this.txtPassword.UseSystemPasswordChar = true;
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin();
                e.Handled = true; // Evita que se produzca el sonido de Windows al presionar Enter
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin();
                e.Handled = true; // Evita que se produzca el sonido de Windows al presionar Enter
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void PerformLogin()
        {
            int result = proc.Login(txtUser.Text, txtPassword.Text);

            if (result == 1)
            {
                string role = proc.ObtenerRol(txtUser.Text); // Obtener el rol del usuario
                int userId = proc.ObtenerIdUsuario(txtUser.Text, txtPassword.Text); // Obtener el ID del usuario
                Principal menu = new Principal(role, userId); // Pasar el rol y el ID como parámetros
                this.Hide();
                menu.ShowDialog();
            }
            else if (result == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}