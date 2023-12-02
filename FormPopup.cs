using com.itextpdf.text.pdf;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class FormPopup : Form
    {
        Procedimientos proc = new Procedimientos();

        public DataRow informeSeleccionado;

        public FormPopup(DataRow informe)
        {
            InitializeComponent();

            informeSeleccionado = informe;

            // Llenar el ListView con los datos del informe
            LlenarListView();
        }

        private void LlenarListView()
        {
            // Limpiar el ListView
            verInforme.Items.Clear();

            // Agregar cada campo y valor del informe como un par de nombre y valor en el ListView
            foreach (DataColumn column in informeSeleccionado.Table.Columns)
            {
                string campo = column.ColumnName;
                string valor = informeSeleccionado[column].ToString();

                ListViewItem item = new ListViewItem(campo);
                item.SubItems.Add(valor);

                verInforme.Items.Add(item);
            }
        }
    }
}
