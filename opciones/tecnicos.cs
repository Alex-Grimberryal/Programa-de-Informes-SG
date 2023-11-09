using Microsoft.Data.SqlClient;
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
    public partial class tecnicos : UserControl
    {
        Procedimientos proc = new Procedimientos();

        public tecnicos()
        {
            InitializeComponent();
        }

        private void tecnicos_Load(object sender, EventArgs e)
        {
            // Llamar al método ObtenerUsuarios de la clase Procedimientos
            DataTable tecnicosTable = proc.ObtenerTecnicos();

            // Crear un BindingSource y asignar el DataTable como origen de datos
            BindingSource bindingSource = new BindingSource();
            VistaTecnicos.DataSource = tecnicosTable;

            // Asignar los datos al DataGridView
            VistaTecnicos.DataSource = tecnicosTable;

            // Configurar las columnas del DataGridView
            VistaTecnicos.Columns["idtecnico"].HeaderText = "ID";
            VistaTecnicos.Columns["dni_tecnico"].HeaderText = "DNI";
            VistaTecnicos.Columns["nombres"].HeaderText = "Nombre";
            VistaTecnicos.Columns["apellido_paterno"].HeaderText = "Apellido Paterno";
            VistaTecnicos.Columns["apellido_materno"].HeaderText = "Apellido Materno";
            VistaTecnicos.Columns["telefono"].HeaderText = "Telefono";

        }

        private void InTecnico_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string nombres = txtnombre.Text;
            string apellidoPaterno = txtAP.Text;
            string apellidoMaterno = txtAM.Text;
            string telefono = txtcelular.Text;

            txtDNI.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtAP.Text = string.Empty;
            txtAM.Text = string.Empty;
            txtcelular.Text = string.Empty;


            proc.InsertarTecnico(DNI, nombres, apellidoPaterno, apellidoMaterno, telefono);
            ActualizarTecnicos();
        }

        private int idTecnico;

        private void ModTecnico_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string nombres = txtnombre.Text;
            string apellidoPaterno = txtAP.Text;
            string apellidoMaterno = txtAM.Text;
            string telefono = txtcelular.Text;

            txtDNI.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtAP.Text = string.Empty;
            txtAM.Text = string.Empty;
            txtcelular.Text = string.Empty;


            proc.ModificarTecnico(idTecnico, DNI, nombres, apellidoPaterno, apellidoMaterno, telefono);
            ActualizarTecnicos();
        }

        private void ElTecnico_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string nombres = txtnombre.Text;
            string apellidoPaterno = txtAP.Text;
            string apellidoMaterno = txtAM.Text;
            string telefono = txtcelular.Text;

            txtDNI.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtAP.Text = string.Empty;
            txtAM.Text = string.Empty;
            txtcelular.Text = string.Empty;

            proc.BorrarTecnico(idTecnico);
            ActualizarTecnicos();
        }

        private void ActualizarTecnicos()
        {
            DataTable tecnicosTable = proc.ObtenerTecnicos();

            VistaTecnicos.DataSource = tecnicosTable;

            VistaTecnicos.Columns["idtecnico"].HeaderText = "ID";
            VistaTecnicos.Columns["dni_tecnico"].HeaderText = "DNI";
            VistaTecnicos.Columns["nombres"].HeaderText = "Nombre";
            VistaTecnicos.Columns["apellido_paterno"].HeaderText = "Apellido Paterno";
            VistaTecnicos.Columns["apellido_materno"].HeaderText = "Apellido Materno";
            VistaTecnicos.Columns["telefono"].HeaderText = "Telefono";
        }

        private void VistaTecnicos_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
