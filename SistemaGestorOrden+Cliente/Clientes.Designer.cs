﻿namespace SistemaGestorOrden_Cliente
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            cmbCliente = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(27, 63);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(27, 356);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(911, 219);
            dgvClientes.TabIndex = 3;
            // 
            // fechaIngreso
            // 
            fechaIngreso.Format = DateTimePickerFormat.Short;
            fechaIngreso.Location = new Point(466, 204);
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.Size = new Size(129, 27);
            fechaIngreso.TabIndex = 4;
            // 
            // a
            // 
            a.AutoSize = true;
            a.BackColor = Color.Gold;
            a.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            a.Location = new Point(27, 114);
            a.Name = "a";
            a.Size = new Size(81, 25);
            a.TabIndex = 5;
            a.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(27, 158);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(129, 159);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 6;
            // 
            // aa
            // 
            aa.AutoSize = true;
            aa.BackColor = Color.Gold;
            aa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            aa.Location = new Point(27, 204);
            aa.Name = "aa";
            aa.Size = new Size(92, 25);
            aa.TabIndex = 9;
            aa.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(129, 205);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 8;
            // 
            // aaa
            // 
            aaa.AutoSize = true;
            aaa.BackColor = Color.Gold;
            aaa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            aaa.Location = new Point(316, 116);
            aaa.Name = "aaa";
            aaa.Size = new Size(83, 25);
            aaa.TabIndex = 11;
            aaa.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(405, 114);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(190, 27);
            txtApellido.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(316, 161);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(401, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 27);
            txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(316, 205);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 14;
            label7.Text = "Fecha Ingreso";
            // 
            // txtIDCliente
            // 
            txtIDCliente.AutoSize = true;
            txtIDCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtIDCliente.Location = new Point(57, 63);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(15, 20);
            txtIDCliente.TabIndex = 16;
            txtIDCliente.Text = "_";
            txtIDCliente.UseMnemonic = false;
            // 
            // btnCarga
            // 
            btnCarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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
            btnBorrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(959, 28);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarClientesToolStripMenuItem, todosLosClientesToolStripMenuItem });
            clientesToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(78, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // ingresarClientesToolStripMenuItem
            // 
            ingresarClientesToolStripMenuItem.Name = "ingresarClientesToolStripMenuItem";
            ingresarClientesToolStripMenuItem.Size = new Size(217, 26);
            ingresarClientesToolStripMenuItem.Text = "Ingresar Clientes";
            // 
            // todosLosClientesToolStripMenuItem
            // 
            todosLosClientesToolStripMenuItem.Name = "todosLosClientesToolStripMenuItem";
            todosLosClientesToolStripMenuItem.Size = new Size(217, 26);
            todosLosClientesToolStripMenuItem.Text = "Todos los Clientes";
            todosLosClientesToolStripMenuItem.Click += todosLosClientesToolStripMenuItem_Click;
            // 
            // ordenesDeReparacionToolStripMenuItem
            // 
            ordenesDeReparacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarOrdenReparcionToolStripMenuItem, verTodasLasOrdenessToolStripMenuItem });
            ordenesDeReparacionToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordenesDeReparacionToolStripMenuItem.Name = "ordenesDeReparacionToolStripMenuItem";
            ordenesDeReparacionToolStripMenuItem.Padding = new Padding(0);
            ordenesDeReparacionToolStripMenuItem.Size = new Size(174, 24);
            ordenesDeReparacionToolStripMenuItem.Text = "Ordenes de Reparacion";
            // 
            // generarOrdenReparcionToolStripMenuItem
            // 
            generarOrdenReparcionToolStripMenuItem.Name = "generarOrdenReparcionToolStripMenuItem";
            generarOrdenReparcionToolStripMenuItem.Size = new Size(263, 26);
            generarOrdenReparcionToolStripMenuItem.Text = "Generar orden reparcion";
            generarOrdenReparcionToolStripMenuItem.Click += generarOrdenReparcionToolStripMenuItem_Click;
            // 
            // verTodasLasOrdenessToolStripMenuItem
            // 
            verTodasLasOrdenessToolStripMenuItem.Name = "verTodasLasOrdenessToolStripMenuItem";
            verTodasLasOrdenessToolStripMenuItem.Size = new Size(263, 26);
            verTodasLasOrdenessToolStripMenuItem.Text = "Ver todas las ordenes";
            verTodasLasOrdenessToolStripMenuItem.Click += verTodasLasOrdenessToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(618, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 110);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 37);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 25;
            label4.Text = "¿Que dato buscar?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 37);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 24;
            label2.Text = "Ingresar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(195, 66);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 23;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(6, 66);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(151, 28);
            cmbCliente.TabIndex = 22;
            cmbCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(959, 587);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Controls.Add(btnBorrar);
            Controls.Add(btnCarga);
            Controls.Add(txtIDCliente);
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
            Controls.Add(txtNombre);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Clientes";
            Text = "Gestor Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
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
        private GroupBox groupBox1;
        private TextBox txtBuscar;
        private ComboBox cmbCliente;
        private Label label4;
        private Label label2;
    }
}
