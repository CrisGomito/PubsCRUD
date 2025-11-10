using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PubsCRUD.Controllers;
using PubsCRUD.Models;

namespace PubsCRUD.Views
{
    public partial class frm_Authors : Form
    {
        private readonly Authors_Controller controller = new Authors_Controller();

        public frm_Authors()
        {
            InitializeComponent();
        }

        private void frm_Authors_Load(object sender, EventArgs e)
        {
            // Si quieres permitir ingreso manual del au_id para nuevos registros,
            // asegúrate en el diseñador que txtAuthorId.ReadOnly = false
            CargarAutores();
        }

        private void CargarAutores()
        {
            try
            {
                List<Author_Model> lista = controller.GetAll();
                dgvAuthors.DataSource = null;
                dgvAuthors.DataSource = lista;

                // Opcional: ajustar encabezados (si deseas nombres legibles)
                if (dgvAuthors.Columns["Au_Id"] != null) dgvAuthors.Columns["Au_Id"].HeaderText = "Author ID";
                if (dgvAuthors.Columns["Au_Fname"] != null) dgvAuthors.Columns["Au_Fname"].HeaderText = "First Name";
                if (dgvAuthors.Columns["Au_Lname"] != null) dgvAuthors.Columns["Au_Lname"].HeaderText = "Last Name";
                // ...otros encabezados si quieres
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar autores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(txtAuthorId.Text))
                {
                    MessageBox.Show("El campo Author ID es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAuthorId.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("Nombre y apellido son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevo = new Author_Model
                {
                    Au_Id = txtAuthorId.Text.Trim(),
                    Au_Fname = txtFirstName.Text.Trim(),
                    Au_Lname = txtLastName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    State = txtState.Text.Trim(),
                    Zip = txtZip.Text.Trim(),
                    // Si tu modelo tiene Contract, ajusta aquí
                };

                bool ok = controller.Add(nuevo);
                if (ok)
                {
                    MessageBox.Show("Autor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAutores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el autor. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAuthorId.Text))
                {
                    MessageBox.Show("Seleccione un autor para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var autor = new Author_Model
                {
                    Au_Id = txtAuthorId.Text.Trim(),
                    Au_Fname = txtFirstName.Text.Trim(),
                    Au_Lname = txtLastName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    State = txtState.Text.Trim(),
                    Zip = txtZip.Text.Trim()
                };

                bool ok = controller.Update(autor);
                if (ok)
                {
                    MessageBox.Show("Autor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAutores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el autor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAuthorId.Text))
                {
                    MessageBox.Show("Seleccione un autor para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dr = MessageBox.Show("¿Confirma eliminación del autor seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;

                bool ok = controller.Delete(txtAuthorId.Text.Trim());
                if (ok)
                {
                    MessageBox.Show("Autor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAutores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el autor. Puede que exista dependencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = dgvAuthors.Rows[e.RowIndex];
                // Asegúrate que los nombres de columna coincidan con las propiedades del modelo
                txtAuthorId.Text = row.Cells["Au_Id"].Value?.ToString() ?? "";
                txtFirstName.Text = row.Cells["Au_Fname"].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells["Au_Lname"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtCity.Text = row.Cells["City"].Value?.ToString() ?? "";
                txtState.Text = row.Cells["State"].Value?.ToString() ?? "";
                txtZip.Text = row.Cells["Zip"].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtAuthorId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
            txtAuthorId.Focus();
        }
    }
}
