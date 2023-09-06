namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class Login : Form
    {
        Principal Principal;

        public Login()
        {
            InitializeComponent();
            Principal = new Principal();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Principal.ShowDialog();
        }
    }
}