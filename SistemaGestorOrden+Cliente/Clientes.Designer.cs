namespace SistemaGestorOrden_Cliente
{
    partial class Clientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNombre = new TextBox();
            button1 = new Button();
            dgvClientes = new DataGridView();
            fechaIngreso = new DateTimePicker();
            a = new Label();
            label3 = new Label();
            txtTelefono = new TextBox();
            aa = new Label();
            txtDireccion = new TextBox();
            aaa = new Label();
            txtApellido = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtBuscar = new TextBox();
            txtIDCliente = new Label();
            btnCarga = new Button();
            btnBorrar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            ingresarClientesToolStripMenuItem = new ToolStripMenuItem();
            todosLosClientesToolStripMenuItem = new ToolStripMenuItem();
            ordenesDeReparacionToolStripMenuItem = new ToolStripMenuItem();
            generarOrdenReparcionToolStripMenuItem = new ToolStripMenuItem();
            verTodasLasOrdenessToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 63);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(761, 58);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar ID Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(27, 356);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(807, 219);
            dgvClientes.TabIndex = 3;
            // 
            // fechaIngreso
            // 
            fechaIngreso.Format = DateTimePickerFormat.Short;
            fechaIngreso.Location = new Point(392, 232);
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.Size = new Size(143, 27);
            fechaIngreso.TabIndex = 4;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(27, 114);
            a.Name = "a";
            a.Size = new Size(64, 20);
            a.TabIndex = 5;
            a.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 174);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(105, 167);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 6;
            // 
            // aa
            // 
            aa.AutoSize = true;
            aa.Location = new Point(27, 232);
            aa.Name = "aa";
            aa.Size = new Size(72, 20);
            aa.TabIndex = 9;
            aa.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(105, 225);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 8;
            // 
            // aaa
            // 
            aaa.AutoSize = true;
            aaa.Location = new Point(285, 114);
            aaa.Name = "aaa";
            aaa.Size = new Size(66, 20);
            aaa.TabIndex = 11;
            aaa.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(357, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 27);
            txtApellido.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 177);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(341, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 27);
            txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(286, 236);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 14;
            label7.Text = "Fecha Ingreso";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(630, 60);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 15;
            // 
            // txtIDCliente
            // 
            txtIDCliente.AutoSize = true;
            txtIDCliente.Location = new Point(57, 63);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(15, 20);
            txtIDCliente.TabIndex = 16;
            txtIDCliente.Text = "_";
            txtIDCliente.UseMnemonic = false;
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(27, 302);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(122, 30);
            btnCarga.TabIndex = 17;
            btnCarga.Text = "Cargar Cliente";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(174, 303);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(158, 29);
            btnBorrar.TabIndex = 18;
            btnBorrar.Text = "Borrar Cliente";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, ordenesDeReparacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(871, 28);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarClientesToolStripMenuItem, todosLosClientesToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ingresarClientesToolStripMenuItem
            // 
            ingresarClientesToolStripMenuItem.Name = "ingresarClientesToolStripMenuItem";
            ingresarClientesToolStripMenuItem.Size = new Size(224, 26);
            ingresarClientesToolStripMenuItem.Text = "Ingresar Clientes";
            // 
            // todosLosClientesToolStripMenuItem
            // 
            todosLosClientesToolStripMenuItem.Name = "todosLosClientesToolStripMenuItem";
            todosLosClientesToolStripMenuItem.Size = new Size(224, 26);
            todosLosClientesToolStripMenuItem.Text = "Todos los Clientes";
            todosLosClientesToolStripMenuItem.Click += todosLosClientesToolStripMenuItem_Click;
            // 
            // ordenesDeReparacionToolStripMenuItem
            // 
            ordenesDeReparacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarOrdenReparcionToolStripMenuItem, verTodasLasOrdenessToolStripMenuItem });
            ordenesDeReparacionToolStripMenuItem.Name = "ordenesDeReparacionToolStripMenuItem";
            ordenesDeReparacionToolStripMenuItem.Size = new Size(178, 24);
            ordenesDeReparacionToolStripMenuItem.Text = "Ordenes de Reparacion";
            // 
            // generarOrdenReparcionToolStripMenuItem
            // 
            generarOrdenReparcionToolStripMenuItem.Name = "generarOrdenReparcionToolStripMenuItem";
            generarOrdenReparcionToolStripMenuItem.Size = new Size(254, 26);
            generarOrdenReparcionToolStripMenuItem.Text = "Generar orden reparcion";
            generarOrdenReparcionToolStripMenuItem.Click += generarOrdenReparcionToolStripMenuItem_Click;
            // 
            // verTodasLasOrdenessToolStripMenuItem
            // 
            verTodasLasOrdenessToolStripMenuItem.Name = "verTodasLasOrdenessToolStripMenuItem";
            verTodasLasOrdenessToolStripMenuItem.Size = new Size(254, 26);
            verTodasLasOrdenessToolStripMenuItem.Text = "Ver todas las ordenes";
            verTodasLasOrdenessToolStripMenuItem.Click += verTodasLasOrdenessToolStripMenuItem_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 587);
            Controls.Add(menuStrip1);
            Controls.Add(btnBorrar);
            Controls.Add(btnCarga);
            Controls.Add(txtIDCliente);
            Controls.Add(txtBuscar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(aaa);
            Controls.Add(txtApellido);
            Controls.Add(aa);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(a);
            Controls.Add(fechaIngreso);
            Controls.Add(dgvClientes);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Clientes";
            Text = "Gestor Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button button1;
        private DataGridView dgvClientes;
        private DateTimePicker fechaIngreso;
        private Label a;
        private Label label3;
        private TextBox txtTelefono;
        private Label aa;
        private TextBox txtDireccion;
        private Label aaa;
        private TextBox txtApellido;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtBuscar;
        private Label txtIDCliente;
        private Button btnCarga;
        private Button btnBorrar;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem ingresarClientesToolStripMenuItem;
        private ToolStripMenuItem todosLosClientesToolStripMenuItem;
        private ToolStripMenuItem ordenesDeReparacionToolStripMenuItem;
        private ToolStripMenuItem generarOrdenReparcionToolStripMenuItem;
        private ToolStripMenuItem verTodasLasOrdenessToolStripMenuItem;
    }
}
