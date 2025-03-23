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
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(25, 81);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCliente.Location = new Point(18, 29);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(106, 30);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar ID Cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // fechaIngreso
            // 
            fechaIngreso.Format = DateTimePickerFormat.Short;
            fechaIngreso.Location = new Point(568, 145);
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.Size = new Size(126, 30);
            fechaIngreso.TabIndex = 3;
            // 
            // txtIdCliente
            // 
            txtIdCliente.AutoSize = true;
            txtIdCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtIdCliente.ForeColor = SystemColors.ControlDarkDark;
            txtIdCliente.Location = new Point(110, 86);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(15, 20);
            txtIdCliente.TabIndex = 4;
            txtIdCliente.Text = "_";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(216, 86);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(433, 86);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 7;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(216, 153);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(18, 153);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 11;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(433, 153);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 13;
            label7.Text = "Fecha Ingreso";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtAccesorios);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 418);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Máquina";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(47, 220);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(657, 103);
            txtObservaciones.TabIndex = 15;
            txtObservaciones.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(47, 185);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 14;
            label11.Text = "Observaciones";
            // 
            // txtAccesorios
            // 
            txtAccesorios.Location = new Point(400, 74);
            txtAccesorios.Name = "txtAccesorios";
            txtAccesorios.Size = new Size(304, 81);
            txtAccesorios.TabIndex = 12;
            txtAccesorios.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(394, 51);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 11;
            label10.Text = "Accesorios";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(205, 51);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 9;
            label9.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(205, 77);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 31);
            txtModelo.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(50, 51);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 7;
            label8.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(50, 74);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 31);
            txtMarca.TabIndex = 6;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(142, 29);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(125, 30);
            txtBuscarCliente.TabIndex = 15;
            // 
            // botonCargarOrden
            // 
            botonCargarOrden.Anchor = AnchorStyles.Bottom;
            botonCargarOrden.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonCargarOrden.Location = new Point(272, 690);
            botonCargarOrden.Name = "botonCargarOrden";
            botonCargarOrden.Size = new Size(242, 35);
            botonCargarOrden.TabIndex = 16;
            botonCargarOrden.Text = "Cargar e Generar Orden";
            botonCargarOrden.UseVisualStyleBackColor = true;
            botonCargarOrden.Click += botonCargarOrden_Click;
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txtNombre.ForeColor = SystemColors.ControlDarkDark;
            txtNombre.Location = new Point(315, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(15, 20);
            txtNombre.TabIndex = 17;
            txtNombre.Text = "_";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(760, 217);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Cliente";
            // 
            // txttDire
            // 
            txttDire.AutoSize = true;
            txttDire.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txttDire.ForeColor = SystemColors.ControlDarkDark;
            txttDire.Location = new Point(110, 153);
            txttDire.Name = "txttDire";
            txttDire.Size = new Size(15, 20);
            txttDire.TabIndex = 23;
            txttDire.Text = "_";
            // 
            // txttTelef
            // 
            txttTelef.AutoSize = true;
            txttTelef.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txttTelef.ForeColor = SystemColors.ControlDarkDark;
            txttTelef.Location = new Point(315, 153);
            txttTelef.Name = "txttTelef";
            txttTelef.Size = new Size(15, 20);
            txttTelef.TabIndex = 22;
            txttTelef.Text = "_";
            // 
            // txttApe
            // 
            txttApe.AutoSize = true;
            txttApe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txttApe.ForeColor = SystemColors.ControlDarkDark;
            txttApe.Location = new Point(524, 86);
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
            BackColor = Color.Gold;
            ClientSize = new Size(803, 737);
            Controls.Add(groupBox2);
            Controls.Add(botonCargarOrden);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "OrdenesReparacion";
            SizeGripStyle = SizeGripStyle.Hide;
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