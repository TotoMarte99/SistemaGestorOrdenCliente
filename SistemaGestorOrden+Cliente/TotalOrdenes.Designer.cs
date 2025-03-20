namespace SistemaGestorOrden_Cliente
{
    partial class TotalOrdenes
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
            dgvTotalOrdenes = new DataGridView();
            button1 = new Button();
            txtBuscarOrden = new TextBox();
            btnPDF = new Button();
            btnCargar0 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTotalOrdenes).BeginInit();
            SuspendLayout();
            // 
            // dgvTotalOrdenes
            // 
            dgvTotalOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTotalOrdenes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTotalOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotalOrdenes.Location = new Point(12, 102);
            dgvTotalOrdenes.Name = "dgvTotalOrdenes";
            dgvTotalOrdenes.RowHeadersWidth = 51;
            dgvTotalOrdenes.Size = new Size(1361, 496);
            dgvTotalOrdenes.TabIndex = 0;
            dgvTotalOrdenes.CellValueChanged += dgvTotalOrdenes_CellValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1225, 18);
            button1.Name = "button1";
            button1.Size = new Size(137, 32);
            button1.TabIndex = 1;
            button1.Text = "Buscar N° Orden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBuscarOrden
            // 
            txtBuscarOrden.Location = new Point(1125, 23);
            txtBuscarOrden.Name = "txtBuscarOrden";
            txtBuscarOrden.Size = new Size(94, 27);
            txtBuscarOrden.TabIndex = 2;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(1125, 57);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(237, 30);
            btnPDF.TabIndex = 3;
            btnPDF.Text = "Generar PDF de Orden";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnCargar0
            // 
            btnCargar0.Location = new Point(12, 67);
            btnCargar0.Name = "btnCargar0";
            btnCargar0.Size = new Size(36, 29);
            btnCargar0.TabIndex = 6;
            btnCargar0.Text = "X";
            btnCargar0.UseVisualStyleBackColor = true;
            btnCargar0.Click += btnCargar0_Click;
            // 
            // TotalOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 610);
            Controls.Add(btnCargar0);
            Controls.Add(btnPDF);
            Controls.Add(txtBuscarOrden);
            Controls.Add(button1);
            Controls.Add(dgvTotalOrdenes);
            Name = "TotalOrdenes";
            Text = "TotalOrdenes";
            Load += TotalOrdenes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTotalOrdenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTotalOrdenes;
        private Button button1;
        private TextBox txtBuscarOrden;
        private Button btnPDF;
        private Button btnCargar0;
    }
}