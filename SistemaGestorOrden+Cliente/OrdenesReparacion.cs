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
using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;



namespace SistemaGestorOrden_Cliente
{
    public partial class OrdenesReparacion : Form
    {
        BindingSource BindingSourceOrdenes = new BindingSource();

        bool BlnNuevo = true;
        public OrdenesReparacion()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
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
                    cmd.Parameters.AddWithValue("id_cliente", txtBuscarCliente.Text);

                    SqlDataReader DatosCliente = cmd.ExecuteReader();

                    if (DatosCliente.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(DatosCliente);

                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            txtIdCliente.Text = row["id_cliente"].ToString(); // Guardamos el ID
                            txtNombre.Text = row["nombre"].ToString();
                            txttApe.Text = row["apellido"].ToString();
                            txttTelef.Text = row["telefono"].ToString();
                            txttDire.Text = row["direccion"].ToString();


                            BlnNuevo = false;
                            txtBuscarCliente.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBuscarCliente.Text = "";
                        txtNombre.Text = "";
                        txttApe.Text = "";
                        txttDire.Text = "";
                        txttTelef.Text = "";
                        fechaIngreso.Text = "";
                        BlnNuevo = true;
                    }

                    DatosCliente.Close();
                }
            }
        }

        private void GenerarEimprimirOrden(int ordenId)
        {
            SaveFileDialog guardar = new SaveFileDialog
            {
                FileName = "OrdenReparacion_" + ordenId + ".pdf",
                Filter = "Archivos PDF (*.pdf)|*.pdf"
            };

            if (guardar.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(guardar.FileName))
            {
                try
                {
                    // Cargar la plantilla HTML
                    string rutaPlantilla = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "plantilla.html");

                    string paginahtml_texto = File.ReadAllText(rutaPlantilla);

                    // Reemplazar variables en la plantilla
                    paginahtml_texto = paginahtml_texto.Replace("@ID_ORDEN", ordenId.ToString());
                    paginahtml_texto = paginahtml_texto.Replace("@NOMBRE", txtNombre.Text);
                    paginahtml_texto = paginahtml_texto.Replace("@APELLIDO", txttApe.Text);
                    paginahtml_texto = paginahtml_texto.Replace("@TELEFONO", txttTelef.Text);
                    paginahtml_texto = paginahtml_texto.Replace("@DIRECCION", txttDire.Text);
                    paginahtml_texto = paginahtml_texto.Replace("@FECHA_INGRESO", fechaIngreso.Text);
                    paginahtml_texto = paginahtml_texto.Replace("@MARCA", txtMarca.Text);
                    paginahtml_texto = paginahtml_texto.Replace("@MODELO", txtModelo.Text);
                    paginahtml_texto = paginahtml_texto.Replace("@ACCESORIOS", txtAccesorios.Text);
                    paginahtml_texto = paginahtml_texto.Replace("@OBSERVACIONES", txtObservaciones.Text);

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

                    MessageBox.Show("Orden generada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FileNotFoundException fnfEx)
                {
                    MessageBox.Show("Error: " + fnfEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







        private void botonCargarOrden_Click(object sender, EventArgs e)
        {
            BlnNuevo = true;
            // Validaciones
            
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Debe ingresar un valor para Marca", "Grabado de Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {
                MessageBox.Show("Debe ingresar un valor para Observaciones", "Grabado de Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (BlnNuevo == true)
                {
                    using (SqlConnection con = new SqlConnection())
                    {
                        con.ConnectionString = "Data Source=VICTUS-TOTO\\SQLEXPRESS; Initial Catalog=Clientes; Integrated Security=True; TrustServerCertificate=True;";
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "INS_ORDEN"; // Nombre procedure
                            cmd.CommandType = CommandType.StoredProcedure; // Tipo de comando
                            cmd.Connection = con;

                            // SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS

                            // Asignación de valores a los parámetros
                            cmd.Parameters.AddWithValue("@id_cliente", txtIdCliente.Text);
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@apellido", txttApe.Text);
                            cmd.Parameters.AddWithValue("@telefono", txttTelef.Text);
                            cmd.Parameters.AddWithValue("@direccion", txttDire.Text);
                            cmd.Parameters.AddWithValue("@fecha_ingreso", fechaIngreso.Value.Date);
                            cmd.Parameters.AddWithValue("@marca", txtMarca.Text.Trim());
                            cmd.Parameters.AddWithValue("@modelo", txtModelo.Text.Trim());
                            cmd.Parameters.AddWithValue("@accesorios", txtAccesorios.Text.Trim());
                            cmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text.Trim());

                            // Parámetro de salida para capturar el ID de la orden
                            SqlParameter outputIdParam = new SqlParameter("@id_orden", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(outputIdParam);

                            cmd.ExecuteNonQuery();

                            int ordenId = (int)outputIdParam.Value; // Obtener el valor del parámetro de salida

                            MessageBox.Show("Orden registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Aquí se llama a GenerarEimprimirOrden con el ordenId
                            GenerarEimprimirOrden(ordenId);

                            // Limpiar los campos después de generar el PDF
                            txtNombre.Text = "";
                            txttApe.Text = "";
                            txttDire.Text = "";
                            txttTelef.Text = "";
                            txtMarca.Text = "";
                            txtModelo.Text = "";
                            txtAccesorios.Text = "";
                            txtObservaciones.Text = "";
                            txtBuscarCliente.Text = "";
                            txtIdCliente.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al grabar la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


