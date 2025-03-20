namespace SistemaGestorOrden_Cliente
{
    partial class OrdenesReparacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnBuscarCliente = new Button();
            fechaIngreso = new DateTimePicker();
            txtIdCliente = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txtObservaciones = new RichTextBox();
            label11 = new Label();
            txtAccesorios = new RichTextBox();
            label10 = new Label();
            label9 = new Label();
            txtModelo = new TextBox();
            label8 = new Label();
            txtMarca = new TextBox();
            txtBuscarCliente = new TextBox();
            botonCargarOrden = new Button();
            txtNombre = new Label();
            groupBox2 = new GroupBox();
            txttDire = new Label();
            txttTelef = new Label();
            txttApe = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 46);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(512, 26);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(131, 29);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar ID Cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // fechaIngreso
            // 
            fechaIngreso.Format = DateTimePickerFormat.Short;
            fechaIngreso.Location = new Point(497, 84);
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.Size = new Size(117, 27);
            fechaIngreso.TabIndex = 3;
            // 
            // txtIdCliente
            // 
            txtIdCliente.AutoSize = true;
            txtIdCliente.Location = new Point(109, 46);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(15, 20);
            txtIdCliente.TabIndex = 4;
            txtIdCliente.Text = "_";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 89);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 89);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 7;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 141);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 141);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 89);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 13;
            label7.Text = "Fecha Ingreso";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtAccesorios);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Location = new Point(52, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 387);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Máquina";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(50, 224);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(572, 97);
            txtObservaciones.TabIndex = 15;
            txtObservaciones.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(47, 185);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 14;
            label11.Text = "Observaciones";
            // 
            // txtAccesorios
            // 
            txtAccesorios.Location = new Point(400, 59);
            txtAccesorios.Name = "txtAccesorios";
            txtAccesorios.Size = new Size(222, 97);
            txtAccesorios.TabIndex = 12;
            txtAccesorios.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(314, 62);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 11;
            label10.Text = "Accesorios";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 113);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 9;
            label9.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(102, 113);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 59);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(91, 56);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 6;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(381, 26);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(125, 27);
            txtBuscarCliente.TabIndex = 15;
            // 
            // botonCargarOrden
            // 
            botonCargarOrden.Location = new Point(267, 641);
            botonCargarOrden.Name = "botonCargarOrden";
            botonCargarOrden.Size = new Size(242, 29);
            botonCargarOrden.TabIndex = 16;
            botonCargarOrden.Text = "Cargar e Imprimir Orden";
            botonCargarOrden.UseVisualStyleBackColor = true;
            botonCargarOrden.Click += botonCargarOrden_Click;
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(109, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(15, 20);
            txtNombre.TabIndex = 17;
            txtNombre.Text = "_";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txttDire);
            groupBox2.Controls.Add(txttTelef);
            groupBox2.Controls.Add(txttApe);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtBuscarCliente);
            groupBox2.Controls.Add(btnBuscarCliente);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(fechaIngreso);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtIdCliente);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(60, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(656, 217);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Cliente";
            // 
            // txttDire
            // 
            txttDire.AutoSize = true;
            txttDire.Location = new Point(109, 141);
            txttDire.Name = "txttDire";
            txttDire.Size = new Size(15, 20);
            txttDire.TabIndex = 23;
            txttDire.Text = "_";
            // 
            // txttTelef
            // 
            txttTelef.AutoSize = true;
            txttTelef.Location = new Point(282, 141);
            txttTelef.Name = "txttTelef";
            txttTelef.Size = new Size(15, 20);
            txttTelef.TabIndex = 22;
            txttTelef.Text = "_";
            // 
            // txttApe
            // 
            txttApe.AutoSize = true;
            txttApe.Location = new Point(282, 89);
            txttApe.Name = "txttApe";
            txttApe.Size = new Size(15, 20);
            txttApe.TabIndex = 21;
            txttApe.Text = "_";
            // 
            // OrdenesReparacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 691);
            Controls.Add(groupBox2);
            Controls.Add(botonCargarOrden);
            Controls.Add(groupBox1);
            Name = "OrdenesReparacion";
            Text = "OrdenesReparacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnBuscarCliente;
        private DateTimePicker fechaIngreso;
        private Label txtIdCliente;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDireccion;
        private Label label7;
        private GroupBox groupBox1;
        private RichTextBox txtObservaciones;
        private Label label11;
        private RichTextBox txtAccesorios;
        private Label label10;
        private Label label9;
        private TextBox txtModelo;
        private Label label8;
        private TextBox txtMarca;
        private TextBox txtBuscarCliente;
        private Button botonCargarOrden;
        private Label txtNombre;
        private Label label12;
        private Label label13;
        //private Label txtDireccion;
        private GroupBox groupBox2;
        private Label txttDire;
        private Label txttTelef;
        private Label txttApe;
    }
}