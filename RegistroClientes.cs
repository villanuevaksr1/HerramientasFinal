using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Trabajo_final_herramientas_II
{
    public partial class RegistroClientes : Form
    {
        // Variables para el modo de edición
        private bool editMode = false;
        private int editingRowIndex = -1;

        public RegistroClientes()
        {
            InitializeComponent();
            // Make sure the DataGridView is initialized before adding columns
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            // Clear existing columns first to avoid duplicates
            dgvNewClient.Columns.Clear();

            // Add columns manually
            dgvNewClient.ColumnCount = 4;
            dgvNewClient.Columns[0].Name = "Nombre";
            dgvNewClient.Columns[1].Name = "Apellido";
            dgvNewClient.Columns[2].Name = "Telefono";
            dgvNewClient.Columns[3].Name = "Tipo de Membresia";

            // Configure selection mode
            dgvNewClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0KBBNKK;Initial Catalog=Herramientas;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=Sebastian\\MSSQLSERVER01;Initial Catalog=Herramientas;Integrated Security=True");
                connection.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validate that the DataGridView has columns before adding rows
            if (dgvNewClient.Columns.Count == 0)
            {
                ConfigureDataGridView();
            }

            string connectionString = "Data Source=Sebastian\\MSSQLSERVER01;Initial Catalog=Herramientas;Integrated Security=True";
            string query = "INSERT INTO Clientes (Nombre, Apellido, Telefono, TipoMembresia) VALUES (@Nombre, @Apellido, @Telefono, @TipoMembresia)";

            // Validate that all necessary fields are filled
            if (string.IsNullOrWhiteSpace(txtNameClient.Text) ||
                string.IsNullOrWhiteSpace(txtLastNameClient.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneClient.Text) ||
                cmbMembresia.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", txtNameClient.Text);
                command.Parameters.AddWithValue("@Apellido", txtLastNameClient.Text);
                command.Parameters.AddWithValue("@Telefono", txtPhoneClient.Text);
                command.Parameters.AddWithValue("@TipoMembresia", cmbMembresia.SelectedItem.ToString());
                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cliente registrado exitosamente.");
                        // Agregar al DataGridView
                        dgvNewClient.Rows.Add(
                            txtNameClient.Text,
                            txtLastNameClient.Text,
                            txtPhoneClient.Text,
                            cmbMembresia.SelectedItem.ToString()
                        );

                        // Clear fields after successful registration
                        txtNameClient.Text = "";
                        txtLastNameClient.Text = "";
                        txtPhoneClient.Text = "";
                        cmbMembresia.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("No se insertó ningún dato.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnbackad_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvNewClient.SelectedRows.Count > 0 || dgvNewClient.SelectedCells.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex;
                if (dgvNewClient.SelectedRows.Count > 0)
                {
                    rowIndex = dgvNewClient.SelectedRows[0].Index;
                }
                else
                {
                    rowIndex = dgvNewClient.SelectedCells[0].RowIndex;
                }

                // Confirmar con el usuario antes de eliminar
                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Obtener los datos del cliente a eliminar
                        string nombre = dgvNewClient.Rows[rowIndex].Cells["Nombre"].Value.ToString();
                        string apellido = dgvNewClient.Rows[rowIndex].Cells["Apellido"].Value.ToString();
                        string telefono = dgvNewClient.Rows[rowIndex].Cells["Telefono"].Value.ToString();

                        // Conectar a la base de datos y eliminar el cliente
                        string connectionString = "Data Source=Sebastian\\MSSQLSERVER01;Initial Catalog=Herramientas;Integrated Security=True";
                        string query = "DELETE FROM Clientes WHERE Nombre = @Nombre AND Apellido = @Apellido AND Telefono = @Telefono";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Configurar los parámetros para la consulta
                            command.Parameters.AddWithValue("@Nombre", nombre);
                            command.Parameters.AddWithValue("@Apellido", apellido);
                            command.Parameters.AddWithValue("@Telefono", telefono);

                            // Ejecutar la consulta
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Eliminar la fila del DataGridView
                                dgvNewClient.Rows.RemoveAt(rowIndex);
                                MessageBox.Show("Cliente eliminado exitosamente.");

                                // Si estábamos en modo edición y se elimina el cliente que estábamos editando
                                if (editMode && rowIndex == editingRowIndex)
                                {
                                    // Salir del modo edición
                                    editMode = false;
                                    editingRowIndex = -1;
                                    btnEditClient.Text = "EDITAR CLIENTE";
                                    // Limpiar los campos
                                    txtNameClient.Text = "";
                                    txtLastNameClient.Text = "";
                                    txtPhoneClient.Text = "";
                                    cmbMembresia.SelectedIndex = -1;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el cliente de la base de datos.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            // Si no estamos en modo edición, cargar los datos y entrar en modo edición
            if (!editMode)
            {
                // Verificar si hay una fila seleccionada
                if (dgvNewClient.SelectedRows.Count > 0 || dgvNewClient.SelectedCells.Count > 0)
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex;
                    if (dgvNewClient.SelectedRows.Count > 0)
                    {
                        rowIndex = dgvNewClient.SelectedRows[0].Index;
                    }
                    else
                    {
                        rowIndex = dgvNewClient.SelectedCells[0].RowIndex;
                    }

                    // Cargar los datos del cliente en los campos del formulario
                    txtNameClient.Text = dgvNewClient.Rows[rowIndex].Cells["Nombre"].Value.ToString();
                    txtLastNameClient.Text = dgvNewClient.Rows[rowIndex].Cells["Apellido"].Value.ToString();
                    txtPhoneClient.Text = dgvNewClient.Rows[rowIndex].Cells["Telefono"].Value.ToString();
                    cmbMembresia.SelectedItem = dgvNewClient.Rows[rowIndex].Cells["Tipo de Membresia"].Value.ToString();

                    // Cambiar al modo edición
                    editMode = true;
                    editingRowIndex = rowIndex;
                    btnEditClient.Text = "CONFIRMAR CAMBIOS";

                    // Mensaje al usuario
                    MessageBox.Show("Ahora puede editar los datos del cliente y luego presionar 'CONFIRMAR CAMBIOS'.");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente para editar.");
                }
            }
            // Si ya estamos en modo edición, guardar los cambios
            else
            {
                // Validar que todos los campos estén completos
                if (string.IsNullOrWhiteSpace(txtNameClient.Text) ||
                    string.IsNullOrWhiteSpace(txtLastNameClient.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneClient.Text) ||
                    cmbMembresia.SelectedItem == null)
                {
                    MessageBox.Show("Por favor complete todos los campos.");
                    return;
                }

                try
                {
                    // Obtener los datos originales para identificar al cliente en la base de datos
                    string nombreOriginal = dgvNewClient.Rows[editingRowIndex].Cells["Nombre"].Value.ToString();
                    string apellidoOriginal = dgvNewClient.Rows[editingRowIndex].Cells["Apellido"].Value.ToString();
                    string telefonoOriginal = dgvNewClient.Rows[editingRowIndex].Cells["Telefono"].Value.ToString();

                    // Conectar a la base de datos y actualizar el cliente
                    string connectionString = "Data Source=Sebastian\\MSSQLSERVER01;Initial Catalog=Herramientas;Integrated Security=True";
                    string query = @"UPDATE Clientes 
                                    SET Nombre = @NuevoNombre, 
                                        Apellido = @NuevoApellido, 
                                        Telefono = @NuevoTelefono, 
                                        TipoMembresia = @NuevoTipoMembresia 
                                    WHERE Nombre = @NombreOriginal 
                                      AND Apellido = @ApellidoOriginal 
                                      AND Telefono = @TelefonoOriginal";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Configurar los parámetros para la consulta
                        // Nuevos valores
                        command.Parameters.AddWithValue("@NuevoNombre", txtNameClient.Text);
                        command.Parameters.AddWithValue("@NuevoApellido", txtLastNameClient.Text);
                        command.Parameters.AddWithValue("@NuevoTelefono", txtPhoneClient.Text);
                        command.Parameters.AddWithValue("@NuevoTipoMembresia", cmbMembresia.SelectedItem.ToString());

                        // Valores originales para la condición WHERE
                        command.Parameters.AddWithValue("@NombreOriginal", nombreOriginal);
                        command.Parameters.AddWithValue("@ApellidoOriginal", apellidoOriginal);
                        command.Parameters.AddWithValue("@TelefonoOriginal", telefonoOriginal);

                        // Ejecutar la consulta
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Actualizar el DataGridView
                            dgvNewClient.Rows[editingRowIndex].Cells["Nombre"].Value = txtNameClient.Text;
                            dgvNewClient.Rows[editingRowIndex].Cells["Apellido"].Value = txtLastNameClient.Text;
                            dgvNewClient.Rows[editingRowIndex].Cells["Telefono"].Value = txtPhoneClient.Text;
                            dgvNewClient.Rows[editingRowIndex].Cells["Tipo de Membresia"].Value = cmbMembresia.SelectedItem.ToString();

                            MessageBox.Show("Cliente actualizado exitosamente.");

                            // Salir del modo edición
                            editMode = false;
                            editingRowIndex = -1;
                            btnEditClient.Text = "EDITAR CLIENTE";

                            // Limpiar los campos
                            txtNameClient.Text = "";
                            txtLastNameClient.Text = "";
                            txtPhoneClient.Text = "";
                            cmbMembresia.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el cliente en la base de datos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
            }
        }
    }
}