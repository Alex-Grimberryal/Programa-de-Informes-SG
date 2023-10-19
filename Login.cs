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
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result = proc.Login(txtUser.Text, txtPassword.Text);

            if (result == 1)
            {
                Principal menu = new Principal();
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