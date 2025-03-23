using Microsoft.Data.SqlClient;
using System.Data;

namespace SistemaGestorOrden_Cliente
{
    public partial class Clientes : Form
    {
        BindingSource BindingSourceClientes = new BindingSource();
        bool BlnNuevo = true;
        // En Clientes.Designer.cs

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = BindingSourceClientes;
            BindingSourceClientes.DataSource = GetCliente("SEL_CLIENTES");

            if (dgvClientes.Columns.Count > 0)
            {
                SetClientes();
            }

            dgvClientes.Refresh();

            // Actualizar el DateTimePicker a la fecha actual
            fechaIngreso.Value = DateTime.Now;

            // Poblar el ComboBox con los nombres de las columnas del DataGridView
            foreach (DataGridViewColumn column in dgvClientes.Columns)
            {
                if (column.Index != 0) // No tomar la columna 0
                {
                    cmbCliente.Items.Add(column.HeaderText);
                }
            }

            // Asociar el evento SelectedIndexChanged del ComboBox
            //cmbCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void SetClientes()
        {
            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvClientes.Columns[0].HeaderText = "ID";
            dgvClientes.Columns[1].HeaderText = "Nombre";
            dgvClientes.Columns[2].HeaderText = "Apellido";
            dgvClientes.Columns[3].HeaderText = "Direccion";
            dgvClientes.Columns[4].HeaderText = "Telefono";
            dgvClientes.Columns[5].HeaderText = "Email";
            dgvClientes.Columns[6].HeaderText = "Fecha de Ingreso";


        }

        private DataTable GetCliente(string SPNombre)
        {
            DataTable dtClientes = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    using (SqlDataAdapter daClientes = new SqlDataAdapter(SPNombre, con))
                    {
                        daClientes.Fill(dtClientes);
                    }
                }
                catch (SqlException exc)
                {
                    MessageBox.Show($"No se pudieron recuperar los datos del cliente.\nError: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dtClientes;
        }

        private void CargarDatos()
        {
            // Este es el método que utilizas para volver a cargar los datos en el DataGridView
            BindingSourceClientes.DataSource = GetCliente("SEL_CLIENTES");
            dgvClientes.DataSource = BindingSourceClientes;
            dgvClientes.Refresh();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {

            // Validaciones

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Nombre", "Grabado de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Apellido", "Grabado de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Telefono", "Grabado de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Email", "Grabado de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Direccion", "Grabado de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BlnNuevo) // Si es un booleano no es necesario poner la asignación
            {
                // Conexión a la BDD
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "INS_CLIENTE"; // Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure; // Tipo de comando
                        cmd.Connection = con;

                        // SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("apellido", txtApellido.Text);
                        cmd.Parameters.AddWithValue("direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("fecha_ingreso", fechaIngreso.Value);

                        // YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtIDCliente.Text = "";
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDireccion.Text = "";
                        txtEmail.Text = "";
                        txtTelefono.Text = "";
                        fechaIngreso.Text = "";

                        CargarDatos();
                    }
                }
            }
            else
            {
                // EDITAR REGISTRO
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UPD_CLIENTE"; // Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure; // Tipo de comando
                        cmd.Connection = con;

                        // SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        cmd.Parameters.AddWithValue("id_cliente", txtIDCliente.Text);
                        cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("apellido", txtApellido.Text);
                        cmd.Parameters.AddWithValue("direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("fecha_ingreso", fechaIngreso.Value);

                        // YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtIDCliente.Text = "";
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDireccion.Text = "";
                        txtTelefono.Text = "";
                        txtEmail.Text = "";
                        fechaIngreso.Text = "";

                        CargarDatos();
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (BlnNuevo == false)
            {
                if (dgvClientes.CurrentRow == null)
                {
                    MessageBox.Show("No hay ninguna fila seleccionada para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea borrar el registro?", "Borrar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection())
                    {
                        con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "DEL_CLIENTE";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("id_cliente", Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
                            cmd.ExecuteNonQuery();
                            txtIDCliente.Text = "";
                            txtNombre.Text = "";
                            txtApellido.Text = "";
                            txtDireccion.Text = "";
                            txtEmail.Text = "";
                            txtTelefono.Text = "";
                            fechaIngreso.Text = "";
                            txtBuscar.Text = "";
                            CargarDatos();

                            BlnNuevo = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha borrado el registro", "Borrar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Debe ingresar valores para Nombre y Apellido", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDCliente.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtEmail.Text = "";
                txtTelefono.Text = "";
                fechaIngreso.Text = "";
                txtBuscar.Text = "";
                CargarDatos();
                return;
            }

            // Dividir el texto ingresado en nombre y apellido
            string[] nombreApellido = txtBuscar.Text.Split(' ');
            if (nombreApellido.Length < 2)
            {
                MessageBox.Show("Debe ingresar tanto el nombre como el apellido", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = nombreApellido[0];
            string apellido = nombreApellido[1];

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                con.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_CLIENTE"; // Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure; // Tipo de comando
                    cmd.Connection = con;
                    // SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);

                    SqlDataReader DatosCliente = cmd.ExecuteReader();

                    if (DatosCliente.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(DatosCliente);
                        dgvClientes.DataSource = dt;

                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            txtIDCliente.Text = row["id_cliente"].ToString(); // Guardamos el ID
                            txtNombre.Text = row["nombre"].ToString();
                            txtApellido.Text = row["apellido"].ToString();
                            txtDireccion.Text = row["direccion"].ToString();
                            txtEmail.Text = row["email"].ToString();
                            txtTelefono.Text = row["telefono"].ToString();
                            fechaIngreso.Text = row["fecha_ingreso"].ToString();

                            BlnNuevo = false;
                            dgvClientes.Rows[0].Selected = true;
                            txtBuscar.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDireccion.Text = "";
                        txtEmail.Text = "";
                        txtTelefono.Text = "";
                        fechaIngreso.Text = "";
                        txtBuscar.Text = "";
                        BlnNuevo = true;
                    }

                    DatosCliente.Close();
                }
            }
        }

        private void verTodasLasOrdenessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalOrdenes Ordenes = new TotalOrdenes();
            Ordenes.ShowDialog();
        }

        private void todosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalClientes Clientes = new TotalClientes();
            Clientes.ShowDialog();
        }

        private void generarOrdenReparcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenesReparacion Ordenes = new OrdenesReparacion();
            Ordenes.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaTelefono_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            // {
            // MessageBox.Show("Debe ingresar valores para Nombre y Apellido", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // txtIDCliente.Text = "";
            // txtNombre.Text = "";
            // txtApellido.Text = "";
            // txtDireccion.Text = "";
            // txtEmail.Text = "";
            // txtTelefono.Text = "";
            // fechaIngreso.Text = "";
            // txtBuscar.Text = "";
            // CargarDatos();
            // return;
            //}


            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                con.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_CLIENTE"; // Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure; // Tipo de comando
                    cmd.Connection = con;
                    // SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                    //cmd.Parameters.AddWithValue("@telefono");

                    SqlDataReader DatosCliente = cmd.ExecuteReader();

                    if (DatosCliente.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(DatosCliente);
                        dgvClientes.DataSource = dt;

                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            txtIDCliente.Text = row["id_cliente"].ToString(); // Guardamos el ID
                            txtNombre.Text = row["nombre"].ToString();
                            txtApellido.Text = row["apellido"].ToString();
                            txtDireccion.Text = row["direccion"].ToString();
                            txtEmail.Text = row["email"].ToString();
                            txtTelefono.Text = row["telefono"].ToString();
                            fechaIngreso.Text = row["fecha_ingreso"].ToString();

                            BlnNuevo = false;
                            dgvClientes.Rows[0].Selected = true;
                            txtBuscar.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDireccion.Text = "";
                        txtEmail.Text = "";
                        txtTelefono.Text = "";
                        fechaIngreso.Text = "";
                        txtBuscar.Text = "";
                        BlnNuevo = true;
                    }

                    DatosCliente.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Clear(); // Borra el texto de búsqueda al cambiar la columna de filtro

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (dgvClientes.DataSource is BindingSource bindingSource)
            {
                if (bindingSource.DataSource is DataTable dt)
                {
                    string columna = cmbCliente.SelectedItem.ToString();
                    string filtro = txtBuscar.Text.Trim();

                    if (dt.Columns.Contains(columna))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                        {
                            dt.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", columna, filtro);
                        }
                        else
                        {
                            dt.DefaultView.RowFilter = "";
                        }
                    }
                    else
                    {
                        // Handle the case where the column does not exist
                        MessageBox.Show($"Column '{columna}' does not exist in the DataTable.");
                    }
                }
            }
        }
    }
}
