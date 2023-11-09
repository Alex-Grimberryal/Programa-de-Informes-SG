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
    public partial class MyC : UserControl
    {
        Procedimientos proc = new Procedimientos();

        public MyC()
        {
            InitializeComponent();
        }

        private void MyC_Load(object sender, EventArgs e)
        {
            // Llamar al método ObtenerUsuarios de la clase Procedimientos
            DataTable categoriasTable = proc.ObtenerCategorias();

            // Crear un BindingSource y asignar el DataTable como origen de datos
            BindingSource bindingSource = new BindingSource();
            VistaCategoria.DataSource = categoriasTable;

            // Asignar los datos al DataGridView
            VistaCategoria.DataSource = categoriasTable;

            // Configurar las columnas del DataGridView
            VistaCategoria.Columns["idcategoria"].HeaderText = "ID";
            VistaCategoria.Columns["categoria"].HeaderText = "Categoria";

            // Llamar al método ObtenerUsuarios de la clase Procedimientos
            DataTable marcasTable = proc.ObtenerMarcas();

            // Crear un BindingSource y asignar el DataTable como origen de datos
            bindingSource = new BindingSource();
            VistaMarca.DataSource = marcasTable;

            // Asignar los datos al DataGridView
            VistaMarca.DataSource = marcasTable;

            // Configurar las columnas del DataGridView
            VistaMarca.Columns["idmarca"].HeaderText = "ID";
            VistaMarca.Columns["marca"].HeaderText = "Marca";
        }

        private void InCategoria_Click(object sender, EventArgs e)
        {
            string categoria = txtcategoria.Text;

            txtcategoria.Text = string.Empty;

            proc.InsertarCategoria(categoria);
            ActualizarCategorias();

        }

        private int idCategoria;

        private void ModCategoria_Click(object sender, EventArgs e)
        {
            string categoria = txtcategoria.Text;

            txtcategoria.Text = string.Empty;

            proc.ModificarCategoria(idCategoria, categoria);
            ActualizarCategorias();
        }

        private void ElCategoria_Click(object sender, EventArgs e)
        {
            string categoria = txtcategoria.Text;

            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres borrar esta Categoria?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    proc.BorrarCategoria(idCategoria);

                    // Actualizar la vista de usuarios
                    ActualizarCategorias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar la Categoria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Selecciona una Categoria para borrar.", "Categoria no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InMarca_Click(object sender, EventArgs e)
        {
            string marca = txtmarca.Text;

            txtmarca.Text = string.Empty;

            proc.InsertarMarca(marca);
            ActualizarMarcas();
        }

        private int idMarca;

        private void ModMarca_Click(object sender, EventArgs e)
        {
            string marca = txtmarca.Text;

            txtmarca.Text = string.Empty;

            proc.ModificarMarca(idMarca, marca);
            ActualizarMarcas();
        }

        private void ElMarca_Click(object sender, EventArgs e)
        {
            string marca = txtmarca.Text;

            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres borrar esta Marcaa?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    proc.BorrarMarca(idMarca);

                    // Actualizar la vista de usuarios
                    ActualizarMarcas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar la Marca: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Selecciona una Marca para borrar.", "Marca no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarCategorias()
        {
            // Obtener los usuarios actualizados de la base de datos
            DataTable categoriasTable = proc.ObtenerCategorias();

            // Asignar los datos al DataGridView
            VistaCategoria.DataSource = categoriasTable;

            // Configurar las columnas del DataGridView
            VistaCategoria.Columns["idcategoria"].HeaderText = "ID";
            VistaCategoria.Columns["categoria"].HeaderText = "Categoria";
        }

        private void ActualizarMarcas()
        {
            DataTable marcasTable = proc.ObtenerMarcas();

            VistaMarca.DataSource = marcasTable;

            VistaMarca.Columns["idmarca"].HeaderText = "ID";
            VistaMarca.Columns["marca"].HeaderText = "Marca";
        }

        private void VistaCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (VistaCategoria.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = VistaCategoria.SelectedRows[0];
                idCategoria = Convert.ToInt32(selectedRow.Cells["idcategoria"].Value);
                string categoria = selectedRow.Cells["categoria"].Value.ToString();

                txtcategoria.Text = categoria;
            }
        }

        private void VistaMarca_SelectionChanged(object sender, EventArgs e)
        {
            if (VistaMarca.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = VistaMarca.SelectedRows[0];
                idMarca = Convert.ToInt32(selectedRow.Cells["idmarca"].Value);
                string marca = selectedRow.Cells["marca"].Value.ToString();

                txtmarca.Text = marca;
            }
        }
    }
}
