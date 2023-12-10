using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


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
            // Crear el documento PDF
            Document doc = new Document();

            try
            {
                // Crear el escritor PDF y abrir el documento
                string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "REPORTES", "Informe_" + informeSeleccionado["nro_de_informe"].ToString() + ".pdf");
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

                // Agregar los datos del informe al documento
                if (informeSeleccionado != null)
                {
                    // Crear una instancia de la clase PdfPTable para la tabla
                    PdfPTable tabla = new PdfPTable(1);

                    // Crear la primera celda con la etiqueta "RUC"
                    PdfPCell celda1 = new PdfPCell(new Phrase("RUC"));

                    // Establecer alineación centrada en la celda
                    celda1.HorizontalAlignment = Element.ALIGN_CENTER;

                    // Establecer estilo de fuente negrita en la celda
                    iTextSharp.text.Font negrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12f);
                    celda1.Phrase.Font = negrita;

                    tabla.AddCell(celda1);

                    // Crear la segunda celda con el siguiente RUC "10164116854"
                    PdfPCell celda2 = new PdfPCell(new Phrase("10164116854"));

                    // Establecer alineación centrada en la celda
                    celda2.HorizontalAlignment = Element.ALIGN_CENTER;

                    // Establecer estilo de fuente negrita en la celda
                    celda2.Phrase.Font = negrita;

                    tabla.AddCell(celda2);

                    // Ruta de la imagen que deseas agregar
                    string rutaImagen = "Pictures\\BANNER_5__3_-removebg-preview (2).png";

                    // Crear una instancia de la clase Image con la ruta de la imagen
                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(rutaImagen);

                    // Ajustar el tamaño de la imagen si es necesario
                    imagen.ScaleToFit(175, 50);

                    // Crear una instancia de la clase PdfPTable para el contenedor
                    PdfPTable contenedor = new PdfPTable(2);

                    // Crear una celda para la imagen
                    PdfPCell celdaImagen = new PdfPCell();
                    celdaImagen.AddElement(imagen); // Agregar la imagen a la celda de la imagen
                    celdaImagen.Border = PdfPCell.NO_BORDER; // Opcional: eliminar los bordes de la celda de la imagen

                    // Alinear la celda de la imagen
                    celdaImagen.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celdaImagen.VerticalAlignment = Element.ALIGN_MIDDLE;

                    // Agregar la celda de la imagen al contenedor
                    contenedor.AddCell(celdaImagen);

                    // Crear una celda para la tabla
                    PdfPCell celdaTabla = new PdfPCell(tabla);
                    celdaTabla.HorizontalAlignment = Element.ALIGN_LEFT;
                    // Agregar la celda de la tabla al contenedor
                    contenedor.AddCell(celdaTabla);

                    // Crear una instancia de la clase PdfPTable para el contenedor
                    contenedor.DefaultCell.Border = PdfPCell.NO_BORDER; // Opcional: eliminar los bordes de las celdas del contenedor
                    contenedor.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                    // Agregar el contenedor al documento PDF
                    doc.Add(contenedor);
                    

                    // Agregar el número de informe
                    doc.Add(new Paragraph("INFORME NROº - " + informeSeleccionado["nro_de_informe"].ToString()));

                    // Agregar los datos del cliente
                    doc.Add(new Paragraph("Nombre completo del cliente: " + informeSeleccionado["nombre_de_cliente"].ToString() + " " + informeSeleccionado["apellido_paterno"].ToString() + " " + informeSeleccionado["apellido_materno"].ToString()));
                    doc.Add(new Paragraph("DNI del cliente: " + informeSeleccionado["dni"].ToString()));

                    // Agregar la fecha de generación del PDF
                    doc.Add(new Paragraph("Fecha de venta / instalación : " + informeSeleccionado["fecha"].ToString()));

                    // Agregar el técnico y la dirección de instalación
                    doc.Add(new Paragraph("Técnico: " + informeSeleccionado["ApellidoTecnico"].ToString()));
                    doc.Add(new Paragraph("Dirección de instalación: " + informeSeleccionado["direccion_instalacion"].ToString()));
                    doc.Add(new Paragraph(" "));

                    // Agregar la tabla de artículos
                    PdfPTable tablaArticulos = new PdfPTable(3);
                    tablaArticulos.WidthPercentage = 100;
                    tablaArticulos.SetWidths(new float[] { 2f, 1f, 1f });

                    // Agregar el encabezado de la tabla
                    tablaArticulos.AddCell(new PdfPCell(new Phrase("Nombre del Artículo", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))));
                    tablaArticulos.AddCell(new PdfPCell(new Phrase("Cantidad", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))));
                    tablaArticulos.AddCell(new PdfPCell(new Phrase("Monto p/a", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))));


                    // Obtener el número de informe seleccionado
                    int nroInforme = Convert.ToInt32(informeSeleccionado["nro_de_informe"]);

                    // Consulta para obtener los artículos, cantidad y monto total relacionados con el informe seleccionado
                    string consultaArticulos = "SELECT a.nombre, av.cantidad, av.monto_total " +
                                               "FROM art_vend AS av " +
                                               "INNER JOIN articulos AS a ON av.art_idArt = a.idarticulo " +
                                               "WHERE av.info_idInforme = " + nroInforme;
                    // Agregar los artículos relacionados con el informe a la tabla
                    DataTable resultadosArticulos;
                    resultadosArticulos = proc.Consulta(consultaArticulos);
                    foreach (DataRow row in resultadosArticulos.Rows)
                    {
                        string nombreArticulo = row["nombre"].ToString();
                        int cantidad = Convert.ToInt32(row["cantidad"]);
                        decimal montoTotala = Convert.ToDecimal(row["monto_total"]);

                        tablaArticulos.AddCell(new PdfPCell(new Phrase(nombreArticulo)));
                        tablaArticulos.AddCell(new PdfPCell(new Phrase(cantidad.ToString())));
                        tablaArticulos.AddCell(new PdfPCell(new Phrase(montoTotala.ToString())));
                    }

                    // Agregar la celda adicional para el monto total
                    decimal montoTotal = Convert.ToDecimal(informeSeleccionado["monto_total"]);
                    PdfPCell celdaMontoTotal = new PdfPCell(new Phrase("Monto total: " + montoTotal.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)));
                    celdaMontoTotal.Colspan = 3;
                    tablaArticulos.AddCell(celdaMontoTotal);

                    // Agregar la tabla de artículos al documento
                    doc.Add(tablaArticulos);
                }

                // Cerrar el documento y el escritor PDF
                doc.Close();
                writer.Close();

                // Mostrar un mensaje de éxito
                MessageBox.Show("El informe se ha guardado exitosamente como PDF en la carpeta 'REPORTES' en el escritorio.", "Informe Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de que ocurra una excepción
                MessageBox.Show("Se produjo un error al generar el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
