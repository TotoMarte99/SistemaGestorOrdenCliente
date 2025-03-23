using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;


namespace SistemaGestorOrden_Cliente
{
    public partial class TotalOrdenes : Form
    {
        BindingSource BindingSourceClientes = new BindingSource();

        public TotalOrdenes()
        {
            InitializeComponent();
        }

        private void SetOrdenes()
        {
            if (dgvTotalOrdenes.Columns.Count > 11)
            {
                dgvTotalOrdenes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvTotalOrdenes.Columns[0].HeaderText = "id_orden";
                dgvTotalOrdenes.Columns[1].HeaderText = "ID Cliente";
                dgvTotalOrdenes.Columns[5].HeaderText = "Telefono";
                dgvTotalOrdenes.Columns[6].HeaderText = "Email";
                dgvTotalOrdenes.Columns[7].HeaderText = "Fecha de Ingreso";
                dgvTotalOrdenes.Columns[8].HeaderText = "Marca Maquina";
                dgvTotalOrdenes.Columns[9].HeaderText = "Modelo Maquina";
                dgvTotalOrdenes.Columns[10].HeaderText = "Accesorios";
                dgvTotalOrdenes.Columns[11].HeaderText = "Observaciones";

                //Números y fechas van por defecto a la derecha
                dgvTotalOrdenes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTotalOrdenes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTotalOrdenes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTotalOrdenes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private DataTable GetOrdenes(string SPNombre)
        {
            DataTable dtOrdenes = new DataTable();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                con.Open();

                try
                {
                    SqlDataAdapter daOrdenes = new SqlDataAdapter(SPNombre, con);
                    SqlCommandBuilder cbAlumnos = new SqlCommandBuilder(daOrdenes);
                    daOrdenes.Fill(dtOrdenes);
                    return dtOrdenes;
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("No se pudieron recuperar los datos", exc.Message.ToString());
                }
            }
            return dtOrdenes;
        }


        private void TotalOrdenes_Load(object sender, EventArgs e)
        {
            dgvTotalOrdenes.DataSource = BindingSourceClientes;
            BindingSourceClientes.DataSource = GetOrdenes("SEL_ORDENES");

            // Imprimir nombres de columnas para depuración
            foreach (DataColumn column in ((DataTable)BindingSourceClientes.DataSource).Columns)
            {
                Console.WriteLine(column.ColumnName);
            }


            if (!dgvTotalOrdenes.Columns.Contains("Estados"))
            {
                DataGridViewComboBoxColumn estadoColumn = new DataGridViewComboBoxColumn();
                estadoColumn.HeaderText = "Actualiza Estado";
                estadoColumn.Name = "Estados";
                estadoColumn.DataPropertyName = "estado"; // Debe coincidir con el nombre del campo en la BD
                estadoColumn.Items.AddRange("Pendiente", "En proceso", "Finalizada", "Entregada");

                dgvTotalOrdenes.Columns.Add(estadoColumn);
            }

            dgvTotalOrdenes.CellValueChanged += dgvTotalOrdenes_CellValueChanged;
            dgvTotalOrdenes.CurrentCellDirtyStateChanged += dgvTotalOrdenes_CurrentCellDirtyStateChanged;



            foreach (DataGridViewColumn column in dgvTotalOrdenes.Columns)
            {
                if (column.Index == 0 || column.Index == 2 || column.Index == 3 || column.Index == 4 || column.Index == 5 || column.Index == 6 || column.Index == 7 || column.Index == 8)
                {
                    cmbOrdenes.Items.Add(column.HeaderText);
                }
            }
        }

        private void dgvTotalOrdenes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTotalOrdenes.IsCurrentCellDirty)
            {
                dgvTotalOrdenes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                con.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_ORDEN";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("id_orden", txtBuscarOrden.Text);

                    SqlDataReader DatosOrden = cmd.ExecuteReader();

                    if (DatosOrden.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(DatosOrden);
                        dgvTotalOrdenes.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros", "Buscar orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTotalOrdenes.DataSource = BindingSourceClientes;
                    }

                    DatosOrden.Close();
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvTotalOrdenes.SelectedRows.Count > 0)
            {
                var ordenSeleccionada = dgvTotalOrdenes.SelectedRows[0].DataBoundItem as DataRowView;

                if (ordenSeleccionada != null)
                {
                    try
                    {
                        string rutaPlantilla = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "plantilla.html");
                        string paginahtml_texto = File.ReadAllText(rutaPlantilla);

                        paginahtml_texto = paginahtml_texto.Replace("@ID_ORDEN", ordenSeleccionada["ID_ORDEN"].ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@NOMBRE", ordenSeleccionada["NOMBRE"].ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@APELLIDO", ordenSeleccionada["APELLIDO"].ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@TELEFONO", ordenSeleccionada["TELEFONO"].ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@DIRECCION", ordenSeleccionada["DIRECCION"].ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@FECHA_INGRESO", ordenSeleccionada["FECHA_INGRESO"].ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@MARCA", ordenSeleccionada["MARCA"].ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@MODELO", ordenSeleccionada["MODELO"].ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@ACCESORIOS", ordenSeleccionada["ACCESORIOS"].ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@OBSERVACIONES", ordenSeleccionada["OBSERVACIONES"].ToString());

                        SaveFileDialog guardar = new SaveFileDialog();
                        guardar.Filter = "PDF Files (*.pdf)|*.pdf";
                        if (guardar.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(guardar.FileName))
                        {
                            using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                using (StringReader sr = new StringReader(paginahtml_texto))
                                {
                                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                                }

                                pdfDoc.Close();
                            }

                            MessageBox.Show("El PDF se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una orden primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una orden primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCargar0_Click(object sender, EventArgs e)
        {
            dgvTotalOrdenes.DataSource = BindingSourceClientes;
            txtBuscarOrden.Clear();
        }

        private void dgvTotalOrdenes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvTotalOrdenes.Columns["Estados"].Index)
            {
                int idOrden = Convert.ToInt32(dgvTotalOrdenes.Rows[e.RowIndex].Cells["id_orden"].Value);
                string? nuevoEstado = dgvTotalOrdenes.Rows[e.RowIndex].Cells["Estados"].Value?.ToString();

                if (nuevoEstado != null)
                {
                    MessageBox.Show($"Actualizando Orden {idOrden} a Estado: {nuevoEstado}");

                    // Llamar a la función para actualizar en la base de datos
                    ActualizarEstadosOrden(idOrden, nuevoEstado);
                }
                else
                {
                    MessageBox.Show("El estado no puede ser nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizarEstadosOrden(int idOrden, string nuevoEstado)
        {
            string connectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPD_ORDEN", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_orden", idOrden);
                    cmd.Parameters.AddWithValue("@estado", nuevoEstado);



                    // Enviar correo electrónico
                }
            }
        }

        private void txtBuscarOrden_TextChanged(object sender, EventArgs e)
        {
            if (dgvTotalOrdenes.DataSource is BindingSource bindingSource)
            {
                if (bindingSource.DataSource is DataTable dt)
                {
                    string columna = cmbOrdenes.SelectedItem.ToString();
                    string filtro = txtBuscarOrden.Text.Trim();

                    if (dt.Columns.Contains(columna))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                        {
                            if (dt.Columns[columna].DataType == typeof(string))
                            {
                                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columna, filtro);
                            }
                            else if (dt.Columns[columna].DataType == typeof(int))
                            {
                                if (int.TryParse(filtro, out int intFiltro))
                                {
                                    dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", columna, intFiltro);
                                }
                                else
                                {
                                    MessageBox.Show("El filtro debe ser un número entero.");
                                }
                            }
                        }
                        else
                        {
                            dt.DefaultView.RowFilter = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Columna '{columna}' No existe.");
                    }
                }
            }
        }

        private void cmbOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //MessageBox.Show("Estado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}


