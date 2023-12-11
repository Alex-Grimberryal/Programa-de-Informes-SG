using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD.opciones
{
    public partial class ExportData : UserControl
    {
        Procedimientos proc = new Procedimientos();

        public ExportData()
        {
            InitializeComponent();
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Seleccionar directorio de destino del respaldo";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string directorioDestinoRespaldo = folderBrowserDialog.SelectedPath;

                // Aquí puedes hacer lo que necesites con el directorio seleccionado
                // Por ejemplo, puedes asignarlo a una variable o mostrarlo en un TextBox
                txtRutaDestino.Text = directorioDestinoRespaldo;

                // Llamar al método para generar el respaldo con el directorio seleccionado
                proc.GenerarRespaldoBaseDatos(directorioDestinoRespaldo);
            }
        }

        
    }
}
