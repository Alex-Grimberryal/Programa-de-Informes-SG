﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class UserControl2 : UserControl
    {
        Procedimientos proc = new Procedimientos();

        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            DataTable dataTable = proc.ObtenerInformes();

            // Modificar las columnas para mostrar los nombres de usuario y los apellidos paternos del técnico
            dataTable.Columns["NombreUsuario"].ColumnName = "Nombre de Usuario";
            dataTable.Columns["ApellidoTecnico"].ColumnName = "Apellido Paterno del Técnico";

            // Asignar el origen de datos al DataGridView
            vistaInformes.DataSource = dataTable;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DTPfechaInicio.Value.Date;
            DateTime fechaFin = DTPfechaFin.Value.Date.AddDays(1).AddSeconds(-1); // Asegurarse de incluir la fecha final completa

            DataTable dataTable = proc.ObtenerInformesPorFecha(fechaInicio, fechaFin);
            vistaInformes.DataSource = dataTable;
        }



        private void vistaInformes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya hecho clic en una celda válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los datos del informe seleccionado
                int numeroInforme = Convert.ToInt32(vistaInformes.Rows[e.RowIndex].Cells["nro_de_informe"].Value);
                DataRow informe = proc.ObtenerInformePorNumero(numeroInforme);

                if (vistaInformes.Columns[e.ColumnIndex].Name == "nro_de_informe")
                {
                    // Crear una instancia de la ventana emergente
                    using (FormPopup popup = new FormPopup(informe))
                    {
                        // Mostrar la ventana emergente
                        popup.ShowDialog();
                    }
                }
            }
        }
    }
}