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

            // Imprimir el contenido de informeSeleccionado en el Label al cargar la interfaz
            if (informeSeleccionado != null)
            {
                // Reemplaza con los datos del informe
                inf.Text = "INFORME NROº - " + informeSeleccionado["nro_de_informe"].ToString();
                nombre.Text = informeSeleccionado["nombre_de_cliente"].ToString() + " " + informeSeleccionado["apellido_paterno"].ToString() + " " + informeSeleccionado["apellido_materno"].ToString();
                dni.Text = informeSeleccionado["dni"].ToString();
                telefono.Text = informeSeleccionado["telefono"].ToString();
                correo.Text = informeSeleccionado["email"].ToString();
                fecha.Text = informeSeleccionado["fecha"].ToString();
                monto.Text = informeSeleccionado["monto_total"].ToString();
                tecnico.Text = informeSeleccionado["ApellidoTecnico"].ToString();
                direcion.Text = informeSeleccionado["direccion_instalacion"].ToString();
                redactor.Text = informeSeleccionado["NombreUsuario"].ToString();

                // Obtener el número de informe seleccionado
                int nroInforme = Convert.ToInt32(informeSeleccionado["nro_de_informe"]);

                // Consulta para obtener los artículos, cantidad y monto total relacionados con el informe seleccionado
                string consultaArticulos = "SELECT a.nombre, av.cantidad, av.monto_total " +
                                           "FROM art_vend AS av " +
                                           "INNER JOIN articulos AS a ON av.art_idArt = a.idarticulo " +
                                           "WHERE av.info_idInforme = " + nroInforme;

                // Ejecutar la consulta y obtener los resultados en un DataTable
                DataTable resultadosArticulos = proc.Consulta(consultaArticulos);

                // Limpiar el ListBox antes de agregar los nuevos elementos
                verArticulos.Items.Clear();

                // Recorrer los resultados y agregar los elementos al ListBox
                foreach (DataRow row in resultadosArticulos.Rows)
                {
                    string nombreArticulo = row["nombre"].ToString();
                    int cantidad = Convert.ToInt32(row["cantidad"]);
                    decimal montoTotal = Convert.ToDecimal(row["monto_total"]);

                    string item = $"{nombreArticulo} - Cantidad: {cantidad} - Monto Total: {montoTotal}";

                    verArticulos.Items.Add(item);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void correo_Click(object sender, EventArgs e)
        {

        }

        private void redactor_Click(object sender, EventArgs e)
        {

        }

        private void verArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
