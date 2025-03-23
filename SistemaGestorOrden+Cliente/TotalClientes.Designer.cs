namespace SistemaGestorOrden_Cliente
{
    partial class TotalClientes
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
            dgvTotalClientes = new DataGridView();
            label1 = new Label();
            txtTotalClientes = new Label();
            btnBuscarClienteTotal = new Button();
            txtIDCliente = new TextBox();
            btnCargar0 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTotalClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvTotalClientes
            // 
            dgvTotalClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTotalClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTotalClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTotalClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotalClientes.Location = new Point(12, 67);
            dgvTotalClientes.Name = "dgvTotalClientes";
            dgvTotalClientes.RowHeadersWidth = 51;
            dgvTotalClientes.Size = new Size(922, 396);
            dgvTotalClientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 480);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 1;
            label1.Text = "Total de Clientes";
            // 
            // txtTotalClientes
            // 
            txtTotalClientes.AutoSize = true;
            txtTotalClientes.Location = new Point(137, 480);
            txtTotalClientes.Name = "txtTotalClientes";
            txtTotalClientes.Size = new Size(15, 20);
            txtTotalClientes.TabIndex = 2;
            txtTotalClientes.Text = "_";
            // 
            // btnBuscarClienteTotal
            // 
            btnBuscarClienteTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarClienteTotal.Location = new Point(781, 23);
            btnBuscarClienteTotal.Name = "btnBuscarClienteTotal";
            btnBuscarClienteTotal.Size = new Size(143, 29);
            btnBuscarClienteTotal.TabIndex = 3;
            btnBuscarClienteTotal.Text = "Buscar ID Cliente";
            btnBuscarClienteTotal.UseVisualStyleBackColor = true;
            btnBuscarClienteTotal.Click += btnBuscarClienteTotal_Click;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(676, 25);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(99, 27);
            txtIDCliente.TabIndex = 4;
            // 
            // btnCargar0
            // 
            btnCargar0.BackColor = Color.Crimson;
            btnCargar0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar0.ForeColor = SystemColors.ButtonHighlight;
            btnCargar0.Location = new Point(12, 32);
            btnCargar0.Name = "btnCargar0";
            btnCargar0.Size = new Size(36, 29);
            btnCargar0.TabIndex = 5;
            btnCargar0.Text = "X";
            btnCargar0.UseVisualStyleBackColor = false;
            btnCargar0.Click += btnCargar0_Click;
            // 
            // TotalClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(946, 513);
            Controls.Add(btnCargar0);
            Controls.Add(txtIDCliente);
            Controls.Add(btnBuscarClienteTotal);
            Controls.Add(txtTotalClientes);
            Controls.Add(label1);
            Controls.Add(dgvTotalClientes);
            Name = "TotalClientes";
            Text = "TotalClientes";
            Load += TotalClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTotalClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTotalClientes;
        private Label label1;
        private Label txtTotalClientes;
        private Button btnBuscarClienteTotal;
        private TextBox txtIDCliente;
        private Button btnCargar0;
    }
}