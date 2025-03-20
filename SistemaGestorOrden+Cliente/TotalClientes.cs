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

namespace SistemaGestorOrden_Cliente
{
    public partial class TotalClientes : Form
    {
        BindingSource BindingSourceClientes = new BindingSource();
        public TotalClientes()
        {
            InitializeComponent();
        }

        private void SetClientes()
        {
            if (dgvTotalClientes.Columns.Count > 0)
            {
                dgvTotalClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvTotalClientes.Columns[0].HeaderText = "ID";
                dgvTotalClientes.Columns[1].HeaderText = "Nombre";
                dgvTotalClientes.Columns[2].HeaderText = "Apellido";
                dgvTotalClientes.Columns[3].HeaderText = "Direccion";
                dgvTotalClientes.Columns[4].HeaderText = "Telefono";
                dgvTotalClientes.Columns[5].HeaderText = "Email";
                dgvTotalClientes.Columns[6].HeaderText = "Fecha de Ingreso";


                //Números y fechas van por defecto a la derecha
                dgvTotalClientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTotalClientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTotalClientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTotalClientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }


        private DataTable GetClientes(string SPNombre)
        {

            // Procedimiento pq no devuelve ningun valor
            //SPNombre es el nombre del procedimiento almacenado que llega como parámetro del procedimiento
            DataTable dtClientes = new DataTable();


            using (SqlConnection con = new SqlConnection())
            {
                //Abrir conexión
                // cadena de conexión o connect string: donde se tiene q conectar mi programa
                // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                //Conecto 
                con.Open();


                try
                {
                    //se ejecuta completo en tanto no haya ningún error

                    // definimos un dataadapter llamado daAlumnos
                    SqlDataAdapter daClientes = new SqlDataAdapter();



                    daClientes = new SqlDataAdapter(SPNombre, con);

                    SqlCommandBuilder cbAlumnos = new SqlCommandBuilder(daClientes);
                    //
                    daClientes.Fill(dtClientes);

                    //

                    return dtClientes;

                }

                catch (SqlException exc)

                {

                    //sólo se ejecuta si se produjo algún error dentro del bloque try
                    MessageBox.Show("No se pudieron recuperar los datos", exc.Message.ToString());


                }
                finally
                {

                    //Con error o sin error se ejecuta


                }

            }
            return dtClientes;
        }

        private void TotalClientes_Load(object sender, EventArgs e)
        {
            //Asigno a mi fuente de dato, la variable que cree
            dgvTotalClientes.DataSource = BindingSourceClientes;



            BindingSourceClientes.DataSource = GetClientes("SEL_CLIENTES");// metodo datasource soporta
                                                                           // o tolera muchos archivos. xml,matrices,vectores,datatable,datareader,dataset,dataview

            SetClientes();
        }

        private void btnBuscarClienteTotal_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                con.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_CLIENTE"; // Nombre del procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure; // Tipo de comando
                    cmd.Connection = con;
                    // Asignación de valores a los parámetros
                    cmd.Parameters.AddWithValue("id_cliente", txtIDCliente.Text);

                    SqlDataReader DatosCliente = cmd.ExecuteReader();

                    if (DatosCliente.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(DatosCliente);

                        dgvTotalClientes.DataSource = dt; // Asigna el DataTable al DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTotalClientes.DataSource = BindingSourceClientes;
                    }

                    DatosCliente.Close();
                }
            }
        }

        private void btnCargar0_Click(object sender, EventArgs e)
        {
            dgvTotalClientes.DataSource = BindingSourceClientes;
            txtIDCliente.Clear();
        }
    }
}
